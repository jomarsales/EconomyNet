using System;
using System.Windows.Forms;
using EconomyNet.Entity;
using EconomyNet.Repository;

namespace EconomyNet.UI
{
    public partial class FrmCategory : Form
    {
        private readonly CategoryRepository _repository;

        public FrmCategory()
        {
            InitializeComponent();

            dgvList.DataSource = null;
            _repository = new CategoryRepository();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show(@"Nome da categoria não informada!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtCategoria.Focus();
                return;
            }

            try
            {
                dgvList.DataSource = null;
                _repository.Save(new Category { CategoryName = txtCategoria.Text });
                dgvList.DataSource = _repository.All();

                txtCategoria.Clear();
                txtCategoria.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show(@"Nome da categoria não informada!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtCategoria.Focus();
                return;
            }

            if (MessageBox.Show(@"Deseja realmente remover este registro?", @"Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            try
            {
                dgvList.DataSource = null;
                _repository.Delete(new Category { CategoryName = txtCategoria.Text });
                dgvList.DataSource = _repository.All();

                txtCategoria.Clear();
                txtCategoria.Enabled = false;
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
                txtCategoria.Text = dgvList.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtCategoria.Enabled = false;
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
            txtCategoria.Clear();
            txtCategoria.Enabled = true;
        }
    }
}
