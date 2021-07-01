
namespace Futurix_School_Prim_En.Forms
{
    partial class Pension
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
            this.comboNiveau = new MetroFramework.Controls.MetroComboBox();
            this.niveauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new JMetroTextBox.JMetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pensionGrid = new MetroFramework.Controls.MetroGrid();
            this.allpensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new JThinButton.JThinButton();
            this.btnBack = new JThinButton.JThinButton();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allpensionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 75);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pension";
            // 
            // comboNiveau
            // 
            this.comboNiveau.FormattingEnabled = true;
            this.comboNiveau.ItemHeight = 23;
            this.comboNiveau.Location = new System.Drawing.Point(131, 107);
            this.comboNiveau.Name = "comboNiveau";
            this.comboNiveau.Size = new System.Drawing.Size(161, 29);
            this.comboNiveau.TabIndex = 5;
            this.comboNiveau.UseSelectable = true;
            // 
            // niveauBindingSource
            // 
            this.niveauBindingSource.DataMember = "niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Niveau  :";
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.Color.Transparent;
            this.txtMontant.BorderColor = System.Drawing.Color.Empty;
            this.txtMontant.BorderRadius = 5;
            this.txtMontant.FillColor = System.Drawing.SystemColors.Window;
            this.txtMontant.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontant.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontant.ForeColors = System.Drawing.Color.Gray;
            this.txtMontant.IsPassword = false;
            this.txtMontant.LineThickness = 2;
            this.txtMontant.Location = new System.Drawing.Point(131, 169);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontant.MaxLength = 32767;
            this.txtMontant.MouseOnHover = System.Drawing.Color.Empty;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontant.OnFocusColor = System.Drawing.Color.Empty;
            this.txtMontant.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtMontant.ReadOnly = false;
            this.txtMontant.Size = new System.Drawing.Size(161, 36);
            this.txtMontant.TabIndex = 9;
            this.txtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMontant.TextName = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Montant :";
            // 
            // pensionGrid
            // 
            this.pensionGrid.AllowUserToResizeRows = false;
            this.pensionGrid.AutoGenerateColumns = false;
            this.pensionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pensionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pensionGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.pensionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pensionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pensionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pensionGrid.DataSource = this.allpensionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pensionGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.pensionGrid.EnableHeadersVisualStyles = false;
            this.pensionGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pensionGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pensionGrid.Location = new System.Drawing.Point(35, 227);
            this.pensionGrid.Name = "pensionGrid";
            this.pensionGrid.ReadOnly = true;
            this.pensionGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pensionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pensionGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pensionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pensionGrid.Size = new System.Drawing.Size(243, 153);
            this.pensionGrid.TabIndex = 10;
            // 
            // allpensionBindingSource
            // 
            this.allpensionBindingSource.DataMember = "allpension";
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
            this.btnSave.Location = new System.Drawing.Point(195, 393);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnBack.Location = new System.Drawing.Point(17, 393);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 31);
            this.btnBack.TabIndex = 12;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // Pension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 437);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pensionGrid);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboNiveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pension";
            this.Text = "Pension";
            this.Load += new System.EventHandler(this.Pension_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allpensionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboNiveau;
        private System.Windows.Forms.Label label2;
        private JMetroTextBox.JMetroTextBox txtMontant;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroGrid pensionGrid;
        private JThinButton.JThinButton btnSave;
        private JThinButton.JThinButton btnBack;
     //   private open_schoolDataSet2 open_schoolDataSet2;
        private System.Windows.Forms.BindingSource niveauBindingSource;
      /*  private open_schoolDataSet2TableAdapters.niveauTableAdapter niveauTableAdapter;
        private open_schoolDataSet5 open_schoolDataSet5;
      */  private System.Windows.Forms.BindingSource allpensionBindingSource;
     //   private open_schoolDataSet5TableAdapters.allpensionTableAdapter allpensionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESIGNATIONDataGridViewTextBoxColumn;
        public JDragControl.JDragControl jDragControl1;
    }
}