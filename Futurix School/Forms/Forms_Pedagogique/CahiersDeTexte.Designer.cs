
namespace Futurix_School_Prim_En.Forms
{
    partial class CahiersDeTexte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClasse = new MetroFramework.Controls.MetroComboBox();
            this.cmbMatieres = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModuleTitre = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUA = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUE = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkIsFinish = new System.Windows.Forms.CheckBox();
            this.btnValider = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 56);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cahiers de Texte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.DisplayMember = "DESIGNATION";
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.ItemHeight = 23;
            this.cmbClasse.Location = new System.Drawing.Point(174, 91);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(137, 29);
            this.cmbClasse.TabIndex = 25;
            this.cmbClasse.UseSelectable = true;
            this.cmbClasse.ValueMember = "DESIGNATION";
            this.cmbClasse.SelectedIndexChanged += new System.EventHandler(this.cmbClasse_SelectedIndexChanged);
            // 
            // cmbMatieres
            // 
            this.cmbMatieres.DisplayMember = "DESIGNATION";
            this.cmbMatieres.FormattingEnabled = true;
            this.cmbMatieres.ItemHeight = 23;
            this.cmbMatieres.Location = new System.Drawing.Point(360, 91);
            this.cmbMatieres.Name = "cmbMatieres";
            this.cmbMatieres.Size = new System.Drawing.Size(137, 29);
            this.cmbMatieres.TabIndex = 25;
            this.cmbMatieres.UseSelectable = true;
            this.cmbMatieres.ValueMember = "DESIGNATION";
            this.cmbMatieres.SelectedIndexChanged += new System.EventHandler(this.cmbMatieres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Matieres";
            // 
            // cmbModuleTitre
            // 
            this.cmbModuleTitre.DisplayMember = "DESIGNATION";
            this.cmbModuleTitre.FormattingEnabled = true;
            this.cmbModuleTitre.ItemHeight = 23;
            this.cmbModuleTitre.Location = new System.Drawing.Point(18, 164);
            this.cmbModuleTitre.Name = "cmbModuleTitre";
            this.cmbModuleTitre.Size = new System.Drawing.Size(594, 29);
            this.cmbModuleTitre.TabIndex = 25;
            this.cmbModuleTitre.UseSelectable = true;
            this.cmbModuleTitre.ValueMember = "DESIGNATION";
            this.cmbModuleTitre.SelectedIndexChanged += new System.EventHandler(this.cmbModuleTitre_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Titre du Module :";
            // 
            // cmbUA
            // 
            this.cmbUA.DisplayMember = "DESIGNATION";
            this.cmbUA.FormattingEnabled = true;
            this.cmbUA.ItemHeight = 23;
            this.cmbUA.Location = new System.Drawing.Point(15, 226);
            this.cmbUA.Name = "cmbUA";
            this.cmbUA.Size = new System.Drawing.Size(594, 29);
            this.cmbUA.TabIndex = 25;
            this.cmbUA.UseSelectable = true;
            this.cmbUA.ValueMember = "DESIGNATION";
            this.cmbUA.SelectedIndexChanged += new System.EventHandler(this.cmbUA_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Titre Unité d\'Apprentissage (U.A) :";
            // 
            // cmbUE
            // 
            this.cmbUE.DisplayMember = "DESIGNATION";
            this.cmbUE.FormattingEnabled = true;
            this.cmbUE.ItemHeight = 23;
            this.cmbUE.Location = new System.Drawing.Point(18, 292);
            this.cmbUE.Name = "cmbUE";
            this.cmbUE.Size = new System.Drawing.Size(594, 29);
            this.cmbUE.TabIndex = 25;
            this.cmbUE.UseSelectable = true;
            this.cmbUE.ValueMember = "DESIGNATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Titre de L\'Unité d\'Enseignement (U.E) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Contenu d\'Enseignement : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 368);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(584, 118);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "% Effectué :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "XXXX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(216, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Date Du Jour :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(341, 508);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "XXXX";
            // 
            // chkIsFinish
            // 
            this.chkIsFinish.AutoSize = true;
            this.chkIsFinish.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsFinish.Location = new System.Drawing.Point(532, 508);
            this.chkIsFinish.Name = "chkIsFinish";
            this.chkIsFinish.Size = new System.Drawing.Size(76, 19);
            this.chkIsFinish.TabIndex = 28;
            this.chkIsFinish.Text = "Terminer";
            this.chkIsFinish.UseVisualStyleBackColor = true;
            this.chkIsFinish.CheckedChanged += new System.EventHandler(this.chkIsFinish_CheckedChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(219, 556);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(155, 34);
            this.btnValider.TabIndex = 29;
            this.btnValider.Text = "Enregistrement";
            this.btnValider.UseSelectable = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // CahiersDeTexte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 602);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.chkIsFinish);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbUA);
            this.Controls.Add(this.cmbUE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModuleTitre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMatieres);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CahiersDeTexte";
            this.Text = "&&";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbClasse;
        private MetroFramework.Controls.MetroComboBox cmbMatieres;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cmbModuleTitre;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbUA;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cmbUE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkIsFinish;
        private MetroFramework.Controls.MetroButton btnValider;
    }
}