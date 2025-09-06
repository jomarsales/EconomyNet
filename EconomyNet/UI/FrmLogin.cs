using EconomyNet.Service;
using System;
using System.Windows.Forms;

namespace EconomyNet.UI
{
    public partial class FrmLogin : Form
    {
        public bool Authenticated { get; private set; }
        public string User { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show(@"Usuário não informado!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show(@"Senha não informada!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtSenha.Focus();
                return;
            }

            try
            {
                Authenticated = AutenticateManager.Login(txtUsuario.Text, txtSenha.Text);
                User = Authenticated ? txtUsuario.Text : string.Empty;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
