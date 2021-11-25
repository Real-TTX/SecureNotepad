
namespace SecureNotepad
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEncryption = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEncryptionPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditRevert = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditGoto = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFormatBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemEncryption,
            this.ToolStripMenuItemEdit,
            this.ToolStripMenuItemFormat,
            this.ToolStripMenuItemView,
            this.ToolStripMenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStripMain.Size = new System.Drawing.Size(2133, 58);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFileNew,
            this.ToolStripMenuItemFileOpen,
            this.ToolStripMenuItemFileSave,
            this.ToolStripMenuItemFileSaveAs,
            this.ToolStripMenuItemFileSeparator2,
            this.ToolStripMenuItemFilePrint,
            this.ToolStripMenuItemFileSeparator1,
            this.ToolStripMenuItemFileClose});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(87, 48);
            this.ToolStripMenuItemFile.Text = "File";
            // 
            // ToolStripMenuItemFileNew
            // 
            this.ToolStripMenuItemFileNew.Name = "ToolStripMenuItemFileNew";
            this.ToolStripMenuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItemFileNew.Size = new System.Drawing.Size(394, 54);
            this.ToolStripMenuItemFileNew.Text = "New";
            // 
            // ToolStripMenuItemFileOpen
            // 
            this.ToolStripMenuItemFileOpen.Name = "ToolStripMenuItemFileOpen";
            this.ToolStripMenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItemFileOpen.Size = new System.Drawing.Size(394, 54);
            this.ToolStripMenuItemFileOpen.Text = "Open...";
            this.ToolStripMenuItemFileOpen.Click += new System.EventHandler(this.ToolStripMenuItemFileOpen_Click);
            // 
            // ToolStripMenuItemFileSave
            // 
            this.ToolStripMenuItemFileSave.Name = "ToolStripMenuItemFileSave";
            this.ToolStripMenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemFileSave.Size = new System.Drawing.Size(394, 54);
            this.ToolStripMenuItemFileSave.Text = "Save";
            this.ToolStripMenuItemFileSave.Click += new System.EventHandler(this.ToolStripMenuItemFileSave_Click);
            // 
            // ToolStripMenuItemFileSaveAs
            // 
            this.ToolStripMenuItemFileSaveAs.Name = "ToolStripMenuItemFileSaveAs";
            this.ToolStripMenuItemFileSaveAs.Size = new System.Drawing.Size(394, 54);
            this.ToolStripMenuItemFileSaveAs.Text = "Save as...";
            this.ToolStripMenuItemFileSaveAs.Click += new System.EventHandler(this.ToolStripMenuItemFileSaveAs_Click);
            // 
            // ToolStripMenuItemFileSeparator2
            // 
            this.ToolStripMenuItemFileSeparator2.Name = "ToolStripMenuItemFileSeparator2";
            this.ToolStripMenuItemFileSeparator2.Size = new System.Drawing.Size(391, 6);
            // 
            // ToolStripMenuItemFilePrint
            // 
            this.ToolStripMenuItemFilePrint.Name = "ToolStripMenuItemFilePrint";
            this.ToolStripMenuItemFilePrint.Size = new System.Drawing.Size(394, 54);
            this.ToolStripMenuItemFilePrint.Text = "Print...";
            this.ToolStripMenuItemFilePrint.Click += new System.EventHandler(this.ToolStripMenuItemFilePrint_Click);
            // 
            // ToolStripMenuItemFileSeparator1
            // 
            this.ToolStripMenuItemFileSeparator1.Name = "ToolStripMenuItemFileSeparator1";
            this.ToolStripMenuItemFileSeparator1.Size = new System.Drawing.Size(391, 6);
            // 
            // ToolStripMenuItemFileClose
            // 
            this.ToolStripMenuItemFileClose.Name = "ToolStripMenuItemFileClose";
            this.ToolStripMenuItemFileClose.Size = new System.Drawing.Size(394, 54);
            this.ToolStripMenuItemFileClose.Text = "Close";
            this.ToolStripMenuItemFileClose.Click += new System.EventHandler(this.ToolStripMenuItemFileClose_Click);
            // 
            // ToolStripMenuItemEncryption
            // 
            this.ToolStripMenuItemEncryption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEncryptionPassword});
            this.ToolStripMenuItemEncryption.Name = "ToolStripMenuItemEncryption";
            this.ToolStripMenuItemEncryption.Size = new System.Drawing.Size(183, 48);
            this.ToolStripMenuItemEncryption.Text = "Encryption";
            // 
            // ToolStripMenuItemEncryptionPassword
            // 
            this.ToolStripMenuItemEncryptionPassword.Name = "ToolStripMenuItemEncryptionPassword";
            this.ToolStripMenuItemEncryptionPassword.Size = new System.Drawing.Size(330, 54);
            this.ToolStripMenuItemEncryptionPassword.Text = "Password...";
            this.ToolStripMenuItemEncryptionPassword.Click += new System.EventHandler(this.ToolStripMenuItemEncryptionPassword_Click);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEditRevert,
            this.ToolStripMenuItemEditSeparator1,
            this.ToolStripMenuItemEditCut,
            this.ToolStripMenuItemEditCopy,
            this.ToolStripMenuItemEditPaste,
            this.ToolStripMenuItemEditDelete,
            this.ToolStripMenuItemEditSeparator2,
            this.ToolStripMenuItemEditFind,
            this.ToolStripMenuItemEditFindNext,
            this.ToolStripMenuItemEditReplace,
            this.ToolStripMenuItemEditGoto,
            this.ToolStripMenuItemEditStripSeparator3,
            this.ToolStripMenuItemEditSelectAll});
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(92, 48);
            this.ToolStripMenuItemEdit.Text = "Edit";
            // 
            // ToolStripMenuItemEditRevert
            // 
            this.ToolStripMenuItemEditRevert.Name = "ToolStripMenuItemEditRevert";
            this.ToolStripMenuItemEditRevert.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditRevert.Text = "Revert";
            this.ToolStripMenuItemEditRevert.Click += new System.EventHandler(this.ToolStripMenuItemEditRevert_Click);
            // 
            // ToolStripMenuItemEditSeparator1
            // 
            this.ToolStripMenuItemEditSeparator1.Name = "ToolStripMenuItemEditSeparator1";
            this.ToolStripMenuItemEditSeparator1.Size = new System.Drawing.Size(445, 6);
            // 
            // ToolStripMenuItemEditCut
            // 
            this.ToolStripMenuItemEditCut.Name = "ToolStripMenuItemEditCut";
            this.ToolStripMenuItemEditCut.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditCut.Text = "Cut";
            this.ToolStripMenuItemEditCut.Click += new System.EventHandler(this.ToolStripMenuItemEditCut_Click);
            // 
            // ToolStripMenuItemEditCopy
            // 
            this.ToolStripMenuItemEditCopy.Name = "ToolStripMenuItemEditCopy";
            this.ToolStripMenuItemEditCopy.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditCopy.Text = "Copy";
            this.ToolStripMenuItemEditCopy.Click += new System.EventHandler(this.ToolStripMenuItemEditCopy_Click);
            // 
            // ToolStripMenuItemEditPaste
            // 
            this.ToolStripMenuItemEditPaste.Name = "ToolStripMenuItemEditPaste";
            this.ToolStripMenuItemEditPaste.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditPaste.Text = "Paste";
            this.ToolStripMenuItemEditPaste.Click += new System.EventHandler(this.ToolStripMenuItemEditPaste_Click);
            // 
            // ToolStripMenuItemEditDelete
            // 
            this.ToolStripMenuItemEditDelete.Name = "ToolStripMenuItemEditDelete";
            this.ToolStripMenuItemEditDelete.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditDelete.Text = "Delete";
            this.ToolStripMenuItemEditDelete.Click += new System.EventHandler(this.ToolStripMenuItemEditDelete_Click);
            // 
            // ToolStripMenuItemEditSeparator2
            // 
            this.ToolStripMenuItemEditSeparator2.Name = "ToolStripMenuItemEditSeparator2";
            this.ToolStripMenuItemEditSeparator2.Size = new System.Drawing.Size(445, 6);
            // 
            // ToolStripMenuItemEditFind
            // 
            this.ToolStripMenuItemEditFind.Name = "ToolStripMenuItemEditFind";
            this.ToolStripMenuItemEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.ToolStripMenuItemEditFind.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditFind.Text = "Find...";
            this.ToolStripMenuItemEditFind.Click += new System.EventHandler(this.ToolStripMenuItemEditFind_Click);
            // 
            // ToolStripMenuItemEditFindNext
            // 
            this.ToolStripMenuItemEditFindNext.Name = "ToolStripMenuItemEditFindNext";
            this.ToolStripMenuItemEditFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.ToolStripMenuItemEditFindNext.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditFindNext.Text = "Find next";
            this.ToolStripMenuItemEditFindNext.Click += new System.EventHandler(this.ToolStripMenuItemEditFindNext_Click);
            // 
            // ToolStripMenuItemEditReplace
            // 
            this.ToolStripMenuItemEditReplace.Name = "ToolStripMenuItemEditReplace";
            this.ToolStripMenuItemEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ToolStripMenuItemEditReplace.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditReplace.Text = "Replace...";
            this.ToolStripMenuItemEditReplace.Click += new System.EventHandler(this.ToolStripMenuItemEditReplace_Click);
            // 
            // ToolStripMenuItemEditGoto
            // 
            this.ToolStripMenuItemEditGoto.Name = "ToolStripMenuItemEditGoto";
            this.ToolStripMenuItemEditGoto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItemEditGoto.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditGoto.Text = "Goto...";
            // 
            // ToolStripMenuItemEditStripSeparator3
            // 
            this.ToolStripMenuItemEditStripSeparator3.Name = "ToolStripMenuItemEditStripSeparator3";
            this.ToolStripMenuItemEditStripSeparator3.Size = new System.Drawing.Size(445, 6);
            // 
            // ToolStripMenuItemEditSelectAll
            // 
            this.ToolStripMenuItemEditSelectAll.Name = "ToolStripMenuItemEditSelectAll";
            this.ToolStripMenuItemEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItemEditSelectAll.Size = new System.Drawing.Size(448, 54);
            this.ToolStripMenuItemEditSelectAll.Text = "Select All";
            this.ToolStripMenuItemEditSelectAll.Click += new System.EventHandler(this.ToolStripMenuItemEditSelectAll_Click);
            // 
            // ToolStripMenuItemFormat
            // 
            this.ToolStripMenuItemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFormatBreak,
            this.ToolStripMenuItemFormatFont});
            this.ToolStripMenuItemFormat.Name = "ToolStripMenuItemFormat";
            this.ToolStripMenuItemFormat.Size = new System.Drawing.Size(136, 48);
            this.ToolStripMenuItemFormat.Text = "Format";
            // 
            // ToolStripMenuItemFormatBreak
            // 
            this.ToolStripMenuItemFormatBreak.Name = "ToolStripMenuItemFormatBreak";
            this.ToolStripMenuItemFormatBreak.Size = new System.Drawing.Size(319, 54);
            this.ToolStripMenuItemFormatBreak.Text = "Line Break";
            // 
            // ToolStripMenuItemFormatFont
            // 
            this.ToolStripMenuItemFormatFont.Name = "ToolStripMenuItemFormatFont";
            this.ToolStripMenuItemFormatFont.Size = new System.Drawing.Size(319, 54);
            this.ToolStripMenuItemFormatFont.Text = "Font...";
            this.ToolStripMenuItemFormatFont.Click += new System.EventHandler(this.ToolStripMenuItemFormatFont_Click);
            // 
            // ToolStripMenuItemView
            // 
            this.ToolStripMenuItemView.Name = "ToolStripMenuItemView";
            this.ToolStripMenuItemView.Size = new System.Drawing.Size(106, 48);
            this.ToolStripMenuItemView.Text = "View";
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHelpInfo});
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(104, 48);
            this.ToolStripMenuItemHelp.Text = "Help";
            // 
            // ToolStripMenuItemHelpInfo
            // 
            this.ToolStripMenuItemHelpInfo.Name = "ToolStripMenuItemHelpInfo";
            this.ToolStripMenuItemHelpInfo.Size = new System.Drawing.Size(236, 54);
            this.ToolStripMenuItemHelpInfo.Text = "Info";
            this.ToolStripMenuItemHelpInfo.Click += new System.EventHandler(this.ToolStripMenuItemHelpInfo_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMain.Location = new System.Drawing.Point(0, 57);
            this.textBoxMain.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMain.Size = new System.Drawing.Size(2127, 951);
            this.textBoxMain.TabIndex = 1;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStripMain.Location = new System.Drawing.Point(0, 1051);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(3, 0, 37, 0);
            this.statusStripMain.Size = new System.Drawing.Size(2133, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormMain";
            this.Text = "Secure Notepad";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFormat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItemFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileClose;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFormatBreak;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFormatFont;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEncryption;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEncryptionPassword;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpInfo;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItemFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFilePrint;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditRevert;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItemEditSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditCut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditCopy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditPaste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditDelete;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItemEditSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditFind;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditFindNext;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditReplace;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditGoto;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItemEditStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditSelectAll;
    }
}

