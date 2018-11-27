namespace Estoques
{
    partial class FrmVenda
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
            System.Windows.Forms.Label id_vendaLabel;
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label id_pessoaLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valor_pagoLabel;
            this.tb_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbPagamento = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.TxtValorPago = new System.Windows.Forms.TextBox();
            this.TxtValorItens = new System.Windows.Forms.TextBox();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnFinPedido = new System.Windows.Forms.Button();
            this.BtnFinaliVenda = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.LblProdutoPesquisado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DtvItens = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_itens_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtCodigoVenda = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.tb_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.id_pessoaComboBox = new System.Windows.Forms.ComboBox();
            this.tb_produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            id_vendaLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            id_pessoaLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valor_pagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_itens_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_vendaLabel.Location = new System.Drawing.Point(102, 20);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(80, 16);
            id_vendaLabel.TabIndex = 0;
            id_vendaLabel.Text = "Codigo Venda:";
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_produtoLabel.Location = new System.Drawing.Point(88, 57);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(93, 16);
            id_produtoLabel.TabIndex = 2;
            id_produtoLabel.Text = "Codigo de Barras";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.Location = new System.Drawing.Point(113, 130);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(70, 16);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(137, 167);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(41, 16);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Preço:";
            // 
            // id_pessoaLabel
            // 
            id_pessoaLabel.AutoSize = true;
            id_pessoaLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_pessoaLabel.Location = new System.Drawing.Point(113, 73);
            id_pessoaLabel.Name = "id_pessoaLabel";
            id_pessoaLabel.Size = new System.Drawing.Size(47, 16);
            id_pessoaLabel.TabIndex = 1;
            id_pessoaLabel.Text = "Cliente:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel1.Location = new System.Drawing.Point(170, 31);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(38, 16);
            valorLabel1.TabIndex = 12;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descontoLabel.Location = new System.Drawing.Point(149, 57);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(59, 16);
            descontoLabel.TabIndex = 13;
            descontoLabel.Text = "Desconto:";
            // 
            // valor_pagoLabel
            // 
            valor_pagoLabel.AutoSize = true;
            valor_pagoLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_pagoLabel.Location = new System.Drawing.Point(143, 87);
            valor_pagoLabel.Name = "valor_pagoLabel";
            valor_pagoLabel.Size = new System.Drawing.Size(65, 16);
            valor_pagoLabel.TabIndex = 14;
            valor_pagoLabel.Text = "Valor pago:";
            // 
            // tb_vendaBindingSource
            // 
            this.tb_vendaBindingSource.DataSource = typeof(Estoques.DAL.tb_venda);
            // 
            // tb_pessoaBindingSource
            // 
            this.tb_pessoaBindingSource.DataSource = typeof(Estoques.DAL.tb_pessoa);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.gbPagamento);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.LblProdutoPesquisado);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DtvItens);
            this.groupBox1.Controls.Add(this.TxtQuantidade);
            this.groupBox1.Controls.Add(this.TxtCodigoVenda);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.TxtValor);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(id_produtoLabel);
            this.groupBox1.Controls.Add(id_vendaLabel);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 647);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(198, 445);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 20);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Cartão";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(112, 444);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 20);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Dinnheiro";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gbPagamento
            // 
            this.gbPagamento.Controls.Add(this.TxtValorPago);
            this.gbPagamento.Controls.Add(this.TxtValorItens);
            this.gbPagamento.Controls.Add(valorLabel1);
            this.gbPagamento.Controls.Add(this.TxtDesconto);
            this.gbPagamento.Controls.Add(descontoLabel);
            this.gbPagamento.Controls.Add(valor_pagoLabel);
            this.gbPagamento.Controls.Add(this.BtnImprimir);
            this.gbPagamento.Controls.Add(this.BtnFinPedido);
            this.gbPagamento.Controls.Add(this.BtnFinaliVenda);
            this.gbPagamento.Enabled = false;
            this.gbPagamento.Location = new System.Drawing.Point(17, 463);
            this.gbPagamento.Name = "gbPagamento";
            this.gbPagamento.Size = new System.Drawing.Size(407, 125);
            this.gbPagamento.TabIndex = 24;
            this.gbPagamento.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(29, 445);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 20);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.Text = "Pendente";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // TxtValorPago
            // 
            this.TxtValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "valor_pago", true));
            this.TxtValorPago.Location = new System.Drawing.Point(209, 87);
            this.TxtValorPago.Name = "TxtValorPago";
            this.TxtValorPago.ReadOnly = true;
            this.TxtValorPago.Size = new System.Drawing.Size(100, 20);
            this.TxtValorPago.TabIndex = 15;
            // 
            // TxtValorItens
            // 
            this.TxtValorItens.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "valor", true));
            this.TxtValorItens.Location = new System.Drawing.Point(209, 28);
            this.TxtValorItens.Name = "TxtValorItens";
            this.TxtValorItens.ReadOnly = true;
            this.TxtValorItens.Size = new System.Drawing.Size(100, 20);
            this.TxtValorItens.TabIndex = 13;
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "desconto", true));
            this.TxtDesconto.Location = new System.Drawing.Point(209, 54);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.ReadOnly = true;
            this.TxtDesconto.Size = new System.Drawing.Size(100, 20);
            this.TxtDesconto.TabIndex = 14;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Enabled = false;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(19, 83);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(105, 23);
            this.BtnImprimir.TabIndex = 18;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnFinPedido
            // 
            this.BtnFinPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinPedido.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinPedido.Location = new System.Drawing.Point(19, 25);
            this.BtnFinPedido.Name = "BtnFinPedido";
            this.BtnFinPedido.Size = new System.Drawing.Size(105, 23);
            this.BtnFinPedido.TabIndex = 16;
            this.BtnFinPedido.Text = "Finalizar Pedido";
            this.BtnFinPedido.UseVisualStyleBackColor = true;
            this.BtnFinPedido.Click += new System.EventHandler(this.BtnFinPedido_Click);
            // 
            // BtnFinaliVenda
            // 
            this.BtnFinaliVenda.Enabled = false;
            this.BtnFinaliVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinaliVenda.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinaliVenda.Location = new System.Drawing.Point(19, 54);
            this.BtnFinaliVenda.Name = "BtnFinaliVenda";
            this.BtnFinaliVenda.Size = new System.Drawing.Size(105, 23);
            this.BtnFinaliVenda.TabIndex = 17;
            this.BtnFinaliVenda.Text = "Finalizar Venda";
            this.BtnFinaliVenda.UseVisualStyleBackColor = true;
            this.BtnFinaliVenda.Click += new System.EventHandler(this.BtnFinaliVenda_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(308, 200);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(167, 43);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(17, 596);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(189, 43);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // LblProdutoPesquisado
            // 
            this.LblProdutoPesquisado.AutoSize = true;
            this.LblProdutoPesquisado.BackColor = System.Drawing.SystemColors.Info;
            this.LblProdutoPesquisado.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProdutoPesquisado.Location = new System.Drawing.Point(183, 90);
            this.LblProdutoPesquisado.Name = "LblProdutoPesquisado";
            this.LblProdutoPesquisado.Size = new System.Drawing.Size(0, 24);
            this.LblProdutoPesquisado.TabIndex = 21;
            this.LblProdutoPesquisado.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(91, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // DtvItens
            // 
            this.DtvItens.AllowUserToAddRows = false;
            this.DtvItens.AllowUserToDeleteRows = false;
            this.DtvItens.AutoGenerateColumns = false;
            this.DtvItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DtvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.DtvItens.DataSource = this.tb_itens_vendaBindingSource;
            this.DtvItens.Location = new System.Drawing.Point(11, 249);
            this.DtvItens.Name = "DtvItens";
            this.DtvItens.ReadOnly = true;
            this.DtvItens.Size = new System.Drawing.Size(583, 190);
            this.DtvItens.TabIndex = 12;
            this.DtvItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtvItens_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = " ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tb_produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Qtd";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tb_itens_vendaBindingSource
            // 
            this.tb_itens_vendaBindingSource.DataSource = typeof(Estoques.DAL.tb_itens_venda);
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_itens_vendaBindingSource, "quantidade", true));
            this.TxtQuantidade.Enabled = false;
            this.TxtQuantidade.Location = new System.Drawing.Point(180, 127);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidade.TabIndex = 12;
            // 
            // TxtCodigoVenda
            // 
            this.TxtCodigoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "id_venda", true));
            this.TxtCodigoVenda.Location = new System.Drawing.Point(183, 17);
            this.TxtCodigoVenda.Name = "TxtCodigoVenda";
            this.TxtCodigoVenda.ReadOnly = true;
            this.TxtCodigoVenda.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoVenda.TabIndex = 10;
            // 
            // TxtValor
            // 
            this.TxtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_itens_vendaBindingSource, "valor", true));
            this.TxtValor.Location = new System.Drawing.Point(180, 165);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(134, 20);
            this.TxtValor.TabIndex = 7;
            // 
            // tb_produtoBindingSource
            // 
            this.tb_produtoBindingSource.DataSource = typeof(Estoques.DAL.tb_produto);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_pessoaComboBox
            // 
            this.id_pessoaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_vendaBindingSource, "id_pessoa", true));
            this.id_pessoaComboBox.DataSource = this.tb_pessoaBindingSource;
            this.id_pessoaComboBox.DisplayMember = "nome";
            this.id_pessoaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_pessoaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.id_pessoaComboBox.FormattingEnabled = true;
            this.id_pessoaComboBox.Location = new System.Drawing.Point(161, 69);
            this.id_pessoaComboBox.Name = "id_pessoaComboBox";
            this.id_pessoaComboBox.Size = new System.Drawing.Size(306, 21);
            this.id_pessoaComboBox.TabIndex = 6;
            this.id_pessoaComboBox.ValueMember = "id_pessoa";
            this.id_pessoaComboBox.DropDown += new System.EventHandler(this.id_pessoaComboBox_DropDown);
            // 
            // tb_produtoBindingSource1
            // 
            this.tb_produtoBindingSource1.DataSource = typeof(Estoques.DAL.tb_produto);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Novo Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 754);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.id_pessoaComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_pessoaLabel);
            this.Name = "FrmVenda";
            this.Text = ":: Vendas ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVenda_FormClosed);
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPagamento.ResumeLayout(false);
            this.gbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_itens_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_vendaBindingSource;
        private System.Windows.Forms.BindingSource tb_pessoaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tb_itens_vendaBindingSource;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox id_pessoaComboBox;
        private System.Windows.Forms.DataGridView DtvItens;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtCodigoVenda;
        private System.Windows.Forms.BindingSource tb_produtoBindingSource1;
        private System.Windows.Forms.BindingSource tb_produtoBindingSource;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnFinaliVenda;
        private System.Windows.Forms.Button BtnFinPedido;
        private System.Windows.Forms.TextBox TxtValorPago;
        private System.Windows.Forms.TextBox TxtDesconto;
        private System.Windows.Forms.TextBox TxtValorItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblProdutoPesquisado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbPagamento;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}