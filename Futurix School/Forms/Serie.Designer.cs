
namespace Futurix_School_Prim_En.Forms
{
    partial class Serie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerie = new JMetroTextBox.JMetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cycleGrid = new MetroFramework.Controls.MetroGrid();
            this.btnSave = new JThinButton.JThinButton();
            this.btnBack = new JThinButton.JThinButton();
      //      this.open_schoolDataSetSerieList = new Open_School_Prim_Fr.open_schoolDataSetSerieList();
            this.serieBindingSource = new System.Windows.Forms.BindingSource(this.components);
       //     this.serieTableAdapter = new Open_School_Prim_Fr.open_schoolDataSetSerieListTableAdapters.serieTableAdapter();
            this.iDSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESIGNATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycleGrid)).BeginInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.open_schoolDataSetSerieList)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(353, 72);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Série";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.Transparent;
            this.txtSerie.BorderColor = System.Drawing.Color.Empty;
            this.txtSerie.BorderRadius = 5;
            this.txtSerie.FillColor = System.Drawing.SystemColors.Window;
            this.txtSerie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSerie.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSerie.ForeColors = System.Drawing.Color.Gray;
            this.txtSerie.IsPassword = false;
            this.txtSerie.LineThickness = 2;
            this.txtSerie.Location = new System.Drawing.Point(133, 116);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSerie.MaxLength = 32767;
            this.txtSerie.MouseOnHover = System.Drawing.Color.Empty;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerie.OnFocusColor = System.Drawing.Color.Empty;
            this.txtSerie.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtSerie.ReadOnly = false;
            this.txtSerie.Size = new System.Drawing.Size(207, 39);
            this.txtSerie.TabIndex = 8;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSerie.TextName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Libelle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Série Créer";
            // 
            // cycleGrid
            // 
            this.cycleGrid.AllowUserToAddRows = false;
            this.cycleGrid.AllowUserToDeleteRows = false;
            this.cycleGrid.AllowUserToResizeColumns = false;
            this.cycleGrid.AllowUserToResizeRows = false;
            this.cycleGrid.AutoGenerateColumns = false;
            this.cycleGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cycleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cycleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cycleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cycleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.cycleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cycleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSERIEDataGridViewTextBoxColumn,
            this.dESIGNATIONDataGridViewTextBoxColumn});
            this.cycleGrid.DataSource = this.serieBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cycleGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.cycleGrid.EnableHeadersVisualStyles = false;
            this.cycleGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cycleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cycleGrid.Location = new System.Drawing.Point(54, 253);
            this.cycleGrid.Name = "cycleGrid";
            this.cycleGrid.ReadOnly = true;
            this.cycleGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cycleGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.cycleGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cycleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cycleGrid.Size = new System.Drawing.Size(241, 176);
            this.cycleGrid.TabIndex = 10;
            this.cycleGrid.UseStyleColors = true;
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
            this.btnSave.Location = new System.Drawing.Point(263, 436);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 31);
            this.btnSave.TabIndex = 12;
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
            this.btnBack.Location = new System.Drawing.Point(12, 436);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 31);
            this.btnBack.TabIndex = 11;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // open_schoolDataSetSerieList
            // 
        /*    this.open_schoolDataSetSerieList.DataSetName = "open_schoolDataSetSerieList";
            this.open_schoolDataSetSerieList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        */    // 
            // serieBindingSource
            // 
            this.serieBindingSource.DataMember = "serie";
       //     this.serieBindingSource.DataSource = this.open_schoolDataSetSerieList;
            // 
            // serieTableAdapter
            // 
       //     this.serieTableAdapter.ClearBeforeFill = true;
            // 
            // iDSERIEDataGridViewTextBoxColumn
            // 
            this.iDSERIEDataGridViewTextBoxColumn.DataPropertyName = "IDSERIE";
            this.iDSERIEDataGridViewTextBoxColumn.HeaderText = "IDSERIE";
            this.iDSERIEDataGridViewTextBoxColumn.Name = "iDSERIEDataGridViewTextBoxColumn";
            this.iDSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESIGNATIONDataGridViewTextBoxColumn
            // 
            this.dESIGNATIONDataGridViewTextBoxColumn.DataPropertyName = "DESIGNATION";
            this.dESIGNATIONDataGridViewTextBoxColumn.HeaderText = "DESIGNATION";
            this.dESIGNATIONDataGridViewTextBoxColumn.Name = "dESIGNATIONDataGridViewTextBoxColumn";
            this.dESIGNATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 480);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cycleGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Serie";
            this.Text = "Serie";
            this.Load += new System.EventHandler(this.Serie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycleGrid)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.open_schoolDataSetSerieList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JMetroTextBox.JMetroTextBox txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroGrid cycleGrid;
        private JThinButton.JThinButton btnSave;
        private JThinButton.JThinButton btnBack;
  //      private open_schoolDataSetSerieList open_schoolDataSetSerieList;
        private System.Windows.Forms.BindingSource serieBindingSource;
 //       private open_schoolDataSetSerieListTableAdapters.serieTableAdapter serieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESIGNATIONDataGridViewTextBoxColumn;
    }
}