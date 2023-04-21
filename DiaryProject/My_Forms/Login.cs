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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void brn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == DiaryProject.Properties.Settings.Default._User)
            {
                if (txt_Password.Text == DiaryProject.Properties.Settings.Default._Password)
                {
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid User or Password");
            }
            else
                MessageBox.Show("Invalid User or Password");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txt_Password.PasswordChar = '*';
        }
    }
}
