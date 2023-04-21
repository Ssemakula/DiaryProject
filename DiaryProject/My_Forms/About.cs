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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.lbl_Company.Text = Application.CompanyName;
            this.lbl_Product.Text = "Product: " + DiaryProject.Properties.Settings.Default._ProductName;
            this.lbl_Version.Text = "Version: " + Application.ProductVersion;
            /*
            + "." +
            DiaryProject.Properties.Settings.Default._Edition.ToString() + "." +
            DiaryProject.Properties.Settings.Default._Revision.ToString(); */
            this.lbl_Developer.Text = "Website: " + DiaryProject.Properties.Settings.Default._URLPlace;
            this.lbl_Programmer.Text = "Developer: " + DiaryProject.Properties.Settings.Default._Developer;
            this.lbl_Copyright.Text = DiaryProject.Properties.Settings.Default._Copyright;
            this.lbl_Rights.Text = DiaryProject.Properties.Settings.Default._Rights;
            // this.lbl_Company.Text = Application.;
        }
    }
}
