namespace DS2
{
    partial class Form3
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
            this.Retour = new System.Windows.Forms.Button();
            this.Vider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ENF = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Fonction = new System.Windows.Forms.Label();
            this.Homme = new System.Windows.Forms.RadioButton();
            this.Femme = new System.Windows.Forms.RadioButton();
            this.Sexe = new System.Windows.Forms.Label();
            this.BD = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Prenom = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Matricule = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(474, 466);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(98, 35);
            this.Retour.TabIndex = 8;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Vider
            // 
            this.Vider.Location = new System.Drawing.Point(339, 466);
            this.Vider.Name = "Vider";
            this.Vider.Size = new System.Drawing.Size(98, 35);
            this.Vider.TabIndex = 7;
            this.Vider.Text = "Vider";
            this.Vider.UseVisualStyleBackColor = true;
            this.Vider.Click += new System.EventHandler(this.Vider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ENF);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Fonction);
            this.groupBox1.Controls.Add(this.Homme);
            this.groupBox1.Controls.Add(this.Femme);
            this.groupBox1.Controls.Add(this.Sexe);
            this.groupBox1.Controls.Add(this.BD);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Prenom);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Matricule);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(91, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 406);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de l\'employé";
            // 
            // ENF
            // 
            this.ENF.AutoSize = true;
            this.ENF.Enabled = false;
            this.ENF.Location = new System.Drawing.Point(77, 351);
            this.ENF.Name = "ENF";
            this.ENF.Size = new System.Drawing.Size(101, 21);
            this.ENF.TabIndex = 13;
            this.ENF.Text = "En fonction";
            this.ENF.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Comptable ",
            "Directeur general",
            "Desingneur",
            "Gardien ",
            "Gestionnaire",
            "Informaticien ",
            "Gestionnaire"});
            this.comboBox1.Location = new System.Drawing.Point(227, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Fonction
            // 
            this.Fonction.AutoSize = true;
            this.Fonction.Location = new System.Drawing.Point(74, 289);
            this.Fonction.Name = "Fonction";
            this.Fonction.Size = new System.Drawing.Size(62, 17);
            this.Fonction.TabIndex = 11;
            this.Fonction.Text = "Fonction";
            // 
            // Homme
            // 
            this.Homme.AutoSize = true;
            this.Homme.Enabled = false;
            this.Homme.Location = new System.Drawing.Point(350, 232);
            this.Homme.Name = "Homme";
            this.Homme.Size = new System.Drawing.Size(77, 21);
            this.Homme.TabIndex = 10;
            this.Homme.TabStop = true;
            this.Homme.Text = "Homme";
            this.Homme.UseVisualStyleBackColor = true;
            // 
            // Femme
            // 
            this.Femme.AutoSize = true;
            this.Femme.Enabled = false;
            this.Femme.Location = new System.Drawing.Point(227, 232);
            this.Femme.Name = "Femme";
            this.Femme.Size = new System.Drawing.Size(75, 21);
            this.Femme.TabIndex = 9;
            this.Femme.TabStop = true;
            this.Femme.Text = "Femme";
            this.Femme.UseVisualStyleBackColor = true;
            // 
            // Sexe
            // 
            this.Sexe.AutoSize = true;
            this.Sexe.Location = new System.Drawing.Point(74, 232);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(39, 17);
            this.Sexe.TabIndex = 8;
            this.Sexe.Text = "Sexe";
            // 
            // BD
            // 
            this.BD.AutoSize = true;
            this.BD.Location = new System.Drawing.Point(74, 174);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(126, 17);
            this.BD.TabIndex = 7;
            this.BD.Text = "Date de naissance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(74, 129);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(57, 17);
            this.Prenom.TabIndex = 5;
            this.Prenom.Text = "Prenom";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(74, 86);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(37, 17);
            this.Nom.TabIndex = 4;
            this.Nom.Text = "Nom";
            // 
            // Matricule
            // 
            this.Matricule.AutoSize = true;
            this.Matricule.Location = new System.Drawing.Point(74, 47);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(65, 17);
            this.Matricule.TabIndex = 3;
            this.Matricule.Text = "Matricule";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(227, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(227, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 0;
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(168, 466);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(101, 35);
            this.supprimer.TabIndex = 9;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Vider);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Modifier un employé";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button Vider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ENF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Fonction;
        private System.Windows.Forms.RadioButton Homme;
        private System.Windows.Forms.RadioButton Femme;
        private System.Windows.Forms.Label Sexe;
        private System.Windows.Forms.Label BD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Matricule;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button supprimer;
    }
}