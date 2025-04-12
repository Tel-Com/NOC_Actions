using System;
using System.Windows.Forms;

namespace NOCActions
{
    public partial class CONFIG_ComunicacaoComCliente : Form
    {
        private SplitContainer splitContainer1;
        private Label labelCliente, labelEmail, labelUnidade, labelEndereco, labelInfo;
        private Label labelID;
        private ColumnHeader columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1UserID;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label combo;
        private System.Windows.Forms.DataGridView listaDeClientesSalvos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
        private System.Windows.Forms.ComboBox comboNomeCliente;
        private System.Windows.Forms.ComboBox comboEnderecoCliente;
        private System.Windows.Forms.ComboBox comboUnidadeDoCliente;
        private System.Windows.Forms.ComboBox comboRazaoSocialCliente;
        private System.Windows.Forms.ComboBox comboEmailContratoCliente;

//        public CONFIG_ComunicacaoComCliente()
//        {
//            InitializeComponent();
//        }

        private void InitializeComponent()
        {
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.labelEmail = new System.Windows.Forms.Label();
        	this.labelUnidade = new System.Windows.Forms.Label();
        	this.labelEndereco = new System.Windows.Forms.Label();
        	this.labelInfo = new System.Windows.Forms.Label();
        	this.labelCliente = new System.Windows.Forms.Label();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.btnSair = new System.Windows.Forms.Button();
        	this.btnSalvar = new System.Windows.Forms.Button();
        	this.btnExcluir = new System.Windows.Forms.Button();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.labelID = new System.Windows.Forms.Label();
        	this.maskedTextBox1UserID = new System.Windows.Forms.MaskedTextBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.combo = new System.Windows.Forms.Label();
        	this.listaDeClientesSalvos = new System.Windows.Forms.DataGridView();
        	this.Column_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column_Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.comboNomeCliente = new System.Windows.Forms.ComboBox();
        	this.comboEnderecoCliente = new System.Windows.Forms.ComboBox();
        	this.comboUnidadeDoCliente = new System.Windows.Forms.ComboBox();
        	this.comboRazaoSocialCliente = new System.Windows.Forms.ComboBox();
        	this.comboEmailContratoCliente = new System.Windows.Forms.ComboBox();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        	this.splitContainer1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.listaDeClientesSalvos)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// splitContainer1
        	// 
        	this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        	this.splitContainer1.Name = "splitContainer1";
        	this.splitContainer1.Size = new System.Drawing.Size(150, 100);
        	this.splitContainer1.TabIndex = 0;
        	// 
        	// labelEmail
        	// 
        	this.labelEmail.AutoSize = true;
        	this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelEmail.Location = new System.Drawing.Point(30, 132);
        	this.labelEmail.Name = "labelEmail";
        	this.labelEmail.Size = new System.Drawing.Size(97, 21);
        	this.labelEmail.TabIndex = 3;
        	this.labelEmail.Text = "Razão Social";
        	// 
        	// labelUnidade
        	// 
        	this.labelUnidade.AutoSize = true;
        	this.labelUnidade.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelUnidade.Location = new System.Drawing.Point(59, 97);
        	this.labelUnidade.Name = "labelUnidade";
        	this.labelUnidade.Size = new System.Drawing.Size(68, 21);
        	this.labelUnidade.TabIndex = 4;
        	this.labelUnidade.Text = "Unidade";
        	// 
        	// labelEndereco
        	// 
        	this.labelEndereco.AutoSize = true;
        	this.labelEndereco.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelEndereco.Location = new System.Drawing.Point(53, 62);
        	this.labelEndereco.Name = "labelEndereco";
        	this.labelEndereco.Size = new System.Drawing.Size(74, 21);
        	this.labelEndereco.TabIndex = 5;
        	this.labelEndereco.Text = "Endereço";
        	// 
        	// labelInfo
        	// 
        	this.labelInfo.AutoSize = true;
        	this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelInfo.ForeColor = System.Drawing.Color.Red;
        	this.labelInfo.Location = new System.Drawing.Point(59, 544);
        	this.labelInfo.Name = "labelInfo";
        	this.labelInfo.Size = new System.Drawing.Size(594, 13);
        	this.labelInfo.TabIndex = 1;
        	this.labelInfo.Text = "ADICIONAR NFORMAÇÕES DO CLIENTE E CONTRATO PARA CONTATAR VIA MENSAGEM DE EMAIL";
        	// 
        	// labelCliente
        	// 
        	this.labelCliente.AutoSize = true;
        	this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelCliente.Location = new System.Drawing.Point(257, 26);
        	this.labelCliente.Name = "labelCliente";
        	this.labelCliente.Size = new System.Drawing.Size(58, 21);
        	this.labelCliente.TabIndex = 2;
        	this.labelCliente.Text = "Cliente";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
        	this.label1.Location = new System.Drawing.Point(112, 212);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(541, 13);
        	this.label1.TabIndex = 14;
        	this.label1.Text = "_________________________________________________________________________________" +
	"________";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label2.Location = new System.Drawing.Point(53, 211);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(65, 21);
        	this.label2.TabIndex = 15;
        	this.label2.Text = "Clientes";
        	// 
        	// btnSair
        	// 
        	this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.btnSair.Location = new System.Drawing.Point(551, 425);
        	this.btnSair.Name = "btnSair";
        	this.btnSair.Size = new System.Drawing.Size(102, 48);
        	this.btnSair.TabIndex = 16;
        	this.btnSair.Text = "Sair";
        	this.btnSair.UseVisualStyleBackColor = true;
        	// 
        	// btnSalvar
        	// 
        	this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.btnSalvar.Location = new System.Drawing.Point(269, 425);
        	this.btnSalvar.Name = "btnSalvar";
        	this.btnSalvar.Size = new System.Drawing.Size(124, 51);
        	this.btnSalvar.TabIndex = 17;
        	this.btnSalvar.Text = "Salvar";
        	this.btnSalvar.UseVisualStyleBackColor = true;
        	this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
        	// 
        	// btnExcluir
        	// 
        	this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.btnExcluir.Location = new System.Drawing.Point(399, 425);
        	this.btnExcluir.Name = "btnExcluir";
        	this.btnExcluir.Size = new System.Drawing.Size(124, 51);
        	this.btnExcluir.TabIndex = 18;
        	this.btnExcluir.Text = "Excluir";
        	this.btnExcluir.UseVisualStyleBackColor = true;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.Red;
        	this.label3.Location = new System.Drawing.Point(53, 499);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(21, 13);
        	this.label3.TabIndex = 10004;
        	this.label3.Text = "01";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.Red;
        	this.label4.Location = new System.Drawing.Point(346, 531);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(277, 13);
        	this.label4.TabIndex = 10005;
        	this.label4.Text = "feat: sistema de cadastro e listagem de clientes";
        	// 
        	// labelID
        	// 
        	this.labelID.AutoSize = true;
        	this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelID.Location = new System.Drawing.Point(53, 24);
        	this.labelID.Name = "labelID";
        	this.labelID.Size = new System.Drawing.Size(25, 21);
        	this.labelID.TabIndex = 10;
        	this.labelID.Text = "ID";
        	// 
        	// maskedTextBox1UserID
        	// 
        	this.maskedTextBox1UserID.Location = new System.Drawing.Point(141, 26);
        	this.maskedTextBox1UserID.Name = "maskedTextBox1UserID";
        	this.maskedTextBox1UserID.ReadOnly = true;
        	this.maskedTextBox1UserID.Size = new System.Drawing.Size(56, 20);
        	this.maskedTextBox1UserID.TabIndex = 9999;
        	// 
        	// button1
        	// 
        	this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.button1.Location = new System.Drawing.Point(139, 425);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(124, 51);
        	this.button1.TabIndex = 10008;
        	this.button1.Text = "Modelo E-mail";
        	this.button1.UseVisualStyleBackColor = true;
        	// 
        	// combo
        	// 
        	this.combo.AutoSize = true;
        	this.combo.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.combo.Location = new System.Drawing.Point(73, 167);
        	this.combo.Name = "combo";
        	this.combo.Size = new System.Drawing.Size(54, 21);
        	this.combo.TabIndex = 10009;
        	this.combo.Text = "E-mail";
        	// 
        	// listaDeClientesSalvos
        	// 
        	this.listaDeClientesSalvos.AllowUserToAddRows = false;
        	this.listaDeClientesSalvos.AllowUserToOrderColumns = true;
        	this.listaDeClientesSalvos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.listaDeClientesSalvos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column_Cliente,
			this.Column_Unidade,
			this.Column_Email});
        	this.listaDeClientesSalvos.Location = new System.Drawing.Point(59, 244);
        	this.listaDeClientesSalvos.Name = "listaDeClientesSalvos";
        	this.listaDeClientesSalvos.ReadOnly = true;
        	this.listaDeClientesSalvos.Size = new System.Drawing.Size(594, 168);
        	this.listaDeClientesSalvos.TabIndex = 10011;
        	this.listaDeClientesSalvos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDeClientesSalvosCellContentClick);
        	// 
        	// Column_Cliente
        	// 
        	this.Column_Cliente.HeaderText = "Cliente";
        	this.Column_Cliente.Name = "Column_Cliente";
        	this.Column_Cliente.ReadOnly = true;
        	// 
        	// Column_Unidade
        	// 
        	this.Column_Unidade.HeaderText = "Unidade";
        	this.Column_Unidade.Name = "Column_Unidade";
        	this.Column_Unidade.ReadOnly = true;
        	// 
        	// Column_Email
        	// 
        	this.Column_Email.HeaderText = "E-mail de Contato";
        	this.Column_Email.Name = "Column_Email";
        	this.Column_Email.ReadOnly = true;
        	// 
        	// comboNomeCliente
        	// 
        	this.comboNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboNomeCliente.FormattingEnabled = true;
        	this.comboNomeCliente.Location = new System.Drawing.Point(321, 29);
        	this.comboNomeCliente.Name = "comboNomeCliente";
        	this.comboNomeCliente.Size = new System.Drawing.Size(332, 25);
        	this.comboNomeCliente.TabIndex = 10012;
        	// 
        	// comboEnderecoCliente
        	// 
        	this.comboEnderecoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboEnderecoCliente.FormattingEnabled = true;
        	this.comboEnderecoCliente.Location = new System.Drawing.Point(141, 65);
        	this.comboEnderecoCliente.Name = "comboEnderecoCliente";
        	this.comboEnderecoCliente.Size = new System.Drawing.Size(512, 25);
        	this.comboEnderecoCliente.TabIndex = 10013;
        	// 
        	// comboUnidadeDoCliente
        	// 
        	this.comboUnidadeDoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboUnidadeDoCliente.FormattingEnabled = true;
        	this.comboUnidadeDoCliente.Location = new System.Drawing.Point(141, 97);
        	this.comboUnidadeDoCliente.Name = "comboUnidadeDoCliente";
        	this.comboUnidadeDoCliente.Size = new System.Drawing.Size(512, 25);
        	this.comboUnidadeDoCliente.TabIndex = 10014;
        	// 
        	// comboRazaoSocialCliente
        	// 
        	this.comboRazaoSocialCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboRazaoSocialCliente.FormattingEnabled = true;
        	this.comboRazaoSocialCliente.Location = new System.Drawing.Point(139, 132);
        	this.comboRazaoSocialCliente.Name = "comboRazaoSocialCliente";
        	this.comboRazaoSocialCliente.Size = new System.Drawing.Size(514, 25);
        	this.comboRazaoSocialCliente.TabIndex = 10015;
        	// 
        	// comboEmailContratoCliente
        	// 
        	this.comboEmailContratoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboEmailContratoCliente.FormattingEnabled = true;
        	this.comboEmailContratoCliente.Location = new System.Drawing.Point(139, 167);
        	this.comboEmailContratoCliente.Name = "comboEmailContratoCliente";
        	this.comboEmailContratoCliente.Size = new System.Drawing.Size(514, 25);
        	this.comboEmailContratoCliente.TabIndex = 10016;
        	// 
        	// CONFIG_ComunicacaoComCliente
        	// 
        	this.ClientSize = new System.Drawing.Size(701, 566);
        	this.Controls.Add(this.comboEmailContratoCliente);
        	this.Controls.Add(this.comboRazaoSocialCliente);
        	this.Controls.Add(this.comboUnidadeDoCliente);
        	this.Controls.Add(this.comboEnderecoCliente);
        	this.Controls.Add(this.comboNomeCliente);
        	this.Controls.Add(this.listaDeClientesSalvos);
        	this.Controls.Add(this.combo);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.maskedTextBox1UserID);
        	this.Controls.Add(this.btnExcluir);
        	this.Controls.Add(this.btnSalvar);
        	this.Controls.Add(this.btnSair);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.labelID);
        	this.Controls.Add(this.labelInfo);
        	this.Controls.Add(this.labelCliente);
        	this.Controls.Add(this.labelEmail);
        	this.Controls.Add(this.labelUnidade);
        	this.Controls.Add(this.labelEndereco);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MaximizeBox = false;
        	this.Name = "CONFIG_ComunicacaoComCliente";
        	this.Text = "Adicionar Novo Cliente";
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        	this.splitContainer1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.listaDeClientesSalvos)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
    }
}