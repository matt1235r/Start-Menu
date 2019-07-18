using ComponentOwl.BetterListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class MenuWindow : Form
    {
        private List<string> filecache = new List<string>();
        public MenuWindow()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            Populate();

            
            // Register the "INSER" hotkey
            Boolean F9Registered = RegisterHotKey(
                this.Handle, 1, 0x0000, (int)Keys.Insert
            );
        }

        public void LoadSettings()
        {
            //Hide Start Button + Menu While Updating
            startButton.Visible = false;
            cleanClose();

            //Assign Start Menu Icon from Settings
            if (Properties.Settings.Default.UseStartIconFile)
            {
                try
                {

                    Icon startIcon = Icon.ExtractAssociatedIcon(Properties.Settings.Default.StartIconFile);
                    startButton.Icon = startIcon;
                }
                catch
                {
                    startButton.Icon = Properties.Resources.StartIcon;
                }
            }
            else
            {
                startButton.Icon = Properties.Resources.StartIcon;
            }

            //Assign Background from Settings
            if (Properties.Settings.Default.UseBackgroundFile){
                try
                {

                    Image background = Image.FromFile(Properties.Settings.Default.BackgroundFile);
                    backgroundPanel.BackgroundImage = background;
                    favouritesListView.BackgroundImage = background;
                }
                catch
                {
                    backgroundPanel.BackgroundImage = Properties.Resources.Background;
                    favouritesListView.BackgroundImage = Properties.Resources.Background;
                }
            }
            else
            {
                backgroundPanel.BackgroundImage = Properties.Resources.Background;
                favouritesListView.BackgroundImage = Properties.Resources.Background;
            }

            favouritesListView.RedrawItems();
            //Show start burron when finished
            startButton.Visible = true;
        }

        private void Populate()
        {
            LoadSettings();
            //Hide Start Button + Menu While Updating
            startButton.Visible = false;
            cleanClose();
            //Assign Start Menu Icon from Settings
            try
            {

                Icon startIcon = Icon.ExtractAssociatedIcon(Properties.Settings.Default.StartIconFile);
                startButton.Icon = startIcon;
            }
            catch
            {
                startButton.Icon = Properties.Resources.StartIcon;
            }

            //Start Menu Text
            usernameLabel.Text = Environment.UserName;
            domainLabel.Text = Environment.UserDomainName;


            //Folder objects
            DirectoryInfo allDir = new System.IO.DirectoryInfo(Properties.Settings.Default.AllAppsFolder);
            DirectoryInfo favDir = new System.IO.DirectoryInfo(Properties.Settings.Default.FavouritesFolder);

            //Add Child Directories to start menu all apps.
            foreach (DirectoryInfo folder in allDir.GetDirectories())
            {
                allFilesTreeView.Nodes.Add(folder.Name, folder.Name, "$directoryempty$", "$directoryempty$");
                foreach (FileInfo file in folder.GetFiles())
                {
                    allFilesTreeView.Nodes[folder.Name].SelectedImageKey = "$directory$";
                    allFilesTreeView.Nodes[folder.Name].ImageKey = "$directory$";
                    Icon iconForFile = SystemIcons.Exclamation;
                    iconForFile = Icon.ExtractAssociatedIcon(file.FullName);
                    fileImageList.Images.Add(file.FullName, iconForFile);
                    filecache.Add(file.FullName);
                    allFilesTreeView.Nodes[folder.Name].Nodes.Add(file.Name, Path.GetFileNameWithoutExtension(file.Name), file.FullName, file.FullName);
                }
            }

            //Add files in root all apps folder.
            foreach (FileInfo file in allDir.GetFiles())
            {
                Icon iconForFile = SystemIcons.Exclamation;
                iconForFile = Icon.ExtractAssociatedIcon(file.FullName);
                fileImageList.Images.Add(file.FullName, iconForFile);
                filecache.Add(file.FullName);
                allFilesTreeView.Nodes.Add(file.Name, Path.GetFileNameWithoutExtension(file.Name), file.FullName, file.FullName);
                allAppsToolStripMenuItem.DropDownItems.Add(Path.GetFileNameWithoutExtension(file.Name), fileImageList.Images[file.FullName]);
            }
           
            searchTreeView.Sort();

            //Populate context menu strip all apps.
            foreach (String file in filecache)
            {
                allAppsToolStripMenuItem.DropDownItems.Add(Path.GetFileNameWithoutExtension(file), fileImageList.Images[file]);
            }

            //Favourites List
            favouritesListView.BeginUpdate();


            foreach (FileInfo file in favDir.GetFiles())
            {
                // Set a default icon for the file.
                Icon iconForFile = SystemIcons.Question;

                BetterListViewItem item = new BetterListViewItem(Path.GetFileNameWithoutExtension(file.FullName), 1);
                iconForFile = Icon.ExtractAssociatedIcon(file.FullName);
                item.Image = iconForFile.ToBitmap();
                item.Tag = file.FullName;
                favouritesListView.Items.Add(item);
            }

            favouritesListView.EndUpdate();

            //Show Start Button Again
            startButton.Visible = true;
        }
      
        private void IndexIcons()
        {
            foreach (string file in Directory.GetFiles(Properties.Settings.Default.AllAppsFolder))
            {
                Image icon = Icon.ExtractAssociatedIcon(file).ToBitmap();
                BetterListViewItem betterListViewItem = new BetterListViewItem();
                betterListViewItem.Text = Path.GetFileNameWithoutExtension(file);
                betterListViewItem.Image = icon;
                favouritesListView.Items.Add(betterListViewItem);
            }
        }
       
        private void FavouritesMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (favouritesListView.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "explorer.exe";
                p.StartInfo.Arguments = "/select, \"" + favouritesListView.SelectedItems[0].Tag.ToString().Replace('/', '\\') + "\""; ;
                p.Start();
                cleanClose();
            }
            catch (Exception)
            {

                //throw;
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = favouritesListView.SelectedItems[0].Tag.ToString();
                p.Start();
            }
            catch
            {

                //throw;
            }

        }

        private void runAsAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.Verb = "runas";
                p.StartInfo.FileName = favouritesListView.SelectedItems[0].Tag.ToString();
                p.Start();
                cleanClose();
            }
            catch
            {

                //throw;
            }


        }

        private void OpenalltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();

                if (searchTreeView.Visible)
                {
                    p.StartInfo.FileName = searchTreeView.SelectedNode.ImageKey.ToString();
                }
                else
                {
                    p.StartInfo.FileName = allFilesTreeView.SelectedNode.ImageKey.ToString();
                }
                p.Start();
                cleanClose();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void adminalltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                if (searchTreeView.Visible)
                {
                    p.StartInfo.FileName = searchTreeView.SelectedNode.ImageKey.ToString();
                }
                else
                {
                    p.StartInfo.FileName = allFilesTreeView.SelectedNode.ImageKey.ToString();
                }
                p.StartInfo.Verb = "runas";
                p.Start();
                cleanClose();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void filelocStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "explorer.exe";
                if (searchTreeView.Visible)
                {
                    p.StartInfo.Arguments = "/select, \"" + searchTreeView.SelectedNode.ImageKey.ToString().Replace('/', '\\') + "\""; ;
                }
                else
                {
                    p.StartInfo.Arguments = "/select, \"" + allFilesTreeView.SelectedNode.ImageKey.ToString().Replace('/', '\\') + "\""; ;
                }
                p.Start();
                cleanClose();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void favouritesListView_ItemActivate(object sender, BetterListViewItemActivateEventArgs eventArgs)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = eventArgs.Item.Tag.ToString();
                p.Start();
                cleanClose();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void allMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (searchTreeView.Visible)
            {
                if (searchTreeView.SelectedNode.ImageKey.ToString() == "$directory$")
                {
                    // e.Cancel = true;
                }
            }
            else
            {
                if (allFilesTreeView.SelectedNode.ImageKey.ToString() == "$directory$")
                {
                    // e.Cancel = true;
                }
            }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                searchTreeView.Visible = true;
                searchTreeView.BeginUpdate();
                searchTreeView.Nodes.Clear();
                foreach (string file in filecache)
                {
                    if (file.ToLower().Contains(searchTextBox.Text.ToLower()))
                    {
                        searchTreeView.Nodes.Add(Path.GetFileName(file), Path.GetFileNameWithoutExtension(file), file, file);
                    }
                }

                searchTreeView.EndUpdate();
            }
            else
            {
                searchTreeView.Visible = false;
            }


        }

        private void searchTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Process p = new Process();
                    p.StartInfo.FileName = e.Node.ImageKey.ToString();
                    p.Start();
                    cleanClose();
                }
                catch (Exception)
                {

                    //throw;
                }
            }
            else
            {
                searchTreeView.SelectedNode = e.Node;
                allMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void showMessage(string title, string message, int timeout)
        {
            startButton.BalloonTipText = message;
            startButton.BalloonTipTitle = title;
            startButton.ShowBalloonTip(timeout);
        }
        private void allFilesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.ImageKey == "$directory$")
            {
                if (e.Node.IsExpanded)
                {
                    e.Node.Collapse();
                }
                else
                {
                    e.Node.Expand();
                }
                
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    try
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = e.Node.ImageKey.ToString();
                        p.Start();
                        cleanClose();
                    }
                    catch (Exception)
                    {

                        //throw;
                    }
                }
                else
                {
                    allFilesTreeView.SelectedNode = e.Node;
                    allMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
                }
            }
            
        }

        private void cleanClose()
        {
            WindowState = FormWindowState.Minimized;
            this.Visible = false;
            searchTreeView.CollapseAll();
            searchTreeView.SelectedNode = null;
            searchTextBox.Clear();

            allFilesTreeView.CollapseAll();
            allFilesTreeView.SelectedNode = null;   

        }
       
        private void startButton_MouseDown(object sender, MouseEventArgs e)
        {
            
            

            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    cleanClose();
                }
                else
                {
                    this.Visible = true;
                    WindowState = FormWindowState.Normal;
                    
                    Rectangle workingArea = Screen.GetWorkingArea(this);
                    this.Location = new Point(workingArea.Right - Size.Width,
                                              workingArea.Bottom - Size.Height);
                    
                }
            }

        }

        private void Window_Deactivate(object sender, EventArgs e)
        {
            cleanClose();
        }

        private void allAppsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = e.ClickedItem.Tag.ToString();
                p.Start();
            }
            catch (Exception)
            {

                //throw;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            new Settings(this).Show();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
            
            startButton.BalloonTipText =
              "I noticed that you double-clicked me! What can I do for you?";
            startButton.BalloonTipTitle = "You called Master?";
            startButton.ShowBalloonTip(10);
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }


        //Unmangaed
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        //[DllImport("user32.dll")]
        //public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    cleanClose();
                }
                else
                {
                    this.Visible = true;
                    WindowState = FormWindowState.Normal;

                    Rectangle workingArea = Screen.GetWorkingArea(this);
                    this.Location = new Point(workingArea.Right - Size.Width,
                                              workingArea.Bottom - Size.Height);

                }
            }
            base.WndProc(ref m);
        }

    }
}
