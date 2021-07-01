
namespace Futurix_School_Prim_En
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new JMaterialTextbox.JMaterialTextbox();
            this.txtPassword = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new JThinButton.JThinButton();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.btnQuit = new JThinButton.JThinButton();
            this.label3 = new System.Windows.Forms.Label();
            this.choixBd = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColors = System.Drawing.Color.Black;
            this.txtUsername.HintText = "nom d\'utilisateur";
            this.txtUsername.IsPassword = false;
            this.txtUsername.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.LineThickness = 2;
            this.txtUsername.Location = new System.Drawing.Point(109, 157);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.OnFocusedColor = System.Drawing.Color.Black;
            this.txtUsername.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(162, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextName = "nom d\'utilisateur";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColors = System.Drawing.Color.Black;
            this.txtPassword.HintText = "Mot de passe";
            this.txtPassword.IsPassword = true;
            this.txtPassword.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(109, 217);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.OnFocusedColor = System.Drawing.Color.Black;
            this.txtPassword.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(162, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextName = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password :";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnLogin.HoverBackground = System.Drawing.Color.White;
            this.btnLogin.HoverBorder = System.Drawing.Color.Empty;
            this.btnLogin.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.LineThickness = 2;
            this.btnLogin.Location = new System.Drawing.Point(65, 317);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 37);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundColor = System.Drawing.Color.White;
            this.btnQuit.BorderColor = System.Drawing.Color.Red;
            this.btnQuit.BorderRadius = 5;
            this.btnQuit.ButtonText = "Quit";
            this.btnQuit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColors = System.Drawing.Color.Red;
            this.btnQuit.HoverBackground = System.Drawing.Color.White;
            this.btnQuit.HoverBorder = System.Drawing.Color.Empty;
            this.btnQuit.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.btnQuit.LineThickness = 2;
            this.btnQuit.Location = new System.Drawing.Point(65, 376);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(141, 37);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choix Ecole";
            // 
            // choixBd
            // 
            this.choixBd.FormattingEnabled = true;
            this.choixBd.ItemHeight = 23;
            this.choixBd.Items.AddRange(new object[] {
            "Primaire Anglophone",
            "Primaire Francophone",
            "Collège Anglophone",
            "Collège Francophone",
            "Collège Technique Anglophone",
            "Collège Technique Francophone"});
            this.choixBd.Location = new System.Drawing.Point(15, 93);
            this.choixBd.Name = "choixBd";
            this.choixBd.Size = new System.Drawing.Size(256, 29);
            this.choixBd.TabIndex = 7;
            this.choixBd.UseSelectable = true;
            this.choixBd.SelectedIndexChanged += new System.EventHandler(this.choixBd_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Futurix_School_Prim_En.Properties.Resources.a;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.choixBd);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private JMaterialTextbox.JMaterialTextbox txtUsername;
        private JMaterialTextbox.JMaterialTextbox txtPassword;
        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton btnLogin;
        private JDragControl.JDragControl jDragControl1;
        private JThinButton.JThinButton btnQuit;
        private MetroFramework.Controls.MetroComboBox choixBd;
        private System.Windows.Forms.Label label3;
    }
}