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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.emailListView = new System.Windows.Forms.ListView();
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnSignout = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnSync = new FontAwesome.Sharp.IconButton();
            this.loadProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.iconUser = new FontAwesome.Sharp.IconButton();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.foldersListView = new System.Windows.Forms.ListView();
            this.emailContentBrowser = new System.Windows.Forms.WebBrowser();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(488, 67);
            this.txtSearch.MaximumSize = new System.Drawing.Size(130, 17);
            this.txtSearch.MinimumSize = new System.Drawing.Size(130, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 17);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Enter text to search...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // emailListView
            // 
            this.emailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubject,
            this.columnSender,
            this.columnDate,
            this.columnID});
            this.emailListView.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.emailListView.FullRowSelect = true;
            this.emailListView.HideSelection = false;
            this.emailListView.Location = new System.Drawing.Point(25, 96);
            this.emailListView.MultiSelect = false;
            this.emailListView.Name = "emailListView";
            this.emailListView.Size = new System.Drawing.Size(625, 205);
            this.emailListView.TabIndex = 8;
            this.emailListView.UseCompatibleStateImageBehavior = false;
            this.emailListView.View = System.Windows.Forms.View.Details;
            this.emailListView.SelectedIndexChanged += new System.EventHandler(this.emailListView_SelectedIndexChanged);
            // 
            // columnSubject
            // 
            this.columnSubject.Text = "Subject";
            this.columnSubject.Width = 210;
            // 
            // columnSender
            // 
            this.columnSender.Text = "Sender";
            this.columnSender.Width = 198;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 164;
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
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconSize = 18;
            this.btnSearch.Location = new System.Drawing.Point(624, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(26, 27);
            this.btnSearch.TabIndex = 7;
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
            this.btnSignout.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSignout.IconColor = System.Drawing.Color.Black;
            this.btnSignout.IconSize = 20;
            this.btnSignout.Location = new System.Drawing.Point(389, 63);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Rotation = 0D;
            this.btnSignout.Size = new System.Drawing.Size(93, 27);
            this.btnSignout.TabIndex = 6;
            this.btnSignout.Text = "Sign Out";
            this.btnSignout.TextAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnNew.IconColor = System.Drawing.Color.Black;
            this.btnNew.IconSize = 20;
            this.btnNew.Location = new System.Drawing.Point(139, 63);
            this.btnNew.Name = "btnNew";
            this.btnNew.Rotation = 0D;
            this.btnNew.Size = new System.Drawing.Size(93, 27);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Mail";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnSync
            // 
            this.btnSync.AutoSize = true;
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnSync.IconColor = System.Drawing.Color.Black;
            this.btnSync.IconSize = 20;
            this.btnSync.Location = new System.Drawing.Point(23, 63);
            this.btnSync.Name = "btnSync";
            this.btnSync.Rotation = 0D;
            this.btnSync.Size = new System.Drawing.Size(110, 27);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "Synchronize";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // loadProgressBar
            // 
            this.loadProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this.loadProgressBar.HideProgressText = false;
            this.loadProgressBar.Location = new System.Drawing.Point(656, 67);
            this.loadProgressBar.Name = "loadProgressBar";
            this.loadProgressBar.Size = new System.Drawing.Size(279, 17);
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
            this.iconUser.Location = new System.Drawing.Point(232, 64);
            this.iconUser.Name = "iconUser";
            this.iconUser.Rotation = 0D;
            this.iconUser.Size = new System.Drawing.Size(26, 26);
            this.iconUser.TabIndex = 11;
            this.iconUser.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconUser.UseVisualStyleBackColor = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(255, 66);
            this.userLabel.MaximumSize = new System.Drawing.Size(128, 19);
            this.userLabel.MinimumSize = new System.Drawing.Size(128, 19);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(128, 19);
            this.userLabel.TabIndex = 12;
            this.userLabel.Text = "email@domain.com";
            // 
            // foldersListView
            // 
            this.foldersListView.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.foldersListView.FullRowSelect = true;
            this.foldersListView.HideSelection = false;
            this.foldersListView.Location = new System.Drawing.Point(656, 96);
            this.foldersListView.Name = "foldersListView";
            this.foldersListView.Size = new System.Drawing.Size(279, 205);
            this.foldersListView.TabIndex = 13;
            this.foldersListView.UseCompatibleStateImageBehavior = false;
            this.foldersListView.View = System.Windows.Forms.View.List;
            // 
            // emailContentBrowser
            // 
            this.emailContentBrowser.Location = new System.Drawing.Point(25, 316);
            this.emailContentBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.emailContentBrowser.Name = "emailContentBrowser";
            this.emailContentBrowser.Size = new System.Drawing.Size(910, 211);
            this.emailContentBrowser.TabIndex = 14;
            // 
            // columnID
            // 
            this.columnID.Width = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 550);
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
        private System.Windows.Forms.TextBox txtSearch;
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
    }
}

