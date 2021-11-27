using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureNotepad
{
    public partial class FormMain : Form
    {

        public Document CurrentDocument;

        public string lastSearchText;
        public bool lastSearchRegex;
        public bool lastSearchIgnoreCase;

        public FormMain()
        {
            InitializeComponent();

            CurrentDocument = new Document();

            CurrentDocument.DocumentLoaded += CurrentDocument_DocumentLoaded;
            CurrentDocument.DocumentSaved += CurrentDocument_DocumentSaved; ;
            CurrentDocument.DocumentSaveFileRequired += CurrentDocument_DocumentSaveFileRequired;
            CurrentDocument.PasswordRequired += CurrentDocument_PasswordRequired;

            UpdateTitle();


            textBoxMain.Font = new Font("Consolas", 11, FontStyle.Regular);

        }

        private void CurrentDocument_PasswordRequired(object sender, PasswordRequiredEventArgs e)
        {

            FormPassword lFormPassword;

            lFormPassword = new FormPassword();
            if (e.Confirmation)
            {
                lFormPassword.setupPasswordConfirm();
            }
            else
            {
                lFormPassword.setupPassword();
            }
            
            if (lFormPassword.ShowDialog() == DialogResult.OK)
            {
                CurrentDocument.Password = lFormPassword.Password;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void CurrentDocument_DocumentSaveFileRequired(object sender, EventArgs e)
        {

            SaveFileDialog lDialog;

            lDialog = new SaveFileDialog();
            lDialog.Filter = "Text Files (*.txt)|*.txt|Secure Text Files (*.txts)|*.txts|All files (*.*)|*.*";
            lDialog.FilterIndex = 2;

            if (lDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentDocument.File = lDialog.FileName;
            }

        }

        private void CurrentDocument_DocumentSaved(object sender, EventArgs e)
        {
            
        }

        private void CurrentDocument_DocumentLoaded(object sender, EventArgs e)
        {
            textBoxMain.Text = CurrentDocument.FileContent;
        }

        private void ToolStripMenuItemFileOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog lDialog;

            lDialog = new OpenFileDialog();

            if (lDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentDocument.Load(lDialog.FileName);
                UpdateTitle();
            }

        }

        private void ToolStripMenuItemFormatFont_Click(object sender, EventArgs e)
        {

            FontDialog lDialog;

            lDialog = new FontDialog();

            if (lDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxMain.Font = lDialog.Font;
            }

        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            CurrentDocument.FileContent = textBoxMain.Text;
            UpdateTitle();
        }

        private void ToolStripMenuItemFileSave_Click(object sender, EventArgs e)
        {
            CurrentDocument.Save();
            UpdateTitle();
        }

        private void ToolStripMenuItemFileSaveAs_Click(object sender, EventArgs e)
        {

            SaveFileDialog lDialog;

            lDialog = new SaveFileDialog();
            lDialog.Filter = "Text Files (*.txt)|*.txt|Secure Text Files (*.txts)|*.txts|All files (*.*)|*.*";
            lDialog.FilterIndex = 2;

            if (lDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentDocument.File = lDialog.FileName;
                CurrentDocument.Save();
                UpdateTitle();
            }

        }

        private void ToolStripMenuItemFileClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateTitle()
        {

            string result;

            if (String.IsNullOrEmpty(CurrentDocument.File))
            {
                result = "Unbenannt";
            }
            else
            {
                result = CurrentDocument.File;
            }

            if (CurrentDocument.PendingChanges)
            {
                result += "*";
            }

            result += " - Secure Notepad";


            this.Text = result;

        }

        private void ToolStripMenuItemHelpInfo_Click(object sender, EventArgs e)
        {

            FormInfo lForm;

            lForm = new FormInfo();
            lForm.ShowDialog();

        }

        private void ToolStripMenuItemEncryptionPassword_Click(object sender, EventArgs e)
        {

            try
            {
                CurrentDocument.SetPassword();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Encryption not available", "It's only allowed to encrypt .txts files.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ToolStripMenuItemFilePrint_Click(object sender, EventArgs e)
        {

            PrintDialog lDialog;

            lDialog = new PrintDialog();

            
            lDialog.ShowDialog();

        }

        private void ToolStripMenuItemEditSelectAll_Click(object sender, EventArgs e)
        {
            textBoxMain.SelectAll();
        }

        private void ToolStripMenuItemEditRevert_Click(object sender, EventArgs e)
        {
            textBoxMain.Undo();
        }

        private void ToolStripMenuItemEditCut_Click(object sender, EventArgs e)
        {
            textBoxMain.Cut();
        }

        private void ToolStripMenuItemEditCopy_Click(object sender, EventArgs e)
        {
            textBoxMain.Copy();
        }

        private void ToolStripMenuItemEditPaste_Click(object sender, EventArgs e)
        {
            textBoxMain.Paste();
        }

        private void ToolStripMenuItemEditDelete_Click(object sender, EventArgs e)
        {
            if (textBoxMain.SelectionLength > 0 )
            {
                textBoxMain.Text = textBoxMain.Text.Remove(textBoxMain.SelectionStart, textBoxMain.SelectionLength);
            }
        }

        private void ToolStripMenuItemEditFind_Click(object sender, EventArgs e)
        {

            FormFind lForm;

            lForm = new FormFind();
            lForm.setModeFind();

            lForm.OldText = textBoxMain.Text;
            lForm.OldPosition = textBoxMain.SelectionStart;

            this.lastSearchText = null;
            this.lastSearchRegex = false;
            this.lastSearchIgnoreCase = false;

            if (lForm.ShowDialog() == DialogResult.OK)
            {
                
                if (lForm.NewPosition > -1)
                {
                    textBoxMain.Select(lForm.NewPosition, 0);

                    this.lastSearchText = lForm.SearchText;
                    this.lastSearchRegex = lForm.SearchRegex;
                    this.lastSearchIgnoreCase = lForm.SearchIgnoreCase;

                }
                else if (!string.IsNullOrEmpty(lForm.NewText))
                {
                    textBoxMain.Text = lForm.NewText;
                }

            }

        }

        private void ToolStripMenuItemEditReplace_Click(object sender, EventArgs e)
        {
            FormFind lForm;

            lForm = new FormFind();
            lForm.setModeReplace();

            lForm.OldText = textBoxMain.Text;
            lForm.OldPosition = textBoxMain.SelectionStart;

            this.lastSearchText = null;
            this.lastSearchRegex = false;
            this.lastSearchIgnoreCase = false;

            if (lForm.ShowDialog() == DialogResult.OK)
            {

                if (lForm.NewPosition > -1)
                {
                    textBoxMain.Select(lForm.NewPosition, 0);

                    this.lastSearchText = lForm.SearchText;
                    this.lastSearchRegex = lForm.SearchRegex;
                    this.lastSearchIgnoreCase = lForm.SearchIgnoreCase;

                }
                else if (!string.IsNullOrEmpty(lForm.NewText))
                {
                    textBoxMain.Text = lForm.NewText;
                }

            }


        }

        private void ToolStripMenuItemEditFindNext_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(this.lastSearchText))
            {

                FormFind lForm;

                lForm = new FormFind();
                lForm.setModeFind();

                lForm.OldText = textBoxMain.Text;
                lForm.OldPosition = textBoxMain.SelectionStart;
                
                lForm.SearchText = this.lastSearchText;
                lForm.SearchRegex = this.lastSearchRegex;
                lForm.SearchIgnoreCase = this.lastSearchIgnoreCase;

                lForm.Process();

                if (lForm.NewPosition > -1)
                {
                    
                    textBoxMain.Select(lForm.NewPosition, 0);
                    
                    this.lastSearchText = lForm.SearchText;
                    this.lastSearchRegex = lForm.SearchRegex;
                    this.lastSearchIgnoreCase = lForm.SearchIgnoreCase;

                }
                else if (!string.IsNullOrEmpty(lForm.NewText))
                {
                    textBoxMain.Text = lForm.NewText;
                }

            }

        }

    }

}
