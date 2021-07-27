using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniBrowser
{
    public partial class historydiag : Form
    {
        public historydiag()
        {
            InitializeComponent();
        }

        private void historydiag_Load(object sender, EventArgs e)
        {
            string working = Path.GetDirectoryName(Application.ExecutablePath);
            string h = Path.Combine(working, "history.html");
            MessageBox.Show(h);
            webBrowser1.Navigate(h);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
