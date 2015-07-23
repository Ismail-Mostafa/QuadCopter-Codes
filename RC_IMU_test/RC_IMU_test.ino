#include <Servo.h>

//**********************************Remote Variabls*************************//
//**********************************Remote Variabls*************************//
//**********************************Remote Variabls*************************//
//############################################################################
// These bit flags are set in bUpdateFlagsShared to indicate which
// channels have new signals
#define THROTTLE_FLAG 1
#define ROLL_FLAG 2
#define PITCH_FLAG 4

#define THROTTLE_IN_PIN 3
#define ROLL_IN_PIN 19
#define PITCH_IN_PIN 2

// holds the update flags defined above
volatile uint8_t bUpdateFlagsShared;

volatile uint16_t unThrottleInShared;
volatile uint16_t unRollInShared;
volatile uint16_t unPitchInShared;

volatile uint16_t rollRemoteOffset=1488;
volatile uint16_t PitchRemoteOffset=1472;


uint32_t ulThrottleStart;
uint32_t ulRollStart;
uint32_t ulPitchStart;




Servo Brushless_1;
Servo Brushless_2;
Servo Brushless_3;
Servo Brushless_4;

//**********************************ARDUIMU Variable*************************//
//**********************************ARDUIMU Variable*************************//
//**********************************ARDUIMU Variable*************************//
//############################################################################
   
volatile byte buffer[10];
volatile char header=0;
volatile char valid=0;
volatile byte rec;
volatile byte IMU_ck_a,IMU_ck_b;
volatile char index=0;
volatile int roll,pitch,yaw;
volatile float roll1,pitch1,yaw1;

//**********************************ARDUIMU Variable*************************//
//**********************************ARDUIMU Variable*************************//
//**********************************ARDUIMU Variable*************************//
//############################################################################




void setup()
{
  Serial.begin(9600);
  Serial3.begin(38400);
  attachInterrupt(4, calcRoll, CHANGE);  //pin2   Roll
  attachInterrupt(1, calcThrottle, CHANGE);  //pin3   Throttle
  attachInterrupt(0, calcPitch, CHANGE);  //pin 19 Pitch
  
  
  
  Brushless_1.attach(4); //red bar back 
  Brushless_2.attach(5); //black bar left
  Brushless_3.attach(7); // red bar front
  Brushless_4.attach(6); //black bar right
}


void loop()
{
  
//**********************************ARDUIMU Program*************************//
//**********************************ARDUIMU Program*************************//
//**********************************ARDUIMU Program*************************//
//############################################################################
while(Serial3.available()>0)
 {
   rec=Serial3.read();
   if(rec=='D')header=1;
   else if(rec=='I'&&header==1)header=2; 
   else if(rec=='Y'&&header==2)header=3;
   else if(rec=='d'&&header==3)header=4; 
   else header=0;
  if(header==4)
  {
    valid=1;
   index=0; 
  }
 if(valid==1)
 {
 buffer[index]=rec;
 index++;
}
}
  
   if(index>=10&&valid==1)
 {
 IMU_ck_a=0;
 IMU_ck_b=0;
 for (int i=1;i<=8;i++) {
     IMU_ck_a+=buffer[i];  //Calculates checksums
     IMU_ck_b+=IMU_ck_a;       
		}

if(buffer[9]==IMU_ck_a&&IMU_ck_b==buffer[10])
{ 
roll=(buffer[3]|((buffer[4]<<8)&0xff00));
roll1=float(roll/100);
//Serial.println("roll");
//Serial.println(roll1);
pitch=buffer[5]|(buffer[6]<<8);
pitch1=float(pitch/100);
//Serial.println("pitch");
//Serial.println(pitch1);
yaw=buffer[7]|(buffer[8]<<8);
yaw1=yaw/100;
//Serial.println("yaw");
//Serial.println(yaw1);
valid=0;header=0;
 } 



 }
  
  
  
  
  
  
  
//**********************************RC Program*************************//
//**********************************RC Program*************************//
//**********************************RC Program*************************//
//############################################################################
 
  

  // create local variables to hold a local copies of the channel inputs
  // these are declared static so that thier values will be retained 
  // between calls to loop.
  static uint16_t unThrottleIn;
  static uint16_t unRollIn;
  static uint16_t unPitchIn;
  // local copy of update flags
  static uint8_t bUpdateFlags;
  
  static int16_t rollValue;
  static int16_t pitchValue;
  
    // check shared update flags to see if any channels have a new signal
   //******************************Calculate RC*****************************************// 
  if(bUpdateFlagsShared)
  {
    noInterrupts(); // turn interrupts off quickly while we take local copies of the shared variables

      // take a local copy of which channels were updated in case we need to use this in the rest of loop
    bUpdateFlags = bUpdateFlagsShared;

    // in the current code, the shared values are always populated
    // so we could copy them without testing the flags
    // however in the future this could change, so lets
    // only copy when the flags tell us we can.

    if(bUpdateFlags & THROTTLE_FLAG)
    {
      unThrottleIn = unThrottleInShared;
     // Serial.println(unThrottleIn);
    }

    if(bUpdateFlags & PITCH_FLAG)
    {
      unPitchIn = unPitchInShared;
      pitchValue = unPitchIn - PitchRemoteOffset; 
     // Serial.println(unPitchInShared); //1472 
    // Serial.println(pitchValue);
    }

    if(bUpdateFlags & ROLL_FLAG)
    {
      unRollIn = unRollInShared;
      rollValue= unRollIn - rollRemoteOffset;
    //  Serial.println(unRollInShared);  //1484 
   // Serial.println(rollValue);

    }

    // clear shared copy of updated flags as we have already taken the updates
    // we still have a local copy if we need to use it in bUpdateFlags
    bUpdateFlagsShared = 0;

    interrupts(); // we have local copies of the inputs, so now we can turn interrupts back on
    // as soon as interrupts are back on, we can no longer use the shared copies, the interrupt
    // service routines own these and could update them at any time. During the update, the 
    // shared copies may contain junk. Luckily we have our local copies to work with :-)
  }
  //******************************Take action*****************************************// 
  if(bUpdateFlags & THROTTLE_FLAG)
  {
   
      Brushless_1.writeMicroseconds(unThrottleIn-pitchValue);
      Brushless_2.writeMicroseconds(unThrottleIn+rollValue);
      Brushless_3.writeMicroseconds(unThrottleIn+pitchValue);
      Brushless_4.writeMicroseconds(unThrottleIn-rollValue);
   
  

  bUpdateFlags = 0;
}
}



//**************************** RC Interrupt ********************************//
void calcThrottle()
{
  // if the pin is high, its a rising edge of the signal pulse, so lets record its value
  if(digitalRead(THROTTLE_IN_PIN) == HIGH)
  { 
    ulThrottleStart = micros();
  }
  else
  {
    // else it must be a falling edge, so lets get the time and subtract the time of the rising edge
    // this gives use the time between the rising and falling edges i.e. the pulse duration.
    unThrottleInShared = (uint16_t)(micros() - ulThrottleStart);
    // use set the throttle flag to indicate that a new throttle signal has been received
    bUpdateFlagsShared |= THROTTLE_FLAG;
  }
}

void calcRoll()
{
  if(digitalRead(ROLL_IN_PIN) == HIGH)
  { 
    ulRollStart = micros();
    
  }
  else
  {
    unRollInShared = (uint16_t)(micros() - ulRollStart);
    bUpdateFlagsShared |= ROLL_FLAG;
  }
}

void calcPitch()
{
  if(digitalRead(PITCH_IN_PIN) == HIGH)
  { 
    ulPitchStart = micros();
  }
  else
  {
    unPitchInShared = (uint16_t)(micros() - ulPitchStart);
    bUpdateFlagsShared |= PITCH_FLAG;
  }
}







