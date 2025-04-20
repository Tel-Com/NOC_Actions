using System;
using System.Windows.Forms;

namespace NOCActions
{
    public partial class CONFIG_ComunicacaoComCliente : Form
    {
        private SplitContainer splitContainer1;
        private Label labelCliente, labelEmail, labelUnidade, labelEndereco;
        private Label labelID;
        private ColumnHeader columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1UserID;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label combo;
        private System.Windows.Forms.ComboBox comboNomeCliente;
        private System.Windows.Forms.ComboBox comboEnderecoCliente;
        private System.Windows.Forms.ComboBox comboUnidadeDoCliente;
        private System.Windows.Forms.ComboBox comboRazaoSocialCliente;
        private System.Windows.Forms.ComboBox comboEmailContratoCliente_01;
        private System.Windows.Forms.ListBox listBox_ClientesAdicionados;
        private System.Windows.Forms.ComboBox comboEmailContratoCliente_02;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEmailContratoCliente_03;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Remetente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDuvida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Destinatario;
        private System.Windows.Forms.Button btnSalvarRemetente;
        private System.Windows.Forms.Button btnSalvarDestinatario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;

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
        	this.labelID = new System.Windows.Forms.Label();
        	this.maskedTextBox1UserID = new System.Windows.Forms.MaskedTextBox();
        	this.combo = new System.Windows.Forms.Label();
        	this.comboNomeCliente = new System.Windows.Forms.ComboBox();
        	this.comboEnderecoCliente = new System.Windows.Forms.ComboBox();
        	this.comboUnidadeDoCliente = new System.Windows.Forms.ComboBox();
        	this.comboRazaoSocialCliente = new System.Windows.Forms.ComboBox();
        	this.comboEmailContratoCliente_01 = new System.Windows.Forms.ComboBox();
        	this.listBox_ClientesAdicionados = new System.Windows.Forms.ListBox();
        	this.comboEmailContratoCliente_02 = new System.Windows.Forms.ComboBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.comboEmailContratoCliente_03 = new System.Windows.Forms.ComboBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.comboBox_Remetente = new System.Windows.Forms.ComboBox();
        	this.label9 = new System.Windows.Forms.Label();
        	this.btnDuvida = new System.Windows.Forms.Button();
        	this.label3 = new System.Windows.Forms.Label();
        	this.comboBox_Destinatario = new System.Windows.Forms.ComboBox();
        	this.btnSalvarRemetente = new System.Windows.Forms.Button();
        	this.btnSalvarDestinatario = new System.Windows.Forms.Button();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label11 = new System.Windows.Forms.Label();
        	this.label8 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        	this.splitContainer1.SuspendLayout();
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
        	this.labelEmail.Location = new System.Drawing.Point(30, 298);
        	this.labelEmail.Name = "labelEmail";
        	this.labelEmail.Size = new System.Drawing.Size(97, 21);
        	this.labelEmail.TabIndex = 3;
        	this.labelEmail.Text = "Razão Social";
        	// 
        	// labelUnidade
        	// 
        	this.labelUnidade.AutoSize = true;
        	this.labelUnidade.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelUnidade.Location = new System.Drawing.Point(59, 263);
        	this.labelUnidade.Name = "labelUnidade";
        	this.labelUnidade.Size = new System.Drawing.Size(68, 21);
        	this.labelUnidade.TabIndex = 4;
        	this.labelUnidade.Text = "Unidade";
        	// 
        	// labelEndereco
        	// 
        	this.labelEndereco.AutoSize = true;
        	this.labelEndereco.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelEndereco.Location = new System.Drawing.Point(53, 228);
        	this.labelEndereco.Name = "labelEndereco";
        	this.labelEndereco.Size = new System.Drawing.Size(74, 21);
        	this.labelEndereco.TabIndex = 5;
        	this.labelEndereco.Text = "Endereço";
        	// 
        	// labelCliente
        	// 
        	this.labelCliente.AutoSize = true;
        	this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelCliente.Location = new System.Drawing.Point(257, 192);
        	this.labelCliente.Name = "labelCliente";
        	this.labelCliente.Size = new System.Drawing.Size(58, 21);
        	this.labelCliente.TabIndex = 2;
        	this.labelCliente.Text = "Cliente";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
        	this.label1.Location = new System.Drawing.Point(112, 468);
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
        	this.label2.Location = new System.Drawing.Point(53, 467);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(65, 21);
        	this.label2.TabIndex = 15;
        	this.label2.Text = "Clientes";
        	// 
        	// btnSair
        	// 
        	this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.btnSair.Location = new System.Drawing.Point(551, 677);
        	this.btnSair.Name = "btnSair";
        	this.btnSair.Size = new System.Drawing.Size(102, 48);
        	this.btnSair.TabIndex = 16;
        	this.btnSair.Text = "Sair";
        	this.btnSair.UseVisualStyleBackColor = true;
        	// 
        	// btnSalvar
        	// 
        	this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.btnSalvar.Location = new System.Drawing.Point(269, 677);
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
        	this.btnExcluir.Location = new System.Drawing.Point(399, 677);
        	this.btnExcluir.Name = "btnExcluir";
        	this.btnExcluir.Size = new System.Drawing.Size(124, 51);
        	this.btnExcluir.TabIndex = 18;
        	this.btnExcluir.Text = "Excluir";
        	this.btnExcluir.UseVisualStyleBackColor = true;
        	// 
        	// labelID
        	// 
        	this.labelID.AutoSize = true;
        	this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelID.Location = new System.Drawing.Point(53, 190);
        	this.labelID.Name = "labelID";
        	this.labelID.Size = new System.Drawing.Size(25, 21);
        	this.labelID.TabIndex = 10;
        	this.labelID.Text = "ID";
        	// 
        	// maskedTextBox1UserID
        	// 
        	this.maskedTextBox1UserID.Location = new System.Drawing.Point(141, 192);
        	this.maskedTextBox1UserID.Name = "maskedTextBox1UserID";
        	this.maskedTextBox1UserID.ReadOnly = true;
        	this.maskedTextBox1UserID.Size = new System.Drawing.Size(56, 20);
        	this.maskedTextBox1UserID.TabIndex = 9999;
        	// 
        	// combo
        	// 
        	this.combo.AutoSize = true;
        	this.combo.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.combo.Location = new System.Drawing.Point(73, 373);
        	this.combo.Name = "combo";
        	this.combo.Size = new System.Drawing.Size(67, 21);
        	this.combo.TabIndex = 10009;
        	this.combo.Text = "E-mail 1";
        	// 
        	// comboNomeCliente
        	// 
        	this.comboNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboNomeCliente.FormattingEnabled = true;
        	this.comboNomeCliente.Location = new System.Drawing.Point(321, 195);
        	this.comboNomeCliente.Name = "comboNomeCliente";
        	this.comboNomeCliente.Size = new System.Drawing.Size(332, 25);
        	this.comboNomeCliente.TabIndex = 10012;
        	// 
        	// comboEnderecoCliente
        	// 
        	this.comboEnderecoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboEnderecoCliente.FormattingEnabled = true;
        	this.comboEnderecoCliente.Location = new System.Drawing.Point(141, 231);
        	this.comboEnderecoCliente.Name = "comboEnderecoCliente";
        	this.comboEnderecoCliente.Size = new System.Drawing.Size(512, 25);
        	this.comboEnderecoCliente.TabIndex = 10013;
        	// 
        	// comboUnidadeDoCliente
        	// 
        	this.comboUnidadeDoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboUnidadeDoCliente.FormattingEnabled = true;
        	this.comboUnidadeDoCliente.Location = new System.Drawing.Point(141, 263);
        	this.comboUnidadeDoCliente.Name = "comboUnidadeDoCliente";
        	this.comboUnidadeDoCliente.Size = new System.Drawing.Size(512, 25);
        	this.comboUnidadeDoCliente.TabIndex = 10014;
        	// 
        	// comboRazaoSocialCliente
        	// 
        	this.comboRazaoSocialCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboRazaoSocialCliente.FormattingEnabled = true;
        	this.comboRazaoSocialCliente.Location = new System.Drawing.Point(141, 298);
        	this.comboRazaoSocialCliente.Name = "comboRazaoSocialCliente";
        	this.comboRazaoSocialCliente.Size = new System.Drawing.Size(512, 25);
        	this.comboRazaoSocialCliente.TabIndex = 10015;
        	// 
        	// comboEmailContratoCliente_01
        	// 
        	this.comboEmailContratoCliente_01.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboEmailContratoCliente_01.FormattingEnabled = true;
        	this.comboEmailContratoCliente_01.Location = new System.Drawing.Point(141, 373);
        	this.comboEmailContratoCliente_01.Name = "comboEmailContratoCliente_01";
        	this.comboEmailContratoCliente_01.Size = new System.Drawing.Size(512, 25);
        	this.comboEmailContratoCliente_01.TabIndex = 10016;
        	// 
        	// listBox_ClientesAdicionados
        	// 
        	this.listBox_ClientesAdicionados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.listBox_ClientesAdicionados.FormattingEnabled = true;
        	this.listBox_ClientesAdicionados.ItemHeight = 17;
        	this.listBox_ClientesAdicionados.Location = new System.Drawing.Point(59, 493);
        	this.listBox_ClientesAdicionados.Name = "listBox_ClientesAdicionados";
        	this.listBox_ClientesAdicionados.Size = new System.Drawing.Size(594, 174);
        	this.listBox_ClientesAdicionados.TabIndex = 10017;
        	// 
        	// comboEmailContratoCliente_02
        	// 
        	this.comboEmailContratoCliente_02.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboEmailContratoCliente_02.FormattingEnabled = true;
        	this.comboEmailContratoCliente_02.Location = new System.Drawing.Point(141, 404);
        	this.comboEmailContratoCliente_02.Name = "comboEmailContratoCliente_02";
        	this.comboEmailContratoCliente_02.Size = new System.Drawing.Size(512, 25);
        	this.comboEmailContratoCliente_02.TabIndex = 10019;
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label5.Location = new System.Drawing.Point(73, 404);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(67, 21);
        	this.label5.TabIndex = 10018;
        	this.label5.Text = "E-mail 2";
        	// 
        	// comboEmailContratoCliente_03
        	// 
        	this.comboEmailContratoCliente_03.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboEmailContratoCliente_03.FormattingEnabled = true;
        	this.comboEmailContratoCliente_03.Location = new System.Drawing.Point(141, 435);
        	this.comboEmailContratoCliente_03.Name = "comboEmailContratoCliente_03";
        	this.comboEmailContratoCliente_03.Size = new System.Drawing.Size(512, 25);
        	this.comboEmailContratoCliente_03.TabIndex = 10021;
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label6.Location = new System.Drawing.Point(73, 435);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(67, 21);
        	this.label6.TabIndex = 10020;
        	this.label6.Text = "E-mail 3";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label7.Location = new System.Drawing.Point(30, 338);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(214, 21);
        	this.label7.TabIndex = 10022;
        	this.label7.Text = "Informe os E-mails do Cliente";
        	// 
        	// comboBox_Remetente
        	// 
        	this.comboBox_Remetente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboBox_Remetente.FormattingEnabled = true;
        	this.comboBox_Remetente.Location = new System.Drawing.Point(141, 50);
        	this.comboBox_Remetente.Name = "comboBox_Remetente";
        	this.comboBox_Remetente.Size = new System.Drawing.Size(443, 25);
        	this.comboBox_Remetente.TabIndex = 10024;
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label9.Location = new System.Drawing.Point(33, 52);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(85, 21);
        	this.label9.TabIndex = 10025;
        	this.label9.Text = "Remetente";
        	// 
        	// btnDuvida
        	// 
        	this.btnDuvida.AutoSize = true;
        	this.btnDuvida.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.btnDuvida.Location = new System.Drawing.Point(59, 687);
        	this.btnDuvida.Name = "btnDuvida";
        	this.btnDuvida.Size = new System.Drawing.Size(27, 31);
        	this.btnDuvida.TabIndex = 10027;
        	this.btnDuvida.Text = "?";
        	this.btnDuvida.UseVisualStyleBackColor = true;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label3.Location = new System.Drawing.Point(24, 87);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(94, 21);
        	this.label3.TabIndex = 10029;
        	this.label3.Text = "Destinatário";
        	// 
        	// comboBox_Destinatario
        	// 
        	this.comboBox_Destinatario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.comboBox_Destinatario.FormattingEnabled = true;
        	this.comboBox_Destinatario.Location = new System.Drawing.Point(141, 85);
        	this.comboBox_Destinatario.Name = "comboBox_Destinatario";
        	this.comboBox_Destinatario.Size = new System.Drawing.Size(443, 25);
        	this.comboBox_Destinatario.TabIndex = 10028;
        	// 
        	// btnSalvarRemetente
        	// 
        	this.btnSalvarRemetente.AutoSize = true;
        	this.btnSalvarRemetente.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.btnSalvarRemetente.Location = new System.Drawing.Point(590, 50);
        	this.btnSalvarRemetente.Name = "btnSalvarRemetente";
        	this.btnSalvarRemetente.Size = new System.Drawing.Size(63, 31);
        	this.btnSalvarRemetente.TabIndex = 10030;
        	this.btnSalvarRemetente.Text = "Salvar";
        	this.btnSalvarRemetente.UseVisualStyleBackColor = true;
        	// 
        	// btnSalvarDestinatario
        	// 
        	this.btnSalvarDestinatario.AutoSize = true;
        	this.btnSalvarDestinatario.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.btnSalvarDestinatario.Location = new System.Drawing.Point(590, 85);
        	this.btnSalvarDestinatario.Name = "btnSalvarDestinatario";
        	this.btnSalvarDestinatario.Size = new System.Drawing.Size(63, 31);
        	this.btnSalvarDestinatario.TabIndex = 10031;
        	this.btnSalvarDestinatario.Text = "Salvar";
        	this.btnSalvarDestinatario.UseVisualStyleBackColor = true;
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
        	this.label4.Location = new System.Drawing.Point(0, 119);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(703, 21);
        	this.label4.TabIndex = 10032;
        	this.label4.Text = "_________________________________________________________________________________" +
	"__________________";
        	// 
        	// label11
        	// 
        	this.label11.AutoSize = true;
        	this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label11.Location = new System.Drawing.Point(4, 4);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(226, 25);
        	this.label11.TabIndex = 10033;
        	this.label11.Text = "Adicionar usuário padrão";
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label8.Location = new System.Drawing.Point(4, 144);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(236, 25);
        	this.label8.TabIndex = 10034;
        	this.label8.Text = "Adicionar um novo Cliente";
        	// 
        	// CONFIG_ComunicacaoComCliente
        	// 
        	this.ClientSize = new System.Drawing.Size(693, 766);
        	this.Controls.Add(this.label8);
        	this.Controls.Add(this.label11);
        	this.Controls.Add(this.btnSalvarDestinatario);
        	this.Controls.Add(this.btnSalvarRemetente);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.comboBox_Destinatario);
        	this.Controls.Add(this.btnDuvida);
        	this.Controls.Add(this.label9);
        	this.Controls.Add(this.comboBox_Remetente);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.comboEmailContratoCliente_03);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.comboEmailContratoCliente_02);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.listBox_ClientesAdicionados);
        	this.Controls.Add(this.comboEmailContratoCliente_01);
        	this.Controls.Add(this.comboRazaoSocialCliente);
        	this.Controls.Add(this.comboUnidadeDoCliente);
        	this.Controls.Add(this.comboEnderecoCliente);
        	this.Controls.Add(this.comboNomeCliente);
        	this.Controls.Add(this.combo);
        	this.Controls.Add(this.maskedTextBox1UserID);
        	this.Controls.Add(this.btnExcluir);
        	this.Controls.Add(this.btnSalvar);
        	this.Controls.Add(this.btnSair);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.labelID);
        	this.Controls.Add(this.labelCliente);
        	this.Controls.Add(this.labelEmail);
        	this.Controls.Add(this.labelUnidade);
        	this.Controls.Add(this.labelEndereco);
        	this.Controls.Add(this.label4);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.MaximizeBox = false;
        	this.Name = "CONFIG_ComunicacaoComCliente";
        	this.Text = "Configurações";
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        	this.splitContainer1.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
    }
}