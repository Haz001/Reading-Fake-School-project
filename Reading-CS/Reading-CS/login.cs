using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_CS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text != "")&&(textBox1.Text.Contains("@")))
            {
                
                if(textBox2.Text.Length >= 8)
                {

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please input your password");
                }
            }
            else
            {
                MessageBox.Show("Please type in your email");
            }
            
        }
    }
}
