
namespace Futurix_School_Prim_En.Forms
{
    partial class Niveau
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboCycle = new MetroFramework.Controls.MetroComboBox();
            this.cycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtNiveau = new JMetroTextBox.JMetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.niveauGrid = new MetroFramework.Controls.MetroGrid();
            this.niveauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new JThinButton.JThinButton();
            this.btnSave = new JThinButton.JThinButton();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cycle  :";
            // 
            // comboCycle
            // 
            this.comboCycle.FormattingEnabled = true;
            this.comboCycle.ItemHeight = 23;
            this.comboCycle.Location = new System.Drawing.Point(131, 109);
            this.comboCycle.Name = "comboCycle";
            this.comboCycle.Size = new System.Drawing.Size(161, 29);
            this.comboCycle.TabIndex = 3;
            this.comboCycle.UseSelectable = true;
            this.comboCycle.SelectedIndexChanged += new System.EventHandler(this.comboCycle_SelectedIndexChanged);
            // 
            // cycleBindingSource
            // 
            this.cycleBindingSource.DataMember = "cycle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libelle :";
            // 
            // txtNiveau
            // 
            this.txtNiveau.BackColor = System.Drawing.Color.Transparent;
            this.txtNiveau.BorderColor = System.Drawing.Color.Empty;
            this.txtNiveau.BorderRadius = 5;
            this.txtNiveau.FillColor = System.Drawing.SystemColors.Window;
            this.txtNiveau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNiveau.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNiveau.ForeColors = System.Drawing.Color.Gray;
            this.txtNiveau.IsPassword = false;
            this.txtNiveau.LineThickness = 2;
            this.txtNiveau.Location = new System.Drawing.Point(130, 168);
            this.txtNiveau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNiveau.MaxLength = 32767;
            this.txtNiveau.MouseOnHover = System.Drawing.Color.Empty;
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNiveau.OnFocusColor = System.Drawing.Color.Empty;
            this.txtNiveau.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtNiveau.ReadOnly = false;
            this.txtNiveau.Size = new System.Drawing.Size(162, 36);
            this.txtNiveau.TabIndex = 7;
            this.txtNiveau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNiveau.TextName = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Niveau Créer";
            // 
            // niveauGrid
            // 
            this.niveauGrid.AllowUserToResizeRows = false;
            this.niveauGrid.AutoGenerateColumns = false;
            this.niveauGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.niveauGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.niveauGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.niveauGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.niveauGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.niveauGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.niveauGrid.DataSource = this.niveauBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.niveauGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.niveauGrid.EnableHeadersVisualStyles = false;
            this.niveauGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.niveauGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.niveauGrid.Location = new System.Drawing.Point(47, 275);
            this.niveauGrid.Name = "niveauGrid";
            this.niveauGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.niveauGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.niveauGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.niveauGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.niveauGrid.Size = new System.Drawing.Size(245, 153);
            this.niveauGrid.TabIndex = 9;
            this.niveauGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.niveauGrid_CellContentClick);
            // 
            // niveauBindingSource
            // 
            this.niveauBindingSource.DataMember = "niveau";
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
            this.btnBack.Location = new System.Drawing.Point(17, 435);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 31);
            this.btnBack.TabIndex = 10;
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
            this.btnSave.Location = new System.Drawing.Point(195, 435);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // Niveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 476);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.niveauGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCycle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Niveau";
            this.Text = "Niveau";
            this.Load += new System.EventHandler(this.Niveau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox comboCycle;
        private System.Windows.Forms.Label label3;
        private JMetroTextBox.JMetroTextBox txtNiveau;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroGrid niveauGrid;
        private JThinButton.JThinButton btnBack;
        private JThinButton.JThinButton btnSave;
        private JDragControl.JDragControl jDragControl1;
      //  private open_schoolDataSet open_schoolDataSet;
        private System.Windows.Forms.BindingSource cycleBindingSource;
      /*  private open_schoolDataSetTableAdapters.cycleTableAdapter cycleTableAdapter;
        private open_schoolDataSet2 open_schoolDataSet2;
       */ private System.Windows.Forms.BindingSource niveauBindingSource;
   //     private open_schoolDataSet2TableAdapters.niveauTableAdapter niveauTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNIVEAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESIGNATIONDataGridViewTextBoxColumn;
    }
}