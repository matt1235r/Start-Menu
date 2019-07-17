using ComponentOwl.BetterListView;

namespace StartMenu
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.domainlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.searchTreeView = new System.Windows.Forms.TreeView();
            this.fileImageList = new System.Windows.Forms.ImageList(this.components);
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allFilesTreeView = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.allMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenalltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.adminalltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.filelocStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.favouritesListView = new ComponentOwl.BetterListView.BetterListView();
            this.FavouritesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.runAsAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.removeFromFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.NotifyIcon(this.components);
            this.startMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.myComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            this.backgroundPanel.SuspendLayout();
            this.allMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favouritesListView)).BeginInit();
            this.FavouritesMenuStrip.SuspendLayout();
            this.startMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.domainlabel);
            this.panel2.Controls.Add(this.usernamelabel);
            this.panel2.Controls.Add(this.profileIcon);
            this.panel2.Location = new System.Drawing.Point(300, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 100);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // domainlabel
            // 
            this.domainlabel.AutoSize = true;
            this.domainlabel.BackColor = System.Drawing.Color.Transparent;
            this.domainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.domainlabel.Location = new System.Drawing.Point(95, 43);
            this.domainlabel.Name = "domainlabel";
            this.domainlabel.Size = new System.Drawing.Size(47, 15);
            this.domainlabel.TabIndex = 2;
            this.domainlabel.Text = "label1";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernamelabel.Location = new System.Drawing.Point(94, 19);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(66, 24);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "label1";
            // 
            // profileIcon
            // 
            this.profileIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileIcon.Image = ((System.Drawing.Image)(resources.GetObject("profileIcon.Image")));
            this.profileIcon.Location = new System.Drawing.Point(8, 8);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(80, 80);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileIcon.TabIndex = 0;
            this.profileIcon.TabStop = false;
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.backgroundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundPanel.BackgroundImage")));
            this.backgroundPanel.Controls.Add(this.searchTreeView);
            this.backgroundPanel.Controls.Add(this.searchTextBox);
            this.backgroundPanel.Controls.Add(this.label1);
            this.backgroundPanel.Controls.Add(this.panel2);
            this.backgroundPanel.Controls.Add(this.allFilesTreeView);
            this.backgroundPanel.Controls.Add(this.button2);
            this.backgroundPanel.Controls.Add(this.button3);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(577, 589);
            this.backgroundPanel.TabIndex = 1;
            this.backgroundPanel.VisibleChanged += new System.EventHandler(this.backgroundPanel_VisibleChanged);
            // 
            // searchTreeView
            // 
            this.searchTreeView.ImageIndex = 0;
            this.searchTreeView.ImageList = this.fileImageList;
            this.searchTreeView.Location = new System.Drawing.Point(9, 46);
            this.searchTreeView.Name = "searchTreeView";
            this.searchTreeView.SelectedImageIndex = 0;
            this.searchTreeView.ShowLines = false;
            this.searchTreeView.ShowPlusMinus = false;
            this.searchTreeView.Size = new System.Drawing.Size(270, 478);
            this.searchTreeView.TabIndex = 8;
            this.searchTreeView.Visible = false;
            this.searchTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.searchTreeView_NodeMouseClick);
            // 
            // fileImageList
            // 
            this.fileImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileImageList.ImageStream")));
            this.fileImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileImageList.Images.SetKeyName(0, "$directory$");
            this.fileImageList.Images.SetKeyName(1, "thumb_14329482510UAC.png");
            this.fileImageList.Images.SetKeyName(2, "$directoryempty$");
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 530);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(270, 20);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "All Applications";
            // 
            // allFilesTreeView
            // 
            this.allFilesTreeView.BackColor = System.Drawing.Color.White;
            this.allFilesTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allFilesTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allFilesTreeView.HotTracking = true;
            this.allFilesTreeView.ImageIndex = 0;
            this.allFilesTreeView.ImageList = this.fileImageList;
            this.allFilesTreeView.Location = new System.Drawing.Point(9, 46);
            this.allFilesTreeView.Name = "allFilesTreeView";
            this.allFilesTreeView.SelectedImageIndex = 0;
            this.allFilesTreeView.ShowLines = false;
            this.allFilesTreeView.ShowPlusMinus = false;
            this.allFilesTreeView.Size = new System.Drawing.Size(270, 478);
            this.allFilesTreeView.TabIndex = 5;
            this.allFilesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.allFilesTreeView_NodeMouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Shut Down";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // allMenuStrip
            // 
            this.allMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenalltoolStripMenuItem,
            this.toolStripSeparator4,
            this.adminalltoolStripMenuItem,
            this.toolStripSeparator5,
            this.filelocStripMenuItem,
            this.toolStripSeparator6,
            this.toolStripMenuItem4});
            this.allMenuStrip.Name = "FavouritesMenuStrip";
            this.allMenuStrip.Size = new System.Drawing.Size(186, 110);
            this.allMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.allMenuStrip_Opening);
            // 
            // OpenalltoolStripMenuItem
            // 
            this.OpenalltoolStripMenuItem.Name = "OpenalltoolStripMenuItem";
            this.OpenalltoolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.OpenalltoolStripMenuItem.Text = "Open";
            this.OpenalltoolStripMenuItem.Click += new System.EventHandler(this.OpenalltoolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // adminalltoolStripMenuItem
            // 
            this.adminalltoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminalltoolStripMenuItem.Image")));
            this.adminalltoolStripMenuItem.Name = "adminalltoolStripMenuItem";
            this.adminalltoolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.adminalltoolStripMenuItem.Text = "Run as Administrator";
            this.adminalltoolStripMenuItem.Click += new System.EventHandler(this.adminalltoolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(182, 6);
            // 
            // filelocStripMenuItem
            // 
            this.filelocStripMenuItem.Name = "filelocStripMenuItem";
            this.filelocStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.filelocStripMenuItem.Text = "Open File Location";
            this.filelocStripMenuItem.Click += new System.EventHandler(this.filelocStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(182, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem4.Text = "Add From Favourites";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Oxygen-Icons.org-Oxygen-Places-folder-red.ico");
            this.imageList1.Images.SetKeyName(1, "fallout_sign.png");
            // 
            // favouritesListView
            // 
            this.favouritesListView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favouritesListView.BackgroundImage")));
            this.favouritesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.favouritesListView.ContextMenuStrip = this.FavouritesMenuStrip;
            this.favouritesListView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouritesListView.ForeColor = System.Drawing.Color.White;
            this.favouritesListView.GridLines = ComponentOwl.BetterListView.BetterListViewGridLines.Grid;
            this.favouritesListView.Location = new System.Drawing.Point(300, 108);
            this.favouritesListView.MultiSelect = false;
            this.favouritesListView.Name = "favouritesListView";
            this.favouritesListView.Size = new System.Drawing.Size(262, 416);
            this.favouritesListView.SubItemFocusBehavior = ComponentOwl.BetterListView.BetterListViewSubItemFocusBehavior.None;
            this.favouritesListView.TabIndex = 2;
            this.favouritesListView.View = ComponentOwl.BetterListView.BetterListViewView.Tile;
            this.favouritesListView.ItemActivate += new ComponentOwl.BetterListView.BetterListViewItemActivateEventHandler(this.favouritesListView_ItemActivate);
            // 
            // FavouritesMenuStrip
            // 
            this.FavouritesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.runAsAdministratorToolStripMenuItem,
            this.toolStripSeparator2,
            this.openFileLocationToolStripMenuItem,
            this.toolStripSeparator3,
            this.removeFromFavouritesToolStripMenuItem});
            this.FavouritesMenuStrip.Name = "FavouritesMenuStrip";
            this.FavouritesMenuStrip.Size = new System.Drawing.Size(206, 110);
            this.FavouritesMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.FavouritesMenuStrip_Opening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // runAsAdministratorToolStripMenuItem
            // 
            this.runAsAdministratorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runAsAdministratorToolStripMenuItem.Image")));
            this.runAsAdministratorToolStripMenuItem.Name = "runAsAdministratorToolStripMenuItem";
            this.runAsAdministratorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.runAsAdministratorToolStripMenuItem.Text = "Run as Administrator";
            this.runAsAdministratorToolStripMenuItem.Click += new System.EventHandler(this.runAsAdministratorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openFileLocationToolStripMenuItem.Text = "Open File Location";
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // removeFromFavouritesToolStripMenuItem
            // 
            this.removeFromFavouritesToolStripMenuItem.Name = "removeFromFavouritesToolStripMenuItem";
            this.removeFromFavouritesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.removeFromFavouritesToolStripMenuItem.Text = "Remove From Favourites";
            // 
            // startButton
            // 
            this.startButton.ContextMenuStrip = this.startMenuStrip;
            this.startButton.Icon = ((System.Drawing.Icon)(resources.GetObject("startButton.Icon")));
            this.startButton.Text = "Old Start";
            this.startButton.Visible = true;
            this.startButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startButton_MouseDown);
            this.startButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startButton_MouseUp);
            // 
            // startMenuStrip
            // 
            this.startMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouritesToolStripMenuItem,
            this.allAppsToolStripMenuItem,
            this.toolStripSeparator7,
            this.myComputerToolStripMenuItem,
            this.powerOptionsToolStripMenuItem,
            this.taskManagerToolStripMenuItem});
            this.startMenuStrip.Name = "startMenuStrip";
            this.startMenuStrip.Size = new System.Drawing.Size(153, 120);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("favouritesToolStripMenuItem.Image")));
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            // 
            // allAppsToolStripMenuItem
            // 
            this.allAppsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allAppsToolStripMenuItem.Image")));
            this.allAppsToolStripMenuItem.Name = "allAppsToolStripMenuItem";
            this.allAppsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allAppsToolStripMenuItem.Text = "All Apps";
            this.allAppsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.allAppsToolStripMenuItem_DropDownItemClicked);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // myComputerToolStripMenuItem
            // 
            this.myComputerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myComputerToolStripMenuItem.Image")));
            this.myComputerToolStripMenuItem.Name = "myComputerToolStripMenuItem";
            this.myComputerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.myComputerToolStripMenuItem.Text = "My Computer";
            // 
            // powerOptionsToolStripMenuItem
            // 
            this.powerOptionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("powerOptionsToolStripMenuItem.Image")));
            this.powerOptionsToolStripMenuItem.Name = "powerOptionsToolStripMenuItem";
            this.powerOptionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.powerOptionsToolStripMenuItem.Text = "Power Options";
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taskManagerToolStripMenuItem.Image")));
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taskManagerToolStripMenuItem.Text = "Task Manager";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(577, 589);
            this.Controls.Add(this.favouritesListView);
            this.Controls.Add(this.backgroundPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window";
            this.Text = "Form1";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.Window_Deactivate);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.allMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.favouritesListView)).EndInit();
            this.FavouritesMenuStrip.ResumeLayout(false);
            this.startMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.Label domainlabel;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private BetterListView favouritesListView;
        private System.Windows.Forms.TreeView allFilesTreeView;
        private System.Windows.Forms.ContextMenuStrip FavouritesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAsAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList fileImageList;
        private System.Windows.Forms.ContextMenuStrip allMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenalltoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem adminalltoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem filelocStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon startButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TreeView searchTreeView;
        private System.Windows.Forms.ContextMenuStrip startMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAppsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem myComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
    }
}

