namespace DiaryProject.My_Forms
{
    partial class MemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoForm));
            ts_Memo = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            SearchToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            exittoolStripButton = new ToolStripButton();
            memo_panel = new Panel();
            memoIDtextBox = new TextBox();
            memoIDlabel = new Label();
            memo_ts = new ToolStrip();
            font_tsb = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            fontColor_tsb = new ToolStripButton();
            fontHighlight_tsb = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            leftAlign_tsb = new ToolStripButton();
            centerAligh_tsb = new ToolStripButton();
            rightAlign_tsb = new ToolStripButton();
            bullets_tsb = new ToolStripButton();
            indent_tsb = new ToolStripButton();
            decreaseIndent_tsb = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            cut_tsb = new ToolStripButton();
            copy_tsb = new ToolStripButton();
            paste_tsb = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            undo_tsb = new ToolStripButton();
            redo_tsb = new ToolStripButton();
            memorichTextBox = new RichTextBox();
            memolabel = new Label();
            datetextBox = new TextBox();
            datelabel = new Label();
            titletextBox = new TextBox();
            titleLabel = new Label();
            fontDialog = new FontDialog();
            resettoolStripButton = new ToolStripButton();
            ts_Memo.SuspendLayout();
            memo_panel.SuspendLayout();
            memo_ts.SuspendLayout();
            SuspendLayout();
            // 
            // ts_Memo
            // 
            ts_Memo.AutoSize = false;
            ts_Memo.GripStyle = ToolStripGripStyle.Hidden;
            ts_Memo.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, SearchToolStripButton, printToolStripButton, toolStripSeparator, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator1, helpToolStripButton, exittoolStripButton, resettoolStripButton });
            ts_Memo.Location = new Point(0, 0);
            ts_Memo.Name = "ts_Memo";
            ts_Memo.Size = new Size(810, 40);
            ts_Memo.TabIndex = 0;
            ts_Memo.Text = "Memo Controls";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 37);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += newToolStripButton_Click;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 37);
            openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 37);
            saveToolStripButton.Text = "&Save";
            saveToolStripButton.Click += saveToolStripButton_Click;
            // 
            // SearchToolStripButton
            // 
            SearchToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SearchToolStripButton.Image = Properties.Resources.search;
            SearchToolStripButton.ImageTransparentColor = Color.Magenta;
            SearchToolStripButton.Name = "SearchToolStripButton";
            SearchToolStripButton.Size = new Size(23, 37);
            SearchToolStripButton.Text = "Search";
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(23, 37);
            printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 40);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = (Image)resources.GetObject("cutToolStripButton.Image");
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(23, 37);
            cutToolStripButton.Text = "C&ut";
            cutToolStripButton.Click += cut_tsb_Click;
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(23, 37);
            copyToolStripButton.Text = "&Copy";
            copyToolStripButton.Click += copy_tsb_Click;
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = (Image)resources.GetObject("pasteToolStripButton.Image");
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(23, 37);
            pasteToolStripButton.Text = "&Paste";
            pasteToolStripButton.Click += paste_tsb_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 40);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 37);
            helpToolStripButton.Text = "He&lp";
            // 
            // exittoolStripButton
            // 
            exittoolStripButton.Alignment = ToolStripItemAlignment.Right;
            exittoolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            exittoolStripButton.Image = Properties.Resources.exit;
            exittoolStripButton.ImageTransparentColor = Color.Magenta;
            exittoolStripButton.Name = "exittoolStripButton";
            exittoolStripButton.Size = new Size(23, 37);
            exittoolStripButton.Text = "toolStripButton1";
            exittoolStripButton.Click += exittoolStripButton_Click;
            // 
            // memo_panel
            // 
            memo_panel.Controls.Add(memoIDtextBox);
            memo_panel.Controls.Add(memoIDlabel);
            memo_panel.Controls.Add(memo_ts);
            memo_panel.Controls.Add(memorichTextBox);
            memo_panel.Controls.Add(memolabel);
            memo_panel.Controls.Add(datetextBox);
            memo_panel.Controls.Add(datelabel);
            memo_panel.Controls.Add(titletextBox);
            memo_panel.Controls.Add(titleLabel);
            memo_panel.Location = new Point(21, 60);
            memo_panel.Name = "memo_panel";
            memo_panel.Size = new Size(765, 399);
            memo_panel.TabIndex = 1;
            // 
            // memoIDtextBox
            // 
            memoIDtextBox.BackColor = SystemColors.Window;
            memoIDtextBox.Location = new Point(104, 16);
            memoIDtextBox.Name = "memoIDtextBox";
            memoIDtextBox.ReadOnly = true;
            memoIDtextBox.Size = new Size(180, 23);
            memoIDtextBox.TabIndex = 9;
            // 
            // memoIDlabel
            // 
            memoIDlabel.Location = new Point(26, 16);
            memoIDlabel.Name = "memoIDlabel";
            memoIDlabel.Size = new Size(78, 23);
            memoIDlabel.TabIndex = 8;
            memoIDlabel.Text = "Memo ID";
            memoIDlabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // memo_ts
            // 
            memo_ts.AutoSize = false;
            memo_ts.Dock = DockStyle.None;
            memo_ts.GripStyle = ToolStripGripStyle.Hidden;
            memo_ts.Items.AddRange(new ToolStripItem[] { font_tsb, toolStripSeparator3, fontColor_tsb, fontHighlight_tsb, toolStripSeparator2, leftAlign_tsb, centerAligh_tsb, rightAlign_tsb, bullets_tsb, indent_tsb, decreaseIndent_tsb, toolStripSeparator4, cut_tsb, copy_tsb, paste_tsb, toolStripSeparator5, undo_tsb, redo_tsb });
            memo_ts.Location = new Point(104, 85);
            memo_ts.Name = "memo_ts";
            memo_ts.Size = new Size(643, 25);
            memo_ts.TabIndex = 7;
            memo_ts.Text = "Text Actions";
            // 
            // font_tsb
            // 
            font_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            font_tsb.Image = Properties.Resources.font_size_icon;
            font_tsb.ImageTransparentColor = Color.Magenta;
            font_tsb.Name = "font_tsb";
            font_tsb.Size = new Size(23, 22);
            font_tsb.Text = "font_tsb";
            font_tsb.Click += font_tsb_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // fontColor_tsb
            // 
            fontColor_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fontColor_tsb.Image = Properties.Resources.font_color_truetype_icon;
            fontColor_tsb.ImageTransparentColor = Color.Magenta;
            fontColor_tsb.Name = "fontColor_tsb";
            fontColor_tsb.Size = new Size(23, 22);
            fontColor_tsb.Text = "Font Colour";
            fontColor_tsb.Click += fontColor_tsb_Click;
            // 
            // fontHighlight_tsb
            // 
            fontHighlight_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fontHighlight_tsb.Image = Properties.Resources.font_color_icon;
            fontHighlight_tsb.ImageTransparentColor = Color.Magenta;
            fontHighlight_tsb.Name = "fontHighlight_tsb";
            fontHighlight_tsb.Size = new Size(23, 22);
            fontHighlight_tsb.Text = "Highlight Colour";
            fontHighlight_tsb.Click += fontHighlight_tsb_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // leftAlign_tsb
            // 
            leftAlign_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            leftAlign_tsb.Image = Properties.Resources.align_left_pink;
            leftAlign_tsb.ImageTransparentColor = Color.Magenta;
            leftAlign_tsb.Name = "leftAlign_tsb";
            leftAlign_tsb.Size = new Size(23, 22);
            leftAlign_tsb.Text = "Align Text Left";
            leftAlign_tsb.Click += leftAlign_tsb_Click;
            // 
            // centerAligh_tsb
            // 
            centerAligh_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            centerAligh_tsb.Image = Properties.Resources.align_center_pink;
            centerAligh_tsb.ImageTransparentColor = Color.Magenta;
            centerAligh_tsb.Name = "centerAligh_tsb";
            centerAligh_tsb.Size = new Size(23, 22);
            centerAligh_tsb.Text = "Align Text Centre";
            centerAligh_tsb.Click += centerAligh_tsb_Click;
            // 
            // rightAlign_tsb
            // 
            rightAlign_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rightAlign_tsb.Image = Properties.Resources.align_right_pink;
            rightAlign_tsb.ImageTransparentColor = Color.Magenta;
            rightAlign_tsb.Name = "rightAlign_tsb";
            rightAlign_tsb.Size = new Size(23, 22);
            rightAlign_tsb.Text = "Align Text Right";
            rightAlign_tsb.Click += rightAlign_tsb_Click;
            // 
            // bullets_tsb
            // 
            bullets_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bullets_tsb.Image = Properties.Resources.bullets_light_icon;
            bullets_tsb.ImageTransparentColor = Color.Magenta;
            bullets_tsb.Name = "bullets_tsb";
            bullets_tsb.Size = new Size(23, 22);
            bullets_tsb.Text = "Bullets";
            bullets_tsb.Click += bullets_tsb_Click;
            // 
            // indent_tsb
            // 
            indent_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            indent_tsb.Image = Properties.Resources.indent_icon;
            indent_tsb.ImageTransparentColor = Color.Magenta;
            indent_tsb.Name = "indent_tsb";
            indent_tsb.Size = new Size(23, 22);
            indent_tsb.Text = "Increase Indent";
            indent_tsb.Click += indent_tsb_Click;
            // 
            // decreaseIndent_tsb
            // 
            decreaseIndent_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            decreaseIndent_tsb.Image = Properties.Resources.decrease_indent_icon;
            decreaseIndent_tsb.ImageTransparentColor = Color.Magenta;
            decreaseIndent_tsb.Name = "decreaseIndent_tsb";
            decreaseIndent_tsb.Size = new Size(23, 22);
            decreaseIndent_tsb.Text = "Decrease Indent";
            decreaseIndent_tsb.Click += decreaseIndent_tsb_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // cut_tsb
            // 
            cut_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cut_tsb.Image = Properties.Resources.clipboard_cut_colour_icon;
            cut_tsb.ImageTransparentColor = Color.Magenta;
            cut_tsb.Name = "cut_tsb";
            cut_tsb.Size = new Size(23, 22);
            cut_tsb.Text = "Cut";
            cut_tsb.Click += cut_tsb_Click;
            // 
            // copy_tsb
            // 
            copy_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copy_tsb.Image = Properties.Resources.clipboard_copy_colour_icon;
            copy_tsb.ImageTransparentColor = Color.Magenta;
            copy_tsb.Name = "copy_tsb";
            copy_tsb.Size = new Size(23, 22);
            copy_tsb.Text = "Copy";
            copy_tsb.Click += copy_tsb_Click;
            // 
            // paste_tsb
            // 
            paste_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            paste_tsb.Image = Properties.Resources.clipboard_paste_colour_icon;
            paste_tsb.ImageTransparentColor = Color.Magenta;
            paste_tsb.Name = "paste_tsb";
            paste_tsb.Size = new Size(23, 22);
            paste_tsb.Text = "Paste";
            paste_tsb.Click += paste_tsb_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // undo_tsb
            // 
            undo_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undo_tsb.Image = Properties.Resources.Undo_2_16;
            undo_tsb.ImageTransparentColor = Color.Magenta;
            undo_tsb.Name = "undo_tsb";
            undo_tsb.Size = new Size(23, 22);
            undo_tsb.Text = "Undo";
            undo_tsb.Click += undo_tsb_Click;
            // 
            // redo_tsb
            // 
            redo_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redo_tsb.Image = Properties.Resources.Redo_2_16;
            redo_tsb.ImageTransparentColor = Color.Magenta;
            redo_tsb.Name = "redo_tsb";
            redo_tsb.Size = new Size(23, 22);
            redo_tsb.Text = "Redo";
            redo_tsb.Click += redo_tsb_Click;
            // 
            // memorichTextBox
            // 
            memorichTextBox.AcceptsTab = true;
            memorichTextBox.AutoWordSelection = true;
            memorichTextBox.BorderStyle = BorderStyle.FixedSingle;
            memorichTextBox.Location = new Point(104, 119);
            memorichTextBox.Name = "memorichTextBox";
            memorichTextBox.Size = new Size(643, 257);
            memorichTextBox.TabIndex = 5;
            memorichTextBox.Text = "";
            // 
            // memolabel
            // 
            memolabel.Location = new Point(26, 90);
            memolabel.Name = "memolabel";
            memolabel.Size = new Size(78, 23);
            memolabel.TabIndex = 4;
            memolabel.Text = "Memo";
            memolabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // datetextBox
            // 
            datetextBox.Location = new Point(104, 62);
            datetextBox.Name = "datetextBox";
            datetextBox.Size = new Size(643, 23);
            datetextBox.TabIndex = 3;
            // 
            // datelabel
            // 
            datelabel.Location = new Point(26, 62);
            datelabel.Name = "datelabel";
            datelabel.Size = new Size(78, 23);
            datelabel.TabIndex = 2;
            datelabel.Text = "Memo Date";
            datelabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // titletextBox
            // 
            titletextBox.Location = new Point(104, 39);
            titletextBox.Name = "titletextBox";
            titletextBox.Size = new Size(643, 23);
            titletextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(26, 39);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(78, 23);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            titleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // resettoolStripButton
            // 
            resettoolStripButton.Alignment = ToolStripItemAlignment.Right;
            resettoolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resettoolStripButton.Image = Properties.Resources.warning_shield_icon;
            resettoolStripButton.ImageTransparentColor = Color.Magenta;
            resettoolStripButton.Name = "resettoolStripButton";
            resettoolStripButton.Size = new Size(23, 37);
            resettoolStripButton.Text = "toolStripButton1";
            resettoolStripButton.Click += resettoolStripButton_Click;
            // 
            // MemoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 473);
            Controls.Add(memo_panel);
            Controls.Add(ts_Memo);
            Name = "MemoForm";
            Text = "Memo Form";
            Load += MemoForm_Load;
            ts_Memo.ResumeLayout(false);
            ts_Memo.PerformLayout();
            memo_panel.ResumeLayout(false);
            memo_panel.PerformLayout();
            memo_ts.ResumeLayout(false);
            memo_ts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip ts_Memo;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton SearchToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton helpToolStripButton;
        private ToolStripButton exittoolStripButton;
        private Panel memo_panel;
        private RichTextBox memorichTextBox;
        private Label memolabel;
        private TextBox datetextBox;
        private Label datelabel;
        private TextBox titletextBox;
        private Label titleLabel;
        private ToolStrip memo_ts;
        private ToolStripButton font_tsb;
        private ToolStripButton leftAlign_tsb;
        private ToolStripButton centerAligh_tsb;
        private ToolStripButton rightAlign_tsb;
        private ToolStripButton bullets_tsb;
        private ToolStripButton indent_tsb;
        private ToolStripButton decreaseIndent_tsb;
        private FontDialog fontDialog;
        private ToolStripButton fontColor_tsb;
        private ToolStripButton fontHighlight_tsb;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton cut_tsb;
        private ToolStripButton copy_tsb;
        private ToolStripButton paste_tsb;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton undo_tsb;
        private ToolStripButton redo_tsb;
        private TextBox memoIDtextBox;
        private Label memoIDlabel;
        private ToolStripButton resettoolStripButton;
    }
}