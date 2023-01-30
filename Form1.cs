using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonPremierProgramme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboDifficulte.Items.Add("Facile");
            comboDifficulte.Items.Add("Moyen");
            comboDifficulte.Items.Add("Difficile");
            comboDifficulte.Items.Add("Enfer");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_rep_Click(object sender, EventArgs e)
        {

        }


        private void Btn_valider_Click(object sender, EventArgs e)
        {
            
            /*string result = "Bonjour ";

            if (rbMr.Checked == true)
            {
                result += "Mr. ";
            }

            if (rbMme.Checked == true)
            {
                result += "Mme ";
            }

            if (txt_nom.Text != "")
            {
                result += txt_prenom.Text + " ";
            }

            else
            {
                result = "Vous ne devez pas avoir une case vide !";
            }

            if (txt_prenom.Text != "")
            {
                result += txt_nom.Text + ", ";
            }

            else
            {
                result = "Vous ne devez pas avoir une case vide !";
            }

            if (txt_nom.Text == "" || txt_prenom.Text == "")
            {
                MessageBox.Show("Aucun nom ou prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TimeSpan calculage;
            Int32 age = 0;
            calculage = DateTime.Now.Subtract(dtpDateDeNaissance.Value);
            age = calculage.Days / 365;
            result += age + " an(s), ";

            if (age <= 18)
            {
               
            }

            else
            {
                int age18 = age;
                int age18final = 0;
                age18final = age18 - 18;
                result += "vous êtes majeur depuis " + age18final + " an(s)";
            }

            result += "\r\nLa difficultés sélectionnée est : " + comboDifficulte.Text;

            txt_afficher.Text = result;*/
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCivilite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCivilite.Checked)
            {
                    rbMr.Visible = false;
                    rbMme.Visible = false;
            }

            if (!cbCivilite.Checked)
            {
                    rbMr.Visible = true;
                    rbMme.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDifficulte.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lblDifficulte.Font = new Font(lblDifficulte.Font, FontStyle.Bold);
                lblDateNaiss.Font = new Font(lblDateNaiss.Font, FontStyle.Bold);
            }

            else if (comboDifficulte.SelectedItem != "Enfer")
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lblDifficulte.Font = new Font(lblDifficulte.Font, FontStyle.Regular);
                lblDateNaiss.Font = new Font(lblDateNaiss.Font, FontStyle.Regular);
            }
        }
    }
}