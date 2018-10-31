using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        
        float X1, Y1, X2, Y2;
        bool flag = false;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
            X2 = e.X;
            Y2 = e.Y;
            flag = false;
           

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                g.DrawLine(p, X1, Y1, e.X, e.Y);
                X1 = e.X;
                Y1 = e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e) // circle
        {
            Color tempcolor = p.Color;
            p.Color = Color.Magenta;
            g.DrawEllipse (p, 40,150,150,150);
            p.Color = tempcolor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color tempcolor = p.Color;
            p.Color = Color.Magenta;
            g.DrawRectangle(p, 220,220,180,180);
            p.Color = tempcolor;
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            g.DrawLine(p, 300,700,300,500);

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Red")
            {
                p.Color = Color.Red;
            }
            else if (comboBox1.Text== "Gold")
            {
                p.Color = Color.Gold;
            }
            else if (comboBox1.Text == "Green")
            {
                p.Color = Color.Green;
            }
            else if (comboBox1.Text == "Purple")
            {
                p.Color = Color.Purple;
            }
            else if (comboBox1.Text == "White")
            {
                p.Color = Color.White;
            }
            else if (comboBox1.Text == "Default")
            {
                p.Color = Color.Black;
            }
           
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "3")
            {
                p.Width = 3;
            }
            else if (comboBox2.Text == "4")
            {
                p.Width = 4;
            }
            else if (comboBox2.Text == "5")
            {
                p.Width = 5;
            }
            else if (comboBox2.Text == "7")
            {
                p.Width = 7;
            } 
            else if (comboBox2.Text == "10")
            {
                p.Width = 10;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            g.DrawLine(p, 300, 500, 450, 500);

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            g.DrawLine(p, 450,500,450,700);

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            g.DrawLine(p, 450, 700, 300, 700);

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Enabled = false;
            g.DrawLine(p, 300, 500, 370,450);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Enabled = false;
            g.DrawLine(p, 370,450, 450, 500);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)

        {
            flag = true;
            X1 = e.X;
            Y1 = e.Y;
         
         }


        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            p = new Pen(Color.Black);
            p.Width = 2;
            g =this.CreateGraphics();
        }
    }
}
