using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen p;
        

        int Rtime, Ytime, Gtime; // apothikeush tou xronou gia to trafficLight
        int R1time, Y1time, G1time; // apothikeush tou xronou gia to trafficLight1

        private void timerTraffic_Tick(object sender, EventArgs e)
        {
            if (redLight.Visible == true)
            {
                timerTraffic.Interval = Gtime * 1000; // to prasino na meinei anoixto

                redLight.Visible = false;
                yellowLight.Visible = false;
                greenLight.Visible = true;
            }

            else if (greenLight.Visible == true)
            {
                timerTraffic.Interval = Ytime * 1000;//to kitrino na meinei anoixto

                redLight.Visible = false;
                yellowLight.Visible = true;
                greenLight.Visible = false;
            }
            else if (yellowLight.Visible == true)
            {
                timerTraffic.Interval = Rtime * 1000; // to kokkino na meinei anoixto

                redLight.Visible = true;
                yellowLight.Visible = false;
                greenLight.Visible = false;
            }
        }

        private void timerCar_Tick(object sender, EventArgs e)
        {
            carBox.Left -= 2;

            if (redLight.Visible==true && motorBox.Left >=550 && motorBox.Left<=560 && carBox.Left>660 && carBox.Left <730)  //bazw oria gia na mporei to amaksi na stamataei mono otan prepei.As poume pws 
            {                                                                                                               //to amaksi brisketai makria kai exei kokkino, upo alles periptwseis tha stamatouse
                carBox.Left = 710;                                                                                         // xwris nohma, enw twra tha stamathsei mono an brisketai mesa sta oria 
            }                                                                                                             //tou dromou opou pou exw thesei. Me auto to tropo to amaksi stamataei mono
            else if ((redLight.Visible==true || yellowLight.Visible==true) && carBox.Left >=520 && carBox.Left<=560)     // sth diastaurwsh (kai ligo pio prin) otan exei kokkino h kitrino afou
                                                                                                                        //to exw kanei na stamatei kai sto kitrino. <<(158)>>
            {
                carBox.Left = 550;
            }
            if (carBox.Left == 0)

            {

                carBox.Left = 978;
            }
        }

        private void timerTraffic1_Tick(object sender, EventArgs e)
        {
            if (redLight1.Visible == true)
            {
                timerTraffic1.Interval = G1time * 1000; //to prasino na meinei anoixto 

                redLight1.Visible = false;
                yellowLight1.Visible = false;
                greenLight1.Visible = true;
            }

            else if (greenLight1.Visible == true)
            {
                timerTraffic1.Interval = Y1time * 1000; //to kitrino na meinei anoixto

                redLight1.Visible = false;
                yellowLight1.Visible = true;
                greenLight1.Visible = false;
            }
            else if (yellowLight1.Visible == true)
            {
                timerTraffic1.Interval = R1time * 1000; //to kokkino na meinei anoixto 

                redLight1.Visible = true;
                yellowLight1.Visible = false;
                greenLight1.Visible = false;
            }
        }

        private void timerPorsche_Tick(object sender, EventArgs e)
        {
            porsche.Top -= 2;

            if (redLight1.Visible == true && fisker.Top >= 390 && fisker.Top <= 510 && porsche.Top >= 510 && porsche.Top <= 570)
            {
                porsche.Top = 550;
            }

            else if ((redLight1.Visible == true || yellowLight1.Visible == true) && porsche.Top >= 390 && porsche.Top <= 415) //bazw oria gia ton idio logo pou anaferw panw  <<(158)>>
                porsche.Top = 400;

            if (porsche.Top == 0)
            {
                porsche.Top = 756;
            }
        }

        private void timerMotor_Tick(object sender, EventArgs e)
        {
            motorBox.Left -= 2;

            if ((redLight.Visible ==true || yellowLight.Visible==true) &&carBox.Left>=550 &carBox.Left <=560 &&motorBox.Left >660 &&motorBox.Left<730 )
            {
                motorBox.Left = 710;
            }

            else if ((redLight.Visible ==true || yellowLight.Visible==true) && motorBox.Left >=520 && motorBox.Left <=560)
            {
                motorBox.Left = 550;
            }


            if (motorBox.Left == 0)
            {
                motorBox.Left = 978;
            }
        }

        private void timerFisker_Tick(object sender, EventArgs e)
        {
            fisker.Top -= 2;
            if ((redLight1.Visible==true || yellowLight1.Visible==true) &&porsche.Top >=400 &&porsche.Top <=415 &&fisker.Top >510 &&fisker.Top <570) //<<158>>
            {
                fisker.Top = 550;
            }

            else if ((redLight1.Visible==true || yellowLight1.Visible==true) && fisker.Top >=390 && fisker.Top <= 430) //
            {
                fisker.Top = 400;
            }

            if (fisker.Top == 0)
            {
                fisker.Top = 756;
            }
        }

        private void Changebtn1_Click(object sender, EventArgs e)
        {
            if (redLight.Visible == true && greenLight1.Visible == false)
            {
                redLight.Visible = false;
                yellowLight.Visible = false;
                greenLight.Visible = true;
            }

            else if (greenLight.Visible == true)
            {
                redLight.Visible = false;
                yellowLight.Visible = true;
                greenLight.Visible = false;
            }
            else if (yellowLight.Visible == true)
            {
                redLight.Visible = true;
                yellowLight.Visible = false;
                greenLight.Visible = false;
            }
            else
                MessageBox.Show("You are not allowed to change the color, because cars will crush");
            
        }

        private void Changebtn2_Click(object sender, EventArgs e)
        {
            if (redLight1.Visible == true && greenLight.Visible == false)
            {
                redLight1.Visible = false;
                yellowLight1.Visible = false;
                greenLight1.Visible = true;
            }

            else if (greenLight1.Visible == true)
            {
                redLight1.Visible = false;
                yellowLight1.Visible = true;
                greenLight1.Visible = false;
            }

            else if (yellowLight1.Visible == true)
            {
                redLight1.Visible = true;
                yellowLight1.Visible = false;
                greenLight1.Visible = false;
            }
            else
                MessageBox.Show("You are not allowed to change the color, because cars will crush");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (red.Text == "" || yellow.Text == "" || green.Text == "" || red1.Text == "" || yellow1.Text == "" || green1.Text == "" || red.Text == "0" || yellow.Text == "0" || green.Text == "0" || red1.Text == "0" || yellow1.Text == "0" || green1.Text == "0")
            {
                MessageBox.Show("Υou need to complete the textboxes with logic times");
            }

            else
            {

                int.TryParse(red.Text, out Rtime /* poso tha meinei to kokkino*/);  //metratoph tou arithmou se xrono pou moy dinei sta textbox gia to prwto fanari (to panw)
                int.TryParse(yellow.Text, out Ytime /* poso tha meinei to kitrino*/);
                int.TryParse(green.Text, out Gtime /* poso tha meinei to prasino*/);



                int.TryParse(red1.Text, out R1time /* poso tha meinei to kokkino*/); //metatroph tou arithmou se xrono pou moy dinei sta textbox gia to deutero fanari (to katw)
                int.TryParse(yellow1.Text, out Y1time /* poso tha meinei to kitrino*/);
                int.TryParse(green1.Text, out G1time /* poso tha meinei to prasino */);


                if (G1time + Y1time < Rtime && Gtime + Ytime < R1time)

                {
                    timerCar.Enabled = true;
                    timerPorsche.Enabled = true;
                    timerTraffic.Enabled = true;
                    timerTraffic1.Enabled = true;
                    timerMotor.Enabled = true;
                    timerFisker.Enabled = true;


                }
                else
                    MessageBox.Show("You need to put logic times so that the the traffic Light can work properly");
            }
        }

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p = new Pen(Color.Red);
            p.Width = 5;
            g = this.CreateGraphics();

            g.DrawLine(p, 1023, 271, 533, 271); // sxediazw tis kokkines orizonties grammes opou anaparistoun tous dromous
            g.DrawLine(p, 1023, 360, 533, 360);
            g.DrawLine(p, 400, 360, 0, 360);
            g.DrawLine(p, 400, 271, 0, 271);

            g.DrawLine(p, 505, 390, 505, 753); // sxediazw tis kokkines kathetes grammes opou anaparistoun tous dromous
            g.DrawLine(p, 425, 390, 425, 753);
            g.DrawLine(p, 425, 250, 425, 0);
            g.DrawLine(p, 505, 250, 505, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            redLight.Visible = false;
            greenLight.Visible = false;
            yellowLight.Visible = true;

            redLight1.Visible = true;
            greenLight1.Visible = false;
            yellowLight1.Visible = false;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }
    }
}
