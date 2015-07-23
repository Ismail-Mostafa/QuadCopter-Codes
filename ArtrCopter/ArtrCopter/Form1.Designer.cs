namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.M1P = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.M2P = new System.Windows.Forms.ProgressBar();
            this.M3P = new System.Windows.Forms.ProgressBar();
            this.M4P = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.M4Speed = new System.Windows.Forms.Label();
            this.M3Speed = new System.Windows.Forms.Label();
            this.M2Speed = new System.Windows.Forms.Label();
            this.M1Speed = new System.Windows.Forms.Label();
            this.Pitch = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Label();
            this.Yaw = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PitchP = new System.Windows.Forms.ProgressBar();
            this.RollP = new System.Windows.Forms.ProgressBar();
            this.YawP = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // M1P
            // 
            this.M1P.Location = new System.Drawing.Point(239, 52);
            this.M1P.Maximum = 2000;
            this.M1P.Minimum = 1000;
            this.M1P.Name = "M1P";
            this.M1P.Size = new System.Drawing.Size(100, 23);
            this.M1P.Step = 1;
            this.M1P.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.M1P.TabIndex = 0;
            this.M1P.Value = 1000;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // M2P
            // 
            this.M2P.Location = new System.Drawing.Point(239, 81);
            this.M2P.Maximum = 2000;
            this.M2P.Minimum = 1000;
            this.M2P.Name = "M2P";
            this.M2P.Size = new System.Drawing.Size(100, 23);
            this.M2P.Step = 1;
            this.M2P.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.M2P.TabIndex = 1;
            this.M2P.Value = 1000;
            // 
            // M3P
            // 
            this.M3P.Location = new System.Drawing.Point(239, 110);
            this.M3P.Maximum = 2000;
            this.M3P.Minimum = 1000;
            this.M3P.Name = "M3P";
            this.M3P.Size = new System.Drawing.Size(100, 23);
            this.M3P.Step = 1;
            this.M3P.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.M3P.TabIndex = 2;
            this.M3P.Value = 1000;
            // 
            // M4P
            // 
            this.M4P.Location = new System.Drawing.Point(239, 139);
            this.M4P.Maximum = 2000;
            this.M4P.Minimum = 1000;
            this.M4P.Name = "M4P";
            this.M4P.Size = new System.Drawing.Size(100, 23);
            this.M4P.Step = 1;
            this.M4P.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.M4P.TabIndex = 3;
            this.M4P.Value = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "M1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "M2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "M3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "M4";
            // 
            // M4Speed
            // 
            this.M4Speed.AutoSize = true;
            this.M4Speed.Location = new System.Drawing.Point(348, 149);
            this.M4Speed.Name = "M4Speed";
            this.M4Speed.Size = new System.Drawing.Size(21, 13);
            this.M4Speed.TabIndex = 11;
            this.M4Speed.Text = "M1";
            // 
            // M3Speed
            // 
            this.M3Speed.AutoSize = true;
            this.M3Speed.Location = new System.Drawing.Point(348, 120);
            this.M3Speed.Name = "M3Speed";
            this.M3Speed.Size = new System.Drawing.Size(21, 13);
            this.M3Speed.TabIndex = 10;
            this.M3Speed.Text = "M1";
            // 
            // M2Speed
            // 
            this.M2Speed.AutoSize = true;
            this.M2Speed.Location = new System.Drawing.Point(348, 91);
            this.M2Speed.Name = "M2Speed";
            this.M2Speed.Size = new System.Drawing.Size(21, 13);
            this.M2Speed.TabIndex = 9;
            this.M2Speed.Text = "M1";
            // 
            // M1Speed
            // 
            this.M1Speed.AutoSize = true;
            this.M1Speed.Location = new System.Drawing.Point(348, 62);
            this.M1Speed.Name = "M1Speed";
            this.M1Speed.Size = new System.Drawing.Size(21, 13);
            this.M1Speed.TabIndex = 8;
            this.M1Speed.Text = "M1";
            // 
            // Pitch
            // 
            this.Pitch.AutoSize = true;
            this.Pitch.Location = new System.Drawing.Point(149, 138);
            this.Pitch.Name = "Pitch";
            this.Pitch.Size = new System.Drawing.Size(21, 13);
            this.Pitch.TabIndex = 20;
            this.Pitch.Text = "M1";
            // 
            // Roll
            // 
            this.Roll.AutoSize = true;
            this.Roll.Location = new System.Drawing.Point(149, 109);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(21, 13);
            this.Roll.TabIndex = 19;
            this.Roll.Text = "M1";
            // 
            // Yaw
            // 
            this.Yaw.AutoSize = true;
            this.Yaw.Location = new System.Drawing.Point(149, 80);
            this.Yaw.Name = "Yaw";
            this.Yaw.Size = new System.Drawing.Size(21, 13);
            this.Yaw.TabIndex = 18;
            this.Yaw.Text = "M1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pitch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Roll";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Yaw";
            // 
            // PitchP
            // 
            this.PitchP.Location = new System.Drawing.Point(40, 128);
            this.PitchP.Maximum = 180;
            this.PitchP.Name = "PitchP";
            this.PitchP.Size = new System.Drawing.Size(100, 23);
            this.PitchP.Step = 1;
            this.PitchP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PitchP.TabIndex = 14;
            // 
            // RollP
            // 
            this.RollP.Location = new System.Drawing.Point(40, 99);
            this.RollP.Maximum = 180;
            this.RollP.Name = "RollP";
            this.RollP.Size = new System.Drawing.Size(100, 23);
            this.RollP.Step = 1;
            this.RollP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RollP.TabIndex = 13;
            // 
            // YawP
            // 
            this.YawP.Location = new System.Drawing.Point(40, 70);
            this.YawP.Maximum = 180;
            this.YawP.Name = "YawP";
            this.YawP.Size = new System.Drawing.Size(100, 23);
            this.YawP.Step = 1;
            this.YawP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.YawP.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(228, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Dissconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 70);
            this.textBox1.TabIndex = 24;
            this.textBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.APM_2_5_MOTORS_QUAD_enc;
            this.pictureBox1.Location = new System.Drawing.Point(392, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 183);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pitch);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.Yaw);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PitchP);
            this.Controls.Add(this.RollP);
            this.Controls.Add(this.YawP);
            this.Controls.Add(this.M4Speed);
            this.Controls.Add(this.M3Speed);
            this.Controls.Add(this.M2Speed);
            this.Controls.Add(this.M1Speed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.M4P);
            this.Controls.Add(this.M3P);
            this.Controls.Add(this.M2P);
            this.Controls.Add(this.M1P);
            this.Name = "Form1";
            this.Text = "ArtroCopter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar M1P;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar M2P;
        private System.Windows.Forms.ProgressBar M3P;
        private System.Windows.Forms.ProgressBar M4P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label M4Speed;
        private System.Windows.Forms.Label M3Speed;
        private System.Windows.Forms.Label M2Speed;
        private System.Windows.Forms.Label M1Speed;
        private System.Windows.Forms.Label Pitch;
        private System.Windows.Forms.Label Roll;
        private System.Windows.Forms.Label Yaw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar PitchP;
        private System.Windows.Forms.ProgressBar RollP;
        private System.Windows.Forms.ProgressBar YawP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

