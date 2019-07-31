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
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnSignout = new FontAwesome.Sharp.IconButton();
            this.btnContacts = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnSync = new FontAwesome.Sharp.IconButton();
            this.loadProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(450, 67);
            this.txtSearch.MaximumSize = new System.Drawing.Size(130, 27);
            this.txtSearch.MinimumSize = new System.Drawing.Size(130, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 17);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Enter text to search...";
            // 
            // emailListView
            // 
            this.emailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubject,
            this.columnSender,
            this.columnDate});
            this.emailListView.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.emailListView.FullRowSelect = true;
            this.emailListView.HideSelection = false;
            this.emailListView.Location = new System.Drawing.Point(25, 96);
            this.emailListView.Name = "emailListView";
            this.emailListView.Size = new System.Drawing.Size(910, 205);
            this.emailListView.TabIndex = 8;
            this.emailListView.UseCompatibleStateImageBehavior = false;
            this.emailListView.View = System.Windows.Forms.View.Details;
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
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.CustomButton.Image = null;
            this.emailTextBox.CustomButton.Location = new System.Drawing.Point(706, 1);
            this.emailTextBox.CustomButton.Name = "";
            this.emailTextBox.CustomButton.Size = new System.Drawing.Size(203, 203);
            this.emailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTextBox.CustomButton.TabIndex = 1;
            this.emailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTextBox.CustomButton.UseSelectable = true;
            this.emailTextBox.CustomButton.Visible = false;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(25, 322);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(910, 205);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.UseSelectable = true;
            this.emailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconSize = 20;
            this.btnSearch.Location = new System.Drawing.Point(586, 63);
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
            this.btnSignout.Location = new System.Drawing.Point(351, 63);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Rotation = 0D;
            this.btnSignout.Size = new System.Drawing.Size(93, 27);
            this.btnSignout.TabIndex = 6;
            this.btnSignout.Text = "Sign Out";
            this.btnSignout.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignout.UseVisualStyleBackColor = false;
            // 
            // btnContacts
            // 
            this.btnContacts.AutoSize = true;
            this.btnContacts.FlatAppearance.BorderSize = 0;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnContacts.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnContacts.IconColor = System.Drawing.Color.Black;
            this.btnContacts.IconSize = 20;
            this.btnContacts.Location = new System.Drawing.Point(238, 63);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Rotation = 0D;
            this.btnContacts.Size = new System.Drawing.Size(107, 27);
            this.btnContacts.TabIndex = 3;
            this.btnContacts.Text = "My Contacts";
            this.btnContacts.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContacts.UseVisualStyleBackColor = false;
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
            // 
            // loadProgressBar
            // 
            this.loadProgressBar.Location = new System.Drawing.Point(619, 67);
            this.loadProgressBar.Name = "loadProgressBar";
            this.loadProgressBar.Size = new System.Drawing.Size(316, 17);
            this.loadProgressBar.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 550);
            this.Controls.Add(this.loadProgressBar);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailListView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSync);
            this.Name = "MainForm";
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
        private FontAwesome.Sharp.IconButton btnContacts;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSignout;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.ListView emailListView;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnSender;
        private System.Windows.Forms.ColumnHeader columnDate;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroProgressBar loadProgressBar;
    }
}

