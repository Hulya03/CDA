using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMenu
{
    public partial class FormSidentifier : Form
    {
        public FormSidentifier()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == textBoxPassword.Text)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                try
                {
                    if (textBoxLogin.Text != textBoxPassword.Text)
                    {
                        errorProviderIdentification.SetError(textBoxPassword, "mot de passe incorrect");
                    }
                    else
                    {
                        errorProviderIdentification.Clear();
                    }
                }
                catch
                {
                    errorProviderIdentification.SetError(textBoxPassword, "problème d'identification");
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
