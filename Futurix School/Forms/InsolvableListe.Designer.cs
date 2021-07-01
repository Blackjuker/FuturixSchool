
namespace Futurix_School_Prim_En.Forms
{
    partial class InsolvableListe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboClasse = new MetroFramework.Controls.MetroComboBox();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCompte = new System.Windows.Forms.Label();
            this.lblTotalVerserT = new System.Windows.Forms.Label();
            this.TotalVerser = new System.Windows.Forms.Label();
            this.mGridInsolvable = new MetroFramework.Controls.MetroGrid();
            this.btnPrintInsolvable = new JThinButton.JThinButton();
            this.btnBack = new JThinButton.JThinButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTranche = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreEleve = new System.Windows.Forms.Label();
            this.lblTotalTrancheAVerser = new System.Windows.Forms.Label();
            this.montantManquant = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGridInsolvable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 75);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Insolvables";
            // 
            // comboClasse
            // 
            this.comboClasse.FormattingEnabled = true;
            this.comboClasse.ItemHeight = 23;
            this.comboClasse.Location = new System.Drawing.Point(110, 94);
            this.comboClasse.Name = "comboClasse";
            this.comboClasse.Size = new System.Drawing.Size(161, 29);
            this.comboClasse.TabIndex = 7;
            this.comboClasse.UseSelectable = true;
            this.comboClasse.SelectedIndexChanged += new System.EventHandler(this.comboClasse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Classe  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Pension  :";
            // 
            // lblTotalCompte
            // 
            this.lblTotalCompte.AutoSize = true;
            this.lblTotalCompte.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompte.Location = new System.Drawing.Point(271, 158);
            this.lblTotalCompte.Name = "lblTotalCompte";
            this.lblTotalCompte.Size = new System.Drawing.Size(20, 21);
            this.lblTotalCompte.TabIndex = 6;
            this.lblTotalCompte.Text = "0";
            // 
            // lblTotalVerserT
            // 
            this.lblTotalVerserT.AutoSize = true;
            this.lblTotalVerserT.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVerserT.Location = new System.Drawing.Point(8, 158);
            this.lblTotalVerserT.Name = "lblTotalVerserT";
            this.lblTotalVerserT.Size = new System.Drawing.Size(56, 21);
            this.lblTotalVerserT.TabIndex = 6;
            this.lblTotalVerserT.Text = " xxxx";
            // 
            // TotalVerser
            // 
            this.TotalVerser.AutoSize = true;
            this.TotalVerser.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVerser.Location = new System.Drawing.Point(236, 126);
            this.TotalVerser.Name = "TotalVerser";
            this.TotalVerser.Size = new System.Drawing.Size(20, 21);
            this.TotalVerser.TabIndex = 6;
            this.TotalVerser.Text = "0";
            // 
            // mGridInsolvable
            // 
            this.mGridInsolvable.AllowUserToResizeRows = false;
            this.mGridInsolvable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGridInsolvable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridInsolvable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridInsolvable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridInsolvable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridInsolvable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridInsolvable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridInsolvable.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridInsolvable.EnableHeadersVisualStyles = false;
            this.mGridInsolvable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridInsolvable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridInsolvable.Location = new System.Drawing.Point(12, 233);
            this.mGridInsolvable.MultiSelect = false;
            this.mGridInsolvable.Name = "mGridInsolvable";
            this.mGridInsolvable.ReadOnly = true;
            this.mGridInsolvable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridInsolvable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridInsolvable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridInsolvable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridInsolvable.Size = new System.Drawing.Size(596, 225);
            this.mGridInsolvable.TabIndex = 8;
            // 
            // btnPrintInsolvable
            // 
            this.btnPrintInsolvable.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintInsolvable.BackgroundColor = System.Drawing.Color.White;
            this.btnPrintInsolvable.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintInsolvable.BorderRadius = 5;
            this.btnPrintInsolvable.ButtonText = "Print";
            this.btnPrintInsolvable.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInsolvable.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInsolvable.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnPrintInsolvable.HoverBackground = System.Drawing.Color.White;
            this.btnPrintInsolvable.HoverBorder = System.Drawing.Color.Empty;
            this.btnPrintInsolvable.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintInsolvable.LineThickness = 2;
            this.btnPrintInsolvable.Location = new System.Drawing.Point(442, 477);
            this.btnPrintInsolvable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintInsolvable.Name = "btnPrintInsolvable";
            this.btnPrintInsolvable.Size = new System.Drawing.Size(165, 39);
            this.btnPrintInsolvable.TabIndex = 15;
            this.btnPrintInsolvable.Click += new System.EventHandler(this.btnPrintInsolvable_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundColor = System.Drawing.Color.White;
            this.btnBack.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.BorderRadius = 5;
            this.btnBack.ButtonText = "Back";
            this.btnBack.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnBack.HoverBackground = System.Drawing.Color.White;
            this.btnBack.HoverBorder = System.Drawing.Color.Empty;
            this.btnBack.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.LineThickness = 2;
            this.btnBack.Location = new System.Drawing.Point(12, 477);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 39);
            this.btnBack.TabIndex = 15;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tranche  :";
            // 
            // cmbTranche
            // 
            this.cmbTranche.FormattingEnabled = true;
            this.cmbTranche.ItemHeight = 23;
            this.cmbTranche.Location = new System.Drawing.Point(441, 94);
            this.cmbTranche.Name = "cmbTranche";
            this.cmbTranche.Size = new System.Drawing.Size(161, 29);
            this.cmbTranche.TabIndex = 7;
            this.cmbTranche.UseSelectable = true;
            this.cmbTranche.SelectedIndexChanged += new System.EventHandler(this.cmbTranche_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre Eleve :";
            // 
            // lblNombreEleve
            // 
            this.lblNombreEleve.AutoSize = true;
            this.lblNombreEleve.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEleve.Location = new System.Drawing.Point(535, 131);
            this.lblNombreEleve.Name = "lblNombreEleve";
            this.lblNombreEleve.Size = new System.Drawing.Size(20, 21);
            this.lblNombreEleve.TabIndex = 6;
            this.lblNombreEleve.Text = "0";
            // 
            // lblTotalTrancheAVerser
            // 
            this.lblTotalTrancheAVerser.AutoSize = true;
            this.lblTotalTrancheAVerser.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTrancheAVerser.Location = new System.Drawing.Point(12, 193);
            this.lblTotalTrancheAVerser.Name = "lblTotalTrancheAVerser";
            this.lblTotalTrancheAVerser.Size = new System.Drawing.Size(40, 21);
            this.lblTotalTrancheAVerser.TabIndex = 6;
            this.lblTotalTrancheAVerser.Text = "yyy";
            // 
            // montantManquant
            // 
            this.montantManquant.AutoSize = true;
            this.montantManquant.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantManquant.ForeColor = System.Drawing.Color.Red;
            this.montantManquant.Location = new System.Drawing.Point(322, 193);
            this.montantManquant.Name = "montantManquant";
            this.montantManquant.Size = new System.Drawing.Size(20, 21);
            this.montantManquant.TabIndex = 6;
            this.montantManquant.Text = "0";
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // InsolvableListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 526);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrintInsolvable);
            this.Controls.Add(this.mGridInsolvable);
            this.Controls.Add(this.cmbTranche);
            this.Controls.Add(this.comboClasse);
            this.Controls.Add(this.lblTotalVerserT);
            this.Controls.Add(this.TotalVerser);
            this.Controls.Add(this.montantManquant);
            this.Controls.Add(this.lblTotalCompte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreEleve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalTrancheAVerser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsolvableListe";
            this.Text = "InsolvableListe";
            this.Load += new System.EventHandler(this.InsolvableListe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGridInsolvable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboClasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalCompte;
        private System.Windows.Forms.Label lblTotalVerserT;
        private System.Windows.Forms.Label TotalVerser;
        private MetroFramework.Controls.MetroGrid mGridInsolvable;
        private JThinButton.JThinButton btnPrintInsolvable;
        private JThinButton.JThinButton btnBack;
    //    private open_schoolDataSetClasse open_schoolDataSetClasse;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbTranche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreEleve;
        private System.Windows.Forms.Label lblTotalTrancheAVerser;
        private System.Windows.Forms.Label montantManquant;
        private JDragControl.JDragControl jDragControl1;
        //    private open_schoolDataSetClasseTableAdapters.classeTableAdapter classeTableAdapter;
    }
}