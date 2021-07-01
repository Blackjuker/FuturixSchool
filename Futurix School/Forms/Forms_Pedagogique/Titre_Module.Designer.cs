
namespace Futurix_School_Prim_En.Forms.Forms_Pedagogique
{
    partial class Titre_Module
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitreModule = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNbreHeure = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnRecord = new MetroFramework.Controls.MetroButton();
            this.gridListeModules = new MetroFramework.Controls.MetroGrid();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMatieres = new MetroFramework.Controls.MetroComboBox();
            this.cmbClasse = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUA = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListeModules)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 78);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Titre Module";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Titre du Module :";
            // 
            // txtTitreModule
            // 
            this.txtTitreModule.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTitreModule.Location = new System.Drawing.Point(15, 178);
            this.txtTitreModule.Multiline = true;
            this.txtTitreModule.Name = "txtTitreModule";
            this.txtTitreModule.Size = new System.Drawing.Size(472, 34);
            this.txtTitreModule.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre d\'Heure :";
            // 
            // txtNbreHeure
            // 
            this.txtNbreHeure.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNbreHeure.Location = new System.Drawing.Point(172, 243);
            this.txtNbreHeure.Name = "txtNbreHeure";
            this.txtNbreHeure.Size = new System.Drawing.Size(43, 20);
            this.txtNbreHeure.TabIndex = 28;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(332, 227);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(155, 34);
            this.btnRecord.TabIndex = 30;
            this.btnRecord.Text = "Enregistrement";
            this.btnRecord.UseSelectable = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // gridListeModules
            // 
            this.gridListeModules.AllowUserToAddRows = false;
            this.gridListeModules.AllowUserToDeleteRows = false;
            this.gridListeModules.AllowUserToResizeColumns = false;
            this.gridListeModules.AllowUserToResizeRows = false;
            this.gridListeModules.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridListeModules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListeModules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListeModules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListeModules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListeModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridListeModules.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridListeModules.EnableHeadersVisualStyles = false;
            this.gridListeModules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridListeModules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridListeModules.Location = new System.Drawing.Point(16, 285);
            this.gridListeModules.MultiSelect = false;
            this.gridListeModules.Name = "gridListeModules";
            this.gridListeModules.ReadOnly = true;
            this.gridListeModules.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListeModules.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridListeModules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridListeModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListeModules.Size = new System.Drawing.Size(471, 136);
            this.gridListeModules.TabIndex = 31;
            this.gridListeModules.UseStyleColors = true;
            this.gridListeModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListeModules_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(157, 427);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 34);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Matieres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Classe";
            // 
            // cmbMatieres
            // 
            this.cmbMatieres.DisplayMember = "DESIGNATION";
            this.cmbMatieres.FormattingEnabled = true;
            this.cmbMatieres.ItemHeight = 23;
            this.cmbMatieres.Location = new System.Drawing.Point(262, 115);
            this.cmbMatieres.Name = "cmbMatieres";
            this.cmbMatieres.Size = new System.Drawing.Size(137, 29);
            this.cmbMatieres.TabIndex = 32;
            this.cmbMatieres.UseSelectable = true;
            this.cmbMatieres.ValueMember = "DESIGNATION";
            this.cmbMatieres.SelectedIndexChanged += new System.EventHandler(this.cmbMatieres_SelectedIndexChanged);
            // 
            // cmbClasse
            // 
            this.cmbClasse.DisplayMember = "DESIGNATION";
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.ItemHeight = 23;
            this.cmbClasse.Location = new System.Drawing.Point(76, 115);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(137, 29);
            this.cmbClasse.TabIndex = 33;
            this.cmbClasse.UseSelectable = true;
            this.cmbClasse.ValueMember = "DESIGNATION";
            this.cmbClasse.SelectedIndexChanged += new System.EventHandler(this.cmbClasse_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(16, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 10);
            this.panel2.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nombre de U.A :";
            // 
            // txtUA
            // 
            this.txtUA.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUA.Location = new System.Drawing.Point(172, 214);
            this.txtUA.Name = "txtUA";
            this.txtUA.Size = new System.Drawing.Size(43, 20);
            this.txtUA.TabIndex = 28;
            // 
            // Titre_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMatieres);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.gridListeModules);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtNbreHeure);
            this.Controls.Add(this.txtUA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitreModule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Titre_Module";
            this.Text = "Titre_Module";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListeModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTitreModule;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNbreHeure;
        private MetroFramework.Controls.MetroButton btnRecord;
        private MetroFramework.Controls.MetroGrid gridListeModules;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox cmbMatieres;
        private MetroFramework.Controls.MetroComboBox cmbClasse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUA;
    }
}