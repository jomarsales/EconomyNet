using System;
using System.Windows.Forms;
using EconomyNet.Entity;
using EconomyNet.Repository;

namespace EconomyNet.UI
{
    public partial class FrmRecord : Form
    {
        private readonly CategoryRepository _catRepository;
        private readonly RecordRepository _repository;
        private Record _record;

        private void MontarControles()
        {
            if (cbTipos.Items.Count == 0)
            {
                cbTipos.Items.Add("...");
                cbTipos.Items.Add("Entrada");
                cbTipos.Items.Add("Saída");
            }

            MontarCategorias();

            txtDescricao.Text = _record?.Description ?? string.Empty;

            if (cbTipos.Items.Count > 0 && _record != null)
                cbTipos.SelectedIndex = _record.Type;
            else
                cbTipos.SelectedIndex = 0;

            if (cbCategorias.Items.Count > 0 && _record != null)
                cbCategorias.SelectedIndex = cbCategorias.FindString(_record.Category);
            else
                cbCategorias.SelectedIndex = 0;

            txtValor.Text = (_record?.Price ?? 0M).ToString("N2");
            txtVencimento.Value = _record?.PaymentDate ?? DateTime.Today;
            cbEfetivado.Checked = _record?.PaidOut ?? false;
        }

        private void MontarCategorias()
        {
            if (cbCategorias.Items.Count == 0)
            {
                cbCategorias.Items.Add("...");
                var categorias = _catRepository.All();
                foreach (var category in categorias)
                    cbCategorias.Items.Add(category.CategoryName);
            }
        }

        public FrmRecord(Record record = null)
        {
            InitializeComponent();
            _catRepository = new CategoryRepository();
            _repository = new RecordRepository();
            _record = record;

            btnApagar.Enabled = _record != null;
        }

        private void FrmRecord_Load(object sender, EventArgs e)
        {
            MontarControles();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (_record == null)
            {
                MessageBox.Show(@"Registro não encontrado!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Close();
                return;
            }

            if (MessageBox.Show(@"Deseja realmente remover este registro?", @"Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            try
            {
                _repository.Delete(_record);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show(@"Descrição não informada!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
                return;
            }

            if (cbTipos.SelectedIndex == 0)
            {
                MessageBox.Show(@"Tipo da transação não informado!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                cbTipos.Focus();
                return;
            }

            if (cbCategorias.SelectedIndex == 0)
            {
                MessageBox.Show(@"Categoria não informada!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                cbCategorias.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show(@"Valor não informado!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
                return;
            }

            if (!decimal.TryParse(txtValor.Text, out var valor) || valor <= 0)
            {
                MessageBox.Show(@"Valor inválido!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
                return;
            }

            if (txtVencimento?.Value == null || txtVencimento.Value < DateTime.Today)
            {
                MessageBox.Show(@"Data de Vencimento inválida!", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
                return;
            }

            if (_record == null)
                _record = new Record();

            _record.Description = txtDescricao.Text;
            _record.Type = (byte)cbTipos.SelectedIndex;
            _record.Category = cbCategorias.Text;
            _record.Price = valor;
            _record.CreationDate = DateTime.Now;
            _record.PaymentDate = txtVencimento.Value;
            _record.PaidOut = cbEfetivado.Checked;

            try
            {
                _repository.Save(_record);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var frm = new FrmCategory();
            frm.ShowDialog();

            cbCategorias.Items.Clear();
            MontarCategorias();
            cbCategorias.Focus();
        }
    }
}
