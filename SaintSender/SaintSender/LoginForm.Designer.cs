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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.iconUser = new FontAwesome.Sharp.IconButton();
            this.iconPassword = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtEmail.Location = new System.Drawing.Point(55, 82);
            this.txtEmail.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 24);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Email address";
            // 
            // iconUser
            // 
            this.iconUser.AutoSize = true;
            this.iconUser.FlatAppearance.BorderSize = 0;
            this.iconUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconUser.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.Black;
            this.iconUser.IconSize = 20;
            this.iconUser.Location = new System.Drawing.Point(23, 82);
            this.iconUser.Name = "iconUser";
            this.iconUser.Rotation = 0D;
            this.iconUser.Size = new System.Drawing.Size(26, 27);
            this.iconUser.TabIndex = 8;
            this.iconUser.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconUser.UseVisualStyleBackColor = false;
            // 
            // iconPassword
            // 
            this.iconPassword.AutoSize = true;
            this.iconPassword.FlatAppearance.BorderSize = 0;
            this.iconPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPassword.IconColor = System.Drawing.Color.Black;
            this.iconPassword.IconSize = 20;
            this.iconPassword.Location = new System.Drawing.Point(23, 128);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Rotation = 0D;
            this.iconPassword.Size = new System.Drawing.Size(26, 27);
            this.iconPassword.TabIndex = 10;
            this.iconPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPassword.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtPassword.Location = new System.Drawing.Point(55, 128);
            this.txtPassword.MinimumSize = new System.Drawing.Size(185, 27);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(185, 24);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.AutoSize = true;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSignIn.IconColor = System.Drawing.Color.Black;
            this.btnSignIn.IconSize = 20;
            this.btnSignIn.Location = new System.Drawing.Point(89, 173);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Rotation = 0D;
            this.btnSignIn.Size = new System.Drawing.Size(93, 27);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 353);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.iconPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.txtEmail);
            this.Name = "LoginForm";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconButton iconUser;
        private FontAwesome.Sharp.IconButton iconPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconButton btnSignIn;
    }
}