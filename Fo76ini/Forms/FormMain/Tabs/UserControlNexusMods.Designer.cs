﻿namespace Fo76ini.Forms.FormMain.Tabs
{
    partial class UserControlNexusMods
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlNexusMods));
            this.labelTitleNexus = new System.Windows.Forms.Label();
            this.labelNexusDesc = new System.Windows.Forms.Label();
            this.panelManageNMProfile = new System.Windows.Forms.Panel();
            this.linkLabelEnableAPIKey = new System.Windows.Forms.LinkLabel();
            this.pictureBoxAPIKeyHelp = new System.Windows.Forms.PictureBox();
            this.linkLabelAPIKeyHelp = new System.Windows.Forms.LinkLabel();
            this.buttonNMLoginManually = new System.Windows.Forms.Button();
            this.labelAPIKey = new System.Windows.Forms.Label();
            this.checkBoxShowAPIKey = new System.Windows.Forms.CheckBox();
            this.textBoxAPIKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNMLogin = new System.Windows.Forms.Button();
            this.buttonNWDeleteCache = new System.Windows.Forms.Button();
            this.buttonNWLogout = new System.Windows.Forms.Button();
            this.checkBoxNMDownloadThumbnails = new System.Windows.Forms.CheckBox();
            this.labelNMOptions = new System.Windows.Forms.Label();
            this.checkBoxNMUpdateProfile = new System.Windows.Forms.CheckBox();
            this.buttonNMUpdateProfile = new System.Windows.Forms.Button();
            this.panelNMProfile = new System.Windows.Forms.Panel();
            this.labelNMNotLoggedIn = new System.Windows.Forms.Label();
            this.labelNMUserID = new System.Windows.Forms.Label();
            this.labelNMDescUserID = new System.Windows.Forms.Label();
            this.labelNMHourlyRateLimit = new System.Windows.Forms.Label();
            this.labelNMDescHourlyRateLimit = new System.Windows.Forms.Label();
            this.pictureBoxNMProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelNMUserName = new System.Windows.Forms.Label();
            this.labelNMDescMembership = new System.Windows.Forms.Label();
            this.labelNMRateLimitReset = new System.Windows.Forms.Label();
            this.labelNMMembership = new System.Windows.Forms.Label();
            this.labelNMDescLimitReset = new System.Windows.Forms.Label();
            this.labelNMDescDailyRateLimit = new System.Windows.Forms.Label();
            this.labelNMDailyRateLimit = new System.Windows.Forms.Label();
            this.backgroundWorkerRetrieveProfileInfo = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSSOLogin = new System.ComponentModel.BackgroundWorker();
            this.panelManageNMProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAPIKeyHelp)).BeginInit();
            this.panelNMProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNMProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleNexus
            // 
            this.labelTitleNexus.AutoSize = true;
            this.labelTitleNexus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleNexus.Location = new System.Drawing.Point(6, 6);
            this.labelTitleNexus.Name = "labelTitleNexus";
            this.labelTitleNexus.Size = new System.Drawing.Size(204, 24);
            this.labelTitleNexus.TabIndex = 4;
            this.labelTitleNexus.Text = "NexusMods Integration";
            // 
            // labelNexusDesc
            // 
            this.labelNexusDesc.AutoSize = true;
            this.labelNexusDesc.Location = new System.Drawing.Point(7, 30);
            this.labelNexusDesc.Name = "labelNexusDesc";
            this.labelNexusDesc.Size = new System.Drawing.Size(274, 13);
            this.labelNexusDesc.TabIndex = 75;
            this.labelNexusDesc.Text = "Login to your NexusMods account to use the integration.";
            // 
            // panelManageNMProfile
            // 
            this.panelManageNMProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManageNMProfile.BackColor = System.Drawing.SystemColors.Window;
            this.panelManageNMProfile.Controls.Add(this.linkLabelEnableAPIKey);
            this.panelManageNMProfile.Controls.Add(this.pictureBoxAPIKeyHelp);
            this.panelManageNMProfile.Controls.Add(this.linkLabelAPIKeyHelp);
            this.panelManageNMProfile.Controls.Add(this.buttonNMLoginManually);
            this.panelManageNMProfile.Controls.Add(this.labelAPIKey);
            this.panelManageNMProfile.Controls.Add(this.checkBoxShowAPIKey);
            this.panelManageNMProfile.Controls.Add(this.textBoxAPIKey);
            this.panelManageNMProfile.Controls.Add(this.label1);
            this.panelManageNMProfile.Controls.Add(this.buttonNMLogin);
            this.panelManageNMProfile.Controls.Add(this.buttonNWDeleteCache);
            this.panelManageNMProfile.Controls.Add(this.buttonNWLogout);
            this.panelManageNMProfile.Controls.Add(this.checkBoxNMDownloadThumbnails);
            this.panelManageNMProfile.Controls.Add(this.labelNMOptions);
            this.panelManageNMProfile.Controls.Add(this.checkBoxNMUpdateProfile);
            this.panelManageNMProfile.Controls.Add(this.buttonNMUpdateProfile);
            this.panelManageNMProfile.Location = new System.Drawing.Point(0, 228);
            this.panelManageNMProfile.Name = "panelManageNMProfile";
            this.panelManageNMProfile.Size = new System.Drawing.Size(700, 372);
            this.panelManageNMProfile.TabIndex = 80;
            // 
            // linkLabelEnableAPIKey
            // 
            this.linkLabelEnableAPIKey.AutoSize = true;
            this.linkLabelEnableAPIKey.Location = new System.Drawing.Point(6, 335);
            this.linkLabelEnableAPIKey.Name = "linkLabelEnableAPIKey";
            this.linkLabelEnableAPIKey.Size = new System.Drawing.Size(287, 13);
            this.linkLabelEnableAPIKey.TabIndex = 113;
            this.linkLabelEnableAPIKey.TabStop = true;
            this.linkLabelEnableAPIKey.Text = "Login doesn\'t work? Click here to use your API key instead.";
            this.linkLabelEnableAPIKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEnableAPIKey_LinkClicked);
            // 
            // pictureBoxAPIKeyHelp
            // 
            this.pictureBoxAPIKeyHelp.Image = global::Fo76ini.Properties.Resources.help_24;
            this.pictureBoxAPIKeyHelp.Location = new System.Drawing.Point(20, 251);
            this.pictureBoxAPIKeyHelp.Name = "pictureBoxAPIKeyHelp";
            this.pictureBoxAPIKeyHelp.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxAPIKeyHelp.TabIndex = 112;
            this.pictureBoxAPIKeyHelp.TabStop = false;
            // 
            // linkLabelAPIKeyHelp
            // 
            this.linkLabelAPIKeyHelp.AutoSize = true;
            this.linkLabelAPIKeyHelp.Location = new System.Drawing.Point(51, 257);
            this.linkLabelAPIKeyHelp.Name = "linkLabelAPIKeyHelp";
            this.linkLabelAPIKeyHelp.Size = new System.Drawing.Size(158, 13);
            this.linkLabelAPIKeyHelp.TabIndex = 111;
            this.linkLabelAPIKeyHelp.TabStop = true;
            this.linkLabelAPIKeyHelp.Text = "How do I login with an API key?";
            this.linkLabelAPIKeyHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAPIKeyHelp_LinkClicked);
            // 
            // buttonNMLoginManually
            // 
            this.buttonNMLoginManually.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.buttonNMLoginManually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNMLoginManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNMLoginManually.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNMLoginManually.Image = global::Fo76ini.Properties.Resources.login_48;
            this.buttonNMLoginManually.Location = new System.Drawing.Point(146, 23);
            this.buttonNMLoginManually.Name = "buttonNMLoginManually";
            this.buttonNMLoginManually.Padding = new System.Windows.Forms.Padding(4);
            this.buttonNMLoginManually.Size = new System.Drawing.Size(120, 120);
            this.buttonNMLoginManually.TabIndex = 110;
            this.buttonNMLoginManually.Text = "Log in with key";
            this.buttonNMLoginManually.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNMLoginManually.UseVisualStyleBackColor = false;
            this.buttonNMLoginManually.Click += new System.EventHandler(this.buttonNMLoginManually_Click);
            // 
            // labelAPIKey
            // 
            this.labelAPIKey.AutoSize = true;
            this.labelAPIKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPIKey.Location = new System.Drawing.Point(6, 232);
            this.labelAPIKey.Name = "labelAPIKey";
            this.labelAPIKey.Size = new System.Drawing.Size(61, 16);
            this.labelAPIKey.TabIndex = 109;
            this.labelAPIKey.Text = "API Key";
            // 
            // checkBoxShowAPIKey
            // 
            this.checkBoxShowAPIKey.AutoSize = true;
            this.checkBoxShowAPIKey.Location = new System.Drawing.Point(20, 307);
            this.checkBoxShowAPIKey.Name = "checkBoxShowAPIKey";
            this.checkBoxShowAPIKey.Size = new System.Drawing.Size(93, 17);
            this.checkBoxShowAPIKey.TabIndex = 108;
            this.checkBoxShowAPIKey.Text = "Show API key";
            this.checkBoxShowAPIKey.UseVisualStyleBackColor = true;
            this.checkBoxShowAPIKey.CheckedChanged += new System.EventHandler(this.checkBoxShowAPIKey_CheckedChanged);
            // 
            // textBoxAPIKey
            // 
            this.textBoxAPIKey.Location = new System.Drawing.Point(20, 281);
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.Size = new System.Drawing.Size(660, 20);
            this.textBoxAPIKey.TabIndex = 107;
            this.textBoxAPIKey.UseSystemPasswordChar = true;
            this.textBoxAPIKey.TextChanged += new System.EventHandler(this.textBoxAPIKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "Actions";
            // 
            // buttonNMLogin
            // 
            this.buttonNMLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.buttonNMLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNMLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNMLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNMLogin.Image = global::Fo76ini.Properties.Resources.login_48;
            this.buttonNMLogin.Location = new System.Drawing.Point(20, 23);
            this.buttonNMLogin.Name = "buttonNMLogin";
            this.buttonNMLogin.Padding = new System.Windows.Forms.Padding(4);
            this.buttonNMLogin.Size = new System.Drawing.Size(120, 120);
            this.buttonNMLogin.TabIndex = 105;
            this.buttonNMLogin.Text = "Log in";
            this.buttonNMLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNMLogin.UseVisualStyleBackColor = false;
            this.buttonNMLogin.Click += new System.EventHandler(this.buttonNMLogin_Click);
            // 
            // buttonNWDeleteCache
            // 
            this.buttonNWDeleteCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.buttonNWDeleteCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNWDeleteCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNWDeleteCache.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNWDeleteCache.Image = global::Fo76ini.Properties.Resources.delete_48;
            this.buttonNWDeleteCache.Location = new System.Drawing.Point(524, 23);
            this.buttonNWDeleteCache.Name = "buttonNWDeleteCache";
            this.buttonNWDeleteCache.Padding = new System.Windows.Forms.Padding(4);
            this.buttonNWDeleteCache.Size = new System.Drawing.Size(120, 120);
            this.buttonNWDeleteCache.TabIndex = 104;
            this.buttonNWDeleteCache.Text = "Delete cache";
            this.buttonNWDeleteCache.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNWDeleteCache.UseVisualStyleBackColor = false;
            this.buttonNWDeleteCache.Click += new System.EventHandler(this.buttonNWDeleteCache_Click);
            // 
            // buttonNWLogout
            // 
            this.buttonNWLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
            this.buttonNWLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNWLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNWLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNWLogout.Image = global::Fo76ini.Properties.Resources.exit_48;
            this.buttonNWLogout.Location = new System.Drawing.Point(272, 23);
            this.buttonNWLogout.Name = "buttonNWLogout";
            this.buttonNWLogout.Padding = new System.Windows.Forms.Padding(4);
            this.buttonNWLogout.Size = new System.Drawing.Size(120, 120);
            this.buttonNWLogout.TabIndex = 103;
            this.buttonNWLogout.Text = "Logout";
            this.buttonNWLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNWLogout.UseVisualStyleBackColor = false;
            this.buttonNWLogout.Click += new System.EventHandler(this.buttonNWLogout_Click);
            // 
            // checkBoxNMDownloadThumbnails
            // 
            this.checkBoxNMDownloadThumbnails.AutoSize = true;
            this.checkBoxNMDownloadThumbnails.Checked = true;
            this.checkBoxNMDownloadThumbnails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNMDownloadThumbnails.Location = new System.Drawing.Point(20, 200);
            this.checkBoxNMDownloadThumbnails.Name = "checkBoxNMDownloadThumbnails";
            this.checkBoxNMDownloadThumbnails.Size = new System.Drawing.Size(127, 17);
            this.checkBoxNMDownloadThumbnails.TabIndex = 102;
            this.checkBoxNMDownloadThumbnails.Text = "Download thumbnails";
            this.checkBoxNMDownloadThumbnails.UseVisualStyleBackColor = true;
            this.checkBoxNMDownloadThumbnails.CheckedChanged += new System.EventHandler(this.checkBoxNMDownloadThumbnails_CheckedChanged);
            // 
            // labelNMOptions
            // 
            this.labelNMOptions.AutoSize = true;
            this.labelNMOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNMOptions.Location = new System.Drawing.Point(6, 155);
            this.labelNMOptions.Name = "labelNMOptions";
            this.labelNMOptions.Size = new System.Drawing.Size(60, 16);
            this.labelNMOptions.TabIndex = 101;
            this.labelNMOptions.Text = "Options";
            // 
            // checkBoxNMUpdateProfile
            // 
            this.checkBoxNMUpdateProfile.AutoSize = true;
            this.checkBoxNMUpdateProfile.Checked = true;
            this.checkBoxNMUpdateProfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNMUpdateProfile.Location = new System.Drawing.Point(20, 177);
            this.checkBoxNMUpdateProfile.Name = "checkBoxNMUpdateProfile";
            this.checkBoxNMUpdateProfile.Size = new System.Drawing.Size(156, 17);
            this.checkBoxNMUpdateProfile.TabIndex = 100;
            this.checkBoxNMUpdateProfile.Text = "Update profile automatically";
            this.checkBoxNMUpdateProfile.UseVisualStyleBackColor = true;
            this.checkBoxNMUpdateProfile.CheckedChanged += new System.EventHandler(this.checkBoxNMUpdateProfile_CheckedChanged);
            // 
            // buttonNMUpdateProfile
            // 
            this.buttonNMUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(142)))), ((int)(((byte)(53)))));
            this.buttonNMUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNMUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNMUpdateProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNMUpdateProfile.Image = global::Fo76ini.Properties.Resources.available_updates_48;
            this.buttonNMUpdateProfile.Location = new System.Drawing.Point(398, 23);
            this.buttonNMUpdateProfile.Name = "buttonNMUpdateProfile";
            this.buttonNMUpdateProfile.Padding = new System.Windows.Forms.Padding(4);
            this.buttonNMUpdateProfile.Size = new System.Drawing.Size(120, 120);
            this.buttonNMUpdateProfile.TabIndex = 94;
            this.buttonNMUpdateProfile.Text = "Update profile";
            this.buttonNMUpdateProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNMUpdateProfile.UseVisualStyleBackColor = false;
            this.buttonNMUpdateProfile.Click += new System.EventHandler(this.buttonNMUpdateProfile_Click);
            // 
            // panelNMProfile
            // 
            this.panelNMProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNMProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelNMProfile.Controls.Add(this.labelNMNotLoggedIn);
            this.panelNMProfile.Controls.Add(this.labelNMUserID);
            this.panelNMProfile.Controls.Add(this.labelNMDescUserID);
            this.panelNMProfile.Controls.Add(this.labelNMHourlyRateLimit);
            this.panelNMProfile.Controls.Add(this.labelNMDescHourlyRateLimit);
            this.panelNMProfile.Controls.Add(this.pictureBoxNMProfilePicture);
            this.panelNMProfile.Controls.Add(this.labelNMUserName);
            this.panelNMProfile.Controls.Add(this.labelNMDescMembership);
            this.panelNMProfile.Controls.Add(this.labelNMRateLimitReset);
            this.panelNMProfile.Controls.Add(this.labelNMMembership);
            this.panelNMProfile.Controls.Add(this.labelNMDescLimitReset);
            this.panelNMProfile.Controls.Add(this.labelNMDescDailyRateLimit);
            this.panelNMProfile.Controls.Add(this.labelNMDailyRateLimit);
            this.panelNMProfile.Location = new System.Drawing.Point(0, 59);
            this.panelNMProfile.Name = "panelNMProfile";
            this.panelNMProfile.Size = new System.Drawing.Size(700, 170);
            this.panelNMProfile.TabIndex = 79;
            // 
            // labelNMNotLoggedIn
            // 
            this.labelNMNotLoggedIn.AutoSize = true;
            this.labelNMNotLoggedIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMNotLoggedIn.Location = new System.Drawing.Point(173, 57);
            this.labelNMNotLoggedIn.Name = "labelNMNotLoggedIn";
            this.labelNMNotLoggedIn.Size = new System.Drawing.Size(73, 13);
            this.labelNMNotLoggedIn.TabIndex = 80;
            this.labelNMNotLoggedIn.Text = "Not logged in.";
            // 
            // labelNMUserID
            // 
            this.labelNMUserID.AutoSize = true;
            this.labelNMUserID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMUserID.Location = new System.Drawing.Point(286, 85);
            this.labelNMUserID.Name = "labelNMUserID";
            this.labelNMUserID.Size = new System.Drawing.Size(16, 13);
            this.labelNMUserID.TabIndex = 79;
            this.labelNMUserID.Text = "-1";
            // 
            // labelNMDescUserID
            // 
            this.labelNMDescUserID.AutoSize = true;
            this.labelNMDescUserID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMDescUserID.Location = new System.Drawing.Point(173, 85);
            this.labelNMDescUserID.Name = "labelNMDescUserID";
            this.labelNMDescUserID.Size = new System.Drawing.Size(46, 13);
            this.labelNMDescUserID.TabIndex = 78;
            this.labelNMDescUserID.Text = "User-ID:";
            // 
            // labelNMHourlyRateLimit
            // 
            this.labelNMHourlyRateLimit.AutoSize = true;
            this.labelNMHourlyRateLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMHourlyRateLimit.Location = new System.Drawing.Point(515, 85);
            this.labelNMHourlyRateLimit.Name = "labelNMHourlyRateLimit";
            this.labelNMHourlyRateLimit.Size = new System.Drawing.Size(30, 13);
            this.labelNMHourlyRateLimit.TabIndex = 77;
            this.labelNMHourlyRateLimit.Text = "0 left";
            // 
            // labelNMDescHourlyRateLimit
            // 
            this.labelNMDescHourlyRateLimit.AutoSize = true;
            this.labelNMDescHourlyRateLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMDescHourlyRateLimit.Location = new System.Drawing.Point(397, 85);
            this.labelNMDescHourlyRateLimit.Name = "labelNMDescHourlyRateLimit";
            this.labelNMDescHourlyRateLimit.Size = new System.Drawing.Size(81, 13);
            this.labelNMDescHourlyRateLimit.TabIndex = 76;
            this.labelNMDescHourlyRateLimit.Text = "Hourly rate limit:";
            // 
            // pictureBoxNMProfilePicture
            // 
            this.pictureBoxNMProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNMProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNMProfilePicture.Image")));
            this.pictureBoxNMProfilePicture.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxNMProfilePicture.Name = "pictureBoxNMProfilePicture";
            this.pictureBoxNMProfilePicture.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxNMProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNMProfilePicture.TabIndex = 65;
            this.pictureBoxNMProfilePicture.TabStop = false;
            this.pictureBoxNMProfilePicture.Click += new System.EventHandler(this.pictureBoxNMProfilePicture_Click);
            // 
            // labelNMUserName
            // 
            this.labelNMUserName.AutoSize = true;
            this.labelNMUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNMUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMUserName.Location = new System.Drawing.Point(170, 20);
            this.labelNMUserName.Name = "labelNMUserName";
            this.labelNMUserName.Size = new System.Drawing.Size(169, 33);
            this.labelNMUserName.TabIndex = 66;
            this.labelNMUserName.Text = "Anonymous";
            // 
            // labelNMDescMembership
            // 
            this.labelNMDescMembership.AutoSize = true;
            this.labelNMDescMembership.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMDescMembership.Location = new System.Drawing.Point(173, 64);
            this.labelNMDescMembership.Name = "labelNMDescMembership";
            this.labelNMDescMembership.Size = new System.Drawing.Size(67, 13);
            this.labelNMDescMembership.TabIndex = 67;
            this.labelNMDescMembership.Text = "Membership:";
            // 
            // labelNMRateLimitReset
            // 
            this.labelNMRateLimitReset.AutoSize = true;
            this.labelNMRateLimitReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMRateLimitReset.Location = new System.Drawing.Point(515, 107);
            this.labelNMRateLimitReset.Name = "labelNMRateLimitReset";
            this.labelNMRateLimitReset.Size = new System.Drawing.Size(36, 13);
            this.labelNMRateLimitReset.TabIndex = 72;
            this.labelNMRateLimitReset.Text = "Never";
            // 
            // labelNMMembership
            // 
            this.labelNMMembership.AutoSize = true;
            this.labelNMMembership.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMMembership.Location = new System.Drawing.Point(286, 64);
            this.labelNMMembership.Name = "labelNMMembership";
            this.labelNMMembership.Size = new System.Drawing.Size(33, 13);
            this.labelNMMembership.TabIndex = 68;
            this.labelNMMembership.Text = "Basic";
            // 
            // labelNMDescLimitReset
            // 
            this.labelNMDescLimitReset.AutoSize = true;
            this.labelNMDescLimitReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMDescLimitReset.Location = new System.Drawing.Point(397, 107);
            this.labelNMDescLimitReset.Name = "labelNMDescLimitReset";
            this.labelNMDescLimitReset.Size = new System.Drawing.Size(79, 13);
            this.labelNMDescLimitReset.TabIndex = 71;
            this.labelNMDescLimitReset.Text = "Rate limit reset:";
            // 
            // labelNMDescDailyRateLimit
            // 
            this.labelNMDescDailyRateLimit.AutoSize = true;
            this.labelNMDescDailyRateLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMDescDailyRateLimit.Location = new System.Drawing.Point(397, 64);
            this.labelNMDescDailyRateLimit.Name = "labelNMDescDailyRateLimit";
            this.labelNMDescDailyRateLimit.Size = new System.Drawing.Size(74, 13);
            this.labelNMDescDailyRateLimit.TabIndex = 69;
            this.labelNMDescDailyRateLimit.Text = "Daily rate limit:";
            // 
            // labelNMDailyRateLimit
            // 
            this.labelNMDailyRateLimit.AutoSize = true;
            this.labelNMDailyRateLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNMDailyRateLimit.Location = new System.Drawing.Point(515, 64);
            this.labelNMDailyRateLimit.Name = "labelNMDailyRateLimit";
            this.labelNMDailyRateLimit.Size = new System.Drawing.Size(30, 13);
            this.labelNMDailyRateLimit.TabIndex = 70;
            this.labelNMDailyRateLimit.Text = "0 left";
            // 
            // backgroundWorkerRetrieveProfileInfo
            // 
            this.backgroundWorkerRetrieveProfileInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRetrieveProfileInfo_DoWork);
            this.backgroundWorkerRetrieveProfileInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerRetrieveProfileInfo_RunWorkerCompleted);
            // 
            // backgroundWorkerSSOLogin
            // 
            this.backgroundWorkerSSOLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSSOLogin_DoWork);
            // 
            // UserControlNexusMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelManageNMProfile);
            this.Controls.Add(this.panelNMProfile);
            this.Controls.Add(this.labelNexusDesc);
            this.Controls.Add(this.labelTitleNexus);
            this.Name = "UserControlNexusMods";
            this.Size = new System.Drawing.Size(700, 600);
            this.Load += new System.EventHandler(this.UserControlNexusMods_Load);
            this.panelManageNMProfile.ResumeLayout(false);
            this.panelManageNMProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAPIKeyHelp)).EndInit();
            this.panelNMProfile.ResumeLayout(false);
            this.panelNMProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNMProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleNexus;
        private System.Windows.Forms.Label labelNexusDesc;
        private System.Windows.Forms.Panel panelManageNMProfile;
        private System.Windows.Forms.LinkLabel linkLabelEnableAPIKey;
        private System.Windows.Forms.PictureBox pictureBoxAPIKeyHelp;
        private System.Windows.Forms.LinkLabel linkLabelAPIKeyHelp;
        private System.Windows.Forms.Button buttonNMLoginManually;
        private System.Windows.Forms.Label labelAPIKey;
        private System.Windows.Forms.CheckBox checkBoxShowAPIKey;
        private System.Windows.Forms.TextBox textBoxAPIKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNMLogin;
        private System.Windows.Forms.Button buttonNWDeleteCache;
        private System.Windows.Forms.Button buttonNWLogout;
        private System.Windows.Forms.CheckBox checkBoxNMDownloadThumbnails;
        private System.Windows.Forms.Label labelNMOptions;
        private System.Windows.Forms.CheckBox checkBoxNMUpdateProfile;
        private System.Windows.Forms.Button buttonNMUpdateProfile;
        private System.Windows.Forms.Panel panelNMProfile;
        private System.Windows.Forms.Label labelNMNotLoggedIn;
        private System.Windows.Forms.Label labelNMUserID;
        private System.Windows.Forms.Label labelNMDescUserID;
        private System.Windows.Forms.Label labelNMHourlyRateLimit;
        private System.Windows.Forms.Label labelNMDescHourlyRateLimit;
        private System.Windows.Forms.PictureBox pictureBoxNMProfilePicture;
        private System.Windows.Forms.Label labelNMUserName;
        private System.Windows.Forms.Label labelNMDescMembership;
        private System.Windows.Forms.Label labelNMRateLimitReset;
        private System.Windows.Forms.Label labelNMMembership;
        private System.Windows.Forms.Label labelNMDescLimitReset;
        private System.Windows.Forms.Label labelNMDescDailyRateLimit;
        private System.Windows.Forms.Label labelNMDailyRateLimit;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRetrieveProfileInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSSOLogin;
    }
}
