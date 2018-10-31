namespace Traffic_Light
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
            this.timerTraffic = new System.Windows.Forms.Timer(this.components);
            this.timerCar = new System.Windows.Forms.Timer(this.components);
            this.timerTraffic1 = new System.Windows.Forms.Timer(this.components);
            this.timerPorsche = new System.Windows.Forms.Timer(this.components);
            this.timerMotor = new System.Windows.Forms.Timer(this.components);
            this.timerFisker = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.Changebtn2 = new System.Windows.Forms.Button();
            this.Changebtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yellow = new System.Windows.Forms.TextBox();
            this.green = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.TextBox();
            this.yellow1 = new System.Windows.Forms.TextBox();
            this.green1 = new System.Windows.Forms.TextBox();
            this.red1 = new System.Windows.Forms.TextBox();
            this.fisker = new System.Windows.Forms.PictureBox();
            this.porsche = new System.Windows.Forms.PictureBox();
            this.motorBox = new System.Windows.Forms.PictureBox();
            this.carBox = new System.Windows.Forms.PictureBox();
            this.redLight1 = new System.Windows.Forms.PictureBox();
            this.yellowLight1 = new System.Windows.Forms.PictureBox();
            this.greenLight1 = new System.Windows.Forms.PictureBox();
            this.yellowLight = new System.Windows.Forms.PictureBox();
            this.redLight = new System.Windows.Forms.PictureBox();
            this.greenLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fisker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porsche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTraffic
            // 
            this.timerTraffic.Interval = 1000;
            this.timerTraffic.Tick += new System.EventHandler(this.timerTraffic_Tick);
            // 
            // timerCar
            // 
            this.timerCar.Interval = 10;
            this.timerCar.Tick += new System.EventHandler(this.timerCar_Tick);
            // 
            // timerTraffic1
            // 
            this.timerTraffic1.Tick += new System.EventHandler(this.timerTraffic1_Tick);
            // 
            // timerPorsche
            // 
            this.timerPorsche.Interval = 10;
            this.timerPorsche.Tick += new System.EventHandler(this.timerPorsche_Tick);
            // 
            // timerMotor
            // 
            this.timerMotor.Interval = 10;
            this.timerMotor.Tick += new System.EventHandler(this.timerMotor_Tick);
            // 
            // timerFisker
            // 
            this.timerFisker.Interval = 10;
            this.timerFisker.Tick += new System.EventHandler(this.timerFisker_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 660);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 80);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Auto";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Changebtn2
            // 
            this.Changebtn2.Location = new System.Drawing.Point(222, 394);
            this.Changebtn2.Name = "Changebtn2";
            this.Changebtn2.Size = new System.Drawing.Size(75, 76);
            this.Changebtn2.TabIndex = 11;
            this.Changebtn2.Text = "Change!";
            this.Changebtn2.UseVisualStyleBackColor = true;
            this.Changebtn2.Click += new System.EventHandler(this.Changebtn2_Click);
            // 
            // Changebtn1
            // 
            this.Changebtn1.Location = new System.Drawing.Point(594, 131);
            this.Changebtn1.Name = "Changebtn1";
            this.Changebtn1.Size = new System.Drawing.Size(75, 76);
            this.Changebtn1.TabIndex = 12;
            this.Changebtn1.Text = "Change!";
            this.Changebtn1.UseVisualStyleBackColor = true;
            this.Changebtn1.Click += new System.EventHandler(this.Changebtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Time for Yellow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Time for Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Time for Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time for Yellow1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Time for Green1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Time for Red1";
            // 
            // yellow
            // 
            this.yellow.Location = new System.Drawing.Point(726, 136);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(100, 20);
            this.yellow.TabIndex = 19;
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(726, 160);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(100, 20);
            this.green.TabIndex = 20;
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(726, 110);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(100, 20);
            this.red.TabIndex = 21;
            // 
            // yellow1
            // 
            this.yellow1.Location = new System.Drawing.Point(126, 541);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(100, 20);
            this.yellow1.TabIndex = 22;
            // 
            // green1
            // 
            this.green1.Location = new System.Drawing.Point(126, 566);
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(100, 20);
            this.green1.TabIndex = 23;
            // 
            // red1
            // 
            this.red1.Location = new System.Drawing.Point(126, 515);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(100, 20);
            this.red1.TabIndex = 24;
            // 
            // fisker
            // 
            this.fisker.Image = global::Traffic_Light.Properties.Resources.fisker1;
            this.fisker.Location = new System.Drawing.Point(429, 660);
            this.fisker.Name = "fisker";
            this.fisker.Size = new System.Drawing.Size(63, 108);
            this.fisker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fisker.TabIndex = 9;
            this.fisker.TabStop = false;
            // 
            // porsche
            // 
            this.porsche.Image = global::Traffic_Light.Properties.Resources.porsche;
            this.porsche.Location = new System.Drawing.Point(429, 500);
            this.porsche.Name = "porsche";
            this.porsche.Size = new System.Drawing.Size(63, 108);
            this.porsche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.porsche.TabIndex = 8;
            this.porsche.TabStop = false;
            // 
            // motorBox
            // 
            this.motorBox.Image = global::Traffic_Light.Properties.Resources.motor;
            this.motorBox.Location = new System.Drawing.Point(883, 278);
            this.motorBox.Name = "motorBox";
            this.motorBox.Size = new System.Drawing.Size(129, 52);
            this.motorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.motorBox.TabIndex = 7;
            this.motorBox.TabStop = false;
            // 
            // carBox
            // 
            this.carBox.Image = global::Traffic_Light.Properties.Resources.boxer;
            this.carBox.Location = new System.Drawing.Point(726, 278);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(114, 52);
            this.carBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carBox.TabIndex = 6;
            this.carBox.TabStop = false;
            // 
            // redLight1
            // 
            this.redLight1.Image = global::Traffic_Light.Properties.Resources.red;
            this.redLight1.Location = new System.Drawing.Point(306, 394);
            this.redLight1.Name = "redLight1";
            this.redLight1.Size = new System.Drawing.Size(53, 130);
            this.redLight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redLight1.TabIndex = 5;
            this.redLight1.TabStop = false;
            // 
            // yellowLight1
            // 
            this.yellowLight1.Image = global::Traffic_Light.Properties.Resources.yellow;
            this.yellowLight1.Location = new System.Drawing.Point(306, 394);
            this.yellowLight1.Name = "yellowLight1";
            this.yellowLight1.Size = new System.Drawing.Size(53, 130);
            this.yellowLight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowLight1.TabIndex = 4;
            this.yellowLight1.TabStop = false;
            this.yellowLight1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // greenLight1
            // 
            this.greenLight1.Image = global::Traffic_Light.Properties.Resources.green;
            this.greenLight1.Location = new System.Drawing.Point(306, 394);
            this.greenLight1.Name = "greenLight1";
            this.greenLight1.Size = new System.Drawing.Size(53, 130);
            this.greenLight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenLight1.TabIndex = 3;
            this.greenLight1.TabStop = false;
            // 
            // yellowLight
            // 
            this.yellowLight.Image = global::Traffic_Light.Properties.Resources.yellow;
            this.yellowLight.Location = new System.Drawing.Point(535, 77);
            this.yellowLight.Name = "yellowLight";
            this.yellowLight.Size = new System.Drawing.Size(53, 130);
            this.yellowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowLight.TabIndex = 2;
            this.yellowLight.TabStop = false;
            // 
            // redLight
            // 
            this.redLight.Image = global::Traffic_Light.Properties.Resources.red;
            this.redLight.Location = new System.Drawing.Point(535, 77);
            this.redLight.Name = "redLight";
            this.redLight.Size = new System.Drawing.Size(53, 130);
            this.redLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redLight.TabIndex = 1;
            this.redLight.TabStop = false;
            // 
            // greenLight
            // 
            this.greenLight.Image = global::Traffic_Light.Properties.Resources.green;
            this.greenLight.Location = new System.Drawing.Point(535, 77);
            this.greenLight.Name = "greenLight";
            this.greenLight.Size = new System.Drawing.Size(53, 130);
            this.greenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenLight.TabIndex = 0;
            this.greenLight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.red1);
            this.Controls.Add(this.green1);
            this.Controls.Add(this.yellow1);
            this.Controls.Add(this.red);
            this.Controls.Add(this.green);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Changebtn1);
            this.Controls.Add(this.Changebtn2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.fisker);
            this.Controls.Add(this.porsche);
            this.Controls.Add(this.motorBox);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.redLight1);
            this.Controls.Add(this.yellowLight1);
            this.Controls.Add(this.greenLight1);
            this.Controls.Add(this.yellowLight);
            this.Controls.Add(this.redLight);
            this.Controls.Add(this.greenLight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.fisker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porsche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox greenLight;
        private System.Windows.Forms.PictureBox redLight;
        private System.Windows.Forms.PictureBox yellowLight;
        private System.Windows.Forms.PictureBox greenLight1;
        private System.Windows.Forms.PictureBox yellowLight1;
        private System.Windows.Forms.PictureBox redLight1;
        private System.Windows.Forms.Timer timerTraffic;
        private System.Windows.Forms.PictureBox carBox;
        private System.Windows.Forms.PictureBox motorBox;
        private System.Windows.Forms.Timer timerCar;
        private System.Windows.Forms.PictureBox porsche;
        private System.Windows.Forms.PictureBox fisker;
        private System.Windows.Forms.Timer timerTraffic1;
        private System.Windows.Forms.Timer timerPorsche;
        private System.Windows.Forms.Timer timerMotor;
        private System.Windows.Forms.Timer timerFisker;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button Changebtn2;
        private System.Windows.Forms.Button Changebtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yellow;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.TextBox yellow1;
        private System.Windows.Forms.TextBox green1;
        private System.Windows.Forms.TextBox red1;
    }
}

