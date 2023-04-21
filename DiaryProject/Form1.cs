using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalAndDates;

namespace DiaryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsb_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Exit?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_Minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tm_TimeNow_Tick(object sender, EventArgs e)
        {
            //this.lbl_TimeShow.Text = DateTime.Now.ToString("HH:mm:ss");
            ShowTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiaryProject.My_Forms.Login lgn = new();

            lgn.ShowDialog();

            this.tm_TimeNow.Enabled = true;
            this.Enabled = true;
            this.lbl_VersionDisplay.Text = Application.ProductVersion;
            MyMethods.SetOtherDates();
            lbl_Date.Text = MyMethods.MonthDayText;
            lbl_DayOfWeek.Text = MyMethods.DayOfWeekText;
            lbl_Month.Text = MyMethods.MonthText;
            lbl_Year.Text = MyMethods.YearText;
            if (System.IO.File.Exists(DiaryProject.Properties.Settings.Default._PicFileName))
            {
                this.pbx_UserPic.Load(DiaryProject.Properties.Settings.Default._PicFileName);
            }
            this.lbl_UserName.Text = DiaryProject.Properties.Settings.Default._User;

        }

        public void ShowTime()
        {
            this.lbl_TimeShow.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiaryProject.My_Forms.About about = new();
            about.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiaryProject.My_Forms.User_Mngmt user_Mngmt = new()
            {
                MdiParent = this
            };
            user_Mngmt.StartPosition = FormStartPosition.CenterScreen;
            user_Mngmt.Show();
        }

        private void lockScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Require login
            DiaryProject.My_Forms.Login login = new();
            login.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tsb_Add_Click(object sender, EventArgs e)
        {
            DiaryProject.My_Forms.MemoForm memoForm = new();
            memoForm.MdiParent = this;
            memoForm.Show();
        }

        private void tsb_Search_Click(object sender, EventArgs e)
        {
            DiaryProject.My_Forms.MemoSearch memoSearch = new();
            memoSearch.MdiParent = this;
            memoSearch.Show();
        }
    }
}