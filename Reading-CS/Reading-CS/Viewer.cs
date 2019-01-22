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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void webBrowser1_LocationChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_LocationChanged(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            
            if (webBrowser1.Url.ToString().Contains("tickets"))
            {
                MessageBox.Show("Buy throught the application");
            }
        }

        private void spek_btn_Click(object sender, EventArgs e)
        {
            speak.Say("Friday 23 August will include: 1975, Juice world, Pale Waves, camephat, hayley kiyoko, bowling for soup. Saturday 24th august will include post malone, 21");
        }
    }
}
