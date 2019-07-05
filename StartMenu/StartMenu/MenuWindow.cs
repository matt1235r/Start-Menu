using ComponentOwl.BetterListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class Window : Form
    {
        private List<string> filecache = new List<string>();
        public Window()
        {
            InitializeComponent();
            this.LostFocus += new EventHandler(Form1_LostFocus);
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            Populate();
        }

        bool yes = false;

        private void Form1_LostFocus(object sender, EventArgs e)

        {
            if (yes)
            {
                this.Hide();

                Application.Exit();
            }


        }

        private void Populate()
        {
            usernamelabel.Text = Environment.UserName;
            domainlabel.Text = Environment.UserDomainName;
            ExtractAssociatedIconEx();
        }

        public void ExtractAssociatedIconEx()
        {
            DirectoryInfo dir = new System.IO.DirectoryInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs");



            foreach (DirectoryInfo folder in dir.GetDirectories())
            {
                allFilesTreeView.Nodes.Add(folder.Name, folder.Name, "$directoryempty$", "$directoryempty$");
                
                foreach (FileInfo file in folder.GetFiles())
                {

                    allFilesTreeView.Nodes[folder.Name].ImageKey = "$directory$";
                    Icon iconForFile = SystemIcons.Exclamation;
                    iconForFile = Icon.ExtractAssociatedIcon(file.FullName);
                    fileImageList.Images.Add(file.FullName, iconForFile);
                    filecache.Add(file.FullName);
                    allFilesTreeView.Nodes[folder.Name].Nodes.Add(file.Name, Path.GetFileNameWithoutExtension(file.Name), file.FullName, file.FullName);
                }
            }

            foreach (FileInfo file in dir.GetFiles())
            {
                Icon iconForFile = SystemIcons.Exclamation;
                iconForFile = Icon.ExtractAssociatedIcon(file.FullName);
                fileImageList.Images.Add(file.FullName, iconForFile);
                filecache.Add(file.FullName);
                allFilesTreeView.Nodes.Add(file.Name, Path.GetFileNameWithoutExtension(file.Name), file.FullName, file.FullName);
            }

            favouritesListView.BeginUpdate();


            foreach (FileInfo file in dir.GetFiles())
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
        }

        private void Icons()
        {
            foreach (string file in Directory.GetFiles(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs"))
            {
                Image icon = Icon.ExtractAssociatedIcon(file).ToBitmap();
                BetterListViewItem betterListViewItem = new BetterListViewItem();
                betterListViewItem.Text = Path.GetFileNameWithoutExtension(file);
                betterListViewItem.Image = icon;
                favouritesListView.Items.Add(betterListViewItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yes = true;
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
            this.Visible = false;
            searchTreeView.CollapseAll();
            searchTreeView.SelectedNode = null;
            searchTextBox.Clear();

            allFilesTreeView.CollapseAll();
            allFilesTreeView.SelectedNode = null;

            

        }
       
        private void startButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (Visible == true)
                {
                    cleanClose();
                }
                else
                {
                    Visible = true;
                    Focus();
                }
            }
            
        }

        private void Window_Deactivate(object sender, EventArgs e)
        {
            cleanClose();
        }
    }
}
