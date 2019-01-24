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
    public partial class days : Form
    {
        public days()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Buying:\nThursday" + THURSDAY.Checked.ToString());
            //MessageBox.Show("Buying:\nFriday" + FRIDAY.Checked.ToString());
            //MessageBox.Show("Buying:\nSaturday" + SATURDAY.Checked.ToString());
            //MessageBox.Show("Buying:\nSunday" + SUNDAY.Checked.ToString());
            VAR.sunday = SUNDAY.Checked;
            VAR.satday = SATURDAY.Checked;
            VAR.friday = FRIDAY.Checked;
            VAR.thusday = THURSDAY.Checked;
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
