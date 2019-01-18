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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string x = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(x == "")
            {
                MessageBox.Show("hello World");
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            Viewer web = new Viewer();
            web.ShowDialog();
            web = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Buypage bp = new Buypage();
            bp.ShowDialog();


        }
    }
}
