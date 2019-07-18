using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class Settings : Form
    {
        private MenuWindow parent;

        public Settings(MenuWindow parentform)
        {
            parent = parentform;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                allTextBox.Text = fbd.SelectedPath;
            }
        }

        private void LoadSettings()
        {
            //Start Menu paths
            allTextBox.Text = Properties.Settings.Default.AllAppsFolder;
            favouruitesTextBox.Text = Properties.Settings.Default.FavouritesFolder;

            //Images
            customStartIconTextBox.Text = Properties.Settings.Default.StartIconFile;
            customBackgroundTextBox.Text = Properties.Settings.Default.BackgroundFile;

            customStartCheckBox.Checked = Properties.Settings.Default.UseStartIconFile;
            customBackgroundCheckBox.Checked = Properties.Settings.Default.UseBackgroundFile;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Start Menu paths
            Properties.Settings.Default.AllAppsFolder = allTextBox.Text;
            Properties.Settings.Default.FavouritesFolder = favouruitesTextBox.Text;

            //Images
            Properties.Settings.Default.StartIconFile = customStartIconTextBox.Text;
            Properties.Settings.Default.BackgroundFile = customBackgroundTextBox.Text;

            Properties.Settings.Default.UseStartIconFile = customStartCheckBox.Checked;
            Properties.Settings.Default.UseBackgroundFile = customBackgroundCheckBox.Checked;

            Properties.Settings.Default.Save();
            parent.LoadSettings();
            this.Close();
        }

        private void customStartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            customOrbPanel.Enabled = customStartCheckBox.Checked;
        }

        private void customBackgroundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            customBackgroundPanel.Enabled = customBackgroundCheckBox.Checked;
        }

        private void favouriteBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                favouruitesTextBox.Text = fbd.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Icon Files |*.ico";
            ofd.Title = "Select a Start Menu Icon";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                customStartIconTextBox.Text = ofd.FileName;
            }
        }

        private void browseBackgroundStartMenuButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files |*.JPEG;*.JPG;*.PNG;*.GIF";
            ofd.Title = "Select a Start Menu Background";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                customBackgroundTextBox.Text = ofd.FileName;
            }
        }
    }
}
