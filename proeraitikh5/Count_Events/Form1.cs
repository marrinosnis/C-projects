using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Count_Events
{
    public partial class Form1 : Form
    {
        //to c pou bazw kathe fora mprosta antiproswpeuei to (c)ounter
        int cB=0; //metrhths gia button1_Click
        int cB0 = 0;//metrhths gia button1_mousedown
        int cB1 = 0; //metrhths gia to button1_mousemove
        int cL = 0; //metrhths gia label
        int cC = 0; //metrhths gia to combox
        int cD = 0; //metrhths gia to comboDropDown
        int cT = 0;//metrhths textbox poso einai to keimeno
        int cM = 0;//metrhths gia to poses fores mphke o deikths sto pedio tou texbox
        int cE = 0; // metrthths gia to textbox keydown
        int cLeave = 0; //metrhths gia to poses fores afhse to textbox
        int cMup = 0; //metrhths gia to poses fores anebhke to klik tou pontokiou
        int cKP = 0;//metrhths gia key press 
        int cMouseMove = 0; //metrhths gia to mouse move 
        int cLM = 0; //metrhths gia to poses fores perases panw apo to label o deikths
        int cLL = 0; //metrhths gia poses fores efyge apo to label
        int cLMouseUp = 0; //poses fores egine mouse up sto label
        int cPanelMouseClick = 0; //poses fores pathse to koumpi pathse to panel
        int cScroll = 0; //poses fores egine scroll sto panel
        int cRadioclick = 0; //poses fores egine clik sto radio
        int cRmousemove = 0; //pose fores phge na pathsei h perase panw apo to radio button



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cB += 1;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(Environment.NewLine + ("To κουμπι PRESS ME πατήθηκε " + Environment.NewLine + cB.ToString() + " για τo MOUSE CLICK, ") + (cB0.ToString() + " για το MOUSE DOWN, ") + cB1.ToString() + " για το MOUSEMOVE " + Environment.NewLine + cMup.ToString() + " για το MOUSE UP" + Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine + ("Άλλαξες το όνομα στη λίστα" + cC.ToString()) + " , και ανεβοκατέβασες τη λίστα " + (cD.ToString()) + " ,πάτησες στη λίστα "
                + cKP.ToString() + "πέρασες απο το combo box " + cMouseMove.ToString() + "  ,τόσες φορές" + Environment.NewLine);

            richTextBox1.AppendText(Environment.NewLine + ("To κείμενο που έβαλες έχει μήκος " + cT.ToString()) + " το ποντίκι έφυγε " + cM.ToString() + " ,πάτησες να γράψεις στο textbox " + cE.ToString() + " ,έφυγες απο το text" + cLeave.ToString());

            richTextBox1.AppendText(Environment.NewLine + ("Tο label πατήθηκε" + cL.ToString() + " ,πέρασε απο πάνω" + cLM.ToString() + " ,έφυγε απο το label" + cLL.ToString() + " ,πόσες φορές έγινε MOUSEUP στο label" + cLMouseUp.ToString()) + Environment.NewLine);


            


            richTextBox1.AppendText(Environment.NewLine + ("Πάτησες το radio button " + cRadioclick.ToString() + " ,πήγες να πατήσεις ή πέρασες απο το radio button" + cRmousemove.ToString()));
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            cB0 = cB+1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "George")
            {
                cC += 1;
            }
            else if (comboBox1.Text == "Maria")
            {
                cC += 1;
            }
            else if (comboBox1.Text == "Mariana")
            {
                cC += 1;
            } 
            else if (comboBox1.Text == "Spuridoula")
            {
                cC += 1;
            }
            else if (comboBox1.Text == "Manwlhs")
            {
                cC += 1;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            cB1 += 1;
        } 

        private void radioButton1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            cD += 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cT += 1;
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            cM += 1;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            cE += 1;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            cLeave += 1;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            cMup += 1;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            cKP += 1;
        }

       

        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cMouseMove += 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cL += 1;
        }

        private void label1_Move(object sender, EventArgs e)
        {
            cLM += 1;
        }

        private void label1_Leave(object sender, EventArgs e)
        {
            cLL += 1;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            cLMouseUp += 1;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            cPanelMouseClick += 1;
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            cScroll += 1;
        }

        private void radioButton1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            cRadioclick += 1;
        }

        private void radioButton1_MouseMove(object sender, MouseEventArgs e)
        {
            cRmousemove += 1;
        }
    }
}
