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
    public partial class basket_page : Form
    {
        public basket_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string x = "";
            for (int i = 0; i< listBox1.Items.Count;i++) {
                listBox1.SelectedIndex = i;
                x += listBox1.GetItemText(listBox1.SelectedItem)+"\n";
            }
            VAR.order = x;
            purches p = new purches();
            p.ShowDialog();

        }

        private void sear_btn_Click(object sender, EventArgs e)
        {
            price += 35f;
            listBox1.Items.Add("Seat £35");
            sear_btn.Enabled = false;
            upd();
        }

        private void park_btn_Click(object sender, EventArgs e)
        {
            
            price += 75f;
            listBox1.Items.Add("Parking £75");
            park_btn.Enabled = false;
            upd();
        }

        private void early_btn_Click(object sender, EventArgs e)
        {
            price += 20f;
            listBox1.Items.Add("Early Pass £20");
            early_btn.Enabled = false;
            upd();
        }

        private void lockers_btn_Click(object sender, EventArgs e)
        {
            price += 20f;
            listBox1.Items.Add("Lockers £20");
            lockers_btn.Enabled = false;
            upd();
        }
        public void upd()
        {
            price_lb.Text = "£" + price.ToString();
        }
        public float price = 0;
        private void basket_page_Load(object sender, EventArgs e)
        {
            if (VAR.friday)
            {
                price += 69.50f;
                listBox1.Items.Add("Friday £69.50");
            }
            if (VAR.satday)
            {
                price += 69.50f;
                listBox1.Items.Add("Satday £69.50");
            }
            if (VAR.sunday)
            {
                price += 74.50f;
                listBox1.Items.Add("Sunday £74.50");
            }
            if (VAR.week)
            {
                price += 205f;
                listBox1.Items.Add("Week £250");
            }
            upd();

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = listBox1.GetItemText(listBox1.SelectedItem);
            try
            {
                
                price -= (float)Convert.ToDouble(a.Split(new string[] { "£", "$" }, StringSplitOptions.None)[1]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
            upd();
           
        }
    }
}
