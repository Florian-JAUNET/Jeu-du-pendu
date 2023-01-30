namespace MonPremierProgramme
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_rep = new System.Windows.Forms.Label();
            this.txt_afficher = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.rbMr = new System.Windows.Forms.RadioButton();
            this.rbMme = new System.Windows.Forms.RadioButton();
            this.lblDateNaiss = new System.Windows.Forms.Label();
            this.dtpDateDeNaissance = new System.Windows.Forms.DateTimePicker();
            this.cbCivilite = new System.Windows.Forms.CheckBox();
            this.comboDifficulte = new System.Windows.Forms.ComboBox();
            this.lblDifficulte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_rep
            // 
            this.lbl_rep.AutoSize = true;
            this.lbl_rep.Location = new System.Drawing.Point(253, 85);
            this.lbl_rep.Name = "lbl_rep";
            this.lbl_rep.Size = new System.Drawing.Size(50, 13);
            this.lbl_rep.TabIndex = 0;
            this.lbl_rep.Text = "Réponse";
            this.lbl_rep.Click += new System.EventHandler(this.Lbl_rep_Click);
            // 
            // txt_afficher
            // 
            this.txt_afficher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_afficher.Enabled = false;
            this.txt_afficher.Location = new System.Drawing.Point(309, 82);
            this.txt_afficher.Multiline = true;
            this.txt_afficher.Name = "txt_afficher";
            this.txt_afficher.Size = new System.Drawing.Size(247, 50);
            this.txt_afficher.TabIndex = 1;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(367, 363);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(78, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Push me";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(347, 268);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(121, 20);
            this.txt_prenom.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(347, 242);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(121, 20);
            this.txt_nom.TabIndex = 4;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(301, 245);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 5;
            this.lbl_nom.Text = "Nom :";
            this.lbl_nom.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(287, 271);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 6;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // rbMr
            // 
            this.rbMr.AutoSize = true;
            this.rbMr.Location = new System.Drawing.Point(347, 219);
            this.rbMr.Name = "rbMr";
            this.rbMr.Size = new System.Drawing.Size(40, 17);
            this.rbMr.TabIndex = 7;
            this.rbMr.TabStop = true;
            this.rbMr.Text = "Mr.";
            this.rbMr.UseVisualStyleBackColor = true;
            this.rbMr.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMme
            // 
            this.rbMme.AutoSize = true;
            this.rbMme.Location = new System.Drawing.Point(420, 219);
            this.rbMme.Name = "rbMme";
            this.rbMme.Size = new System.Drawing.Size(48, 17);
            this.rbMme.TabIndex = 8;
            this.rbMme.TabStop = true;
            this.rbMme.Text = "Mme";
            this.rbMme.UseVisualStyleBackColor = true;
            // 
            // lblDateNaiss
            // 
            this.lblDateNaiss.AutoSize = true;
            this.lblDateNaiss.Location = new System.Drawing.Point(234, 297);
            this.lblDateNaiss.Name = "lblDateNaiss";
            this.lblDateNaiss.Size = new System.Drawing.Size(102, 13);
            this.lblDateNaiss.TabIndex = 9;
            this.lblDateNaiss.Text = "Date de naissance :";
            // 
            // dtpDateDeNaissance
            // 
            this.dtpDateDeNaissance.Location = new System.Drawing.Point(347, 297);
            this.dtpDateDeNaissance.Name = "dtpDateDeNaissance";
            this.dtpDateDeNaissance.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDeNaissance.TabIndex = 10;
            // 
            // cbCivilite
            // 
            this.cbCivilite.AutoSize = true;
            this.cbCivilite.Location = new System.Drawing.Point(223, 220);
            this.cbCivilite.Name = "cbCivilite";
            this.cbCivilite.Size = new System.Drawing.Size(56, 17);
            this.cbCivilite.TabIndex = 11;
            this.cbCivilite.Text = "Civilité";
            this.cbCivilite.UseVisualStyleBackColor = true;
            this.cbCivilite.CheckedChanged += new System.EventHandler(this.cbCivilite_CheckedChanged);
            // 
            // comboDifficulte
            // 
            this.comboDifficulte.FormattingEnabled = true;
            this.comboDifficulte.Location = new System.Drawing.Point(347, 323);
            this.comboDifficulte.Name = "comboDifficulte";
            this.comboDifficulte.Size = new System.Drawing.Size(153, 21);
            this.comboDifficulte.TabIndex = 12;
            this.comboDifficulte.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDifficulte
            // 
            this.lblDifficulte.AutoSize = true;
            this.lblDifficulte.Location = new System.Drawing.Point(288, 326);
            this.lblDifficulte.Name = "lblDifficulte";
            this.lblDifficulte.Size = new System.Drawing.Size(48, 13);
            this.lblDifficulte.TabIndex = 13;
            this.lblDifficulte.Text = "Difficulté";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDifficulte);
            this.Controls.Add(this.comboDifficulte);
            this.Controls.Add(this.cbCivilite);
            this.Controls.Add(this.dtpDateDeNaissance);
            this.Controls.Add(this.lblDateNaiss);
            this.Controls.Add(this.rbMme);
            this.Controls.Add(this.rbMr);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_afficher);
            this.Controls.Add(this.lbl_rep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rep;
        private System.Windows.Forms.TextBox txt_afficher;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.RadioButton rbMr;
        private System.Windows.Forms.RadioButton rbMme;
        private System.Windows.Forms.Label lblDateNaiss;
        private System.Windows.Forms.DateTimePicker dtpDateDeNaissance;
        private System.Windows.Forms.CheckBox cbCivilite;
        private System.Windows.Forms.ComboBox comboDifficulte;
        private System.Windows.Forms.Label lblDifficulte;
    }
}

