using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAdditionneur
{
    public partial class FormAdditionneur : Form
    {
        private int somme;
        public FormAdditionneur()
        {
            InitializeComponent();
            this.somme = 0;
        }
        //private void btnCaseGeneral_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    this.textBoxZoneCalculs.Text += btn.Text + "+";
        //    this.somme += int.Parse(btn.Text);
        //}

        // version de dessus comporte un danger : car ca peut lever une excpetion (une exception donne des infos de qui ce passe derriere) et
        //                                        les excaption sont généralement traçable donc permet d'atteindre le code 


        private void btnCaseGeneral_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;   // on envoie le sender en tant que button, si pas button il envoie null
            if (btn != null)
            {
                this.textBoxZoneCalculs.Text += btn.Text + "+";
                this.somme += int.Parse(btn.Text);
            }
        }

        //version plus récente :


        /*la fonction généraliste ci-dessus remplace toutes les fonctions ci-dessous : 
         * 
        
        private void btnCaseZero_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "0+";
            this.somme += 0;
        }

        private void btnCase1_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "1+";
            this.somme += 1;
        }

        private void bntCase2_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "2+";
            this.somme += 2;
        }

        private void btnCase3_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "3+";
            this.somme += 3;
        }

        private void btnCase4_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "4+";
            this.somme += 4;
        }

        private void btnCase5_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "5+";
            this.somme += 5;
        }

        private void btnCase6_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "6+";
            this.somme += 6;
        }

        private void btnCase7_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "7+";
            this.somme += 7;
        }

        private void btnCase8_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "8+";
            this.somme += 8;
        }

        private void btnCase9_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "9+";
            this.somme += 9;
        }*/

        private void btnVider_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text = "";
            this.somme = 0;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.textBoxZoneCalculs.Text += "=" + this.somme + "+";
        }
    }
}
