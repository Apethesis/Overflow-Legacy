using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overflow
{
    public partial class KeySystem : Form
    {
        public KeySystem()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://link-target.net/471958/overflow");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            string gettext = richTextBox1.Text;
            int gettext_ammount = gettext.Length;

            if (gettext_ammount > 29)
            {
                WebClient wc = new WebClient();
                string ks = wc.DownloadString("https://raw.githubusercontent.com/Apethesis/Overflow-Legacy/master/key-system");

                if (ks.Contains(richTextBox1.Text))
                {
                    //true
                    this.Hide();
                    Form1 mainui = new Form1();
                    mainui.Show();
                }
                else
                {
                    //false
                    MessageBox.Show("Enter Valid key you retard");
                }

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://link-target.net/471958/overflow");
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            string gettext = richTextBox1.Text;
            int gettext_ammount = gettext.Length;

            if (gettext_ammount > 29)
            {
                WebClient wc = new WebClient();
                string ks = wc.DownloadString("https://raw.githubusercontent.com/Apethesis/Overflow-Legacy/master/key-system");

                if (ks.Contains(richTextBox1.Text))
                {
                    //true
                    this.Hide();
                    Form1 mainui = new Form1();
                    mainui.Show();
                }
                else
                {
                    //false
                    MessageBox.Show("Enter Valid key you retard");
                }
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
