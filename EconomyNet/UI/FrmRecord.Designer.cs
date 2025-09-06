namespace EconomyNet.UI
{
    partial class FrmRecord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEfetivado = new System.Windows.Forms.CheckBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(563, 38);
            this.panel1.TabIndex = 1;
            // 
            // btnApagar
            // 
            this.btnApagar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnApagar.Location = new System.Drawing.Point(373, 6);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(92, 26);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Remover";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(465, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCategorias);
            this.groupBox1.Controls.Add(this.txtVencimento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbEfetivado);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCategorias);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTipos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(507, 116);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(36, 23);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.TabStop = false;
            this.btnCategorias.Text = "...";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // txtVencimento
            // 
            this.txtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimento.Location = new System.Drawing.Point(305, 156);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(123, 20);
            this.txtVencimento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vencimento";
            // 
            // cbEfetivado
            // 
            this.cbEfetivado.AutoSize = true;
            this.cbEfetivado.Location = new System.Drawing.Point(472, 158);
            this.cbEfetivado.Name = "cbEfetivado";
            this.cbEfetivado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbEfetivado.Size = new System.Drawing.Size(71, 17);
            this.cbEfetivado.TabIndex = 11;
            this.cbEfetivado.Text = "Efetivado";
            this.cbEfetivado.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(70, 156);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(151, 20);
            this.txtValor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(305, 117);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(202, 21);
            this.cbCategorias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // cbTipos
            // 
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(70, 117);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(151, 21);
            this.cbTipos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(70, 34);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(473, 69);
            this.txtDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // FrmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada/Saída";
            this.Load += new System.EventHandler(this.FrmRecord_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbEfetivado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCategorias;
    }
}