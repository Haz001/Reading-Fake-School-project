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
    public partial class purches : Form
    {
        public purches()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();
            pu = true;
            this.Close();
        }
        public int x = 1;
        public int y = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            donate_btn.Location = new Point(donate_btn.Location.X + x, donate_btn.Location.Y);
            donate_btn.Location = new Point(donate_btn.Location.X, donate_btn.Location.Y+y);
            if(donate_btn.Location.X+donate_btn.Width >= this.Width)
            {
                x = -1;
            }
            if(donate_btn.Location.X <= 0)
            {
                x = +1;
            }
            if (donate_btn.Location.Y+donate_btn.Height >= this.Height)
            {
                y = -1;
            }
            if (donate_btn.Location.Y <= 0)
            {
                y = +1;
            }

        }
        public bool pu = false;
        private void purches_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!pu)
            {
                MessageBox.Show("Purches is required!");
                e.Cancel = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not avalible");
        }

        private void donate_btn_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();
        }
    }
}
