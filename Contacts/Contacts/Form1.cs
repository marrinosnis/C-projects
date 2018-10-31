using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Contacts
{
    public partial class Form1 : Form
    {

         bool flag=false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            openFileDialog1.InitialDirectory = Application.StartupPath; // έχω βάλει ως προεπιλογή που θα αποθηκεύνται για να μπορεί να γίνει το Search Contact
            saveFileDialog1.InitialDirectory = Application.StartupPath;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (textBox2.Text != "FirstName") //bazw diaforo tou FirstName giati an pataga to koumpi to eperne ws keimeno kai to ebaze sto richtextbox.To idio kai sta alla 
            {
                if (textBox3.Text != "LastName")
                {
                    if (textBox4.Text != "Phone")
                    {
                        button5.Visible = true;
                        button6.Visible = true;
                        richTextBox1.AppendText((textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + textBox4.Text).ToString());
                    }
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text; // prepei na dothei kai o fakelos pu einai to arxeio alla kai h katalaksh tou arxeiou (p.x. txt ) kai dixnei an uparxei h oxi
 
            if (File.Exists(search))
            {
                label2.Text = "Exist";
                
            }
            else
            {
                label2.Text = "Not Exist";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                button4.Text = "Upadate";  // βάζω flag και event για να γίνεται η διαφορά της λειτουργίας που θα έχει κάθε  
                button5_Click(this, e);    // φορά το κουμπί. Δηλαδή στο flag=true το κουμπι  4 παίρνει τη λειτουργία του  
                button4_Enter(this, e);    //κουμπιού 5 και μόλις γίνει button enter το flag αλλάζει σε false 
                flag = false;              // Αυτό που δεν κατάφερα να κάνω είναι όταν θα φέρνει 
            }                              //πίσω τα στοιχεία για διαμόρφωση δεν πηγαίνουν ξανά στα textboxes. Συνεπώς 
                                           // η επεξεργασία των στοιχείων θα γίνει μέσα στο richtextbox και θα πατήθει το
        }                                  // κουμπί που λέει Save the new update  (OXI TO SAVE)και θα γίνει αποθήκευση στο ίδιο αρχείο (για να φανεί 
                                           // οτι όντως έγινε ενημέρωση) αλλιώς είναι στην επιλιγή του χρήστη


        private void button4_Enter(object sender, EventArgs e)
        {
            
            if (flag == false)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                button4.Text = "Save the new update";
                flag = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e) //apo kai katw xrhsimopoiw 2 apo ta events twn textbox gia na ftiaksw placehold me ta onomata tou kathenos 
        {
            if (textBox2.Text == "FirstName")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "FirstName";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "LastName")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "LastName";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Phone")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Phone";
                textBox4.ForeColor = Color.Silver;
            }
        }
    }
}
