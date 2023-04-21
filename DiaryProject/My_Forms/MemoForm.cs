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
    public partial class MemoForm : Form
    {
        string _UserDataPath = "";
        int _laastMemoId = 0;
        int _currentMemoID; // To be used on load operations
        bool _editStatus = false; // To check whether edit or new

        public MemoForm()
        {
            InitializeComponent();
        }

        private void exittoolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close?", "Close window", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void font_tsb_Click(object sender, EventArgs e)
        {
            if (this.fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.memorichTextBox.SelectionFont = this.fontDialog.Font;
            }
        }

        private void leftAlign_tsb_Click(object sender, EventArgs e)
        {
            this.memorichTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAligh_tsb_Click(object sender, EventArgs e)
        {
            this.memorichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightAlign_tsb_Click(object sender, EventArgs e)
        {
            this.memorichTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void bullets_tsb_Click(object sender, EventArgs e)
        {
            if (this.memorichTextBox.SelectionBullet)
                this.memorichTextBox.SelectionBullet = false;
            else
                this.memorichTextBox.SelectionBullet = true;
        }

        private void indent_tsb_Click(object sender, EventArgs e)
        {
            int IndentValue;

            IndentValue = this.memorichTextBox.SelectionIndent + 8;
            this.memorichTextBox.SelectionIndent = IndentValue;
        }

        private void decreaseIndent_tsb_Click(object sender, EventArgs e)
        {
            int IndentValue;

            IndentValue = this.memorichTextBox.SelectionIndent - 8;
            if (IndentValue < 0)
                IndentValue = 0;

            this.memorichTextBox.SelectionIndent = IndentValue;
        }

        private void fontColor_tsb_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new ColorDialog();

            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.memorichTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void fontHighlight_tsb_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new ColorDialog();

            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.memorichTextBox.SelectionBackColor = colorDialog.Color;
            }
        }

        private void cut_tsb_Click(object sender, EventArgs e)
        {
            this.memorichTextBox.Cut();
        }

        private void copy_tsb_Click(object sender, EventArgs e)
        {
            this.memorichTextBox.Copy();
        }

        private void paste_tsb_Click(object sender, EventArgs e)
        {
            this.memorichTextBox.Paste();
        }

        private void undo_tsb_Click(object sender, EventArgs e)
        {
            if (this.memorichTextBox.CanUndo)
            {
                this.memorichTextBox.Undo();
            }
        }

        private void redo_tsb_Click(object sender, EventArgs e)
        {
            if (this.memorichTextBox.CanRedo)
            {
                this.memorichTextBox.Redo();
            }
        }

        private void disableButtons()
        {
            this.memo_panel.Enabled = false;
            this.saveToolStripButton.Enabled = false;
            this.copyToolStripButton.Enabled = false;
            this.pasteToolStripButton.Enabled = false;
            this.cutToolStripButton.Enabled = false;
            this.printToolStripButton.Enabled = false;
            this.newToolStripButton.Enabled = true;
            this.openToolStripButton.Enabled = true;
            this.resettoolStripButton.Enabled = true;
        }

        private void enableButtons()
        {
            this.memo_panel.Enabled = true;
            this.saveToolStripButton.Enabled = true;
            this.copyToolStripButton.Enabled = true;
            this.pasteToolStripButton.Enabled = true;
            this.cutToolStripButton.Enabled = true;
            this.printToolStripButton.Enabled = true;
            this.newToolStripButton.Enabled = false;
            this.openToolStripButton.Enabled = false;
            this.resettoolStripButton.Enabled = false;
        }
        private void MemoForm_Load(object sender, EventArgs e)
        {
            disableButtons();

            if (DiaryProject.Properties.Settings.Default._SaveLocation == null || DiaryProject.Properties.Settings.Default._SaveLocation.Trim() == "")
            {
                _UserDataPath = Application.UserAppDataPath;
            }
            else
            {
                _UserDataPath = DiaryProject.Properties.Settings.Default._SaveLocation;
            }
            _UserDataPath += "\\";

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            enableButtons();
            this.memorichTextBox.ResetText();
            this.datetextBox.ResetText();
            this.titletextBox.ResetText();
            //______________________________________________________
            //Lesson says so but I suspect I'd rather do it after save
            _laastMemoId = DiaryProject.Properties.Settings.Default._last_id;
            _laastMemoId += 1;
            this.memoIDtextBox.Text = _laastMemoId.ToString(); 
            //------------------------------------------------------
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            string fileSaveName, fileDate, fileTitle;

            if(this.datetextBox.Text.Trim().Length == 0 || this.titletextBox.Text.Trim().Length == 0) {
                MessageBox.Show("Date or Title fields cannot be empty");
                return;
            }
            disableButtons();

            if(!_editStatus)
            {
                _currentMemoID = _laastMemoId;
            }

            //___________________________________________________
            //This section will be revisited after database lessons
            fileSaveName = _UserDataPath + _currentMemoID.ToString() + "_memo.rtf";
            fileDate = _UserDataPath + _currentMemoID.ToString() + "_date.rtf";
            fileTitle = _UserDataPath + _currentMemoID.ToString() + "_title.rtf";
            this.memorichTextBox.SaveFile(fileSaveName);
            System.IO.File.WriteAllText(fileDate, datetextBox.Text);
            System.IO.File.WriteAllText(fileTitle, titletextBox.Text);
            //---------------------------------------------------

            DiaryProject.Properties.Settings.Default._last_id = _laastMemoId;
            DiaryProject.Properties.Settings.Default.Save();
        }

        private void resettoolStripButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to reset?", "Reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _laastMemoId = 0;
                DiaryProject.Properties.Settings.Default._last_id = 0;
                DiaryProject.Properties.Settings.Default.Save();
            }
        }
    }
}
