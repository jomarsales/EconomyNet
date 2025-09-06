using System;
using System.Windows.Forms;
using EconomyNet.Entity;
using EconomyNet.Repository;

namespace EconomyNet.UI
{
    public partial class FrmUsers : Form
    {
        private readonly UserRepository _repository;

        public FrmUsers()
        {
            InitializeComponent();

            dgvList.DataSource = null;
            _repository = new UserRepository();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
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
                dgvList.DataSource = null;
                _repository.Save(new User { UserName = txtUsuario.Text, Password = txtSenha.Text });
                dgvList.DataSource = _repository.All();

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show(@"Usuário não informado!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtUsuario.Focus();
                return;
            }

            if (MessageBox.Show(@"Deseja realmente remover este registro?", @"Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            try
            {
                dgvList.DataSource = null;
                _repository.Delete(new User { UserName = txtUsuario.Text, Password = txtSenha.Text });
                dgvList.DataSource = _repository.All();

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUsuario.Text = dgvList.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtSenha.Text = dgvList.Rows[e.RowIndex].Cells[1].Value?.ToString();

                txtUsuario.Enabled = false;
                txtSenha.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = _repository.All();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }
    }
}
