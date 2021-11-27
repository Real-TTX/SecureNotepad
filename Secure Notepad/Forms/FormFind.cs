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
    public partial class FormFind : Form
    {

        public string NewText;
        public string OldText;
        public int NewPosition;
        public int OldPosition;

        public string SearchText
        {
            get
            {
                return this.textBoxFind.Text;
            }
            set
            {
                this.textBoxFind.Text = value;
            }
        }

        public bool SearchRegex
        {
            get
            {
                return this.checkBoxRegex.Checked;
            }
            set
            {
                this.checkBoxRegex.Checked = value;
            }
        }

        public bool SearchIgnoreCase
        {
            get
            {
                return this.checkBoxIgnoreCase.Checked;
            }
            set
            {
                this.checkBoxIgnoreCase.Checked = value;
            }
        }

        public FormFind()
        {
            InitializeComponent();
        }

        public void setModeFind()
        {
            this.checkBoxReplace.Checked = false;
            this.textBoxReplace.Enabled = false;
            this.buttonFind.Text = "Find";
            this.Text = "Find";
        }

        public void setModeReplace()
        {
            this.checkBoxReplace.Checked = true;
            this.textBoxReplace.Enabled = true;
            this.buttonFind.Text = "Replace";
            this.Text = "Replace";
        }

        private void checkBoxReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxReplace.Checked)
            {
                this.setModeReplace();
            }
            else
            {
                this.setModeFind();
            }
        }

        public void Process()
        {

            System.Text.RegularExpressions.Regex regex;
            System.Text.RegularExpressions.RegexOptions options;
            string find;
            string replacement;

            // default
            this.NewText = null;
            this.NewPosition = -1;

            // options
            options = 0;
            if (checkBoxIgnoreCase.Checked)
            {
                options = options | System.Text.RegularExpressions.RegexOptions.IgnoreCase;
            }
            
            // find
            find = checkBoxRegex.Checked ? this.textBoxFind.Text : System.Text.RegularExpressions.Regex.Escape(this.textBoxFind.Text);

            // replacement
            replacement = null;
            if (this.checkBoxReplace.Checked)
            {
                replacement = checkBoxRegex.Checked ? this.textBoxReplace.Text.Replace("$", "$$") : this.textBoxReplace.Text;
            }

            // prepare
            regex = new System.Text.RegularExpressions.Regex(find, options);

            // process
            if (!string.IsNullOrEmpty(replacement))
            {
                this.NewPosition = -1;
                this.NewText = regex.Replace(this.OldText, replacement);
            }
            else
            {

                System.Text.RegularExpressions.Match lMatch;

                lMatch = regex.Match(this.OldText, this.OldPosition+1);

                this.NewPosition = lMatch.Index;
                this.NewText = null;

            }
            
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            this.Process();

            DialogResult = DialogResult.OK;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
