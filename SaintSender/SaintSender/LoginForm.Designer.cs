namespace SaintSender
{
    partial class LoginForm
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
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.iconUser = new FontAwesome.Sharp.IconButton();
            this.iconPassword = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnSignIn = new FontAwesome.Sharp.IconButton();
            this.signInLabel = new MetroFramework.Controls.MetroLabel();
            this.rememberCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(57, 142);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email address";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(234, 27);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Email address";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
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
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.Black;
            this.iconUser.IconSize = 20;
            this.iconUser.Location = new System.Drawing.Point(25, 142);
            this.iconUser.Name = "iconUser";
            this.iconUser.Rotation = 0D;
            this.iconUser.Size = new System.Drawing.Size(26, 27);
            this.iconUser.TabIndex = 4;
            this.iconUser.TabStop = false;
            this.iconUser.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconUser.UseVisualStyleBackColor = false;
            // 
            // iconPassword
            // 
            this.iconPassword.AutoSize = true;
            this.iconPassword.FlatAppearance.BorderSize = 0;
            this.iconPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPassword.IconColor = System.Drawing.Color.Black;
            this.iconPassword.IconSize = 20;
            this.iconPassword.Location = new System.Drawing.Point(25, 188);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Rotation = 0D;
            this.iconPassword.Size = new System.Drawing.Size(26, 27);
            this.iconPassword.TabIndex = 10;
            this.iconPassword.TabStop = false;
            this.iconPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPassword.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(57, 188);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(234, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // btnSignIn
            // 
            this.btnSignIn.AutoSize = true;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnSignIn.FlatAppearance.BorderSize = 2;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSignIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSignIn.IconColor = System.Drawing.Color.Black;
            this.btnSignIn.IconSize = 24;
            this.btnSignIn.Location = new System.Drawing.Point(110, 273);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Rotation = 0D;
            this.btnSignIn.Size = new System.Drawing.Size(102, 39);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.signInLabel.Location = new System.Drawing.Point(110, 92);
            this.signInLabel.MaximumSize = new System.Drawing.Size(100, 35);
            this.signInLabel.MinimumSize = new System.Drawing.Size(100, 35);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(100, 35);
            this.signInLabel.TabIndex = 5;
            this.signInLabel.Text = "Sign In";
            this.signInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Checked = true;
            this.rememberCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rememberCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rememberCheckBox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rememberCheckBox.Location = new System.Drawing.Point(57, 230);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(114, 19);
            this.rememberCheckBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.rememberCheckBox.TabIndex = 2;
            this.rememberCheckBox.Text = "Remember Me";
            this.rememberCheckBox.UseSelectable = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 388);
            this.Controls.Add(this.rememberCheckBox);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.iconPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.txtEmail);
            this.Name = "LoginForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Saint Sender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtEmail;
        private FontAwesome.Sharp.IconButton iconUser;
        private FontAwesome.Sharp.IconButton iconPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private FontAwesome.Sharp.IconButton btnSignIn;
        private MetroFramework.Controls.MetroLabel signInLabel;
        private MetroFramework.Controls.MetroCheckBox rememberCheckBox;
    }
}