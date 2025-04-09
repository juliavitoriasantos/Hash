using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Hash;

namespace Hash
{
    public partial class LogReg : Form
    {
        public LogReg()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //variaveis locais para tratar o usuario e a senha
            string usuario = txtUserL.Text;
            string senha = Crypto.sha256encrypt(txtSenhaL.Text);

            //percorre cada tabela do banco de dados
            foreach (DataRow row in LoginsDataSet.Acessos)
            {
                //e verifica pelo usuário e senha que coincidem
                if (row.ItemArray[1].Equals(usuario) && row.ItemArray[2].Equals(senha))
                {
                    txtUserL.Text = String.Empty;
                    txtSenhaL.Text = String.Empty;
                    MessageBox.Show("Login realizado com sucesso !");
                    break;
                }
                //Se não achar então
                else
                {
                    MessageBox.Show("Usuário/Senha incorretos");
                    break;
                }
            }
        }
    }
}
