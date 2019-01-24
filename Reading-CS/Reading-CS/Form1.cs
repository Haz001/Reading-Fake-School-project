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
            orderpage bp = new orderpage();
            bp.ShowDialog();


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void speak_btn_Click(object sender, EventArgs e)
        {
            speak.Say("100% Genuin Offical and Trustworthy Reading Festival Order application, Click Buy to buy tickets, click view to view timetable and more. Sponsered by Pepsi Max and Highlits on BBC Radio");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(this.Opacity < 1f)
            {
                
                
                this.Opacity += 0.05f;
            }
        }
    }
}
