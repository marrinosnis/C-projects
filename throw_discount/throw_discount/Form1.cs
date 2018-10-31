using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace throw_discount
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 
            final.Visible = true;
            label3.Visible = true;

            final.Text = ( Convert.ToDouble(first.Text) - ((Convert.ToDouble(first.Text)* (Convert.ToDouble(disc.Text)))/100 )   ).ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Is the follow wrong" + ex);
            }

        }
    }
}
