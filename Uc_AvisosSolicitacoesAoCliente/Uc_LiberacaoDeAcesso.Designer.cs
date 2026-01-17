/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 06/12/2025
 * Hora: 13:38
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Actions
{
	partial class Uc_LiberacaoDeAcesso
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnGerarAlerta;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnSalvarECopiar;
		private System.Windows.Forms.Button btnApagarCampos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_nomeEquipeTecnica;
        private System.Windows.Forms.Label labelNomeEqTecnica;
		private System.Windows.Forms.Label labelOperadora;
		private System.Windows.Forms.ComboBox comboBox_operadoraResponsavel;
        private System.Windows.Forms.ComboBox comboBox_previaoDeChegada;
        private System.Windows.Forms.Label labelChegada;
		private System.Windows.Forms.ComboBox comboBox_unidadeParaLiberacaoDeAcesso;
        private System.Windows.Forms.Label labelUnidade;
		private System.Windows.Forms.Label labelEnderecoDaUnidade;
		private System.Windows.Forms.ComboBox comboBox_enderecoDaUnidadeResponsavel;
        private System.Windows.Forms.RichTextBox richTextBox_mensagemASerEncaminhadaAoCliente;
        private System.Windows.Forms.Label labelMensagemASerEncaminhada;
		private System.Windows.Forms.Label label8;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnGerarAlerta = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnSalvarECopiar = new System.Windows.Forms.Button();
            this.btnApagarCampos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeEquipeTecnica = new System.Windows.Forms.TextBox();
            this.labelNomeEqTecnica = new System.Windows.Forms.Label();
            this.labelOperadora = new System.Windows.Forms.Label();
            this.comboBox_operadoraResponsavel = new System.Windows.Forms.ComboBox();
            this.comboBox_previaoDeChegada = new System.Windows.Forms.ComboBox();
            this.labelChegada = new System.Windows.Forms.Label();
            this.comboBox_unidadeParaLiberacaoDeAcesso = new System.Windows.Forms.ComboBox();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.labelEnderecoDaUnidade = new System.Windows.Forms.Label();
            this.comboBox_enderecoDaUnidadeResponsavel = new System.Windows.Forms.ComboBox();
            this.richTextBox_mensagemASerEncaminhadaAoCliente = new System.Windows.Forms.RichTextBox();
            this.labelMensagemASerEncaminhada = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_credenciaisDePessoaFisica = new System.Windows.Forms.TextBox();
            this.btnAmplicarTexto = new System.Windows.Forms.Button();
            this.btnExcluirTodosOsCampos = new System.Windows.Forms.Button();
            this.bntExcluirSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarAlerta
            // 
            this.btnGerarAlerta.BackColor = System.Drawing.Color.Transparent;
            this.btnGerarAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarAlerta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnGerarAlerta.ForeColor = System.Drawing.Color.Black;
            this.btnGerarAlerta.Location = new System.Drawing.Point(344, 394);
            this.btnGerarAlerta.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarAlerta.Name = "btnGerarAlerta";
            this.btnGerarAlerta.Size = new System.Drawing.Size(128, 54);
            this.btnGerarAlerta.TabIndex = 6;
            this.btnGerarAlerta.Text = "Gerar";
            this.btnGerarAlerta.UseVisualStyleBackColor = false;
            this.btnGerarAlerta.Click += new System.EventHandler(this.btnGerarAlerta_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCloseWindow.ForeColor = System.Drawing.Color.Black;
            this.btnCloseWindow.Location = new System.Drawing.Point(48, 394);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(128, 54);
            this.btnCloseWindow.TabIndex = 9;
            this.btnCloseWindow.Text = "Fechar";
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnSalvarECopiar
            // 
            this.btnSalvarECopiar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarECopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarECopiar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvarECopiar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarECopiar.Location = new System.Drawing.Point(480, 394);
            this.btnSalvarECopiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarECopiar.Name = "btnSalvarECopiar";
            this.btnSalvarECopiar.Size = new System.Drawing.Size(128, 54);
            this.btnSalvarECopiar.TabIndex = 7;
            this.btnSalvarECopiar.Text = "Gravar e Copiar";
            this.btnSalvarECopiar.UseVisualStyleBackColor = false;
            this.btnSalvarECopiar.Click += new System.EventHandler(this.btnSalvarECopiar_Click);
            // 
            // btnApagarCampos
            // 
            this.btnApagarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnApagarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarCampos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnApagarCampos.ForeColor = System.Drawing.Color.Black;
            this.btnApagarCampos.Location = new System.Drawing.Point(184, 394);
            this.btnApagarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnApagarCampos.Name = "btnApagarCampos";
            this.btnApagarCampos.Size = new System.Drawing.Size(152, 54);
            this.btnApagarCampos.TabIndex = 8;
            this.btnApagarCampos.Text = "Apagar campos";
            this.btnApagarCampos.UseVisualStyleBackColor = false;
            this.btnApagarCampos.Click += new System.EventHandler(this.btnApagarCampos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mensagem - Liberação de acesso";
            // 
            // textBox_nomeEquipeTecnica
            // 
            this.textBox_nomeEquipeTecnica.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_nomeEquipeTecnica.Location = new System.Drawing.Point(21, 59);
            this.textBox_nomeEquipeTecnica.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nomeEquipeTecnica.Name = "textBox_nomeEquipeTecnica";
            this.textBox_nomeEquipeTecnica.Size = new System.Drawing.Size(248, 29);
            this.textBox_nomeEquipeTecnica.TabIndex = 0;
            // 
            // labelNomeEqTecnica
            // 
            this.labelNomeEqTecnica.AutoSize = true;
            this.labelNomeEqTecnica.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelNomeEqTecnica.Location = new System.Drawing.Point(17, 32);
            this.labelNomeEqTecnica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeEqTecnica.Name = "labelNomeEqTecnica";
            this.labelNomeEqTecnica.Size = new System.Drawing.Size(145, 23);
            this.labelNomeEqTecnica.TabIndex = 46;
            this.labelNomeEqTecnica.Text = "Nome Eq. Técnica";
            // 
            // labelOperadora
            // 
            this.labelOperadora.AutoSize = true;
            this.labelOperadora.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelOperadora.Location = new System.Drawing.Point(288, 32);
            this.labelOperadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperadora.Name = "labelOperadora";
            this.labelOperadora.Size = new System.Drawing.Size(92, 23);
            this.labelOperadora.TabIndex = 47;
            this.labelOperadora.Text = "Operadora";
            // 
            // comboBox_operadoraResponsavel
            // 
            this.comboBox_operadoraResponsavel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_operadoraResponsavel.FormattingEnabled = true;
            this.comboBox_operadoraResponsavel.Location = new System.Drawing.Point(288, 57);
            this.comboBox_operadoraResponsavel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_operadoraResponsavel.Name = "comboBox_operadoraResponsavel";
            this.comboBox_operadoraResponsavel.Size = new System.Drawing.Size(159, 29);
            this.comboBox_operadoraResponsavel.TabIndex = 1;
            // 
            // comboBox_previaoDeChegada
            // 
            this.comboBox_previaoDeChegada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_previaoDeChegada.FormattingEnabled = true;
            this.comboBox_previaoDeChegada.Location = new System.Drawing.Point(456, 57);
            this.comboBox_previaoDeChegada.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_previaoDeChegada.Name = "comboBox_previaoDeChegada";
            this.comboBox_previaoDeChegada.Size = new System.Drawing.Size(151, 29);
            this.comboBox_previaoDeChegada.TabIndex = 2;
            // 
            // labelChegada
            // 
            this.labelChegada.AutoSize = true;
            this.labelChegada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelChegada.Location = new System.Drawing.Point(456, 32);
            this.labelChegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChegada.Name = "labelChegada";
            this.labelChegada.Size = new System.Drawing.Size(120, 23);
            this.labelChegada.TabIndex = 49;
            this.labelChegada.Text = "Prev. Chegada";
            // 
            // comboBox_unidadeParaLiberacaoDeAcesso
            // 
            this.comboBox_unidadeParaLiberacaoDeAcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_unidadeParaLiberacaoDeAcesso.FormattingEnabled = true;
            this.comboBox_unidadeParaLiberacaoDeAcesso.Location = new System.Drawing.Point(288, 119);
            this.comboBox_unidadeParaLiberacaoDeAcesso.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_unidadeParaLiberacaoDeAcesso.Name = "comboBox_unidadeParaLiberacaoDeAcesso";
            this.comboBox_unidadeParaLiberacaoDeAcesso.Size = new System.Drawing.Size(319, 29);
            this.comboBox_unidadeParaLiberacaoDeAcesso.TabIndex = 4;
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelUnidade.Location = new System.Drawing.Point(288, 95);
            this.labelUnidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(74, 23);
            this.labelUnidade.TabIndex = 52;
            this.labelUnidade.Text = "Unidade";
            // 
            // labelEnderecoDaUnidade
            // 
            this.labelEnderecoDaUnidade.AutoSize = true;
            this.labelEnderecoDaUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelEnderecoDaUnidade.Location = new System.Drawing.Point(17, 153);
            this.labelEnderecoDaUnidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnderecoDaUnidade.Name = "labelEnderecoDaUnidade";
            this.labelEnderecoDaUnidade.Size = new System.Drawing.Size(174, 23);
            this.labelEnderecoDaUnidade.TabIndex = 54;
            this.labelEnderecoDaUnidade.Text = "Endereço da Unidade";
            // 
            // comboBox_enderecoDaUnidadeResponsavel
            // 
            this.comboBox_enderecoDaUnidadeResponsavel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_enderecoDaUnidadeResponsavel.FormattingEnabled = true;
            this.comboBox_enderecoDaUnidadeResponsavel.Location = new System.Drawing.Point(21, 177);
            this.comboBox_enderecoDaUnidadeResponsavel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_enderecoDaUnidadeResponsavel.Name = "comboBox_enderecoDaUnidadeResponsavel";
            this.comboBox_enderecoDaUnidadeResponsavel.Size = new System.Drawing.Size(586, 29);
            this.comboBox_enderecoDaUnidadeResponsavel.TabIndex = 5;
            // 
            // richTextBox_mensagemASerEncaminhadaAoCliente
            // 
            this.richTextBox_mensagemASerEncaminhadaAoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.richTextBox_mensagemASerEncaminhadaAoCliente.Location = new System.Drawing.Point(21, 251);
            this.richTextBox_mensagemASerEncaminhadaAoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_mensagemASerEncaminhadaAoCliente.Name = "richTextBox_mensagemASerEncaminhadaAoCliente";
            this.richTextBox_mensagemASerEncaminhadaAoCliente.Size = new System.Drawing.Size(586, 122);
            this.richTextBox_mensagemASerEncaminhadaAoCliente.TabIndex = 55;
            this.richTextBox_mensagemASerEncaminhadaAoCliente.Text = "";
            // 
            // labelMensagemASerEncaminhada
            // 
            this.labelMensagemASerEncaminhada.AutoSize = true;
            this.labelMensagemASerEncaminhada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelMensagemASerEncaminhada.Location = new System.Drawing.Point(17, 218);
            this.labelMensagemASerEncaminhada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMensagemASerEncaminhada.Name = "labelMensagemASerEncaminhada";
            this.labelMensagemASerEncaminhada.Size = new System.Drawing.Size(243, 23);
            this.labelMensagemASerEncaminhada.TabIndex = 56;
            this.labelMensagemASerEncaminhada.Text = "Mensagem a ser encaminhada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(1, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(654, 23);
            this.label8.TabIndex = 57;
            this.label8.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "CPF / RG";
            // 
            // textBox_credenciaisDePessoaFisica
            // 
            this.textBox_credenciaisDePessoaFisica.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_credenciaisDePessoaFisica.Location = new System.Drawing.Point(21, 119);
            this.textBox_credenciaisDePessoaFisica.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_credenciaisDePessoaFisica.Name = "textBox_credenciaisDePessoaFisica";
            this.textBox_credenciaisDePessoaFisica.Size = new System.Drawing.Size(248, 29);
            this.textBox_credenciaisDePessoaFisica.TabIndex = 3;
            // 
            // btnAmplicarTexto
            // 
            this.btnAmplicarTexto.AutoSize = true;
            this.btnAmplicarTexto.BackColor = System.Drawing.Color.Transparent;
            this.btnAmplicarTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmplicarTexto.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnAmplicarTexto.ForeColor = System.Drawing.Color.Black;
            this.btnAmplicarTexto.Location = new System.Drawing.Point(567, 213);
            this.btnAmplicarTexto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmplicarTexto.Name = "btnAmplicarTexto";
            this.btnAmplicarTexto.Size = new System.Drawing.Size(40, 30);
            this.btnAmplicarTexto.TabIndex = 10;
            this.btnAmplicarTexto.Text = "🔎";
            this.btnAmplicarTexto.UseVisualStyleBackColor = false;
            // 
            // btnExcluirTodosOsCampos
            // 
            this.btnExcluirTodosOsCampos.AutoSize = true;
            this.btnExcluirTodosOsCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirTodosOsCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirTodosOsCampos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTodosOsCampos.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirTodosOsCampos.Location = new System.Drawing.Point(452, 212);
            this.btnExcluirTodosOsCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirTodosOsCampos.Name = "btnExcluirTodosOsCampos";
            this.btnExcluirTodosOsCampos.Size = new System.Drawing.Size(110, 33);
            this.btnExcluirTodosOsCampos.TabIndex = 101;
            this.btnExcluirTodosOsCampos.Text = "Excluir tudo";
            this.btnExcluirTodosOsCampos.UseVisualStyleBackColor = false;
            // 
            // bntExcluirSelecionado
            // 
            this.bntExcluirSelecionado.AutoSize = true;
            this.bntExcluirSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.bntExcluirSelecionado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExcluirSelecionado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluirSelecionado.ForeColor = System.Drawing.Color.Black;
            this.bntExcluirSelecionado.Location = new System.Drawing.Point(281, 212);
            this.bntExcluirSelecionado.Margin = new System.Windows.Forms.Padding(4);
            this.bntExcluirSelecionado.Name = "bntExcluirSelecionado";
            this.bntExcluirSelecionado.Size = new System.Drawing.Size(164, 33);
            this.bntExcluirSelecionado.TabIndex = 102;
            this.bntExcluirSelecionado.Text = "Excluir selecionado";
            this.bntExcluirSelecionado.UseVisualStyleBackColor = false;
            // 
            // Uc_LiberacaoDeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnExcluirTodosOsCampos);
            this.Controls.Add(this.bntExcluirSelecionado);
            this.Controls.Add(this.btnAmplicarTexto);
            this.Controls.Add(this.textBox_credenciaisDePessoaFisica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMensagemASerEncaminhada);
            this.Controls.Add(this.richTextBox_mensagemASerEncaminhadaAoCliente);
            this.Controls.Add(this.labelEnderecoDaUnidade);
            this.Controls.Add(this.comboBox_enderecoDaUnidadeResponsavel);
            this.Controls.Add(this.labelUnidade);
            this.Controls.Add(this.comboBox_unidadeParaLiberacaoDeAcesso);
            this.Controls.Add(this.comboBox_previaoDeChegada);
            this.Controls.Add(this.labelChegada);
            this.Controls.Add(this.comboBox_operadoraResponsavel);
            this.Controls.Add(this.labelOperadora);
            this.Controls.Add(this.labelNomeEqTecnica);
            this.Controls.Add(this.textBox_nomeEquipeTecnica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarAlerta);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSalvarECopiar);
            this.Controls.Add(this.btnApagarCampos);
            this.Controls.Add(this.label8);
            this.Location = new System.Drawing.Point(437, 3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_LiberacaoDeAcesso";
            this.Size = new System.Drawing.Size(627, 468);
            this.Load += new System.EventHandler(this.Uc_LiberacaoDeAcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_credenciaisDePessoaFisica;
        private System.Windows.Forms.Button btnAmplicarTexto;
        private System.Windows.Forms.Button btnExcluirTodosOsCampos;
        private System.Windows.Forms.Button bntExcluirSelecionado;
    }
}
