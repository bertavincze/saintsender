namespace SaintSender
{
    partial class NewMailForm
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
            this.txtNewMail = new MetroFramework.Controls.MetroTextBox();
            this.txtSubject = new MetroFramework.Controls.MetroTextBox();
            this.txtTo = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new FontAwesome.Sharp.IconButton();
            this.txtCc = new MetroFramework.Controls.MetroTextBox();
            this.txtBcc = new MetroFramework.Controls.MetroTextBox();
            this.iconTo = new FontAwesome.Sharp.IconButton();
            this.iconSubject = new FontAwesome.Sharp.IconButton();
            this.iconBody = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtNewMail
            // 
            // 
            // 
            // 
            this.txtNewMail.CustomButton.Image = null;
            this.txtNewMail.CustomButton.Location = new System.Drawing.Point(157, 2);
            this.txtNewMail.CustomButton.Name = "";
            this.txtNewMail.CustomButton.Size = new System.Drawing.Size(267, 267);
            this.txtNewMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewMail.CustomButton.TabIndex = 1;
            this.txtNewMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewMail.CustomButton.UseSelectable = true;
            this.txtNewMail.CustomButton.Visible = false;
            this.txtNewMail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewMail.Lines = new string[0];
            this.txtNewMail.Location = new System.Drawing.Point(53, 141);
            this.txtNewMail.MaxLength = 32767;
            this.txtNewMail.Multiline = true;
            this.txtNewMail.Name = "txtNewMail";
            this.txtNewMail.PasswordChar = '\0';
            this.txtNewMail.PromptText = "Type your message here...";
            this.txtNewMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewMail.SelectedText = "";
            this.txtNewMail.SelectionLength = 0;
            this.txtNewMail.SelectionStart = 0;
            this.txtNewMail.ShortcutsEnabled = true;
            this.txtNewMail.Size = new System.Drawing.Size(427, 272);
            this.txtNewMail.TabIndex = 4;
            this.txtNewMail.UseSelectable = true;
            this.txtNewMail.WaterMark = "Type your message here...";
            this.txtNewMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSubject
            // 
            // 
            // 
            // 
            this.txtSubject.CustomButton.Image = null;
            this.txtSubject.CustomButton.Location = new System.Drawing.Point(401, 2);
            this.txtSubject.CustomButton.Name = "";
            this.txtSubject.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubject.CustomButton.TabIndex = 1;
            this.txtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubject.CustomButton.UseSelectable = true;
            this.txtSubject.CustomButton.Visible = false;
            this.txtSubject.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSubject.Lines = new string[0];
            this.txtSubject.Location = new System.Drawing.Point(53, 73);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.PromptText = "Subject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.ShortcutsEnabled = true;
            this.txtSubject.Size = new System.Drawing.Size(427, 28);
            this.txtSubject.TabIndex = 0;
            this.txtSubject.UseSelectable = true;
            this.txtSubject.WaterMark = "Subject";
            this.txtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTo
            // 
            // 
            // 
            // 
            this.txtTo.CustomButton.Image = null;
            this.txtTo.CustomButton.Location = new System.Drawing.Point(113, 2);
            this.txtTo.CustomButton.Name = "";
            this.txtTo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTo.CustomButton.TabIndex = 1;
            this.txtTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTo.CustomButton.UseSelectable = true;
            this.txtTo.CustomButton.Visible = false;
            this.txtTo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTo.Lines = new string[0];
            this.txtTo.Location = new System.Drawing.Point(53, 107);
            this.txtTo.MaxLength = 32767;
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PromptText = "To";
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTo.SelectedText = "";
            this.txtTo.SelectionLength = 0;
            this.txtTo.SelectionStart = 0;
            this.txtTo.ShortcutsEnabled = true;
            this.txtTo.Size = new System.Drawing.Size(139, 28);
            this.txtTo.TabIndex = 1;
            this.txtTo.UseSelectable = true;
            this.txtTo.WaterMark = "To";
            this.txtTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnSend.IconColor = System.Drawing.Color.Black;
            this.btnSend.IconSize = 20;
            this.btnSend.Location = new System.Drawing.Point(414, 420);
            this.btnSend.Name = "btnSend";
            this.btnSend.Rotation = 0D;
            this.btnSend.Size = new System.Drawing.Size(68, 29);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCc
            // 
            // 
            // 
            // 
            this.txtCc.CustomButton.Image = null;
            this.txtCc.CustomButton.Location = new System.Drawing.Point(112, 2);
            this.txtCc.CustomButton.Name = "";
            this.txtCc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCc.CustomButton.TabIndex = 1;
            this.txtCc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCc.CustomButton.UseSelectable = true;
            this.txtCc.CustomButton.Visible = false;
            this.txtCc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCc.Lines = new string[0];
            this.txtCc.Location = new System.Drawing.Point(198, 107);
            this.txtCc.MaxLength = 32767;
            this.txtCc.Name = "txtCc";
            this.txtCc.PasswordChar = '\0';
            this.txtCc.PromptText = "Cc";
            this.txtCc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCc.SelectedText = "";
            this.txtCc.SelectionLength = 0;
            this.txtCc.SelectionStart = 0;
            this.txtCc.ShortcutsEnabled = true;
            this.txtCc.Size = new System.Drawing.Size(138, 28);
            this.txtCc.TabIndex = 2;
            this.txtCc.UseSelectable = true;
            this.txtCc.WaterMark = "Cc";
            this.txtCc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBcc
            // 
            // 
            // 
            // 
            this.txtBcc.CustomButton.Image = null;
            this.txtBcc.CustomButton.Location = new System.Drawing.Point(112, 2);
            this.txtBcc.CustomButton.Name = "";
            this.txtBcc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBcc.CustomButton.TabIndex = 1;
            this.txtBcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBcc.CustomButton.UseSelectable = true;
            this.txtBcc.CustomButton.Visible = false;
            this.txtBcc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBcc.Lines = new string[0];
            this.txtBcc.Location = new System.Drawing.Point(343, 107);
            this.txtBcc.MaxLength = 32767;
            this.txtBcc.Name = "txtBcc";
            this.txtBcc.PasswordChar = '\0';
            this.txtBcc.PromptText = "Bcc";
            this.txtBcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBcc.SelectedText = "";
            this.txtBcc.SelectionLength = 0;
            this.txtBcc.SelectionStart = 0;
            this.txtBcc.ShortcutsEnabled = true;
            this.txtBcc.Size = new System.Drawing.Size(138, 28);
            this.txtBcc.TabIndex = 3;
            this.txtBcc.UseSelectable = true;
            this.txtBcc.WaterMark = "Bcc";
            this.txtBcc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // iconTo
            // 
            this.iconTo.AutoSize = true;
            this.iconTo.FlatAppearance.BorderSize = 0;
            this.iconTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconTo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconTo.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconTo.IconColor = System.Drawing.Color.Black;
            this.iconTo.IconSize = 20;
            this.iconTo.Location = new System.Drawing.Point(23, 107);
            this.iconTo.Name = "iconTo";
            this.iconTo.Rotation = 0D;
            this.iconTo.Size = new System.Drawing.Size(26, 27);
            this.iconTo.TabIndex = 9;
            this.iconTo.TabStop = false;
            this.iconTo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconTo.UseVisualStyleBackColor = false;
            // 
            // iconSubject
            // 
            this.iconSubject.AutoSize = true;
            this.iconSubject.FlatAppearance.BorderSize = 0;
            this.iconSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSubject.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSubject.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconSubject.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.iconSubject.IconColor = System.Drawing.Color.Black;
            this.iconSubject.IconSize = 20;
            this.iconSubject.Location = new System.Drawing.Point(23, 73);
            this.iconSubject.Name = "iconSubject";
            this.iconSubject.Rotation = 0D;
            this.iconSubject.Size = new System.Drawing.Size(26, 27);
            this.iconSubject.TabIndex = 10;
            this.iconSubject.TabStop = false;
            this.iconSubject.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSubject.UseVisualStyleBackColor = false;
            // 
            // iconBody
            // 
            this.iconBody.AutoSize = true;
            this.iconBody.FlatAppearance.BorderSize = 0;
            this.iconBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBody.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBody.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBody.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconBody.IconColor = System.Drawing.Color.Black;
            this.iconBody.IconSize = 20;
            this.iconBody.Location = new System.Drawing.Point(23, 141);
            this.iconBody.Name = "iconBody";
            this.iconBody.Rotation = 0D;
            this.iconBody.Size = new System.Drawing.Size(26, 27);
            this.iconBody.TabIndex = 11;
            this.iconBody.TabStop = false;
            this.iconBody.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconBody.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBody.UseVisualStyleBackColor = false;
            // 
            // NewMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 470);
            this.Controls.Add(this.iconBody);
            this.Controls.Add(this.iconSubject);
            this.Controls.Add(this.iconTo);
            this.Controls.Add(this.txtBcc);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtNewMail);
            this.Name = "NewMailForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "New Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNewMail;
        private MetroFramework.Controls.MetroTextBox txtSubject;
        private MetroFramework.Controls.MetroTextBox txtTo;
        private FontAwesome.Sharp.IconButton btnSend;
        private MetroFramework.Controls.MetroTextBox txtCc;
        private MetroFramework.Controls.MetroTextBox txtBcc;
        private FontAwesome.Sharp.IconButton iconTo;
        private FontAwesome.Sharp.IconButton iconSubject;
        private FontAwesome.Sharp.IconButton iconBody;
    }
}