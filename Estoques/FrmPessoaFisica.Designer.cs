namespace Estoques
{
    partial class FrmPessoaFisica
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label maeLabel;
            System.Windows.Forms.Label paiLabel;
            System.Windows.Forms.Label telefoneLabel;
            this.tb_pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maeTextBox = new System.Windows.Forms.TextBox();
            this.paiTextBox = new System.Windows.Forms.TextBox();
            this.tb_pessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            maeLabel = new System.Windows.Forms.Label();
            paiLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(73, 11);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(39, 16);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(75, 37);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(37, 16);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpfLabel.Location = new System.Drawing.Point(90, 94);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(22, 16);
            cpfLabel.TabIndex = 5;
            cpfLabel.Text = "BI:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_nascimentoLabel.Location = new System.Drawing.Point(2, 121);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(112, 16);
            data_nascimentoLabel.TabIndex = 7;
            data_nascimentoLabel.Text = "Data de Nascimento:";
            // 
            // maeLabel
            // 
            maeLabel.AutoSize = true;
            maeLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maeLabel.Location = new System.Drawing.Point(34, 151);
            maeLabel.Name = "maeLabel";
            maeLabel.Size = new System.Drawing.Size(77, 16);
            maeLabel.TabIndex = 9;
            maeLabel.Text = "Nome da Mae:";
            // 
            // paiLabel
            // 
            paiLabel.AutoSize = true;
            paiLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paiLabel.Location = new System.Drawing.Point(39, 182);
            paiLabel.Name = "paiLabel";
            paiLabel.Size = new System.Drawing.Size(72, 16);
            paiLabel.TabIndex = 11;
            paiLabel.Text = "Nome do Pai:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(61, 63);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(53, 16);
            telefoneLabel.TabIndex = 17;
            telefoneLabel.Text = "telefone:";
            // 
            // tb_pessoaBindingSource
            // 
            this.tb_pessoaBindingSource.DataSource = typeof(Estoques.DAL.tb_pessoa);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_pessoaBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(115, 8);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(402, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_pessoaBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(115, 34);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(402, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_pessoaBindingSource, "tb_pessoa_fisica.cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(115, 91);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(220, 20);
            this.cpfTextBox.TabIndex = 4;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_pessoaBindingSource, "tb_pessoa_fisica.data_nascimento", true));
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(112, 117);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(223, 20);
            this.data_nascimentoDateTimePicker.TabIndex = 5;
            // 
            // maeTextBox
            // 
            this.maeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_pessoaBindingSource, "tb_pessoa_fisica.mae", true));
            this.maeTextBox.Location = new System.Drawing.Point(112, 149);
            this.maeTextBox.Name = "maeTextBox";
            this.maeTextBox.Size = new System.Drawing.Size(407, 20);
            this.maeTextBox.TabIndex = 6;
            // 
            // paiTextBox
            // 
            this.paiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_pessoaBindingSource, "tb_pessoa_fisica.pai", true));
            this.paiTextBox.Location = new System.Drawing.Point(111, 179);
            this.paiTextBox.Name = "paiTextBox";
            this.paiTextBox.Size = new System.Drawing.Size(406, 20);
            this.paiTextBox.TabIndex = 7;
            // 
            // tb_pessoaDataGridView
            // 
            this.tb_pessoaDataGridView.AllowUserToAddRows = false;
            this.tb_pessoaDataGridView.AllowUserToDeleteRows = false;
            this.tb_pessoaDataGridView.AutoGenerateColumns = false;
            this.tb_pessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_pessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tb_pessoaDataGridView.DataSource = this.tb_pessoaBindingSource;
            this.tb_pessoaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_pessoaDataGridView.Location = new System.Drawing.Point(20, 351);
            this.tb_pessoaDataGridView.Name = "tb_pessoaDataGridView";
            this.tb_pessoaDataGridView.ReadOnly = true;
            this.tb_pessoaDataGridView.Size = new System.Drawing.Size(509, 220);
            this.tb_pessoaDataGridView.TabIndex = 12;
            this.tb_pessoaDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tb_pessoaDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pessoa";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tb_pessoa_fisica";
            this.dataGridViewTextBoxColumn5.HeaderText = "BI";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(380, 300);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 38);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(174, 300);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(97, 38);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(277, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 38);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(71, 300);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 38);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_pessoaBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(115, 60);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(220, 20);
            this.telefoneTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefoneTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.cpfTextBox);
            this.groupBox1.Controls.Add(cpfLabel);
            this.groupBox1.Controls.Add(this.data_nascimentoDateTimePicker);
            this.groupBox1.Controls.Add(paiLabel);
            this.groupBox1.Controls.Add(data_nascimentoLabel);
            this.groupBox1.Controls.Add(this.paiTextBox);
            this.groupBox1.Controls.Add(this.maeTextBox);
            this.groupBox1.Controls.Add(maeLabel);
            this.groupBox1.Location = new System.Drawing.Point(9, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 231);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            this.groupBox1.Visible = false;
            // 
            // FrmPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tb_pessoaDataGridView);
            this.Name = "FrmPessoaFisica";
            this.Text = ":: Cadastro de Pessoas Fisicas ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCliente_FormClosed);
            this.Load += new System.EventHandler(this.FrmPessoaFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_pessoaBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox maeTextBox;
        private System.Windows.Forms.TextBox paiTextBox;
        private System.Windows.Forms.DataGridView tb_pessoaDataGridView;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}