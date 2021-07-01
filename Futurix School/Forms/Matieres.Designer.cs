
namespace Futurix_School_Prim_En.Forms
{
    partial class Matieres
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
            this.matieresGrid = new MetroFramework.Controls.MetroGrid();
            this.matiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatiere = new JMetroTextBox.JMetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new JThinButton.JThinButton();
            this.btnQuit = new JThinButton.JThinButton();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matieresGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matiereBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matieres";
            // 
            // matieresGrid
            // 
            this.matieresGrid.AllowUserToResizeRows = false;
            this.matieresGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matieresGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matieresGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.matieresGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matieresGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.matieresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matieresGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.matieresGrid.EnableHeadersVisualStyles = false;
            this.matieresGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.matieresGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matieresGrid.Location = new System.Drawing.Point(34, 231);
            this.matieresGrid.Name = "matieresGrid";
            this.matieresGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matieresGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.matieresGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matieresGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.matieresGrid.Size = new System.Drawing.Size(275, 179);
            this.matieresGrid.TabIndex = 13;
            // 
            // matiereBindingSource
            // 
            this.matiereBindingSource.DataMember = "matiere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Matiere Créer";
            // 
            // txtMatiere
            // 
            this.txtMatiere.BackColor = System.Drawing.Color.Transparent;
            this.txtMatiere.BorderColor = System.Drawing.Color.Empty;
            this.txtMatiere.BorderRadius = 5;
            this.txtMatiere.FillColor = System.Drawing.SystemColors.Window;
            this.txtMatiere.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMatiere.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMatiere.ForeColors = System.Drawing.Color.Gray;
            this.txtMatiere.IsPassword = false;
            this.txtMatiere.LineThickness = 2;
            this.txtMatiere.Location = new System.Drawing.Point(147, 108);
            this.txtMatiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatiere.MaxLength = 32767;
            this.txtMatiere.MouseOnHover = System.Drawing.Color.Empty;
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatiere.OnFocusColor = System.Drawing.Color.Empty;
            this.txtMatiere.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtMatiere.ReadOnly = false;
            this.txtMatiere.Size = new System.Drawing.Size(162, 36);
            this.txtMatiere.TabIndex = 11;
            this.txtMatiere.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatiere.TextName = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Libelle :";
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
            this.btnSave.Location = new System.Drawing.Point(180, 152);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundColor = System.Drawing.Color.White;
            this.btnQuit.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnQuit.BorderRadius = 5;
            this.btnQuit.ButtonText = "Quit";
            this.btnQuit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnQuit.HoverBackground = System.Drawing.Color.White;
            this.btnQuit.HoverBorder = System.Drawing.Color.Empty;
            this.btnQuit.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnQuit.LineThickness = 2;
            this.btnQuit.Location = new System.Drawing.Point(122, 432);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(97, 31);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // Matieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 476);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.matieresGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatiere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Matieres";
            this.Text = "Matieres";
            this.Load += new System.EventHandler(this.Matieres_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matieresGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matiereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid matieresGrid;
        private System.Windows.Forms.Label label4;
        private JMetroTextBox.JMetroTextBox txtMatiere;
        private System.Windows.Forms.Label label3;
     //   private open_schoolDataSet6 open_schoolDataSet6;
        private System.Windows.Forms.BindingSource matiereBindingSource;
     //   private open_schoolDataSet6TableAdapters.matiereTableAdapter matiereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMATIEREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESIGNATIONDataGridViewTextBoxColumn;
        private JThinButton.JThinButton btnSave;
        private JThinButton.JThinButton btnQuit;
        private JDragControl.JDragControl jDragControl1;
    }
}