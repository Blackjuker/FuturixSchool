
namespace Futurix_School_Prim_En.Forms
{
    partial class Classe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboNiveau = new MetroFramework.Controls.MetroComboBox();
            this.niveauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtClasse = new JMetroTextBox.JMetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classeGrid = new MetroFramework.Controls.MetroGrid();
            this.listdeniveauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new JThinButton.JThinButton();
            this.btnSave = new JThinButton.JThinButton();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSerie = new MetroFramework.Controls.MetroComboBox();
            this.serieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCapacite = new JMetroTextBox.JMetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listdeniveauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 75);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Niveau  :";
            // 
            // comboNiveau
            // 
            this.comboNiveau.FormattingEnabled = true;
            this.comboNiveau.ItemHeight = 23;
            this.comboNiveau.Location = new System.Drawing.Point(130, 102);
            this.comboNiveau.Name = "comboNiveau";
            this.comboNiveau.Size = new System.Drawing.Size(161, 29);
            this.comboNiveau.TabIndex = 4;
            this.comboNiveau.UseSelectable = true;
            this.comboNiveau.SelectedIndexChanged += new System.EventHandler(this.comboNiveau_SelectedIndexChanged);
            // 
            // niveauBindingSource
            // 
            this.niveauBindingSource.DataMember = "niveau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Classe Nom :";
            // 
            // txtClasse
            // 
            this.txtClasse.BackColor = System.Drawing.Color.Transparent;
            this.txtClasse.BorderColor = System.Drawing.Color.Empty;
            this.txtClasse.BorderRadius = 5;
            this.txtClasse.FillColor = System.Drawing.SystemColors.Window;
            this.txtClasse.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtClasse.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtClasse.ForeColors = System.Drawing.Color.Gray;
            this.txtClasse.IsPassword = false;
            this.txtClasse.LineThickness = 2;
            this.txtClasse.Location = new System.Drawing.Point(130, 151);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClasse.MaxLength = 32767;
            this.txtClasse.MouseOnHover = System.Drawing.Color.Empty;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClasse.OnFocusColor = System.Drawing.Color.Empty;
            this.txtClasse.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtClasse.ReadOnly = false;
            this.txtClasse.Size = new System.Drawing.Size(161, 38);
            this.txtClasse.TabIndex = 8;
            this.txtClasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClasse.TextName = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Classes Créer";
            // 
            // classeGrid
            // 
            this.classeGrid.AllowUserToResizeRows = false;
            this.classeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.classeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.classeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.classeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classeGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.classeGrid.EnableHeadersVisualStyles = false;
            this.classeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.classeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.classeGrid.Location = new System.Drawing.Point(23, 255);
            this.classeGrid.MultiSelect = false;
            this.classeGrid.Name = "classeGrid";
            this.classeGrid.ReadOnly = true;
            this.classeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.classeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.classeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classeGrid.Size = new System.Drawing.Size(642, 153);
            this.classeGrid.TabIndex = 10;
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
            this.btnBack.Location = new System.Drawing.Point(130, 429);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 31);
            this.btnBack.TabIndex = 11;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnSave.HoverBackground = System.Drawing.Color.White;
            this.btnSave.HoverBorder = System.Drawing.Color.Empty;
            this.btnSave.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.LineThickness = 2;
            this.btnSave.Location = new System.Drawing.Point(461, 429);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 31);
            this.btnSave.TabIndex = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = null;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(441, 102);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(0, 29);
            this.metroComboBox2.TabIndex = 14;
            this.metroComboBox2.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Série  :";
            // 
            // comboSerie
            // 
            this.comboSerie.FormattingEnabled = true;
            this.comboSerie.ItemHeight = 23;
            this.comboSerie.Location = new System.Drawing.Point(461, 102);
            this.comboSerie.Name = "comboSerie";
            this.comboSerie.Size = new System.Drawing.Size(161, 29);
            this.comboSerie.TabIndex = 15;
            this.comboSerie.UseSelectable = true;
            // 
            // serieBindingSource
            // 
            this.serieBindingSource.DataMember = "serie";
            // 
            // txtCapacite
            // 
            this.txtCapacite.BackColor = System.Drawing.Color.Transparent;
            this.txtCapacite.BorderColor = System.Drawing.Color.Empty;
            this.txtCapacite.BorderRadius = 5;
            this.txtCapacite.FillColor = System.Drawing.SystemColors.Window;
            this.txtCapacite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCapacite.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCapacite.ForeColors = System.Drawing.Color.Gray;
            this.txtCapacite.IsPassword = false;
            this.txtCapacite.LineThickness = 2;
            this.txtCapacite.Location = new System.Drawing.Point(461, 151);
            this.txtCapacite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCapacite.MaxLength = 32767;
            this.txtCapacite.MouseOnHover = System.Drawing.Color.Empty;
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacite.OnFocusColor = System.Drawing.Color.Empty;
            this.txtCapacite.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtCapacite.ReadOnly = false;
            this.txtCapacite.Size = new System.Drawing.Size(161, 38);
            this.txtCapacite.TabIndex = 17;
            this.txtCapacite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCapacite.TextName = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Capacite :";
            // 
            // Classe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 472);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboSerie);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.classeGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboNiveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classe";
            this.Text = "Classe";
            this.Load += new System.EventHandler(this.Classe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listdeniveauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox comboNiveau;
        private System.Windows.Forms.Label label3;
        private JMetroTextBox.JMetroTextBox txtClasse;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroGrid classeGrid;
        private JThinButton.JThinButton btnBack;
        private JThinButton.JThinButton btnSave;
        private JDragControl.JDragControl jDragControl1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox comboSerie;
    //    private open_schoolDataSet2 open_schoolDataSet2;
        private System.Windows.Forms.BindingSource niveauBindingSource;
  //      private open_schoolDataSet2TableAdapters.niveauTableAdapter niveauTableAdapter;
  //      private open_schoolDataSetSerieList open_schoolDataSetSerieList;
        private System.Windows.Forms.BindingSource serieBindingSource;
    //    private open_schoolDataSetSerieListTableAdapters.serieTableAdapter serieTableAdapter;
        private JMetroTextBox.JMetroTextBox txtCapacite;
        private System.Windows.Forms.Label label6;
   //     private open_schoolDataSet3 open_schoolDataSet3;
        private System.Windows.Forms.BindingSource listdeniveauBindingSource;
   //     private open_schoolDataSet3TableAdapters.list_de_niveauTableAdapter list_de_niveauTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIBELLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAPACITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBRELEVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIBELLENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIBELLESDataGridViewTextBoxColumn;
    }
}