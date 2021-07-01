
namespace Futurix_School_Prim_En.Main_1
{
    partial class MainNiveau1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainNiveau1));
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVersement = new JImageButton.JImageButton();
            this.setting = new JImageButton.JImageButton();
            this.btnInscription = new JImageButton.JImageButton();
            this.label = new JThinButton.JThinButton();
            this.btnEtatJour = new JImageButton.JImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inscription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(192, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Versements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Insolvables";
            // 
            // btnVersement
            // 
            this.btnVersement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVersement.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnVersement.CausesValidation = false;
            this.btnVersement.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVersement.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnVersement.ErrorImage")));
            this.btnVersement.Image = ((System.Drawing.Image)(resources.GetObject("btnVersement.Image")));
            this.btnVersement.ImageHover = null;
            this.btnVersement.InitialImage = null;
            this.btnVersement.Location = new System.Drawing.Point(190, 88);
            this.btnVersement.Name = "btnVersement";
            this.btnVersement.Size = new System.Drawing.Size(111, 92);
            this.btnVersement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnVersement.TabIndex = 3;
            this.btnVersement.Zoom = 4;
            this.btnVersement.Click += new System.EventHandler(this.btnVersement_Click);
            // 
            // setting
            // 
            this.setting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setting.BackColor = System.Drawing.Color.Red;
            this.setting.CausesValidation = false;
            this.setting.Cursor = System.Windows.Forms.Cursors.Default;
            this.setting.ErrorImage = ((System.Drawing.Image)(resources.GetObject("setting.ErrorImage")));
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.ImageHover = null;
            this.setting.InitialImage = null;
            this.setting.Location = new System.Drawing.Point(24, 248);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(111, 92);
            this.setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.setting.TabIndex = 3;
            this.setting.Zoom = 4;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // btnInscription
            // 
            this.btnInscription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInscription.BackColor = System.Drawing.Color.Lime;
            this.btnInscription.CausesValidation = false;
            this.btnInscription.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInscription.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnInscription.ErrorImage")));
            this.btnInscription.Image = ((System.Drawing.Image)(resources.GetObject("btnInscription.Image")));
            this.btnInscription.ImageHover = null;
            this.btnInscription.InitialImage = null;
            this.btnInscription.Location = new System.Drawing.Point(24, 88);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(111, 92);
            this.btnInscription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnInscription.TabIndex = 3;
            this.btnInscription.Zoom = 4;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.BackgroundColor = System.Drawing.Color.White;
            this.label.BorderColor = System.Drawing.SystemColors.Highlight;
            this.label.BorderRadius = 5;
            this.label.ButtonText = "Back";
            this.label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColors = System.Drawing.SystemColors.Highlight;
            this.label.HoverBackground = System.Drawing.Color.White;
            this.label.HoverBorder = System.Drawing.Color.Empty;
            this.label.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.label.LineThickness = 2;
            this.label.Location = new System.Drawing.Point(189, 389);
            this.label.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 37);
            this.label.TabIndex = 8;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // btnEtatJour
            // 
            this.btnEtatJour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEtatJour.BackColor = System.Drawing.Color.Gold;
            this.btnEtatJour.CausesValidation = false;
            this.btnEtatJour.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEtatJour.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnEtatJour.ErrorImage")));
            this.btnEtatJour.Image = ((System.Drawing.Image)(resources.GetObject("btnEtatJour.Image")));
            this.btnEtatJour.ImageHover = null;
            this.btnEtatJour.InitialImage = null;
            this.btnEtatJour.Location = new System.Drawing.Point(190, 248);
            this.btnEtatJour.Name = "btnEtatJour";
            this.btnEtatJour.Size = new System.Drawing.Size(111, 92);
            this.btnEtatJour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnEtatJour.TabIndex = 3;
            this.btnEtatJour.Zoom = 4;
            this.btnEtatJour.Click += new System.EventHandler(this.btnEtatJour_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(192, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Etat Jour.";
            // 
            // MainNiveau1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 439);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnEtatJour);
            this.Controls.Add(this.btnVersement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainNiveau1";
            this.Text = "MainNiveau1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JDragControl.JDragControl jDragControl1;
        private JImageButton.JImageButton btnInscription;
        private System.Windows.Forms.Label label1;
        private JImageButton.JImageButton btnVersement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private JImageButton.JImageButton setting;
        private System.Windows.Forms.Label label4;
        private JThinButton.JThinButton label;
        private JImageButton.JImageButton btnEtatJour;
        private System.Windows.Forms.Label label5;
    }
}