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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HomePage = HomePageTextBox.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings are saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            HomePageTextBox.Text = Properties.Settings.Default.HomePage;
        }
    }
}
