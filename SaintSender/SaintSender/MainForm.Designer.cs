namespace SaintSender
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.emailListView = new System.Windows.Forms.ListView();
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnSignout = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnSync = new FontAwesome.Sharp.IconButton();
            this.loadProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.iconUser = new FontAwesome.Sharp.IconButton();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.foldersListView = new System.Windows.Forms.ListView();
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.emailContentBrowser = new System.Windows.Forms.WebBrowser();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.maxMailComboBox = new MetroFramework.Controls.MetroComboBox();
            this.dateComboBox = new MetroFramework.Controls.MetroComboBox();
            this.folderProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.btnReply = new FontAwesome.Sharp.IconButton();
            this.btnFwd = new FontAwesome.Sharp.IconButton();
            this.btnMarkUnread = new FontAwesome.Sharp.IconButton();
            this.btnReplyAll = new FontAwesome.Sharp.IconButton();
            this.btnStar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(474, 61);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaximumSize = new System.Drawing.Size(131, 25);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(131, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(131, 25);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // emailListView
            // 
            this.emailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubject,
            this.columnSender,
            this.columnDate,
            this.columnID});
            this.emailListView.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.emailListView.FullRowSelect = true;
            this.emailListView.HideSelection = false;
            this.emailListView.Location = new System.Drawing.Point(25, 96);
            this.emailListView.MultiSelect = false;
            this.emailListView.Name = "emailListView";
            this.emailListView.Size = new System.Drawing.Size(721, 205);
            this.emailListView.TabIndex = 8;
            this.emailListView.TabStop = false;
            this.emailListView.UseCompatibleStateImageBehavior = false;
            this.emailListView.View = System.Windows.Forms.View.Details;
            this.emailListView.SelectedIndexChanged += new System.EventHandler(this.emailListView_SelectedIndexChanged);
            // 
            // columnSubject
            // 
            this.columnSubject.Text = "Subject";
            this.columnSubject.Width = 294;
            // 
            // columnSender
            // 
            this.columnSender.Text = "Sender";
            this.columnSender.Width = 223;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 164;
            // 
            // columnID
            // 
            this.columnID.Width = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnSearch.IconSize = 18;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.Location = new System.Drawing.Point(445, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(26, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TabStop = false;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnSignout
            // 
            this.btnSignout.AutoSize = true;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSignout.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnSignout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSignout.IconColor = System.Drawing.Color.Black;
            this.btnSignout.IconSize = 20;
            this.btnSignout.Location = new System.Drawing.Point(356, 61);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Rotation = 0D;
            this.btnSignout.Size = new System.Drawing.Size(83, 27);
            this.btnSignout.TabIndex = 3;
            this.btnSignout.Text = "Sign Out";
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnNew.IconColor = System.Drawing.Color.Black;
            this.btnNew.IconSize = 20;
            this.btnNew.Location = new System.Drawing.Point(134, 61);
            this.btnNew.Name = "btnNew";
            this.btnNew.Rotation = 0D;
            this.btnNew.Size = new System.Drawing.Size(63, 27);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSync
            // 
            this.btnSync.AutoSize = true;
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnSync.IconColor = System.Drawing.Color.Black;
            this.btnSync.IconSize = 20;
            this.btnSync.Location = new System.Drawing.Point(23, 62);
            this.btnSync.Name = "btnSync";
            this.btnSync.Rotation = 0D;
            this.btnSync.Size = new System.Drawing.Size(105, 27);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "Synchronize";
            this.btnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // loadProgressBar
            // 
            this.loadProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this.loadProgressBar.HideProgressText = false;
            this.loadProgressBar.Location = new System.Drawing.Point(752, 61);
            this.loadProgressBar.Name = "loadProgressBar";
            this.loadProgressBar.Size = new System.Drawing.Size(249, 25);
            this.loadProgressBar.Style = MetroFramework.MetroColorStyle.Green;
            this.loadProgressBar.TabIndex = 10;
            this.loadProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconUser
            // 
            this.iconUser.AutoSize = true;
            this.iconUser.FlatAppearance.BorderSize = 0;
            this.iconUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconUser.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUser.IconColor = System.Drawing.Color.Black;
            this.iconUser.IconSize = 18;
            this.iconUser.Location = new System.Drawing.Point(199, 63);
            this.iconUser.Name = "iconUser";
            this.iconUser.Rotation = 0D;
            this.iconUser.Size = new System.Drawing.Size(26, 26);
            this.iconUser.TabIndex = 11;
            this.iconUser.TabStop = false;
            this.iconUser.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconUser.UseVisualStyleBackColor = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.userLabel.Location = new System.Drawing.Point(224, 66);
            this.userLabel.MaximumSize = new System.Drawing.Size(128, 19);
            this.userLabel.MinimumSize = new System.Drawing.Size(128, 19);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(107, 15);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "email@domain.com";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // foldersListView
            // 
            this.foldersListView.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.foldersListView.FullRowSelect = true;
            this.foldersListView.HideSelection = false;
            this.foldersListView.LargeImageList = this.iconImageList;
            this.foldersListView.Location = new System.Drawing.Point(752, 96);
            this.foldersListView.Margin = new System.Windows.Forms.Padding(0);
            this.foldersListView.MultiSelect = false;
            this.foldersListView.Name = "foldersListView";
            this.foldersListView.Size = new System.Drawing.Size(249, 205);
            this.foldersListView.SmallImageList = this.iconImageList;
            this.foldersListView.TabIndex = 13;
            this.foldersListView.TabStop = false;
            this.foldersListView.TileSize = new System.Drawing.Size(220, 21);
            this.foldersListView.UseCompatibleStateImageBehavior = false;
            this.foldersListView.View = System.Windows.Forms.View.Tile;
            this.foldersListView.SelectedIndexChanged += new System.EventHandler(this.foldersListView_SelectedIndexChanged);
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "Folder-Yellow.png");
            // 
            // emailContentBrowser
            // 
            this.emailContentBrowser.Location = new System.Drawing.Point(25, 340);
            this.emailContentBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.emailContentBrowser.Name = "emailContentBrowser";
            this.emailContentBrowser.Size = new System.Drawing.Size(976, 243);
            this.emailContentBrowser.TabIndex = 14;
            this.emailContentBrowser.TabStop = false;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // maxMailComboBox
            // 
            this.maxMailComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxMailComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.maxMailComboBox.FormattingEnabled = true;
            this.maxMailComboBox.ItemHeight = 19;
            this.maxMailComboBox.Items.AddRange(new object[] {
            "100",
            "500",
            "1000"});
            this.maxMailComboBox.Location = new System.Drawing.Point(610, 61);
            this.maxMailComboBox.Name = "maxMailComboBox";
            this.maxMailComboBox.PromptText = "Limit";
            this.maxMailComboBox.Size = new System.Drawing.Size(65, 25);
            this.maxMailComboBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.maxMailComboBox.TabIndex = 5;
            this.maxMailComboBox.UseSelectable = true;
            this.maxMailComboBox.SelectedIndexChanged += new System.EventHandler(this.maxMailComboBox_SelectedIndexChanged);
            // 
            // dateComboBox
            // 
            this.dateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.ItemHeight = 19;
            this.dateComboBox.Items.AddRange(new object[] {
            "1 week",
            "1 month",
            "1 year"});
            this.dateComboBox.Location = new System.Drawing.Point(681, 61);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.PromptText = "Date";
            this.dateComboBox.Size = new System.Drawing.Size(65, 25);
            this.dateComboBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.dateComboBox.TabIndex = 6;
            this.dateComboBox.UseSelectable = true;
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.dateComboBox_SelectedIndexChanged);
            // 
            // folderProgressBar
            // 
            this.folderProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this.folderProgressBar.HideProgressText = false;
            this.folderProgressBar.Location = new System.Drawing.Point(752, 61);
            this.folderProgressBar.Name = "folderProgressBar";
            this.folderProgressBar.Size = new System.Drawing.Size(249, 25);
            this.folderProgressBar.Style = MetroFramework.MetroColorStyle.Green;
            this.folderProgressBar.TabIndex = 17;
            this.folderProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReply
            // 
            this.btnReply.AutoSize = true;
            this.btnReply.FlatAppearance.BorderSize = 0;
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReply.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReply.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReply.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnReply.IconColor = System.Drawing.Color.Black;
            this.btnReply.IconSize = 20;
            this.btnReply.Location = new System.Drawing.Point(25, 307);
            this.btnReply.Name = "btnReply";
            this.btnReply.Rotation = 0D;
            this.btnReply.Size = new System.Drawing.Size(66, 27);
            this.btnReply.TabIndex = 7;
            this.btnReply.Text = "Reply";
            this.btnReply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReply.UseVisualStyleBackColor = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.AutoSize = true;
            this.btnFwd.FlatAppearance.BorderSize = 0;
            this.btnFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFwd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFwd.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnFwd.IconColor = System.Drawing.Color.Black;
            this.btnFwd.IconSize = 20;
            this.btnFwd.Location = new System.Drawing.Point(201, 307);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Rotation = 0D;
            this.btnFwd.Size = new System.Drawing.Size(79, 27);
            this.btnFwd.TabIndex = 9;
            this.btnFwd.Text = "Forward";
            this.btnFwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFwd.UseVisualStyleBackColor = false;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnMarkUnread
            // 
            this.btnMarkUnread.AutoSize = true;
            this.btnMarkUnread.FlatAppearance.BorderSize = 0;
            this.btnMarkUnread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkUnread.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMarkUnread.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkUnread.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnMarkUnread.IconColor = System.Drawing.Color.Black;
            this.btnMarkUnread.IconSize = 20;
            this.btnMarkUnread.Location = new System.Drawing.Point(286, 307);
            this.btnMarkUnread.Name = "btnMarkUnread";
            this.btnMarkUnread.Rotation = 0D;
            this.btnMarkUnread.Size = new System.Drawing.Size(120, 27);
            this.btnMarkUnread.TabIndex = 10;
            this.btnMarkUnread.Text = "Mark As Unread";
            this.btnMarkUnread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarkUnread.UseVisualStyleBackColor = false;
            this.btnMarkUnread.Click += new System.EventHandler(this.btnMarkUnread_Click);
            // 
            // btnReplyAll
            // 
            this.btnReplyAll.AutoSize = true;
            this.btnReplyAll.FlatAppearance.BorderSize = 0;
            this.btnReplyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplyAll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReplyAll.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplyAll.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnReplyAll.IconColor = System.Drawing.Color.Black;
            this.btnReplyAll.IconSize = 20;
            this.btnReplyAll.Location = new System.Drawing.Point(97, 307);
            this.btnReplyAll.Name = "btnReplyAll";
            this.btnReplyAll.Rotation = 0D;
            this.btnReplyAll.Size = new System.Drawing.Size(98, 27);
            this.btnReplyAll.TabIndex = 8;
            this.btnReplyAll.Text = "Reply To All";
            this.btnReplyAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReplyAll.UseVisualStyleBackColor = false;
            this.btnReplyAll.Click += new System.EventHandler(this.btnReplyAll_Click);
            // 
            // btnStar
            // 
            this.btnStar.AutoSize = true;
            this.btnStar.FlatAppearance.BorderSize = 0;
            this.btnStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStar.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnStar.IconColor = System.Drawing.Color.Black;
            this.btnStar.IconSize = 20;
            this.btnStar.Location = new System.Drawing.Point(412, 307);
            this.btnStar.Name = "btnStar";
            this.btnStar.Rotation = 0D;
            this.btnStar.Size = new System.Drawing.Size(59, 27);
            this.btnStar.TabIndex = 11;
            this.btnStar.Text = "Star";
            this.btnStar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStar.UseVisualStyleBackColor = false;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 605);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.btnReplyAll);
            this.Controls.Add(this.btnMarkUnread);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.folderProgressBar);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.maxMailComboBox);
            this.Controls.Add(this.emailContentBrowser);
            this.Controls.Add(this.foldersListView);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.loadProgressBar);
            this.Controls.Add(this.emailListView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSync);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Saint Sender";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSync;
        private FontAwesome.Sharp.IconButton btnNew;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSignout;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.ListView emailListView;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnSender;
        private System.Windows.Forms.ColumnHeader columnDate;
        private MetroFramework.Controls.MetroProgressBar loadProgressBar;
        private FontAwesome.Sharp.IconButton iconUser;
        private MetroFramework.Controls.MetroLabel userLabel;
        private System.Windows.Forms.ListView foldersListView;
        private System.Windows.Forms.WebBrowser emailContentBrowser;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.Timer refreshTimer;
        private MetroFramework.Controls.MetroComboBox maxMailComboBox;
        private MetroFramework.Controls.MetroComboBox dateComboBox;
        private MetroFramework.Controls.MetroProgressBar folderProgressBar;
        private FontAwesome.Sharp.IconButton btnReply;
        private FontAwesome.Sharp.IconButton btnFwd;
        private FontAwesome.Sharp.IconButton btnMarkUnread;
        private FontAwesome.Sharp.IconButton btnReplyAll;
        private FontAwesome.Sharp.IconButton btnStar;
    }
}

