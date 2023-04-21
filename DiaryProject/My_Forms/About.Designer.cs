namespace DiaryProject.My_Forms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            lbl_Company = new Label();
            lbl_Product = new Label();
            lbl_Version = new Label();
            lbl_Developer = new Label();
            lbl_Programmer = new Label();
            pnl_Divider = new Panel();
            lbl_Copyright = new Label();
            lbl_Rights = new Label();
            SuspendLayout();
            // 
            // lbl_Company
            // 
            lbl_Company.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Company.Location = new Point(34, 32);
            lbl_Company.Name = "lbl_Company";
            lbl_Company.Size = new Size(436, 37);
            lbl_Company.TabIndex = 0;
            lbl_Company.Text = "label1";
            lbl_Company.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Product
            // 
            lbl_Product.Location = new Point(34, 97);
            lbl_Product.Name = "lbl_Product";
            lbl_Product.Size = new Size(436, 27);
            lbl_Product.TabIndex = 1;
            lbl_Product.Text = "label1";
            lbl_Product.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Version
            // 
            lbl_Version.Location = new Point(34, 124);
            lbl_Version.Name = "lbl_Version";
            lbl_Version.Size = new Size(436, 27);
            lbl_Version.TabIndex = 2;
            lbl_Version.Text = "label1";
            lbl_Version.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Developer
            // 
            lbl_Developer.Location = new Point(34, 151);
            lbl_Developer.Name = "lbl_Developer";
            lbl_Developer.Size = new Size(436, 27);
            lbl_Developer.TabIndex = 3;
            lbl_Developer.Text = "label1";
            lbl_Developer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Programmer
            // 
            lbl_Programmer.Location = new Point(34, 178);
            lbl_Programmer.Name = "lbl_Programmer";
            lbl_Programmer.Size = new Size(436, 27);
            lbl_Programmer.TabIndex = 4;
            lbl_Programmer.Text = "label1";
            lbl_Programmer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_Divider
            // 
            pnl_Divider.BackColor = SystemColors.ActiveCaptionText;
            pnl_Divider.BorderStyle = BorderStyle.Fixed3D;
            pnl_Divider.Location = new Point(-1, 218);
            pnl_Divider.Name = "pnl_Divider";
            pnl_Divider.Size = new Size(515, 1);
            pnl_Divider.TabIndex = 5;
            // 
            // lbl_Copyright
            // 
            lbl_Copyright.Location = new Point(34, 231);
            lbl_Copyright.Name = "lbl_Copyright";
            lbl_Copyright.Size = new Size(436, 27);
            lbl_Copyright.TabIndex = 6;
            lbl_Copyright.Text = "label1";
            lbl_Copyright.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Rights
            // 
            lbl_Rights.Location = new Point(34, 258);
            lbl_Rights.Name = "lbl_Rights";
            lbl_Rights.Size = new Size(436, 27);
            lbl_Rights.TabIndex = 7;
            lbl_Rights.Text = "label1";
            lbl_Rights.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 354);
            Controls.Add(lbl_Rights);
            Controls.Add(lbl_Copyright);
            Controls.Add(pnl_Divider);
            Controls.Add(lbl_Programmer);
            Controls.Add(lbl_Developer);
            Controls.Add(lbl_Version);
            Controls.Add(lbl_Product);
            Controls.Add(lbl_Company);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            Load += About_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Company;
        private Label lbl_Product;
        private Label lbl_Version;
        private Label lbl_Developer;
        private Label lbl_Programmer;
        private Panel pnl_Divider;
        private Label lbl_Copyright;
        private Label lbl_Rights;
    }
}