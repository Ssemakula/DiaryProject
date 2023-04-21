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
    public partial class MemoSearch : Form
    {
        string _UserDataPath = "";
        int _laastMemoId = 0;
        int _currentMemoID; // To be used on load operations
        bool _editStatus = false; // To check whether edit or new
        public MemoSearch()
        {
            InitializeComponent();
        }

        private void MemoSearch_Load(object sender, EventArgs e)
        {
            if (DiaryProject.Properties.Settings.Default._SaveLocation == null || DiaryProject.Properties.Settings.Default._SaveLocation.Trim() == "")
            {
                _UserDataPath = Application.UserAppDataPath;
            }
            else
            {
                _UserDataPath = DiaryProject.Properties.Settings.Default._SaveLocation;
            }
            _UserDataPath += "\\";
            _laastMemoId = DiaryProject.Properties.Settings.Default._last_id;

            for(int i = 1; i <= _laastMemoId; i++)
            {
                this.lb_Seach.Items.Add(i.ToString());
            }
        }
        
    }
}
