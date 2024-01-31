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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show(("ne vse zapolneno"),"message");
            }
            else
            {
                if(Convert.ToInt32(textBox2.Text)<=500)
                {
                    MessageBox.Show(("neverno"),"m");
                }
                if (Convert.ToInt32(textBox3.Text) <= 1800)
                {
                    MessageBox.Show(("neverno"), "m");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
