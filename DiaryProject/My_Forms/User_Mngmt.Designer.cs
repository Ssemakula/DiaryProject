namespace DiaryProject.My_Forms
{
    partial class User_Mngmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Mngmt));
            pbx_Pics = new PictureBox();
            btn_Pic = new Button();
            lbl_UserName = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            lbl_Password = new Label();
            txt_ConfirmPass = new TextBox();
            lbl_ConfirmPass = new Label();
            btn_Save = new Button();
            panel1 = new Panel();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx_Pics).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbx_Pics
            // 
            pbx_Pics.BorderStyle = BorderStyle.FixedSingle;
            pbx_Pics.Location = new Point(136, 13);
            pbx_Pics.Name = "pbx_Pics";
            pbx_Pics.Size = new Size(126, 144);
            pbx_Pics.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_Pics.TabIndex = 0;
            pbx_Pics.TabStop = false;
            // 
            // btn_Pic
            // 
            btn_Pic.Location = new Point(162, 163);
            btn_Pic.Name = "btn_Pic";
            btn_Pic.Size = new Size(75, 23);
            btn_Pic.TabIndex = 1;
            btn_Pic.Text = "Select Pic";
            btn_Pic.UseVisualStyleBackColor = true;
            btn_Pic.Click += btn_Pic_Click;
            // 
            // lbl_UserName
            // 
            lbl_UserName.Location = new Point(33, 204);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(111, 23);
            lbl_UserName.TabIndex = 2;
            lbl_UserName.Text = "User Name:";
            lbl_UserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(145, 204);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(226, 23);
            txt_UserName.TabIndex = 3;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(145, 233);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(226, 23);
            txt_Password.TabIndex = 5;
            // 
            // lbl_Password
            // 
            lbl_Password.Location = new Point(33, 233);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(111, 23);
            lbl_Password.TabIndex = 4;
            lbl_Password.Text = "Password";
            lbl_Password.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ConfirmPass
            // 
            txt_ConfirmPass.Location = new Point(145, 262);
            txt_ConfirmPass.Name = "txt_ConfirmPass";
            txt_ConfirmPass.Size = new Size(226, 23);
            txt_ConfirmPass.TabIndex = 7;
            // 
            // lbl_ConfirmPass
            // 
            lbl_ConfirmPass.Location = new Point(33, 262);
            lbl_ConfirmPass.Name = "lbl_ConfirmPass";
            lbl_ConfirmPass.Size = new Size(111, 23);
            lbl_ConfirmPass.TabIndex = 6;
            lbl_ConfirmPass.Text = "Confirm Password:";
            lbl_ConfirmPass.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(157, 324);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 8;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbx_Pics);
            panel1.Controls.Add(btn_Pic);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(txt_UserName);
            panel1.Controls.Add(lbl_UserName);
            panel1.Controls.Add(lbl_Password);
            panel1.Controls.Add(txt_ConfirmPass);
            panel1.Controls.Add(lbl_ConfirmPass);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 306);
            panel1.TabIndex = 9;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(336, 324);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(75, 23);
            btn_Exit.TabIndex = 10;
            btn_Exit.Text = "Close";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // User_Mngmt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 355);
            Controls.Add(btn_Exit);
            Controls.Add(panel1);
            Controls.Add(btn_Save);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "User_Mngmt";
            Text = "User Management";
            Load += User_Mngmt_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_Pics).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbx_Pics;
        private Button btn_Pic;
        private Label lbl_UserName;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Label lbl_Password;
        private TextBox txt_ConfirmPass;
        private Label lbl_ConfirmPass;
        private Button btn_Save;
        private Panel panel1;
        private Button btn_Exit;
    }
}