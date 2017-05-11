﻿namespace WindowsFormsApplication1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tSBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tSBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tSBtnCut = new System.Windows.Forms.ToolStripButton();
            this.tSBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tSBtnUndo = new System.Windows.Forms.ToolStripButton();
            this.tSBtnRedo = new System.Windows.Forms.ToolStripButton();
            this.tSBtnPinNote = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tSCBFont = new System.Windows.Forms.ToolStripComboBox();
            this.tSCBSize = new System.Windows.Forms.ToolStripComboBox();
            this.tSBtnTextColor = new System.Windows.Forms.ToolStripButton();
            this.tSBtnBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.tSBtnNoteColor = new System.Windows.Forms.ToolStripButton();
            this.rTBMain = new System.Windows.Forms.RichTextBox();
            this.tSBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tSBtnBold = new System.Windows.Forms.ToolStripButton();
            this.tSBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tSBtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem1,
            this.textColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.noteColorToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.fontToolStripMenuItem1.Text = "Font";
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // noteColorToolStripMenuItem
            // 
            this.noteColorToolStripMenuItem.Name = "noteColorToolStripMenuItem";
            this.noteColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.noteColorToolStripMenuItem.Text = "Note Color";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolbarToolStripMenuItem,
            this.formatToolbarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fileToolbarToolStripMenuItem
            // 
            this.fileToolbarToolStripMenuItem.Name = "fileToolbarToolStripMenuItem";
            this.fileToolbarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fileToolbarToolStripMenuItem.Text = "File Toolbar";
            // 
            // formatToolbarToolStripMenuItem
            // 
            this.formatToolbarToolStripMenuItem.Name = "formatToolbarToolStripMenuItem";
            this.formatToolbarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.formatToolbarToolStripMenuItem.Text = "Format Toolbar";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnNew,
            this.tSBtnOpen,
            this.tSBtnSave,
            this.tSBtnCut,
            this.tSBtnCopy,
            this.tSBtnPaste,
            this.tSBtnUndo,
            this.tSBtnRedo,
            this.tSBtnPinNote});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnNew
            // 
            this.tSBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnNew.Image")));
            this.tSBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnNew.Name = "tSBtnNew";
            this.tSBtnNew.Size = new System.Drawing.Size(24, 24);
            this.tSBtnNew.Text = "New";
            this.tSBtnNew.Click += new System.EventHandler(this.tSBtnNew_Click);
            // 
            // tSBtnOpen
            // 
            this.tSBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnOpen.Image")));
            this.tSBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnOpen.Name = "tSBtnOpen";
            this.tSBtnOpen.Size = new System.Drawing.Size(24, 24);
            this.tSBtnOpen.Text = "Open";
            this.tSBtnOpen.Click += new System.EventHandler(this.tSBtnOpen_Click);
            // 
            // tSBtnSave
            // 
            this.tSBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnSave.Image")));
            this.tSBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnSave.Name = "tSBtnSave";
            this.tSBtnSave.Size = new System.Drawing.Size(24, 24);
            this.tSBtnSave.Text = "Save";
            this.tSBtnSave.Click += new System.EventHandler(this.tSBtnSave_Click);
            // 
            // tSBtnCut
            // 
            this.tSBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnCut.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnCut.Image")));
            this.tSBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnCut.Name = "tSBtnCut";
            this.tSBtnCut.Size = new System.Drawing.Size(24, 24);
            this.tSBtnCut.Text = "Cut";
            // 
            // tSBtnPaste
            // 
            this.tSBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnPaste.Image")));
            this.tSBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnPaste.Name = "tSBtnPaste";
            this.tSBtnPaste.Size = new System.Drawing.Size(24, 24);
            this.tSBtnPaste.Text = "Paste";
            // 
            // tSBtnUndo
            // 
            this.tSBtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnUndo.Image")));
            this.tSBtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnUndo.Name = "tSBtnUndo";
            this.tSBtnUndo.Size = new System.Drawing.Size(24, 24);
            this.tSBtnUndo.Text = "Undo";
            // 
            // tSBtnRedo
            // 
            this.tSBtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnRedo.Image")));
            this.tSBtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnRedo.Name = "tSBtnRedo";
            this.tSBtnRedo.Size = new System.Drawing.Size(24, 24);
            this.tSBtnRedo.Text = "ReDo";
            // 
            // tSBtnPinNote
            // 
            this.tSBtnPinNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnPinNote.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnPinNote.Image")));
            this.tSBtnPinNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnPinNote.Name = "tSBtnPinNote";
            this.tSBtnPinNote.Size = new System.Drawing.Size(24, 24);
            this.tSBtnPinNote.Text = "Pin Note";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCBFont,
            this.tSCBSize,
            this.tSBtnBold,
            this.tSBtnItalic,
            this.tSBtnUnderline,
            this.tSBtnTextColor,
            this.tSBtnBackgroundColor,
            this.tSBtnNoteColor});
            this.toolStrip2.Location = new System.Drawing.Point(241, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(387, 27);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSCBFont
            // 
            this.tSCBFont.Name = "tSCBFont";
            this.tSCBFont.Size = new System.Drawing.Size(121, 27);
            this.tSCBFont.Text = "Times New Roman";
            this.tSCBFont.SelectedIndexChanged += new System.EventHandler(this.tSCBFont_SelectedIndexChanged);
            // 
            // tSCBSize
            // 
            this.tSCBSize.Name = "tSCBSize";
            this.tSCBSize.Size = new System.Drawing.Size(75, 27);
            this.tSCBSize.Text = "12";
            this.tSCBSize.SelectedIndexChanged += new System.EventHandler(this.tSCBSize_SelectedIndexChanged);
            this.tSCBSize.Click += new System.EventHandler(this.tSCBSize_Click);
            // 
            // tSBtnTextColor
            // 
            this.tSBtnTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnTextColor.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnTextColor.Image")));
            this.tSBtnTextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnTextColor.Name = "tSBtnTextColor";
            this.tSBtnTextColor.Size = new System.Drawing.Size(24, 24);
            this.tSBtnTextColor.Text = "Text Color";
            // 
            // tSBtnBackgroundColor
            // 
            this.tSBtnBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnBackgroundColor.Image")));
            this.tSBtnBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnBackgroundColor.Name = "tSBtnBackgroundColor";
            this.tSBtnBackgroundColor.Size = new System.Drawing.Size(24, 24);
            this.tSBtnBackgroundColor.Text = "Background Color";
            // 
            // tSBtnNoteColor
            // 
            this.tSBtnNoteColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnNoteColor.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnNoteColor.Image")));
            this.tSBtnNoteColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnNoteColor.Name = "tSBtnNoteColor";
            this.tSBtnNoteColor.Size = new System.Drawing.Size(24, 24);
            this.tSBtnNoteColor.Text = "Note Color";
            // 
            // rTBMain
            // 
            this.rTBMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBMain.Location = new System.Drawing.Point(0, 51);
            this.rTBMain.Name = "rTBMain";
            this.rTBMain.Size = new System.Drawing.Size(777, 351);
            this.rTBMain.TabIndex = 3;
            this.rTBMain.Text = "";
            // 
            // tSBtnCopy
            // 
            this.tSBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnCopy.Image")));
            this.tSBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnCopy.Name = "tSBtnCopy";
            this.tSBtnCopy.Size = new System.Drawing.Size(24, 24);
            this.tSBtnCopy.Text = "Copy";
            // 
            // tSBtnBold
            // 
            this.tSBtnBold.CheckOnClick = true;
            this.tSBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnBold.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnBold.Image")));
            this.tSBtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnBold.Name = "tSBtnBold";
            this.tSBtnBold.Size = new System.Drawing.Size(24, 24);
            this.tSBtnBold.Text = "Bold";
            // 
            // tSBtnItalic
            // 
            this.tSBtnItalic.CheckOnClick = true;
            this.tSBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnItalic.Image")));
            this.tSBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnItalic.Name = "tSBtnItalic";
            this.tSBtnItalic.Size = new System.Drawing.Size(24, 24);
            this.tSBtnItalic.Text = "Italic";
            // 
            // tSBtnUnderline
            // 
            this.tSBtnUnderline.CheckOnClick = true;
            this.tSBtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnUnderline.Image")));
            this.tSBtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnUnderline.Name = "tSBtnUnderline";
            this.tSBtnUnderline.Size = new System.Drawing.Size(24, 24);
            this.tSBtnUnderline.Text = "Underline";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.wordToolStripMenuItem.Text = "Word Wrap";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 402);
            this.Controls.Add(this.rTBMain);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Super Notepath";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnOpen;
        private System.Windows.Forms.ToolStripButton tSBtnSave;
        private System.Windows.Forms.ToolStripButton tSBtnCut;
        private System.Windows.Forms.ToolStripButton tSBtnUndo;
        private System.Windows.Forms.ToolStripButton tSBtnPinNote;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox tSCBFont;
        private System.Windows.Forms.ToolStripComboBox tSCBSize;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tSBtnRedo;
        private System.Windows.Forms.ToolStripButton tSBtnNew;
        private System.Windows.Forms.ToolStripButton tSBtnPaste;
        private System.Windows.Forms.ToolStripButton tSBtnTextColor;
        private System.Windows.Forms.ToolStripButton tSBtnBackgroundColor;
        private System.Windows.Forms.ToolStripButton tSBtnNoteColor;
        private System.Windows.Forms.RichTextBox rTBMain;
        private System.Windows.Forms.ToolStripButton tSBtnCopy;
        private System.Windows.Forms.ToolStripButton tSBtnBold;
        private System.Windows.Forms.ToolStripButton tSBtnItalic;
        private System.Windows.Forms.ToolStripButton tSBtnUnderline;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
    }
}

