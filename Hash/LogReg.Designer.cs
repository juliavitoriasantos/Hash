namespace Hash
{
    partial class LogReg
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLogin = new Button();
            lblSenhaL = new Label();
            lblUserL = new Label();
            txtUserL = new TextBox();
            txtSenhaL = new TextBox();
            tabPage2 = new TabPage();
            txtUserR = new TextBox();
            txtSenhaR = new TextBox();
            txtConfirmarR = new TextBox();
            txtEmailR = new TextBox();
            lblSEnhaR = new Label();
            lblConfirmarR = new Label();
            lblEmailR = new Label();
            lblUserR = new Label();
            btnRegistro = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 460);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(lblSenhaL);
            tabPage1.Controls.Add(lblUserL);
            tabPage1.Controls.Add(txtUserL);
            tabPage1.Controls.Add(txtSenhaL);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 432);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(376, 296);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSenhaL
            // 
            lblSenhaL.AutoSize = true;
            lblSenhaL.Location = new Point(322, 168);
            lblSenhaL.Name = "lblSenhaL";
            lblSenhaL.Size = new Size(39, 15);
            lblSenhaL.TabIndex = 3;
            lblSenhaL.Text = "Senha";
            // 
            // lblUserL
            // 
            lblUserL.AutoSize = true;
            lblUserL.Location = new Point(322, 83);
            lblUserL.Name = "lblUserL";
            lblUserL.Size = new Size(47, 15);
            lblUserL.TabIndex = 2;
            lblUserL.Text = "Usuário";
            // 
            // txtUserL
            // 
            txtUserL.Location = new Point(442, 80);
            txtUserL.Name = "txtUserL";
            txtUserL.Size = new Size(100, 23);
            txtUserL.TabIndex = 1;
            // 
            // txtSenhaL
            // 
            txtSenhaL.Location = new Point(442, 165);
            txtSenhaL.Name = "txtSenhaL";
            txtSenhaL.Size = new Size(100, 23);
            txtSenhaL.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtUserR);
            tabPage2.Controls.Add(txtSenhaR);
            tabPage2.Controls.Add(txtConfirmarR);
            tabPage2.Controls.Add(txtEmailR);
            tabPage2.Controls.Add(lblSEnhaR);
            tabPage2.Controls.Add(lblConfirmarR);
            tabPage2.Controls.Add(lblEmailR);
            tabPage2.Controls.Add(lblUserR);
            tabPage2.Controls.Add(btnRegistro);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 432);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUserR
            // 
            txtUserR.Location = new Point(396, 51);
            txtUserR.Name = "txtUserR";
            txtUserR.Size = new Size(100, 23);
            txtUserR.TabIndex = 8;
            // 
            // txtSenhaR
            // 
            txtSenhaR.Location = new Point(396, 103);
            txtSenhaR.Name = "txtSenhaR";
            txtSenhaR.Size = new Size(100, 23);
            txtSenhaR.TabIndex = 7;
            // 
            // txtConfirmarR
            // 
            txtConfirmarR.Location = new Point(396, 152);
            txtConfirmarR.Name = "txtConfirmarR";
            txtConfirmarR.Size = new Size(100, 23);
            txtConfirmarR.TabIndex = 6;
            // 
            // txtEmailR
            // 
            txtEmailR.Location = new Point(396, 209);
            txtEmailR.Name = "txtEmailR";
            txtEmailR.Size = new Size(100, 23);
            txtEmailR.TabIndex = 5;
            // 
            // lblSEnhaR
            // 
            lblSEnhaR.AutoSize = true;
            lblSEnhaR.Location = new Point(205, 103);
            lblSEnhaR.Name = "lblSEnhaR";
            lblSEnhaR.Size = new Size(39, 15);
            lblSEnhaR.TabIndex = 4;
            lblSEnhaR.Text = "Senha";
            // 
            // lblConfirmarR
            // 
            lblConfirmarR.AutoSize = true;
            lblConfirmarR.Location = new Point(205, 160);
            lblConfirmarR.Name = "lblConfirmarR";
            lblConfirmarR.Size = new Size(61, 15);
            lblConfirmarR.TabIndex = 3;
            lblConfirmarR.Text = "Confirmar";
            // 
            // lblEmailR
            // 
            lblEmailR.AutoSize = true;
            lblEmailR.Location = new Point(205, 217);
            lblEmailR.Name = "lblEmailR";
            lblEmailR.Size = new Size(36, 15);
            lblEmailR.TabIndex = 2;
            lblEmailR.Text = "Email";
            // 
            // lblUserR
            // 
            lblUserR.AutoSize = true;
            lblUserR.Location = new Point(205, 54);
            lblUserR.Name = "lblUserR";
            lblUserR.Size = new Size(47, 15);
            lblUserR.TabIndex = 1;
            lblUserR.Text = "Usuário";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(354, 304);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 0;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // LogReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "LogReg";
            Text = "LogReg";
            Load += LogReg_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnLogin;
        private Label lblSenhaL;
        private Label lblUserL;
        private TextBox txtUserL;
        private TextBox txtSenhaL;
        private TabPage tabPage2;
        private TextBox txtUserR;
        private TextBox txtSenhaR;
        private TextBox txtConfirmarR;
        private TextBox txtEmailR;
        private Label lblSEnhaR;
        private Label lblConfirmarR;
        private Label lblEmailR;
        private Label lblUserR;
        private Button btnRegistro;
    }
}