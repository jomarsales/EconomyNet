namespace EconomyNet.UI
{
    partial class FrmRoot
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUserNme = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarReceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarDespesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbEfetivadas = new System.Windows.Forms.CheckBox();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListIn = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvListOut = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalSaidas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListIn)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOut)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserNme,
            this.toolStripStatusLabel1,
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUserNme
            // 
            this.lblUserNme.Name = "lblUserNme";
            this.lblUserNme.Size = new System.Drawing.Size(65, 17);
            this.lblUserNme.Text = "User Name";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel1.Text = "  |  ";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 17);
            this.lblData.Text = "Date/Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recebimentosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.adicionarReceitaToolStripMenuItem,
            this.adicionarDespesaToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // recebimentosToolStripMenuItem
            // 
            this.recebimentosToolStripMenuItem.Name = "recebimentosToolStripMenuItem";
            this.recebimentosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.recebimentosToolStripMenuItem.Text = "Receitas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.comprasToolStripMenuItem.Text = "Despesas";
            // 
            // adicionarReceitaToolStripMenuItem
            // 
            this.adicionarReceitaToolStripMenuItem.Name = "adicionarReceitaToolStripMenuItem";
            this.adicionarReceitaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.adicionarReceitaToolStripMenuItem.Text = "Adicionar Receita";
            // 
            // adicionarDespesaToolStripMenuItem
            // 
            this.adicionarDespesaToolStripMenuItem.Name = "adicionarDespesaToolStripMenuItem";
            this.adicionarDespesaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.adicionarDespesaToolStripMenuItem.Text = "Adicionar Despesa";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cbEfetivadas);
            this.groupBox1.Controls.Add(this.txtDataFinal);
            this.groupBox1.Controls.Add(this.txtDataInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::EconomyNet.Properties.Resources.new_folder;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(683, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 37);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::EconomyNet.Properties.Resources.edit_find;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(637, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 37);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbEfetivadas
            // 
            this.cbEfetivadas.AutoSize = true;
            this.cbEfetivadas.Location = new System.Drawing.Point(498, 23);
            this.cbEfetivadas.Name = "cbEfetivadas";
            this.cbEfetivadas.Size = new System.Drawing.Size(111, 17);
            this.cbEfetivadas.TabIndex = 5;
            this.cbEfetivadas.Text = "Só as efetivadas?";
            this.cbEfetivadas.UseVisualStyleBackColor = true;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(325, 21);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(137, 20);
            this.txtDataFinal.TabIndex = 3;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(111, 21);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(137, 20);
            this.txtDataInicial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListIn);
            this.groupBox2.Location = new System.Drawing.Point(5, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 240);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entradas";
            // 
            // dgvListIn
            // 
            this.dgvListIn.AllowUserToAddRows = false;
            this.dgvListIn.AllowUserToDeleteRows = false;
            this.dgvListIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListIn.Location = new System.Drawing.Point(3, 16);
            this.dgvListIn.MultiSelect = false;
            this.dgvListIn.Name = "dgvListIn";
            this.dgvListIn.ReadOnly = true;
            this.dgvListIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListIn.Size = new System.Drawing.Size(969, 221);
            this.dgvListIn.TabIndex = 1;
            this.dgvListIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListClick);
            this.dgvListIn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvListOut);
            this.groupBox3.Location = new System.Drawing.Point(5, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(975, 234);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saídas";
            // 
            // dgvListOut
            // 
            this.dgvListOut.AllowUserToAddRows = false;
            this.dgvListOut.AllowUserToDeleteRows = false;
            this.dgvListOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListOut.Location = new System.Drawing.Point(3, 16);
            this.dgvListOut.MultiSelect = false;
            this.dgvListOut.Name = "dgvListOut";
            this.dgvListOut.ReadOnly = true;
            this.dgvListOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOut.Size = new System.Drawing.Size(969, 215);
            this.dgvListOut.TabIndex = 2;
            this.dgvListOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListClick);
            this.dgvListOut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalSaidas);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblSaldo);
            this.groupBox4.Controls.Add(this.lblTotalEntradas);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 561);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(984, 58);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resumo";
            // 
            // lblTotalSaidas
            // 
            this.lblTotalSaidas.AutoSize = true;
            this.lblTotalSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaidas.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalSaidas.Location = new System.Drawing.Point(442, 19);
            this.lblTotalSaidas.Name = "lblTotalSaidas";
            this.lblTotalSaidas.Size = new System.Drawing.Size(94, 25);
            this.lblTotalSaidas.TabIndex = 5;
            this.lblTotalSaidas.Text = "R$ 0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total saídas";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(761, 19);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(94, 25);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "R$ 0,00";
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalEntradas.Location = new System.Drawing.Point(148, 19);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(94, 25);
            this.lblTotalEntradas.TabIndex = 2;
            this.lblTotalEntradas.Text = "R$ 0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saldo atual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total entradas";
            // 
            // FrmRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 680);
            this.Name = "FrmRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area de Trabalho";
            this.Load += new System.EventHandler(this.FrmRoot_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListIn)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOut)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserNme;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarReceitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarDespesaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvListIn;
        private System.Windows.Forms.DataGridView dgvListOut;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbEfetivadas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblTotalSaidas;
        private System.Windows.Forms.Label label6;
    }
}

