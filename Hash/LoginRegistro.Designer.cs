namespace Hash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txbUser = new TextBox();
            txbSenha = new TextBox();
            lblSenha = new Label();
            lblUser = new Label();
            btnLogin = new Button();
            tabPage2 = new TabPage();
            btnRegistrar = new Button();
            lblEmailR = new Label();
            lblConfirmarR = new Label();
            lbeSenhaR = new Label();
            lblUserR = new Label();
            txbEmailR = new TextBox();
            txbConfirmarR = new TextBox();
            txbSenhaR = new TextBox();
            txbUserR = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(137, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(492, 319);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txbUser);
            tabPage1.Controls.Add(txbSenha);
            tabPage1.Controls.Add(lblSenha);
            tabPage1.Controls.Add(lblUser);
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(484, 291);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // txbUser
            // 
            txbUser.Location = new Point(174, 52);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(100, 23);
            txbUser.TabIndex = 5;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(174, 117);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(100, 23);
            txbSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(105, 120);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(105, 55);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuário";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(199, 221);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += this.btnLogin_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRegistrar);
            tabPage2.Controls.Add(lblEmailR);
            tabPage2.Controls.Add(lblConfirmarR);
            tabPage2.Controls.Add(lbeSenhaR);
            tabPage2.Controls.Add(lblUserR);
            tabPage2.Controls.Add(txbEmailR);
            tabPage2.Controls.Add(txbConfirmarR);
            tabPage2.Controls.Add(txbSenhaR);
            tabPage2.Controls.Add(txbUserR);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(484, 291);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(203, 228);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblEmailR
            // 
            lblEmailR.AutoSize = true;
            lblEmailR.Location = new Point(104, 170);
            lblEmailR.Name = "lblEmailR";
            lblEmailR.Size = new Size(36, 15);
            lblEmailR.TabIndex = 7;
            lblEmailR.Text = "Email";
            // 
            // lblConfirmarR
            // 
            lblConfirmarR.AutoSize = true;
            lblConfirmarR.Location = new Point(104, 117);
            lblConfirmarR.Name = "lblConfirmarR";
            lblConfirmarR.Size = new Size(61, 15);
            lblConfirmarR.TabIndex = 6;
            lblConfirmarR.Text = "Confirmar";
            // 
            // lbeSenhaR
            // 
            lbeSenhaR.AutoSize = true;
            lbeSenhaR.Location = new Point(104, 68);
            lbeSenhaR.Name = "lbeSenhaR";
            lbeSenhaR.Size = new Size(39, 15);
            lbeSenhaR.TabIndex = 5;
            lbeSenhaR.Text = "Senha";
            // 
            // lblUserR
            // 
            lblUserR.AutoSize = true;
            lblUserR.Location = new Point(104, 18);
            lblUserR.Name = "lblUserR";
            lblUserR.Size = new Size(47, 15);
            lblUserR.TabIndex = 4;
            lblUserR.Text = "Usuário";
            // 
            // txbEmailR
            // 
            txbEmailR.Location = new Point(233, 170);
            txbEmailR.Name = "txbEmailR";
            txbEmailR.Size = new Size(100, 23);
            txbEmailR.TabIndex = 3;
            // 
            // txbConfirmarR
            // 
            txbConfirmarR.Location = new Point(233, 117);
            txbConfirmarR.Name = "txbConfirmarR";
            txbConfirmarR.Size = new Size(100, 23);
            txbConfirmarR.TabIndex = 2;
            // 
            // txbSenhaR
            // 
            txbSenhaR.Location = new Point(233, 68);
            txbSenhaR.Name = "txbSenhaR";
            txbSenhaR.Size = new Size(100, 23);
            txbSenhaR.TabIndex = 1;
            // 
            // txbUserR
            // 
            txbUserR.Location = new Point(233, 18);
            txbUserR.Name = "txbUserR";
            txbUserR.Size = new Size(100, 23);
            txbUserR.TabIndex = 0;
            txbUserR.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
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
        private TabPage tabPage2;
        private Button btnLogin;
        private TextBox txbUser;
        private TextBox txbSenha;
        private Label lblSenha;
        private Label lblUser;
        private TextBox txbEmailR;
        private TextBox txbConfirmarR;
        private TextBox txbSenhaR;
        private TextBox txbUserR;
        private Label lblEmailR;
        private Label lblConfirmarR;
        private Label lbeSenhaR;
        private Label lblUserR;
        private Button btnRegistrar;
    }
}
