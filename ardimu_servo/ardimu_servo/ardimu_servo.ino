#include <Servo.h>

//String inputString = "";        
byte buffer[10];
char header=0;
char valid=0;
byte rec;
int x;
byte IMU_ck_a,IMU_ck_b;
char index=0;
int roll,pitch,yaw;
float roll1,pitch1,yaw1;
Servo roll_s;
Servo pitch_s;
void setup() {

  Serial.begin(38400);
roll_s.attach(8);
pitch_s.attach(9);
}

void loop()
{
 
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
 
 
   
// if(buffer[2]==0x02){Serial.println("RP"); 
 roll=(buffer[3]|((buffer[4]<<8)&0xff00));
 roll_s.write(((roll/100)+180)/2);
 
 roll1=float(roll/100);
 Serial.println("roll");
 Serial.println(roll1);
pitch=buffer[5]|(buffer[6]<<8);
pitch_s.write(((pitch/100)+180)/2);
pitch1=float(pitch/100);
//if((pre_pitch1-pitch1)>2||(-pre_pitch1+pitch1)>2)
//{
//pre_pitch1=pitch1;
//}
Serial.println("pitch");
Serial.println(pitch1);

yaw=buffer[7]|(buffer[8]<<8);
yaw1=yaw/100;
Serial.println("yaw");
Serial.println(yaw1);


 valid=0;header=0;
 delay(150);
// }
 } 



 }
} 








void serialEvent() {
while(Serial.available()>0)
 {
   rec=Serial.read();
//   x=rec;
//   Serial.println(x);
   if(rec=='D')header=1;
   else if(rec=='I'&&header==1)header=2; 
   else if(rec=='Y'&&header==2)header=3;
   else if(rec=='d'&&header==3)header=4; 
  // else if(rec=='f'&&header==4)header=5;
   else header=0;
  if(header==4)
  {
    valid=1;
   index=0; 
  }
 if(valid==1)
 {
 //Serial.println("valid");
 buffer[index]=rec;
 index++;
}
}

}
