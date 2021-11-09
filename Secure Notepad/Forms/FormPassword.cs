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
    public partial class FormPassword : Form
    {

        bool mIsConfirmationEnabled;

        public FormPassword()
        {
            InitializeComponent();
        }

        public string Password
        {
            get
            {
                return textBoxPassword.Text;
            }
            set
            {
                textBoxPassword.Text = value;
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (mIsConfirmationEnabled && (this.textBoxPassword.Text != this.textBoxConfirmation.Text))
            {
                MessageBox.Show("Invalid Password", "Both passwords does not match. Please retry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmation.Text = "";
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void setupPassword()
        {
            this.textBoxConfirmation.Enabled = false;
            mIsConfirmationEnabled = false;
        }

        public void setupPasswordConfirm()
        {
            this.textBoxConfirmation.Enabled = true;
            mIsConfirmationEnabled = true;
        }

    }
}
