﻿namespace RenamerX
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.scRename = new System.Windows.Forms.SplitContainer();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.lvShows = new System.Windows.Forms.ListView();
            this.lvShowsColumn1 = new System.Windows.Forms.ColumnHeader();
            this.cbShowErrors = new System.Windows.Forms.CheckBox();
            this.btnRenameAll = new System.Windows.Forms.Button();
            this.btnRenameClear = new System.Windows.Forms.Button();
            this.lblRenameFileFilter = new System.Windows.Forms.Label();
            this.txtRenameFileFilter = new System.Windows.Forms.TextBox();
            this.lblNameFormat = new System.Windows.Forms.Label();
            this.btnRenameRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNameFormat = new System.Windows.Forms.TextBox();
            this.btnRenameAdd = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.lvListColumn1 = new System.Windows.Forms.ColumnHeader();
            this.lvListColumn2 = new System.Windows.Forms.ColumnHeader();
            this.tpExtract = new System.Windows.Forms.TabPage();
            this.scExtract = new System.Windows.Forms.SplitContainer();
            this.txtExtractPassword = new System.Windows.Forms.TextBox();
            this.lblExtractPassword = new System.Windows.Forms.Label();
            this.cbExtractOverwrite = new System.Windows.Forms.CheckBox();
            this.pbExtract = new System.Windows.Forms.ProgressBar();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.txtExtractFileSizeFilter = new System.Windows.Forms.TextBox();
            this.lblExtractFileSizeFilter = new System.Windows.Forms.Label();
            this.lblExtractPath = new System.Windows.Forms.Label();
            this.txtExtractFileFilter = new System.Windows.Forms.TextBox();
            this.txtExtractPath = new System.Windows.Forms.TextBox();
            this.lblExtractFileFilter = new System.Windows.Forms.Label();
            this.txtUnRARPath = new System.Windows.Forms.TextBox();
            this.btnExtractClear = new System.Windows.Forms.Button();
            this.cbSearchSubFolders = new System.Windows.Forms.CheckBox();
            this.btnExtractRemove = new System.Windows.Forms.Button();
            this.lblUnRARPath = new System.Windows.Forms.Label();
            this.btnExtractAdd = new System.Windows.Forms.Button();
            this.btnExtractBrowse = new System.Windows.Forms.Button();
            this.btnExtractAll = new System.Windows.Forms.Button();
            this.btnUnRARBrowse = new System.Windows.Forms.Button();
            this.lvExtractList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.tpConsole = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.pgApp = new System.Windows.Forms.PropertyGrid();
            this.gbRename = new System.Windows.Forms.GroupBox();
            this.cbGuessShowName = new System.Windows.Forms.CheckBox();
            this.txtRegexpPattern = new System.Windows.Forms.TextBox();
            this.cbShowActionMessages = new System.Windows.Forms.CheckBox();
            this.lblRegexpPattern = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.scRename.Panel1.SuspendLayout();
            this.scRename.Panel2.SuspendLayout();
            this.scRename.SuspendLayout();
            this.tpExtract.SuspendLayout();
            this.scExtract.Panel1.SuspendLayout();
            this.scExtract.Panel2.SuspendLayout();
            this.scExtract.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.gbRename.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tpExtract);
            this.tcMain.Controls.Add(this.tpConsole);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.Padding = new System.Drawing.Point(15, 4);
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1002, 636);
            this.tcMain.TabIndex = 2;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.scRename);
            this.tpMain.Location = new System.Drawing.Point(4, 24);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(994, 608);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Rename";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // scRename
            // 
            this.scRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRename.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scRename.IsSplitterFixed = true;
            this.scRename.Location = new System.Drawing.Point(3, 3);
            this.scRename.Name = "scRename";
            this.scRename.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRename.Panel1
            // 
            this.scRename.Panel1.Controls.Add(this.lblItemsCount);
            this.scRename.Panel1.Controls.Add(this.lvShows);
            this.scRename.Panel1.Controls.Add(this.cbShowErrors);
            this.scRename.Panel1.Controls.Add(this.btnRenameAll);
            this.scRename.Panel1.Controls.Add(this.btnRenameClear);
            this.scRename.Panel1.Controls.Add(this.lblRenameFileFilter);
            this.scRename.Panel1.Controls.Add(this.txtRenameFileFilter);
            this.scRename.Panel1.Controls.Add(this.lblNameFormat);
            this.scRename.Panel1.Controls.Add(this.btnRenameRemove);
            this.scRename.Panel1.Controls.Add(this.btnRefresh);
            this.scRename.Panel1.Controls.Add(this.txtNameFormat);
            this.scRename.Panel1.Controls.Add(this.btnRenameAdd);
            // 
            // scRename.Panel2
            // 
            this.scRename.Panel2.Controls.Add(this.lvList);
            this.scRename.Size = new System.Drawing.Size(988, 602);
            this.scRename.SplitterDistance = 130;
            this.scRename.SplitterWidth = 2;
            this.scRename.TabIndex = 3;
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.BackColor = System.Drawing.Color.Black;
            this.lblItemsCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemsCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsCount.Location = new System.Drawing.Point(344, 96);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(72, 21);
            this.lblItemsCount.TabIndex = 15;
            this.lblItemsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvShows
            // 
            this.lvShows.AllowDrop = true;
            this.lvShows.CheckBoxes = true;
            this.lvShows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvShowsColumn1});
            this.lvShows.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvShows.FullRowSelect = true;
            this.lvShows.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvShows.HideSelection = false;
            this.lvShows.Location = new System.Drawing.Point(0, 0);
            this.lvShows.Name = "lvShows";
            this.lvShows.ShowItemToolTips = true;
            this.lvShows.Size = new System.Drawing.Size(333, 130);
            this.lvShows.TabIndex = 14;
            this.lvShows.UseCompatibleStateImageBehavior = false;
            this.lvShows.View = System.Windows.Forms.View.Details;
            this.lvShows.SelectedIndexChanged += new System.EventHandler(this.lvShows_SelectedIndexChanged);
            this.lvShows.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvShows_DragDrop);
            this.lvShows.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvShows_DragEnter);
            // 
            // lvShowsColumn1
            // 
            this.lvShowsColumn1.Width = 329;
            // 
            // cbShowErrors
            // 
            this.cbShowErrors.AutoSize = true;
            this.cbShowErrors.Checked = global::RenamerX.Properties.Settings.Default.ShowErrors;
            this.cbShowErrors.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "ShowErrors", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbShowErrors.Location = new System.Drawing.Point(440, 72);
            this.cbShowErrors.Name = "cbShowErrors";
            this.cbShowErrors.Size = new System.Drawing.Size(278, 17);
            this.cbShowErrors.TabIndex = 13;
            this.cbShowErrors.Text = "Show error message dialog boxes while renaming files";
            this.toolTip1.SetToolTip(this.cbShowErrors, "Example if a filename contains illegal characters then \"Illegal characters in pat" +
                    "h\" error will be shown.\r\nIf you press cancel button in this message box then wil" +
                    "l be stop renaming.");
            this.cbShowErrors.UseVisualStyleBackColor = true;
            // 
            // btnRenameAll
            // 
            this.btnRenameAll.Location = new System.Drawing.Point(528, 96);
            this.btnRenameAll.Name = "btnRenameAll";
            this.btnRenameAll.Size = new System.Drawing.Size(80, 24);
            this.btnRenameAll.TabIndex = 12;
            this.btnRenameAll.Text = "Rename all";
            this.btnRenameAll.UseVisualStyleBackColor = true;
            this.btnRenameAll.Click += new System.EventHandler(this.btnRenameAll_Click);
            // 
            // btnRenameClear
            // 
            this.btnRenameClear.Location = new System.Drawing.Point(344, 56);
            this.btnRenameClear.Name = "btnRenameClear";
            this.btnRenameClear.Size = new System.Drawing.Size(72, 24);
            this.btnRenameClear.TabIndex = 11;
            this.btnRenameClear.Text = "Clear";
            this.btnRenameClear.UseVisualStyleBackColor = true;
            this.btnRenameClear.Click += new System.EventHandler(this.btnRenameClear_Click);
            // 
            // lblRenameFileFilter
            // 
            this.lblRenameFileFilter.AutoSize = true;
            this.lblRenameFileFilter.Location = new System.Drawing.Point(437, 40);
            this.lblRenameFileFilter.Name = "lblRenameFileFilter";
            this.lblRenameFileFilter.Size = new System.Drawing.Size(48, 13);
            this.lblRenameFileFilter.TabIndex = 3;
            this.lblRenameFileFilter.Text = "File filter:";
            // 
            // txtRenameFileFilter
            // 
            this.txtRenameFileFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "RenameFileFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRenameFileFilter.Location = new System.Drawing.Point(520, 40);
            this.txtRenameFileFilter.Name = "txtRenameFileFilter";
            this.txtRenameFileFilter.Size = new System.Drawing.Size(176, 20);
            this.txtRenameFileFilter.TabIndex = 2;
            this.txtRenameFileFilter.Text = global::RenamerX.Properties.Settings.Default.RenameFileFilter;
            this.toolTip1.SetToolTip(this.txtRenameFileFilter, resources.GetString("txtRenameFileFilter.ToolTip"));
            // 
            // lblNameFormat
            // 
            this.lblNameFormat.AutoSize = true;
            this.lblNameFormat.Location = new System.Drawing.Point(437, 16);
            this.lblNameFormat.Name = "lblNameFormat";
            this.lblNameFormat.Size = new System.Drawing.Size(70, 13);
            this.lblNameFormat.TabIndex = 4;
            this.lblNameFormat.Text = "Name format:";
            // 
            // btnRenameRemove
            // 
            this.btnRenameRemove.Location = new System.Drawing.Point(344, 32);
            this.btnRenameRemove.Name = "btnRenameRemove";
            this.btnRenameRemove.Size = new System.Drawing.Size(72, 24);
            this.btnRenameRemove.TabIndex = 8;
            this.btnRenameRemove.Text = "Remove";
            this.btnRenameRemove.UseVisualStyleBackColor = true;
            this.btnRenameRemove.Click += new System.EventHandler(this.btnRenameRemove_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(440, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 24);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtNameFormat
            // 
            this.txtNameFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "NameFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNameFormat.Location = new System.Drawing.Point(520, 16);
            this.txtNameFormat.Name = "txtNameFormat";
            this.txtNameFormat.Size = new System.Drawing.Size(176, 20);
            this.txtNameFormat.TabIndex = 0;
            this.txtNameFormat.Text = global::RenamerX.Properties.Settings.Default.NameFormat;
            this.toolTip1.SetToolTip(this.txtNameFormat, resources.GetString("txtNameFormat.ToolTip"));
            // 
            // btnRenameAdd
            // 
            this.btnRenameAdd.Location = new System.Drawing.Point(344, 8);
            this.btnRenameAdd.Name = "btnRenameAdd";
            this.btnRenameAdd.Size = new System.Drawing.Size(72, 24);
            this.btnRenameAdd.TabIndex = 7;
            this.btnRenameAdd.Text = "Add";
            this.btnRenameAdd.UseVisualStyleBackColor = true;
            this.btnRenameAdd.Click += new System.EventHandler(this.btnRenameAdd_Click);
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvListColumn1,
            this.lvListColumn2});
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(0, 0);
            this.lvList.Name = "lvList";
            this.lvList.ShowItemToolTips = true;
            this.lvList.Size = new System.Drawing.Size(988, 470);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // lvListColumn1
            // 
            this.lvListColumn1.Text = "Default filenames";
            this.lvListColumn1.Width = 450;
            // 
            // lvListColumn2
            // 
            this.lvListColumn2.Text = "New filenames";
            this.lvListColumn2.Width = 450;
            // 
            // tpExtract
            // 
            this.tpExtract.Controls.Add(this.scExtract);
            this.tpExtract.Location = new System.Drawing.Point(4, 24);
            this.tpExtract.Name = "tpExtract";
            this.tpExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tpExtract.Size = new System.Drawing.Size(994, 608);
            this.tpExtract.TabIndex = 3;
            this.tpExtract.Text = "Extract";
            this.tpExtract.UseVisualStyleBackColor = true;
            // 
            // scExtract
            // 
            this.scExtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scExtract.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scExtract.IsSplitterFixed = true;
            this.scExtract.Location = new System.Drawing.Point(3, 3);
            this.scExtract.Name = "scExtract";
            this.scExtract.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scExtract.Panel1
            // 
            this.scExtract.Panel1.Controls.Add(this.txtExtractPassword);
            this.scExtract.Panel1.Controls.Add(this.lblExtractPassword);
            this.scExtract.Panel1.Controls.Add(this.cbExtractOverwrite);
            this.scExtract.Panel1.Controls.Add(this.pbExtract);
            this.scExtract.Panel1.Controls.Add(this.lblFileCount);
            this.scExtract.Panel1.Controls.Add(this.txtExtractFileSizeFilter);
            this.scExtract.Panel1.Controls.Add(this.lblExtractFileSizeFilter);
            this.scExtract.Panel1.Controls.Add(this.lblExtractPath);
            this.scExtract.Panel1.Controls.Add(this.txtExtractFileFilter);
            this.scExtract.Panel1.Controls.Add(this.txtExtractPath);
            this.scExtract.Panel1.Controls.Add(this.lblExtractFileFilter);
            this.scExtract.Panel1.Controls.Add(this.txtUnRARPath);
            this.scExtract.Panel1.Controls.Add(this.btnExtractClear);
            this.scExtract.Panel1.Controls.Add(this.cbSearchSubFolders);
            this.scExtract.Panel1.Controls.Add(this.btnExtractRemove);
            this.scExtract.Panel1.Controls.Add(this.lblUnRARPath);
            this.scExtract.Panel1.Controls.Add(this.btnExtractAdd);
            this.scExtract.Panel1.Controls.Add(this.btnExtractBrowse);
            this.scExtract.Panel1.Controls.Add(this.btnExtractAll);
            this.scExtract.Panel1.Controls.Add(this.btnUnRARBrowse);
            // 
            // scExtract.Panel2
            // 
            this.scExtract.Panel2.Controls.Add(this.lvExtractList);
            this.scExtract.Size = new System.Drawing.Size(988, 602);
            this.scExtract.SplitterDistance = 130;
            this.scExtract.SplitterWidth = 2;
            this.scExtract.TabIndex = 12;
            // 
            // txtExtractPassword
            // 
            this.txtExtractPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "ExtractPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtractPassword.Location = new System.Drawing.Point(360, 64);
            this.txtExtractPassword.Name = "txtExtractPassword";
            this.txtExtractPassword.Size = new System.Drawing.Size(192, 20);
            this.txtExtractPassword.TabIndex = 18;
            this.txtExtractPassword.Text = global::RenamerX.Properties.Settings.Default.ExtractPassword;
            // 
            // lblExtractPassword
            // 
            this.lblExtractPassword.AutoSize = true;
            this.lblExtractPassword.Location = new System.Drawing.Point(296, 67);
            this.lblExtractPassword.Name = "lblExtractPassword";
            this.lblExtractPassword.Size = new System.Drawing.Size(56, 13);
            this.lblExtractPassword.TabIndex = 17;
            this.lblExtractPassword.Text = "Password:";
            // 
            // cbExtractOverwrite
            // 
            this.cbExtractOverwrite.AutoSize = true;
            this.cbExtractOverwrite.Checked = global::RenamerX.Properties.Settings.Default.ExtractOverwrite;
            this.cbExtractOverwrite.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "ExtractOverwrite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbExtractOverwrite.Location = new System.Drawing.Point(152, 64);
            this.cbExtractOverwrite.Name = "cbExtractOverwrite";
            this.cbExtractOverwrite.Size = new System.Drawing.Size(125, 17);
            this.cbExtractOverwrite.TabIndex = 16;
            this.cbExtractOverwrite.Text = "Overwrite existing file";
            this.cbExtractOverwrite.UseVisualStyleBackColor = true;
            // 
            // pbExtract
            // 
            this.pbExtract.Location = new System.Drawing.Point(352, 96);
            this.pbExtract.Name = "pbExtract";
            this.pbExtract.Size = new System.Drawing.Size(440, 23);
            this.pbExtract.TabIndex = 15;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(864, 104);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(65, 13);
            this.lblFileCount.TabIndex = 14;
            this.lblFileCount.Text = "File count: 0";
            // 
            // txtExtractFileSizeFilter
            // 
            this.txtExtractFileSizeFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "ExtractFileSizeFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtractFileSizeFilter.Location = new System.Drawing.Point(776, 40);
            this.txtExtractFileSizeFilter.Name = "txtExtractFileSizeFilter";
            this.txtExtractFileSizeFilter.Size = new System.Drawing.Size(176, 20);
            this.txtExtractFileSizeFilter.TabIndex = 13;
            this.txtExtractFileSizeFilter.Text = global::RenamerX.Properties.Settings.Default.ExtractFileSizeFilter;
            this.toolTip1.SetToolTip(this.txtExtractFileSizeFilter, resources.GetString("txtExtractFileSizeFilter.ToolTip"));
            // 
            // lblExtractFileSizeFilter
            // 
            this.lblExtractFileSizeFilter.AutoSize = true;
            this.lblExtractFileSizeFilter.Location = new System.Drawing.Point(696, 44);
            this.lblExtractFileSizeFilter.Name = "lblExtractFileSizeFilter";
            this.lblExtractFileSizeFilter.Size = new System.Drawing.Size(69, 13);
            this.lblExtractFileSizeFilter.TabIndex = 12;
            this.lblExtractFileSizeFilter.Text = "File size filter:";
            // 
            // lblExtractPath
            // 
            this.lblExtractPath.AutoSize = true;
            this.lblExtractPath.Location = new System.Drawing.Point(16, 16);
            this.lblExtractPath.Name = "lblExtractPath";
            this.lblExtractPath.Size = new System.Drawing.Size(55, 13);
            this.lblExtractPath.TabIndex = 2;
            this.lblExtractPath.Text = "Extract to:";
            // 
            // txtExtractFileFilter
            // 
            this.txtExtractFileFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "ExtractFileFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtractFileFilter.Location = new System.Drawing.Point(776, 16);
            this.txtExtractFileFilter.Name = "txtExtractFileFilter";
            this.txtExtractFileFilter.Size = new System.Drawing.Size(176, 20);
            this.txtExtractFileFilter.TabIndex = 1;
            this.txtExtractFileFilter.Text = global::RenamerX.Properties.Settings.Default.ExtractFileFilter;
            this.toolTip1.SetToolTip(this.txtExtractFileFilter, resources.GetString("txtExtractFileFilter.ToolTip"));
            // 
            // txtExtractPath
            // 
            this.txtExtractPath.AllowDrop = true;
            this.txtExtractPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtExtractPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtExtractPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "ExtractPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtractPath.Location = new System.Drawing.Point(112, 12);
            this.txtExtractPath.Name = "txtExtractPath";
            this.txtExtractPath.Size = new System.Drawing.Size(472, 20);
            this.txtExtractPath.TabIndex = 1;
            this.txtExtractPath.Text = global::RenamerX.Properties.Settings.Default.ExtractPath;
            this.toolTip1.SetToolTip(this.txtExtractPath, "Where are you want to extract all files?");
            this.txtExtractPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtExtractPath_DragDrop);
            this.txtExtractPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtExtractPath_DragEnter);
            // 
            // lblExtractFileFilter
            // 
            this.lblExtractFileFilter.AutoSize = true;
            this.lblExtractFileFilter.Location = new System.Drawing.Point(696, 20);
            this.lblExtractFileFilter.Name = "lblExtractFileFilter";
            this.lblExtractFileFilter.Size = new System.Drawing.Size(48, 13);
            this.lblExtractFileFilter.TabIndex = 0;
            this.lblExtractFileFilter.Text = "File filter:";
            // 
            // txtUnRARPath
            // 
            this.txtUnRARPath.AllowDrop = true;
            this.txtUnRARPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnRARPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtUnRARPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "UnRARPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUnRARPath.Location = new System.Drawing.Point(112, 36);
            this.txtUnRARPath.Name = "txtUnRARPath";
            this.txtUnRARPath.Size = new System.Drawing.Size(472, 20);
            this.txtUnRARPath.TabIndex = 4;
            this.txtUnRARPath.Text = global::RenamerX.Properties.Settings.Default.UnRARPath;
            this.toolTip1.SetToolTip(this.txtUnRARPath, "Using WinRAR for extract files. If you have WinRAR then you will find UnRAR.exe i" +
                    "n WinRAR folder.");
            this.txtUnRARPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtUnRARPath_DragDrop);
            this.txtUnRARPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtUnRARPath_DragEnter);
            // 
            // btnExtractClear
            // 
            this.btnExtractClear.Location = new System.Drawing.Point(176, 96);
            this.btnExtractClear.Name = "btnExtractClear";
            this.btnExtractClear.Size = new System.Drawing.Size(72, 24);
            this.btnExtractClear.TabIndex = 11;
            this.btnExtractClear.Text = "Clear";
            this.btnExtractClear.UseVisualStyleBackColor = true;
            this.btnExtractClear.Click += new System.EventHandler(this.btnExtractClear_Click);
            // 
            // cbSearchSubFolders
            // 
            this.cbSearchSubFolders.AutoSize = true;
            this.cbSearchSubFolders.Checked = global::RenamerX.Properties.Settings.Default.SearchSubFolders;
            this.cbSearchSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSearchSubFolders.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "SearchSubFolders", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbSearchSubFolders.Location = new System.Drawing.Point(16, 64);
            this.cbSearchSubFolders.Name = "cbSearchSubFolders";
            this.cbSearchSubFolders.Size = new System.Drawing.Size(114, 17);
            this.cbSearchSubFolders.TabIndex = 7;
            this.cbSearchSubFolders.Text = "Search sub folders";
            this.toolTip1.SetToolTip(this.cbSearchSubFolders, "Example if you added this folder: E:\\TV\\Lost\r\nThen will be search sub folders too" +
                    " (Season 1, Season 2...)");
            this.cbSearchSubFolders.UseVisualStyleBackColor = true;
            // 
            // btnExtractRemove
            // 
            this.btnExtractRemove.Location = new System.Drawing.Point(96, 96);
            this.btnExtractRemove.Name = "btnExtractRemove";
            this.btnExtractRemove.Size = new System.Drawing.Size(72, 24);
            this.btnExtractRemove.TabIndex = 10;
            this.btnExtractRemove.Text = "Remove";
            this.btnExtractRemove.UseVisualStyleBackColor = true;
            this.btnExtractRemove.Click += new System.EventHandler(this.btnExtractRemove_Click);
            // 
            // lblUnRARPath
            // 
            this.lblUnRARPath.AutoSize = true;
            this.lblUnRARPath.Location = new System.Drawing.Point(16, 40);
            this.lblUnRARPath.Name = "lblUnRARPath";
            this.lblUnRARPath.Size = new System.Drawing.Size(91, 13);
            this.lblUnRARPath.TabIndex = 3;
            this.lblUnRARPath.Text = "UnRAR.exe path:";
            // 
            // btnExtractAdd
            // 
            this.btnExtractAdd.Location = new System.Drawing.Point(16, 96);
            this.btnExtractAdd.Name = "btnExtractAdd";
            this.btnExtractAdd.Size = new System.Drawing.Size(72, 24);
            this.btnExtractAdd.TabIndex = 9;
            this.btnExtractAdd.Text = "Add";
            this.btnExtractAdd.UseVisualStyleBackColor = true;
            this.btnExtractAdd.Click += new System.EventHandler(this.btnExtractAdd_Click);
            // 
            // btnExtractBrowse
            // 
            this.btnExtractBrowse.Location = new System.Drawing.Point(592, 12);
            this.btnExtractBrowse.Name = "btnExtractBrowse";
            this.btnExtractBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnExtractBrowse.TabIndex = 5;
            this.btnExtractBrowse.Text = "Browse...";
            this.btnExtractBrowse.UseVisualStyleBackColor = true;
            this.btnExtractBrowse.Click += new System.EventHandler(this.btnExtractBrowse_Click);
            // 
            // btnExtractAll
            // 
            this.btnExtractAll.Location = new System.Drawing.Point(256, 96);
            this.btnExtractAll.Name = "btnExtractAll";
            this.btnExtractAll.Size = new System.Drawing.Size(88, 24);
            this.btnExtractAll.TabIndex = 8;
            this.btnExtractAll.Text = "Extract all";
            this.btnExtractAll.UseVisualStyleBackColor = true;
            this.btnExtractAll.Click += new System.EventHandler(this.btnExtractAll_Click);
            // 
            // btnUnRARBrowse
            // 
            this.btnUnRARBrowse.Location = new System.Drawing.Point(592, 36);
            this.btnUnRARBrowse.Name = "btnUnRARBrowse";
            this.btnUnRARBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnUnRARBrowse.TabIndex = 6;
            this.btnUnRARBrowse.Text = "Browse...";
            this.btnUnRARBrowse.UseVisualStyleBackColor = true;
            this.btnUnRARBrowse.Click += new System.EventHandler(this.btnUnRARBrowse_Click);
            // 
            // lvExtractList
            // 
            this.lvExtractList.AllowDrop = true;
            this.lvExtractList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvExtractList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExtractList.FullRowSelect = true;
            this.lvExtractList.HideSelection = false;
            this.lvExtractList.Location = new System.Drawing.Point(0, 0);
            this.lvExtractList.MultiSelect = false;
            this.lvExtractList.Name = "lvExtractList";
            this.lvExtractList.Size = new System.Drawing.Size(988, 470);
            this.lvExtractList.TabIndex = 0;
            this.lvExtractList.UseCompatibleStateImageBehavior = false;
            this.lvExtractList.View = System.Windows.Forms.View.Details;
            this.lvExtractList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvExtractList_DragDrop);
            this.lvExtractList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvExtractList_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Files";
            this.columnHeader1.Width = 972;
            // 
            // tpConsole
            // 
            this.tpConsole.Controls.Add(this.txtConsole);
            this.tpConsole.Location = new System.Drawing.Point(4, 24);
            this.tpConsole.Name = "tpConsole";
            this.tpConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsole.Size = new System.Drawing.Size(994, 608);
            this.tpConsole.TabIndex = 1;
            this.tpConsole.Text = "Console";
            this.tpConsole.UseVisualStyleBackColor = true;
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Location = new System.Drawing.Point(3, 3);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(988, 602);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.WordWrap = false;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.pgApp);
            this.tpSettings.Controls.Add(this.gbRename);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(994, 608);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // pgApp
            // 
            this.pgApp.HelpVisible = false;
            this.pgApp.Location = new System.Drawing.Point(8, 248);
            this.pgApp.Name = "pgApp";
            this.pgApp.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.pgApp.Size = new System.Drawing.Size(976, 352);
            this.pgApp.TabIndex = 5;
            this.pgApp.ToolbarVisible = false;
            // 
            // gbRename
            // 
            this.gbRename.Controls.Add(this.cbGuessShowName);
            this.gbRename.Controls.Add(this.txtRegexpPattern);
            this.gbRename.Controls.Add(this.cbShowActionMessages);
            this.gbRename.Controls.Add(this.lblRegexpPattern);
            this.gbRename.Location = new System.Drawing.Point(8, 8);
            this.gbRename.Name = "gbRename";
            this.gbRename.Size = new System.Drawing.Size(976, 232);
            this.gbRename.TabIndex = 3;
            this.gbRename.TabStop = false;
            this.gbRename.Text = "Rename settings";
            // 
            // cbGuessShowName
            // 
            this.cbGuessShowName.AutoSize = true;
            this.cbGuessShowName.Checked = global::RenamerX.Properties.Settings.Default.GuessShowName;
            this.cbGuessShowName.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "GuessShowName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbGuessShowName.Location = new System.Drawing.Point(16, 104);
            this.cbGuessShowName.Name = "cbGuessShowName";
            this.cbGuessShowName.Size = new System.Drawing.Size(301, 17);
            this.cbGuessShowName.TabIndex = 4;
            this.cbGuessShowName.Text = "Guess show name as root folder name instead folder name";
            this.toolTip1.SetToolTip(this.cbGuessShowName, resources.GetString("cbGuessShowName.ToolTip"));
            this.cbGuessShowName.UseVisualStyleBackColor = true;
            // 
            // txtRegexpPattern
            // 
            this.txtRegexpPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "RegexpPattern", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRegexpPattern.Location = new System.Drawing.Point(16, 48);
            this.txtRegexpPattern.Name = "txtRegexpPattern";
            this.txtRegexpPattern.Size = new System.Drawing.Size(944, 20);
            this.txtRegexpPattern.TabIndex = 0;
            this.txtRegexpPattern.Text = global::RenamerX.Properties.Settings.Default.RegexpPattern;
            this.toolTip1.SetToolTip(this.txtRegexpPattern, "For find episode name need to know show and episode numbers.\r\nFor find this numbe" +
                    "rs using regular expression with this pattern.");
            // 
            // cbShowActionMessages
            // 
            this.cbShowActionMessages.AutoSize = true;
            this.cbShowActionMessages.Checked = global::RenamerX.Properties.Settings.Default.ShowActionMessages;
            this.cbShowActionMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "ShowActionMessages", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbShowActionMessages.Location = new System.Drawing.Point(16, 80);
            this.cbShowActionMessages.Name = "cbShowActionMessages";
            this.cbShowActionMessages.Size = new System.Drawing.Size(447, 17);
            this.cbShowActionMessages.TabIndex = 2;
            this.cbShowActionMessages.Text = "Add important debug information (start and finish messages) for every show to the" +
                " console";
            this.toolTip1.SetToolTip(this.cbShowActionMessages, resources.GetString("cbShowActionMessages.ToolTip"));
            this.cbShowActionMessages.UseVisualStyleBackColor = true;
            // 
            // lblRegexpPattern
            // 
            this.lblRegexpPattern.AutoSize = true;
            this.lblRegexpPattern.Location = new System.Drawing.Point(16, 24);
            this.lblRegexpPattern.Name = "lblRegexpPattern";
            this.lblRegexpPattern.Size = new System.Drawing.Size(273, 13);
            this.lblRegexpPattern.TabIndex = 1;
            this.lblRegexpPattern.Text = "Regexp pattern for finding season and episode numbers:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 20;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.tcMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenamerX - Rename your files eXpressly";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.scRename.Panel1.ResumeLayout(false);
            this.scRename.Panel1.PerformLayout();
            this.scRename.Panel2.ResumeLayout(false);
            this.scRename.ResumeLayout(false);
            this.tpExtract.ResumeLayout(false);
            this.scExtract.Panel1.ResumeLayout(false);
            this.scExtract.Panel1.PerformLayout();
            this.scExtract.Panel2.ResumeLayout(false);
            this.scExtract.ResumeLayout(false);
            this.tpConsole.ResumeLayout(false);
            this.tpConsole.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.gbRename.ResumeLayout(false);
            this.gbRename.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpConsole;
        private System.Windows.Forms.TextBox txtNameFormat;
        private System.Windows.Forms.TextBox txtRenameFileFilter;
        private System.Windows.Forms.Label lblNameFormat;
        private System.Windows.Forms.Label lblRenameFileFilter;
        private System.Windows.Forms.Button btnRenameAdd;
        private System.Windows.Forms.Button btnRenameRemove;
        private System.Windows.Forms.SplitContainer scRename;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRenameClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRenameAll;
        private System.Windows.Forms.CheckBox cbShowErrors;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ListView lvShows;
        private System.Windows.Forms.ColumnHeader lvListColumn1;
        private System.Windows.Forms.ColumnHeader lvShowsColumn1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.Label lblRegexpPattern;
        private System.Windows.Forms.TextBox txtRegexpPattern;
        private System.Windows.Forms.ColumnHeader lvListColumn2;
        private System.Windows.Forms.CheckBox cbShowActionMessages;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.TabPage tpExtract;
        private System.Windows.Forms.Label lblExtractPath;
        private System.Windows.Forms.TextBox txtExtractPath;
        private System.Windows.Forms.ListView lvExtractList;
        private System.Windows.Forms.TextBox txtUnRARPath;
        private System.Windows.Forms.Label lblUnRARPath;
        private System.Windows.Forms.GroupBox gbRename;
        private System.Windows.Forms.Button btnExtractAdd;
        private System.Windows.Forms.Button btnExtractAll;
        private System.Windows.Forms.CheckBox cbSearchSubFolders;
        private System.Windows.Forms.Button btnUnRARBrowse;
        private System.Windows.Forms.Button btnExtractBrowse;
        private System.Windows.Forms.Button btnExtractClear;
        private System.Windows.Forms.Button btnExtractRemove;
        private System.Windows.Forms.Label lblExtractFileFilter;
        private System.Windows.Forms.TextBox txtExtractFileFilter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PropertyGrid pgApp;
        private System.Windows.Forms.SplitContainer scExtract;
        private System.Windows.Forms.TextBox txtExtractFileSizeFilter;
        private System.Windows.Forms.Label lblExtractFileSizeFilter;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.CheckBox cbGuessShowName;
        private System.Windows.Forms.ProgressBar pbExtract;
        private System.Windows.Forms.CheckBox cbExtractOverwrite;
        private System.Windows.Forms.TextBox txtExtractPassword;
        private System.Windows.Forms.Label lblExtractPassword;
    }
}