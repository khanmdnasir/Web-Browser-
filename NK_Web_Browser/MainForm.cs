using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NK_Web_Browser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All rights reserved Program with nk 2021", "Nk_WebBrowser", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nk_webBrowser.Navigate("http://www.google.co.uk");
            AddressToolStripComboBox.Text = "http://www.google.co.uk";
        }

        private void HomeToolStripButton_Click(object sender, EventArgs e)
        {
            nk_webBrowser.Navigate("http://www.google.co.uk");
            AddressToolStripComboBox.Text = "http://www.google.co.uk";
        }

        private void GoToolStripButton_Click(object sender, EventArgs e)
        {
            nk_webBrowser.Navigate(AddressToolStripComboBox.Text);
        }

        private void AddressToolStripComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nk_webBrowser.Navigate(AddressToolStripComboBox.Text);
            }
        }

    }
}
