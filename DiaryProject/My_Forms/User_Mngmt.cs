using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryProject.My_Forms
{
    public partial class User_Mngmt : Form
    {
        string PicFileName;
        public User_Mngmt()
        {
            InitializeComponent();
        }

        private void User_Mngmt_Load(object sender, EventArgs e)
        {
            this.txt_Password.PasswordChar = '*';
            this.txt_ConfirmPass.PasswordChar = '*';
            this.txt_UserName.Text = DiaryProject.Properties.Settings.Default._User;
            this.txt_Password.Text = DiaryProject.Properties.Settings.Default._Password;
            this.txt_ConfirmPass.Text = "";
            PicFileName = DiaryProject.Properties.Settings.Default._PicFileName;
            if(System.IO.File.Exists(PicFileName))
            {
                this.pbx_Pics.Load(PicFileName);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_Password.Text == this.txt_ConfirmPass.Text)
            {
                DiaryProject.Properties.Settings.Default._User = this.txt_UserName.Text;
                DiaryProject.Properties.Settings.Default._Password = this.txt_Password.Text;
                if (PicFileName != null)
                {
                    DiaryProject.Properties.Settings.Default._PicFileName = PicFileName;
                }
                DiaryProject.Properties.Settings.Default.Save();
                User_Mngmt_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files| *.jpg; *.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PicFileName = dlg.FileName;
                this.pbx_Pics.Load(PicFileName);

                /*
                 * Look into the posibility of Saving the User Pix
                 * Either in the CommonAppDataPath
                 * or StartupPath
                 * or Some other place that can be accessed via the Application or System Defaults
                MessageBox.Show($"Allication Startup {Application.StartupPath} Application {Application.CommonAppDataPath}");
                */
            }
        }
    }
}
