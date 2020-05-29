﻿namespace Fo76ini
{
    partial class FormMods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMods));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModarchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deployToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConflictingFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairddsFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showREADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarMods = new System.Windows.Forms.ProgressBar();
            this.buttonModsDeploy = new System.Windows.Forms.Button();
            this.labelModsDeploy = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageModOrder = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddModFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCheckAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonModEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteMod = new System.Windows.Forms.ToolStripButton();
            this.listViewMods = new System.Windows.Forms.ListView();
            this.columnHeaderModTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstallAs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstallInto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArchiveName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArchiveFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageModsSettings = new System.Windows.Forms.TabPage();
            this.groupBoxGamePaths = new System.Windows.Forms.GroupBox();
            this.labelGamePath = new System.Windows.Forms.Label();
            this.textBoxGamePath = new System.Windows.Forms.TextBox();
            this.buttonPickGamePath = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogMod = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogMod = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxDisableMods = new System.Windows.Forms.CheckBox();
            this.openFileDialogGamePath = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageModOrder.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPageModsSettings.SuspendLayout();
            this.groupBoxGamePaths.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModarchiveToolStripMenuItem,
            this.toolStripMenuItemModsImport,
            this.toolStripSeparator1,
            this.deployToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addModarchiveToolStripMenuItem
            // 
            this.addModarchiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromArchiveToolStripMenuItem,
            this.fromFolderToolStripMenuItem});
            this.addModarchiveToolStripMenuItem.Name = "addModarchiveToolStripMenuItem";
            this.addModarchiveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addModarchiveToolStripMenuItem.Text = "Add mod";
            // 
            // fromArchiveToolStripMenuItem
            // 
            this.fromArchiveToolStripMenuItem.Name = "fromArchiveToolStripMenuItem";
            this.fromArchiveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.fromArchiveToolStripMenuItem.Text = "From archive";
            this.fromArchiveToolStripMenuItem.Click += new System.EventHandler(this.fromArchiveToolStripMenuItem_Click);
            // 
            // fromFolderToolStripMenuItem
            // 
            this.fromFolderToolStripMenuItem.Name = "fromFolderToolStripMenuItem";
            this.fromFolderToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.fromFolderToolStripMenuItem.Text = "From folder";
            this.fromFolderToolStripMenuItem.Click += new System.EventHandler(this.fromFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItemModsImport
            // 
            this.toolStripMenuItemModsImport.Name = "toolStripMenuItemModsImport";
            this.toolStripMenuItemModsImport.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemModsImport.Text = "Import installed mods";
            this.toolStripMenuItemModsImport.Click += new System.EventHandler(this.toolStripMenuItemModsImport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // deployToolStripMenuItem
            // 
            this.deployToolStripMenuItem.Name = "deployToolStripMenuItem";
            this.deployToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deployToolStripMenuItem.Text = "Deploy";
            this.deployToolStripMenuItem.Click += new System.EventHandler(this.deployToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showConflictingFilesToolStripMenuItem,
            this.reloadUIToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // showConflictingFilesToolStripMenuItem
            // 
            this.showConflictingFilesToolStripMenuItem.Name = "showConflictingFilesToolStripMenuItem";
            this.showConflictingFilesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showConflictingFilesToolStripMenuItem.Text = "Show conflicting files";
            this.showConflictingFilesToolStripMenuItem.Click += new System.EventHandler(this.showConflictingFilesToolStripMenuItem_Click);
            // 
            // reloadUIToolStripMenuItem
            // 
            this.reloadUIToolStripMenuItem.Name = "reloadUIToolStripMenuItem";
            this.reloadUIToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reloadUIToolStripMenuItem.Text = "Reload UI";
            this.reloadUIToolStripMenuItem.Click += new System.EventHandler(this.reloadUIToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repairddsFilesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // repairddsFilesToolStripMenuItem
            // 
            this.repairddsFilesToolStripMenuItem.Name = "repairddsFilesToolStripMenuItem";
            this.repairddsFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.repairddsFilesToolStripMenuItem.Text = "Repair all *.dds files";
            this.repairddsFilesToolStripMenuItem.Click += new System.EventHandler(this.repairddsFilesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showREADMEToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // showREADMEToolStripMenuItem
            // 
            this.showREADMEToolStripMenuItem.Name = "showREADMEToolStripMenuItem";
            this.showREADMEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showREADMEToolStripMenuItem.Text = "Show README";
            this.showREADMEToolStripMenuItem.Click += new System.EventHandler(this.showREADMEToolStripMenuItem_Click);
            // 
            // progressBarMods
            // 
            this.progressBarMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMods.Location = new System.Drawing.Point(12, 526);
            this.progressBarMods.Name = "progressBarMods";
            this.progressBarMods.Size = new System.Drawing.Size(280, 23);
            this.progressBarMods.TabIndex = 51;
            // 
            // buttonModsDeploy
            // 
            this.buttonModsDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModsDeploy.Location = new System.Drawing.Point(3, 22);
            this.buttonModsDeploy.Name = "buttonModsDeploy";
            this.buttonModsDeploy.Size = new System.Drawing.Size(154, 23);
            this.buttonModsDeploy.TabIndex = 50;
            this.buttonModsDeploy.Text = "Deploy";
            this.buttonModsDeploy.UseVisualStyleBackColor = true;
            this.buttonModsDeploy.Click += new System.EventHandler(this.buttonModsDeploy_Click);
            // 
            // labelModsDeploy
            // 
            this.labelModsDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelModsDeploy.AutoSize = true;
            this.labelModsDeploy.ForeColor = System.Drawing.Color.Crimson;
            this.labelModsDeploy.Location = new System.Drawing.Point(12, 510);
            this.labelModsDeploy.Name = "labelModsDeploy";
            this.labelModsDeploy.Size = new System.Drawing.Size(114, 13);
            this.labelModsDeploy.TabIndex = 52;
            this.labelModsDeploy.Text = "Deployment necessary";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageModOrder);
            this.tabControl1.Controls.Add(this.tabPageModsSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 470);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPageModOrder
            // 
            this.tabPageModOrder.Controls.Add(this.toolStrip1);
            this.tabPageModOrder.Controls.Add(this.listViewMods);
            this.tabPageModOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageModOrder.Name = "tabPageModOrder";
            this.tabPageModOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModOrder.Size = new System.Drawing.Size(432, 444);
            this.tabPageModOrder.TabIndex = 0;
            this.tabPageModOrder.Text = "Mod order";
            this.tabPageModOrder.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddMod,
            this.toolStripButtonAddModFolder,
            this.toolStripSeparator4,
            this.toolStripButtonCheckAll,
            this.toolStripSeparator2,
            this.toolStripButtonMoveUp,
            this.toolStripButtonMoveDown,
            this.toolStripSeparator3,
            this.toolStripButtonModEdit,
            this.toolStripButtonModOpenFolder,
            this.toolStripSeparator5,
            this.toolStripButtonDeleteMod});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(31, 438);
            this.toolStrip1.TabIndex = 44;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddMod
            // 
            this.toolStripButtonAddMod.AutoSize = false;
            this.toolStripButtonAddMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddMod.Image = global::Fo76ini.Properties.Resources.plus;
            this.toolStripButtonAddMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddMod.Name = "toolStripButtonAddMod";
            this.toolStripButtonAddMod.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonAddMod.Text = "Add mod (from archive)";
            this.toolStripButtonAddMod.Click += new System.EventHandler(this.toolStripButtonAddMod_Click);
            // 
            // toolStripButtonAddModFolder
            // 
            this.toolStripButtonAddModFolder.AutoSize = false;
            this.toolStripButtonAddModFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddModFolder.Image = global::Fo76ini.Properties.Resources.folder_plus;
            this.toolStripButtonAddModFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddModFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddModFolder.Name = "toolStripButtonAddModFolder";
            this.toolStripButtonAddModFolder.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonAddModFolder.Text = "Add mod (from folder)";
            this.toolStripButtonAddModFolder.Click += new System.EventHandler(this.toolStripButtonAddModFolder_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(28, 6);
            // 
            // toolStripButtonCheckAll
            // 
            this.toolStripButtonCheckAll.AutoSize = false;
            this.toolStripButtonCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCheckAll.Image = global::Fo76ini.Properties.Resources.checkbox_checked;
            this.toolStripButtonCheckAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCheckAll.Name = "toolStripButtonCheckAll";
            this.toolStripButtonCheckAll.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonCheckAll.Text = "Check/uncheck all";
            this.toolStripButtonCheckAll.Click += new System.EventHandler(this.toolStripButtonCheckAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(28, 6);
            // 
            // toolStripButtonMoveUp
            // 
            this.toolStripButtonMoveUp.AutoSize = false;
            this.toolStripButtonMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveUp.Image")));
            this.toolStripButtonMoveUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveUp.Name = "toolStripButtonMoveUp";
            this.toolStripButtonMoveUp.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonMoveUp.Text = "Move up";
            this.toolStripButtonMoveUp.Click += new System.EventHandler(this.toolStripButtonMoveUp_Click);
            // 
            // toolStripButtonMoveDown
            // 
            this.toolStripButtonMoveDown.AutoSize = false;
            this.toolStripButtonMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveDown.Image = global::Fo76ini.Properties.Resources.arrow_down;
            this.toolStripButtonMoveDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveDown.Name = "toolStripButtonMoveDown";
            this.toolStripButtonMoveDown.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonMoveDown.Text = "Move down";
            this.toolStripButtonMoveDown.Click += new System.EventHandler(this.toolStripButtonMoveDown_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(28, 6);
            // 
            // toolStripButtonModEdit
            // 
            this.toolStripButtonModEdit.AutoSize = false;
            this.toolStripButtonModEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonModEdit.Image = global::Fo76ini.Properties.Resources.pencil;
            this.toolStripButtonModEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonModEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModEdit.Name = "toolStripButtonModEdit";
            this.toolStripButtonModEdit.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonModEdit.Text = "Edit mod details";
            this.toolStripButtonModEdit.Click += new System.EventHandler(this.toolStripButtonModEdit_Click);
            // 
            // toolStripButtonModOpenFolder
            // 
            this.toolStripButtonModOpenFolder.AutoSize = false;
            this.toolStripButtonModOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonModOpenFolder.Image = global::Fo76ini.Properties.Resources.folder_open;
            this.toolStripButtonModOpenFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonModOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModOpenFolder.Name = "toolStripButtonModOpenFolder";
            this.toolStripButtonModOpenFolder.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonModOpenFolder.Text = "Open mod folder";
            this.toolStripButtonModOpenFolder.Click += new System.EventHandler(this.toolStripButtonModOpenFolder_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(28, 6);
            // 
            // toolStripButtonDeleteMod
            // 
            this.toolStripButtonDeleteMod.AutoSize = false;
            this.toolStripButtonDeleteMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteMod.Image = global::Fo76ini.Properties.Resources.bin;
            this.toolStripButtonDeleteMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDeleteMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteMod.Name = "toolStripButtonDeleteMod";
            this.toolStripButtonDeleteMod.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonDeleteMod.Text = "Delete mod";
            this.toolStripButtonDeleteMod.Click += new System.EventHandler(this.toolStripButtonDeleteMod_Click);
            // 
            // listViewMods
            // 
            this.listViewMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMods.CausesValidation = false;
            this.listViewMods.CheckBoxes = true;
            this.listViewMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderModTitle,
            this.columnHeaderInstallAs,
            this.columnHeaderInstallInto,
            this.columnHeaderArchiveName,
            this.columnHeaderArchiveFormat});
            this.listViewMods.FullRowSelect = true;
            this.listViewMods.GridLines = true;
            this.listViewMods.HideSelection = false;
            this.listViewMods.LabelWrap = false;
            this.listViewMods.Location = new System.Drawing.Point(40, 3);
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(386, 432);
            this.listViewMods.TabIndex = 41;
            this.listViewMods.TabStop = false;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            this.listViewMods.SelectedIndexChanged += new System.EventHandler(this.listViewMods_SelectedIndexChanged);
            // 
            // columnHeaderModTitle
            // 
            this.columnHeaderModTitle.Text = "Mod name";
            this.columnHeaderModTitle.Width = 342;
            // 
            // columnHeaderInstallAs
            // 
            this.columnHeaderInstallAs.Text = "Type";
            // 
            // columnHeaderInstallInto
            // 
            this.columnHeaderInstallInto.Text = "Install into";
            // 
            // columnHeaderArchiveName
            // 
            this.columnHeaderArchiveName.Text = "Archive name";
            this.columnHeaderArchiveName.Width = 100;
            // 
            // columnHeaderArchiveFormat
            // 
            this.columnHeaderArchiveFormat.Text = "Archive format";
            this.columnHeaderArchiveFormat.Width = 90;
            // 
            // tabPageModsSettings
            // 
            this.tabPageModsSettings.Controls.Add(this.groupBoxGamePaths);
            this.tabPageModsSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageModsSettings.Name = "tabPageModsSettings";
            this.tabPageModsSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModsSettings.Size = new System.Drawing.Size(432, 444);
            this.tabPageModsSettings.TabIndex = 1;
            this.tabPageModsSettings.Text = "Settings";
            this.tabPageModsSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxGamePaths
            // 
            this.groupBoxGamePaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGamePaths.Controls.Add(this.labelGamePath);
            this.groupBoxGamePaths.Controls.Add(this.textBoxGamePath);
            this.groupBoxGamePaths.Controls.Add(this.buttonPickGamePath);
            this.groupBoxGamePaths.Location = new System.Drawing.Point(6, 6);
            this.groupBoxGamePaths.Name = "groupBoxGamePaths";
            this.groupBoxGamePaths.Size = new System.Drawing.Size(420, 52);
            this.groupBoxGamePaths.TabIndex = 53;
            this.groupBoxGamePaths.TabStop = false;
            this.groupBoxGamePaths.Text = "Paths";
            // 
            // labelGamePath
            // 
            this.labelGamePath.AutoSize = true;
            this.labelGamePath.Location = new System.Drawing.Point(6, 20);
            this.labelGamePath.Name = "labelGamePath";
            this.labelGamePath.Size = new System.Drawing.Size(78, 13);
            this.labelGamePath.TabIndex = 14;
            this.labelGamePath.Text = "Game location:";
            // 
            // textBoxGamePath
            // 
            this.textBoxGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGamePath.Location = new System.Drawing.Point(123, 17);
            this.textBoxGamePath.Name = "textBoxGamePath";
            this.textBoxGamePath.Size = new System.Drawing.Size(259, 20);
            this.textBoxGamePath.TabIndex = 15;
            this.textBoxGamePath.TextChanged += new System.EventHandler(this.textBoxGamePath_TextChanged);
            // 
            // buttonPickGamePath
            // 
            this.buttonPickGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPickGamePath.Location = new System.Drawing.Point(388, 15);
            this.buttonPickGamePath.Name = "buttonPickGamePath";
            this.buttonPickGamePath.Size = new System.Drawing.Size(26, 23);
            this.buttonPickGamePath.TabIndex = 16;
            this.buttonPickGamePath.Text = "...";
            this.buttonPickGamePath.UseVisualStyleBackColor = true;
            this.buttonPickGamePath.Click += new System.EventHandler(this.buttonPickGamePath_Click);
            // 
            // openFileDialogMod
            // 
            this.openFileDialogMod.Filter = "All Archives|*.zip;*.rar;*.7z;*.tar;*.tar.gz;*.gz;*.xz;*.lz;*.bz2|Archive2|*.ba2";
            this.openFileDialogMod.Title = "Add *.ba2 or any other archive.";
            // 
            // checkBoxDisableMods
            // 
            this.checkBoxDisableMods.AutoSize = true;
            this.checkBoxDisableMods.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDisableMods.Name = "checkBoxDisableMods";
            this.checkBoxDisableMods.Size = new System.Drawing.Size(89, 17);
            this.checkBoxDisableMods.TabIndex = 55;
            this.checkBoxDisableMods.Text = "Disable mods";
            this.checkBoxDisableMods.UseVisualStyleBackColor = true;
            this.checkBoxDisableMods.CheckedChanged += new System.EventHandler(this.checkBoxDisableMods_CheckedChanged);
            // 
            // openFileDialogGamePath
            // 
            this.openFileDialogGamePath.FileName = "Fallout76.exe";
            this.openFileDialogGamePath.Filter = "Fallout76.exe|Fallout76.exe";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonModsDeploy);
            this.panel1.Controls.Add(this.checkBoxDisableMods);
            this.panel1.Location = new System.Drawing.Point(298, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 58);
            this.panel1.TabIndex = 56;
            // 
            // FormMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBarMods);
            this.Controls.Add(this.labelModsDeploy);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 600);
            this.Name = "FormMods";
            this.Text = "Manage mods";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageModOrder.ResumeLayout(false);
            this.tabPageModOrder.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPageModsSettings.ResumeLayout(false);
            this.groupBoxGamePaths.ResumeLayout(false);
            this.groupBoxGamePaths.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModarchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModsImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deployToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showREADMEToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarMods;
        private System.Windows.Forms.Button buttonModsDeploy;
        private System.Windows.Forms.Label labelModsDeploy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageModOrder;
        private System.Windows.Forms.TabPage tabPageModsSettings;
        public System.Windows.Forms.ListView listViewMods;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveUp;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveDown;
        private System.Windows.Forms.ToolStripButton toolStripButtonModEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonModOpenFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddModFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColumnHeader columnHeaderModTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderInstallAs;
        private System.Windows.Forms.ColumnHeader columnHeaderArchiveFormat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddMod;
        private System.Windows.Forms.ToolStripButton toolStripButtonCheckAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteMod;
        private System.Windows.Forms.OpenFileDialog openFileDialogMod;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMod;
        private System.Windows.Forms.CheckBox checkBoxDisableMods;
        private System.Windows.Forms.OpenFileDialog openFileDialogGamePath;
        private System.Windows.Forms.GroupBox groupBoxGamePaths;
        private System.Windows.Forms.Label labelGamePath;
        private System.Windows.Forms.TextBox textBoxGamePath;
        private System.Windows.Forms.Button buttonPickGamePath;
        private System.Windows.Forms.ColumnHeader columnHeaderInstallInto;
        private System.Windows.Forms.ColumnHeader columnHeaderArchiveName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem showConflictingFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairddsFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadUIToolStripMenuItem;
    }
}