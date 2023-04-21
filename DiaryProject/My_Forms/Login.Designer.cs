namespace DiaryProject.My_Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbl_User = new Label();
            txt_User = new TextBox();
            txt_Password = new TextBox();
            lbl_Password = new Label();
            btn_OK = new Button();
            brn_Cancel = new Button();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // lbl_User
            // 
            lbl_User.Location = new Point(30, 52);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(71, 23);
            lbl_User.TabIndex = 0;
            lbl_User.Text = "User";
            lbl_User.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(101, 52);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(199, 23);
            txt_User.TabIndex = 1;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(101, 81);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(199, 23);
            txt_Password.TabIndex = 3;
            // 
            // lbl_Password
            // 
            lbl_Password.Location = new Point(30, 81);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(71, 23);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "Password";
            lbl_Password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_OK
            // 
            btn_OK.Image = Properties.Resources.check_confirm_ok_yes_icon;
            btn_OK.Location = new Point(101, 120);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(75, 23);
            btn_OK.TabIndex = 4;
            btn_OK.Text = "OK";
            btn_OK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // brn_Cancel
            // 
            brn_Cancel.Image = Properties.Resources.close_cross_cancel_remove_icon;
            brn_Cancel.Location = new Point(225, 120);
            brn_Cancel.Name = "brn_Cancel";
            brn_Cancel.Size = new Size(75, 23);
            brn_Cancel.TabIndex = 5;
            brn_Cancel.Text = "Cancel";
            brn_Cancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            brn_Cancel.UseVisualStyleBackColor = true;
            brn_Cancel.Click += brn_Cancel_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Title.Location = new Point(30, 12);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(270, 23);
            lbl_Title.TabIndex = 6;
            lbl_Title.Text = "Enter Credentials";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 163);
            ControlBox = false;
            Controls.Add(lbl_Title);
            Controls.Add(brn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(txt_Password);
            Controls.Add(lbl_Password);
            Controls.Add(txt_User);
            Controls.Add(lbl_User);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_User;
        private TextBox txt_User;
        private TextBox txt_Password;
        private Label lbl_Password;
        private Button btn_OK;
        private Button brn_Cancel;
        private Label lbl_Title;
    }
}