
namespace Futurix_School_Prim_En.Forms
{
    partial class Tranche
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontantReste = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.dataGridTranche = new MetroFramework.Controls.MetroGrid();
            this.btnValider = new JThinButton.JThinButton();
            this.btnModify = new JThinButton.JThinButton();
            this.btnCancel = new JThinButton.JThinButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.txtMontantTranche = new MetroFramework.Controls.MetroTextBox();
            this.alert = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLibelle = new JMetroTextBox.JMetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTranche)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 75);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tranche";
            // 
            // comboNiveau
            // 
            this.comboNiveau.FormattingEnabled = true;
            this.comboNiveau.ItemHeight = 23;
            this.comboNiveau.Location = new System.Drawing.Point(189, 98);
            this.comboNiveau.Name = "comboNiveau";
            this.comboNiveau.Size = new System.Drawing.Size(161, 29);
            this.comboNiveau.TabIndex = 5;
            this.comboNiveau.UseSelectable = true;
            this.comboNiveau.SelectedIndexChanged += new System.EventHandler(this.comboNiveau_SelectedIndexChanged);
            // 
            // niveauBindingSource
            // 
            this.niveauBindingSource.DataMember = "niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Niveau  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Montant Pension : ";
            // 
            // txtMontant
            // 
            this.txtMontant.AutoSize = true;
            this.txtMontant.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontant.Location = new System.Drawing.Point(608, 98);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(26, 29);
            this.txtMontant.TabIndex = 7;
            this.txtMontant.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Montant T. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Montant Reste : ";
            // 
            // txtMontantReste
            // 
            this.txtMontantReste.AutoSize = true;
            this.txtMontantReste.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontantReste.Location = new System.Drawing.Point(608, 178);
            this.txtMontantReste.Name = "txtMontantReste";
            this.txtMontantReste.Size = new System.Drawing.Size(26, 29);
            this.txtMontantReste.TabIndex = 7;
            this.txtMontantReste.Text = "0";
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // dataGridTranche
            // 
            this.dataGridTranche.AllowUserToResizeRows = false;
            this.dataGridTranche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridTranche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTranche.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridTranche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTranche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTranche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTranche.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTranche.EnableHeadersVisualStyles = false;
            this.dataGridTranche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridTranche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridTranche.Location = new System.Drawing.Point(44, 284);
            this.dataGridTranche.Name = "dataGridTranche";
            this.dataGridTranche.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTranche.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridTranche.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTranche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTranche.Size = new System.Drawing.Size(406, 131);
            this.dataGridTranche.TabIndex = 10;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Transparent;
            this.btnValider.BackgroundColor = System.Drawing.Color.White;
            this.btnValider.BorderColor = System.Drawing.Color.Lime;
            this.btnValider.BorderRadius = 5;
            this.btnValider.ButtonText = "Save";
            this.btnValider.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnValider.HoverBackground = System.Drawing.Color.White;
            this.btnValider.HoverBorder = System.Drawing.Color.Empty;
            this.btnValider.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnValider.LineThickness = 2;
            this.btnValider.Location = new System.Drawing.Point(613, 284);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(163, 35);
            this.btnValider.TabIndex = 11;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.BackgroundColor = System.Drawing.Color.White;
            this.btnModify.BorderColor = System.Drawing.Color.Yellow;
            this.btnModify.BorderRadius = 5;
            this.btnModify.ButtonText = "Modify";
            this.btnModify.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnModify.HoverBackground = System.Drawing.Color.White;
            this.btnModify.HoverBorder = System.Drawing.Color.Empty;
            this.btnModify.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnModify.LineThickness = 2;
            this.btnModify.Location = new System.Drawing.Point(613, 332);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(163, 35);
            this.btnModify.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnCancel.HoverBackground = System.Drawing.Color.White;
            this.btnCancel.HoverBorder = System.Drawing.Color.Empty;
            this.btnCancel.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.LineThickness = 2;
            this.btnCancel.Location = new System.Drawing.Point(613, 380);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Fin :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(187, 234);
            this.dateTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(192, 29);
            this.dateTimePicker.TabIndex = 13;
            // 
            // txtMontantTranche
            // 
            // 
            // 
            // 
            this.txtMontantTranche.CustomButton.Image = null;
            this.txtMontantTranche.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtMontantTranche.CustomButton.Name = "";
            this.txtMontantTranche.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontantTranche.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontantTranche.CustomButton.TabIndex = 1;
            this.txtMontantTranche.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontantTranche.CustomButton.UseSelectable = true;
            this.txtMontantTranche.CustomButton.Visible = false;
            this.txtMontantTranche.Lines = new string[0];
            this.txtMontantTranche.Location = new System.Drawing.Point(189, 186);
            this.txtMontantTranche.MaxLength = 32767;
            this.txtMontantTranche.Name = "txtMontantTranche";
            this.txtMontantTranche.PasswordChar = '\0';
            this.txtMontantTranche.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontantTranche.SelectedText = "";
            this.txtMontantTranche.SelectionLength = 0;
            this.txtMontantTranche.SelectionStart = 0;
            this.txtMontantTranche.ShortcutsEnabled = true;
            this.txtMontantTranche.Size = new System.Drawing.Size(161, 23);
            this.txtMontantTranche.TabIndex = 14;
            this.txtMontantTranche.UseSelectable = true;
            this.txtMontantTranche.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontantTranche.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontantTranche.TextChanged += new System.EventHandler(this.txtMontantTranche_TextChanged);
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(398, 153);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(236, 24);
            this.alert.TabIndex = 15;
            this.alert.Text = "Attention ! seuil dépassé";
            this.alert.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Libelle :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.BackColor = System.Drawing.Color.Transparent;
            this.txtLibelle.BorderColor = System.Drawing.Color.Empty;
            this.txtLibelle.BorderRadius = 1;
            this.txtLibelle.FillColor = System.Drawing.SystemColors.Window;
            this.txtLibelle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLibelle.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLibelle.ForeColors = System.Drawing.Color.Gray;
            this.txtLibelle.IsPassword = false;
            this.txtLibelle.LineThickness = 2;
            this.txtLibelle.Location = new System.Drawing.Point(189, 141);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibelle.MaxLength = 32767;
            this.txtLibelle.MouseOnHover = System.Drawing.Color.Empty;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLibelle.OnFocusColor = System.Drawing.Color.Empty;
            this.txtLibelle.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtLibelle.ReadOnly = false;
            this.txtLibelle.Size = new System.Drawing.Size(161, 36);
            this.txtLibelle.TabIndex = 17;
            this.txtLibelle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLibelle.TextName = "";
            // 
            // Tranche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.txtMontantTranche);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dataGridTranche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMontantReste);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboNiveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tranche";
            this.Text = "Tranche";
            this.Load += new System.EventHandler(this.Tranche_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTranche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboNiveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMontant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtMontantReste;
        private JDragControl.JDragControl jDragControl1;
        private MetroFramework.Controls.MetroGrid dataGridTranche;
    //    private open_schoolDataSet2 open_schoolDataSet2;
        private System.Windows.Forms.BindingSource niveauBindingSource;
     //   private open_schoolDataSet2TableAdapters.niveauTableAdapter niveauTableAdapter;
        private JThinButton.JThinButton btnCancel;
        private JThinButton.JThinButton btnModify;
        private JThinButton.JThinButton btnValider;
        private MetroFramework.Controls.MetroDateTime dateTimePicker;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtMontantTranche;
        private System.Windows.Forms.Label alert;
        private JMetroTextBox.JMetroTextBox txtLibelle;
        private System.Windows.Forms.Label label7;
    }
}