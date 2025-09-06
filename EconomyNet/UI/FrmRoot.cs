using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EconomyNet.Entity;
using EconomyNet.Repository;

namespace EconomyNet.UI
{
    public partial class FrmRoot : Form
    {
        private readonly RecordRepository _repository;
        private List<Record> _records;

        private void Pesquisar(DateTime dtInicial, DateTime dtFinal, bool efetivadas)
        {
            _repository.Read();

            _records = efetivadas ?
                _repository.All().Where(r => r.PaymentDate >= dtInicial && r.PaymentDate <= dtFinal && r.PaidOut).OrderByDescending(r => r.CreationDate).ToList() :
                _repository.All().Where(r => r.PaymentDate >= dtInicial && r.PaymentDate <= dtFinal).OrderByDescending(r => r.CreationDate).ToList();
        }

        private void MontarControles()
        {
            dgvListIn.DataSource = null;
            dgvListOut.DataSource = null;

            var rIn = _records.Where(r => r.Type == (byte)RecordType.In).ToList();
            var rOut = _records.Where(r => r.Type == (byte)RecordType.Out).ToList();

            dgvListIn.DataSource = rIn;
            dgvListOut.DataSource = rOut;

            var totIn = rIn.Sum(r => r.Price);
            var totOut = rOut.Sum(r => r.Price);
            var saldo = totIn - totOut;

            lblTotalEntradas.Text = totIn.ToString("C");
            lblTotalSaidas.Text = totOut.ToString("C");
            lblSaldo.Text = saldo.ToString("C");

            if (saldo < 0)
                lblSaldo.ForeColor = Color.DarkRed;
            else if (saldo > 0)
                lblSaldo.ForeColor = Color.DarkGreen;
            else
                lblSaldo.ForeColor = Color.Black;
        }

        public FrmRoot()
        {
            InitializeComponent();

            _repository = new RecordRepository();
            _records = new List<Record>();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("F");
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmUsers();
            frm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCategory();
            frm.ShowDialog();
        }

        private void FrmRoot_Load(object sender, EventArgs e)
        {
            txtDataInicial.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            txtDataFinal.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            cbEfetivadas.Checked = false;

            Pesquisar(txtDataInicial.Value, txtDataFinal.Value, cbEfetivadas.Checked);
            MontarControles();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(txtDataInicial.Value, txtDataFinal.Value, cbEfetivadas.Checked);
            MontarControles();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new FrmRecord();
            frm.ShowDialog();

            Pesquisar(txtDataInicial.Value, txtDataFinal.Value, cbEfetivadas.Checked);
            MontarControles();
        }

        private void dgvListDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var record = _repository.Find((sender as DataGridView)?.CurrentRow?.Cells[0].Value?.ToString());

            var frm = new FrmRecord(record);
            frm.ShowDialog();

            Pesquisar(txtDataInicial.Value, txtDataFinal.Value, cbEfetivadas.Checked);
            MontarControles();
        }

        private void dgvListClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(sender is DataGridView grid)) return;

            var row = e.RowIndex;

            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();

            try
            {
                ch1 = grid.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
            }
            catch
            {
                //ignore
            }

            if (ch1 != null)
            {
                var record = _repository.Find(grid.Rows[e.RowIndex].Cells[0].Value?.ToString());

                record.PaidOut = !record.PaidOut;

                _repository.Save(record);
                _repository.Write();

                Pesquisar(txtDataInicial.Value, txtDataFinal.Value, cbEfetivadas.Checked);
                MontarControles();
            }

            grid.Rows[row].Selected = true;
        }
    }
}
