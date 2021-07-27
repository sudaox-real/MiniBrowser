using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void url_TextChanged(object sender, EventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {
            browser.Navigate(url.Text);
        }
    }
}
