using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random2
{
    public partial class Form1 : Form
    {
        int time;

        int score = 1; // bazw arxikh timh 1 sto score giati an ebaza 0 tote sto prwto pathma ths eikonas to score tha ginotan 0 kai OXI 1
        Random r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            timer1.Enabled = true;

            timer2.Enabled = true;

            label3.Visible = false;

            time = Convert.ToInt32(textBox1.Text);
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            r = new Random();
            Point p1 = new Point(r.Next(0, this.Width - pictureBox2.Width), r.Next(0, this.Height - pictureBox2.Height));

            pictureBox2.Location = p1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

            label1.Text = "your score is:" + " " + score; // kathe fora pou ta pataw thn eikona tote to score megalwnei kata 1 
            score += 1;
            pictureBox2.Visible = true;
            

            if (score > 10)
            {
                pictureBox2.Width = pictureBox2.Width - 10;
                pictureBox2.Height = pictureBox2.Height - 10;
            };
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (time > 0)
            {
                time--;
                textBox1.Text = "00:" + time.ToString();
                if (time < 10)
                {
                    
                    textBox1.Text = "00:0" + time.ToString();
                }
            }
            else
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                pictureBox2.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;

                MessageBox.Show("Your score is:" + (score -1)); // bazw -1 giati ws arxikh timh eixa dwse to 1 kai OXI to 0. Epomenos an to score sthn othonh elege 10 
                                                               //tha mou edeixne 11, enw twra mou deixnei to idio arithmo me auton ths othonhs 

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
