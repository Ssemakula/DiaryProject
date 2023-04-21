namespace DiaryProject.My_Forms
{
    partial class MemoSearch
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
            lb_Seach = new ListBox();
            gb_Search = new GroupBox();
            lbl_SearchID = new Label();
            txt_IDSearch = new TextBox();
            btn_Search = new Button();
            memo_panel.SuspendLayout();
            memo_ts.SuspendLayout();
            gb_Search.SuspendLayout();
            SuspendLayout();
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
            memo_panel.Location = new Point(151, 12);
            memo_panel.Name = "memo_panel";
            memo_panel.Size = new Size(637, 399);
            memo_panel.TabIndex = 2;
            // 
            // memoIDtextBox
            // 
            memoIDtextBox.BackColor = SystemColors.Window;
            memoIDtextBox.Location = new Point(88, 15);
            memoIDtextBox.Name = "memoIDtextBox";
            memoIDtextBox.ReadOnly = true;
            memoIDtextBox.Size = new Size(180, 23);
            memoIDtextBox.TabIndex = 9;
            // 
            // memoIDlabel
            // 
            memoIDlabel.Location = new Point(10, 15);
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
            memo_ts.Location = new Point(88, 84);
            memo_ts.Name = "memo_ts";
            memo_ts.Size = new Size(537, 25);
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
            // 
            // fontHighlight_tsb
            // 
            fontHighlight_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fontHighlight_tsb.Image = Properties.Resources.font_color_icon;
            fontHighlight_tsb.ImageTransparentColor = Color.Magenta;
            fontHighlight_tsb.Name = "fontHighlight_tsb";
            fontHighlight_tsb.Size = new Size(23, 22);
            fontHighlight_tsb.Text = "Highlight Colour";
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
            // 
            // centerAligh_tsb
            // 
            centerAligh_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            centerAligh_tsb.Image = Properties.Resources.align_center_pink;
            centerAligh_tsb.ImageTransparentColor = Color.Magenta;
            centerAligh_tsb.Name = "centerAligh_tsb";
            centerAligh_tsb.Size = new Size(23, 22);
            centerAligh_tsb.Text = "Align Text Centre";
            // 
            // rightAlign_tsb
            // 
            rightAlign_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rightAlign_tsb.Image = Properties.Resources.align_right_pink;
            rightAlign_tsb.ImageTransparentColor = Color.Magenta;
            rightAlign_tsb.Name = "rightAlign_tsb";
            rightAlign_tsb.Size = new Size(23, 22);
            rightAlign_tsb.Text = "Align Text Right";
            // 
            // bullets_tsb
            // 
            bullets_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bullets_tsb.Image = Properties.Resources.bullets_light_icon;
            bullets_tsb.ImageTransparentColor = Color.Magenta;
            bullets_tsb.Name = "bullets_tsb";
            bullets_tsb.Size = new Size(23, 22);
            bullets_tsb.Text = "Bullets";
            // 
            // indent_tsb
            // 
            indent_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            indent_tsb.Image = Properties.Resources.indent_icon;
            indent_tsb.ImageTransparentColor = Color.Magenta;
            indent_tsb.Name = "indent_tsb";
            indent_tsb.Size = new Size(23, 22);
            indent_tsb.Text = "Increase Indent";
            // 
            // decreaseIndent_tsb
            // 
            decreaseIndent_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            decreaseIndent_tsb.Image = Properties.Resources.decrease_indent_icon;
            decreaseIndent_tsb.ImageTransparentColor = Color.Magenta;
            decreaseIndent_tsb.Name = "decreaseIndent_tsb";
            decreaseIndent_tsb.Size = new Size(23, 22);
            decreaseIndent_tsb.Text = "Decrease Indent";
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
            // 
            // copy_tsb
            // 
            copy_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copy_tsb.Image = Properties.Resources.clipboard_copy_colour_icon;
            copy_tsb.ImageTransparentColor = Color.Magenta;
            copy_tsb.Name = "copy_tsb";
            copy_tsb.Size = new Size(23, 22);
            copy_tsb.Text = "Copy";
            // 
            // paste_tsb
            // 
            paste_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            paste_tsb.Image = Properties.Resources.clipboard_paste_colour_icon;
            paste_tsb.ImageTransparentColor = Color.Magenta;
            paste_tsb.Name = "paste_tsb";
            paste_tsb.Size = new Size(23, 22);
            paste_tsb.Text = "Paste";
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
            // 
            // redo_tsb
            // 
            redo_tsb.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redo_tsb.Image = Properties.Resources.Redo_2_16;
            redo_tsb.ImageTransparentColor = Color.Magenta;
            redo_tsb.Name = "redo_tsb";
            redo_tsb.Size = new Size(23, 22);
            redo_tsb.Text = "Redo";
            // 
            // memorichTextBox
            // 
            memorichTextBox.AcceptsTab = true;
            memorichTextBox.AutoWordSelection = true;
            memorichTextBox.BorderStyle = BorderStyle.FixedSingle;
            memorichTextBox.Location = new Point(88, 118);
            memorichTextBox.Name = "memorichTextBox";
            memorichTextBox.Size = new Size(537, 257);
            memorichTextBox.TabIndex = 5;
            memorichTextBox.Text = "";
            // 
            // memolabel
            // 
            memolabel.Location = new Point(10, 89);
            memolabel.Name = "memolabel";
            memolabel.Size = new Size(78, 23);
            memolabel.TabIndex = 4;
            memolabel.Text = "Memo";
            memolabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // datetextBox
            // 
            datetextBox.BackColor = SystemColors.Window;
            datetextBox.Location = new Point(88, 61);
            datetextBox.Name = "datetextBox";
            datetextBox.ReadOnly = true;
            datetextBox.Size = new Size(537, 23);
            datetextBox.TabIndex = 3;
            // 
            // datelabel
            // 
            datelabel.Location = new Point(10, 61);
            datelabel.Name = "datelabel";
            datelabel.Size = new Size(78, 23);
            datelabel.TabIndex = 2;
            datelabel.Text = "Memo Date";
            datelabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // titletextBox
            // 
            titletextBox.BackColor = SystemColors.Window;
            titletextBox.Location = new Point(88, 38);
            titletextBox.Name = "titletextBox";
            titletextBox.ReadOnly = true;
            titletextBox.Size = new Size(537, 23);
            titletextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(10, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(78, 23);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            titleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb_Seach
            // 
            lb_Seach.FormattingEnabled = true;
            lb_Seach.ItemHeight = 15;
            lb_Seach.Location = new Point(6, 119);
            lb_Seach.Name = "lb_Seach";
            lb_Seach.Size = new Size(120, 259);
            lb_Seach.TabIndex = 3;
            // 
            // gb_Search
            // 
            gb_Search.Controls.Add(btn_Search);
            gb_Search.Controls.Add(txt_IDSearch);
            gb_Search.Controls.Add(lbl_SearchID);
            gb_Search.Controls.Add(lb_Seach);
            gb_Search.Location = new Point(7, 12);
            gb_Search.Name = "gb_Search";
            gb_Search.Size = new Size(138, 399);
            gb_Search.TabIndex = 4;
            gb_Search.TabStop = false;
            // 
            // lbl_SearchID
            // 
            lbl_SearchID.AutoSize = true;
            lbl_SearchID.Location = new Point(7, 94);
            lbl_SearchID.Name = "lbl_SearchID";
            lbl_SearchID.Size = new Size(21, 15);
            lbl_SearchID.TabIndex = 4;
            lbl_SearchID.Text = "ID:";
            // 
            // txt_IDSearch
            // 
            txt_IDSearch.Location = new Point(29, 90);
            txt_IDSearch.Name = "txt_IDSearch";
            txt_IDSearch.Size = new Size(70, 23);
            txt_IDSearch.TabIndex = 5;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(99, 90);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(39, 23);
            btn_Search.TabIndex = 6;
            btn_Search.Text = "Go";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // MemoSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(gb_Search);
            Controls.Add(memo_panel);
            Name = "MemoSearch";
            Text = "Search Memo";
            Load += MemoSearch_Load;
            memo_panel.ResumeLayout(false);
            memo_panel.PerformLayout();
            memo_ts.ResumeLayout(false);
            memo_ts.PerformLayout();
            gb_Search.ResumeLayout(false);
            gb_Search.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel memo_panel;
        private TextBox memoIDtextBox;
        private Label memoIDlabel;
        private ToolStrip memo_ts;
        private ToolStripButton font_tsb;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton fontColor_tsb;
        private ToolStripButton fontHighlight_tsb;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton leftAlign_tsb;
        private ToolStripButton centerAligh_tsb;
        private ToolStripButton rightAlign_tsb;
        private ToolStripButton bullets_tsb;
        private ToolStripButton indent_tsb;
        private ToolStripButton decreaseIndent_tsb;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton cut_tsb;
        private ToolStripButton copy_tsb;
        private ToolStripButton paste_tsb;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton undo_tsb;
        private ToolStripButton redo_tsb;
        private RichTextBox memorichTextBox;
        private Label memolabel;
        private TextBox datetextBox;
        private Label datelabel;
        private TextBox titletextBox;
        private Label titleLabel;
        private ListBox lb_Seach;
        private GroupBox gb_Search;
        private Label lbl_SearchID;
        private Button btn_Search;
        private TextBox txt_IDSearch;
    }
}