namespace DiaryProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ts_Main = new ToolStrip();
            tsb_Exit = new ToolStripButton();
            tsb_Add = new ToolStripButton();
            tsb_Search = new ToolStripButton();
            tsb_Settings = new ToolStripButton();
            tsb_Tools = new ToolStripDropDownButton();
            usersToolStripMenuItem = new ToolStripMenuItem();
            tsb_About = new ToolStripDropDownButton();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pnl_UserInfor = new Panel();
            lbl_UserName = new Label();
            pbx_UserPic = new PictureBox();
            pnl_Cal = new Panel();
            lbl_DayOfWeek = new Label();
            lbl_Date = new Label();
            lbl_Month = new Label();
            lbl_Year = new Label();
            lbl_TimeShow = new Label();
            btn_Minimise = new Button();
            panel2 = new Panel();
            lbl_VersionDisplay = new Label();
            lbl_VersionWord = new Label();
            tm_TimeNow = new System.Windows.Forms.Timer(components);
            cms_LockScreen = new ContextMenuStrip(components);
            refreshToolStripMenuItem = new ToolStripMenuItem();
            lockScreenToolStripMenuItem = new ToolStripMenuItem();
            ts_Main.SuspendLayout();
            panel1.SuspendLayout();
            pnl_UserInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_UserPic).BeginInit();
            pnl_Cal.SuspendLayout();
            panel2.SuspendLayout();
            cms_LockScreen.SuspendLayout();
            SuspendLayout();
            // 
            // ts_Main
            // 
            ts_Main.AutoSize = false;
            ts_Main.GripStyle = ToolStripGripStyle.Hidden;
            ts_Main.Items.AddRange(new ToolStripItem[] { tsb_Exit, tsb_Add, tsb_Search, tsb_Settings, tsb_Tools, tsb_About });
            ts_Main.Location = new Point(143, 0);
            ts_Main.Name = "ts_Main";
            ts_Main.Size = new Size(1044, 57);
            ts_Main.TabIndex = 0;
            ts_Main.Text = "Main Menu";
            // 
            // tsb_Exit
            // 
            tsb_Exit.Alignment = ToolStripItemAlignment.Right;
            tsb_Exit.AutoSize = false;
            tsb_Exit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Exit.Image = Properties.Resources.exit_oct_icon;
            tsb_Exit.ImageScaling = ToolStripItemImageScaling.None;
            tsb_Exit.ImageTransparentColor = Color.Magenta;
            tsb_Exit.Name = "tsb_Exit";
            tsb_Exit.Size = new Size(60, 55);
            tsb_Exit.Text = "Exit";
            tsb_Exit.Click += tsb_Exit_Click;
            // 
            // tsb_Add
            // 
            tsb_Add.AutoSize = false;
            tsb_Add.Image = Properties.Resources.add_memo;
            tsb_Add.ImageScaling = ToolStripItemImageScaling.None;
            tsb_Add.ImageTransparentColor = Color.Magenta;
            tsb_Add.Name = "tsb_Add";
            tsb_Add.Size = new Size(60, 55);
            tsb_Add.Text = "Add";
            tsb_Add.TextImageRelation = TextImageRelation.ImageAboveText;
            tsb_Add.Click += tsb_Add_Click;
            // 
            // tsb_Search
            // 
            tsb_Search.AutoSize = false;
            tsb_Search.Image = Properties.Resources.search;
            tsb_Search.ImageScaling = ToolStripItemImageScaling.None;
            tsb_Search.ImageTransparentColor = Color.Magenta;
            tsb_Search.Name = "tsb_Search";
            tsb_Search.Size = new Size(60, 55);
            tsb_Search.Text = "Search";
            tsb_Search.TextImageRelation = TextImageRelation.ImageAboveText;
            tsb_Search.Click += tsb_Search_Click;
            // 
            // tsb_Settings
            // 
            tsb_Settings.AutoSize = false;
            tsb_Settings.Image = Properties.Resources.settings_alt_32;
            tsb_Settings.ImageScaling = ToolStripItemImageScaling.None;
            tsb_Settings.ImageTransparentColor = Color.Magenta;
            tsb_Settings.Name = "tsb_Settings";
            tsb_Settings.Size = new Size(60, 55);
            tsb_Settings.Text = "Settings";
            tsb_Settings.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsb_Tools
            // 
            tsb_Tools.AutoSize = false;
            tsb_Tools.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
            tsb_Tools.Image = Properties.Resources.tools;
            tsb_Tools.ImageScaling = ToolStripItemImageScaling.None;
            tsb_Tools.ImageTransparentColor = Color.Magenta;
            tsb_Tools.Name = "tsb_Tools";
            tsb_Tools.Size = new Size(60, 55);
            tsb_Tools.Text = "Tools";
            tsb_Tools.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(102, 22);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // tsb_About
            // 
            tsb_About.AutoSize = false;
            tsb_About.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem, aboutToolStripMenuItem });
            tsb_About.Image = Properties.Resources.about_faq_help_info_information_icon;
            tsb_About.ImageScaling = ToolStripItemImageScaling.None;
            tsb_About.ImageTransparentColor = Color.Magenta;
            tsb_About.Name = "tsb_About";
            tsb_About.Size = new Size(60, 55);
            tsb_About.Text = "About";
            tsb_About.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(107, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pnl_UserInfor);
            panel1.Controls.Add(pnl_Cal);
            panel1.Controls.Add(lbl_TimeShow);
            panel1.Controls.Add(btn_Minimise);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 676);
            panel1.TabIndex = 1;
            // 
            // pnl_UserInfor
            // 
            pnl_UserInfor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_UserInfor.Controls.Add(lbl_UserName);
            pnl_UserInfor.Controls.Add(pbx_UserPic);
            pnl_UserInfor.Location = new Point(6, 503);
            pnl_UserInfor.Name = "pnl_UserInfor";
            pnl_UserInfor.Size = new Size(132, 149);
            pnl_UserInfor.TabIndex = 4;
            // 
            // lbl_UserName
            // 
            lbl_UserName.Location = new Point(5, 122);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(124, 23);
            lbl_UserName.TabIndex = 1;
            lbl_UserName.Text = "User";
            lbl_UserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbx_UserPic
            // 
            pbx_UserPic.Location = new Point(10, 3);
            pbx_UserPic.Name = "pbx_UserPic";
            pbx_UserPic.Size = new Size(115, 116);
            pbx_UserPic.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_UserPic.TabIndex = 0;
            pbx_UserPic.TabStop = false;
            // 
            // pnl_Cal
            // 
            pnl_Cal.BackgroundImage = Properties.Resources.calander;
            pnl_Cal.BackgroundImageLayout = ImageLayout.Zoom;
            pnl_Cal.Controls.Add(lbl_DayOfWeek);
            pnl_Cal.Controls.Add(lbl_Date);
            pnl_Cal.Controls.Add(lbl_Month);
            pnl_Cal.Controls.Add(lbl_Year);
            pnl_Cal.Location = new Point(2, 29);
            pnl_Cal.Name = "pnl_Cal";
            pnl_Cal.Size = new Size(137, 150);
            pnl_Cal.TabIndex = 3;
            // 
            // lbl_DayOfWeek
            // 
            lbl_DayOfWeek.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_DayOfWeek.BackColor = Color.Transparent;
            lbl_DayOfWeek.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DayOfWeek.Location = new Point(14, 92);
            lbl_DayOfWeek.Name = "lbl_DayOfWeek";
            lbl_DayOfWeek.Size = new Size(110, 36);
            lbl_DayOfWeek.TabIndex = 7;
            lbl_DayOfWeek.Text = "DayWeek";
            lbl_DayOfWeek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            lbl_Date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Date.BackColor = Color.Transparent;
            lbl_Date.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Date.Location = new Point(14, 62);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(110, 30);
            lbl_Date.TabIndex = 6;
            lbl_Date.Text = "00";
            lbl_Date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Month
            // 
            lbl_Month.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Month.BackColor = Color.Transparent;
            lbl_Month.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Month.ForeColor = SystemColors.ButtonFace;
            lbl_Month.Location = new Point(56, 39);
            lbl_Month.Name = "lbl_Month";
            lbl_Month.Size = new Size(68, 25);
            lbl_Month.TabIndex = 5;
            lbl_Month.Text = "Month";
            lbl_Month.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_Year
            // 
            lbl_Year.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Year.BackColor = Color.Transparent;
            lbl_Year.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Year.ForeColor = SystemColors.ButtonFace;
            lbl_Year.Location = new Point(14, 39);
            lbl_Year.Name = "lbl_Year";
            lbl_Year.Size = new Size(43, 25);
            lbl_Year.TabIndex = 0;
            lbl_Year.Text = "Year";
            // 
            // lbl_TimeShow
            // 
            lbl_TimeShow.BackColor = Color.Transparent;
            lbl_TimeShow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TimeShow.Location = new Point(6, -1);
            lbl_TimeShow.Name = "lbl_TimeShow";
            lbl_TimeShow.Size = new Size(133, 23);
            lbl_TimeShow.TabIndex = 1;
            lbl_TimeShow.Text = "00:00:00";
            lbl_TimeShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Minimise
            // 
            btn_Minimise.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Minimise.FlatStyle = FlatStyle.Popup;
            btn_Minimise.Image = Properties.Resources.desktop;
            btn_Minimise.Location = new Point(-1, 819);
            btn_Minimise.Name = "btn_Minimise";
            btn_Minimise.Size = new Size(140, 28);
            btn_Minimise.TabIndex = 0;
            btn_Minimise.Text = "Show Desktop";
            btn_Minimise.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Minimise.UseVisualStyleBackColor = true;
            btn_Minimise.Click += btn_Minimise_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_VersionDisplay);
            panel2.Controls.Add(lbl_VersionWord);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(143, 648);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 28);
            panel2.TabIndex = 2;
            // 
            // lbl_VersionDisplay
            // 
            lbl_VersionDisplay.Location = new Point(48, 0);
            lbl_VersionDisplay.Name = "lbl_VersionDisplay";
            lbl_VersionDisplay.Size = new Size(195, 23);
            lbl_VersionDisplay.TabIndex = 1;
            lbl_VersionDisplay.Text = "Version";
            lbl_VersionDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_VersionWord
            // 
            lbl_VersionWord.Location = new Point(2, 0);
            lbl_VersionWord.Name = "lbl_VersionWord";
            lbl_VersionWord.Size = new Size(46, 23);
            lbl_VersionWord.TabIndex = 0;
            lbl_VersionWord.Text = "Version";
            lbl_VersionWord.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tm_TimeNow
            // 
            tm_TimeNow.Enabled = true;
            tm_TimeNow.Interval = 1000;
            tm_TimeNow.Tick += tm_TimeNow_Tick;
            // 
            // cms_LockScreen
            // 
            cms_LockScreen.Items.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, lockScreenToolStripMenuItem });
            cms_LockScreen.Name = "cms_LockScreen";
            cms_LockScreen.Size = new Size(138, 48);
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(137, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // lockScreenToolStripMenuItem
            // 
            lockScreenToolStripMenuItem.Name = "lockScreenToolStripMenuItem";
            lockScreenToolStripMenuItem.Size = new Size(137, 22);
            lockScreenToolStripMenuItem.Text = "Lock Screen";
            lockScreenToolStripMenuItem.Click += lockScreenToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 676);
            ContextMenuStrip = cms_LockScreen;
            Controls.Add(panel2);
            Controls.Add(ts_Main);
            Controls.Add(panel1);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            KeyPreview = true;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Czemi Simple Diary";
            Load += Form1_Load;
            ts_Main.ResumeLayout(false);
            ts_Main.PerformLayout();
            panel1.ResumeLayout(false);
            pnl_UserInfor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_UserPic).EndInit();
            pnl_Cal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            cms_LockScreen.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip ts_Main;
        private ToolStripButton tsb_Exit;
        private Panel panel1;
        private Panel panel2;
        private ToolStripButton tsb_Add;
        private ToolStripButton tsb_Search;
        private ToolStripButton tsb_Settings;
        private ToolStripDropDownButton tsb_About;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btn_Minimise;
        private Label lbl_TimeShow;
        private System.Windows.Forms.Timer tm_TimeNow;
        private Panel pnl_Cal;
        private Label lbl_DayOfWeek;
        private Label lbl_Date;
        private Label lbl_Month;
        private Label lbl_Year;
        private Label lbl_VersionDisplay;
        private Label lbl_VersionWord;
        private ToolStripDropDownButton tsb_Tools;
        private ToolStripMenuItem usersToolStripMenuItem;
        private Panel pnl_UserInfor;
        private Label lbl_UserName;
        private PictureBox pbx_UserPic;
        private ContextMenuStrip cms_LockScreen;
        private ToolStripMenuItem lockScreenToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}