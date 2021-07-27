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
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

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

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Go to webpage
            url.Text = browser.Url.ToString();
            // Save to history
            string historyold = File.ReadAllText("minibrowser_history.html"); // Get history
            using (StreamWriter sw = File.CreateText("minibrowser_history.html"))
            {
                WebClient x = new WebClient();
                string web = x.DownloadString(browser.Url.ToString());
                string title = Regex.Match(web, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;
                sw.WriteLine("<a href='" + browser.Url.ToString() + "'>" + title + "</a><br>" + historyold);
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            new historydiag().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Function to create history
            if (File.Exists(@"minibrowser_history.html"))
            {

            }
            else
            {
                using (StreamWriter sw = File.CreateText("minibrowser_history.html"))
                {

                    sw.WriteLine("<a href='http://google.com/'>http://google.com</a><br>");
                }
            }
        }
    }
}
