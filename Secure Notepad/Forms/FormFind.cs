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

            if (this.checkBoxReplace.Checked)
            {

                this.NewText = this.OldText;
                this.NewText = this.NewText.Replace(this.textBoxFind.Text, this.textBoxReplace.Text);
                this.NewPosition = -1;

            }
            else
            {

                this.NewText = null;

                this.NewPosition = this.OldText.IndexOf(this.textBoxFind.Text, this.OldPosition);

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
