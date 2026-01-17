/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 06/12/2025
 * Hora: 13:39
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Actions
{
	partial class Uc_PossivelQuedaDeEnergia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGerarAlerta;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnSalvarECopiar;
		private System.Windows.Forms.Button btnApagarCampos;
		private System.Windows.Forms.Label labelUnidade;
		private System.Windows.Forms.ComboBox comboBox_unidadeParaAnaliseEnergia;
        private System.Windows.Forms.ComboBox comboBox_enderecoUnidade;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_operadoraUnidade;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_horarioQuedaCircuito;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_dataReferencia;
        private System.Windows.Forms.Label labelMensagemASerEncaminhada;
		private System.Windows.Forms.RichTextBox richTextBox_MensagemASerEncaminhadaAoCliente;
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarAlerta = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnSalvarECopiar = new System.Windows.Forms.Button();
            this.btnApagarCampos = new System.Windows.Forms.Button();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.comboBox_unidadeParaAnaliseEnergia = new System.Windows.Forms.ComboBox();
            this.comboBox_enderecoUnidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_operadoraUnidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_horarioQuedaCircuito = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_dataReferencia = new System.Windows.Forms.MaskedTextBox();
            this.labelMensagemASerEncaminhada = new System.Windows.Forms.Label();
            this.richTextBox_MensagemASerEncaminhadaAoCliente = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcluirTodosOsCampos = new System.Windows.Forms.Button();
            this.bntExcluirSelecionado = new System.Windows.Forms.Button();
            this.btnAmplicarTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mensagem - Possível queda de energia";
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
            this.btnGerarAlerta.TabIndex = 5;
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
            this.btnCloseWindow.TabIndex = 7;
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
            this.btnSalvarECopiar.TabIndex = 6;
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
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelUnidade.Location = new System.Drawing.Point(16, 42);
            this.labelUnidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(74, 23);
            this.labelUnidade.TabIndex = 50;
            this.labelUnidade.Text = "Unidade";
            // 
            // comboBox_unidadeParaAnaliseEnergia
            // 
            this.comboBox_unidadeParaAnaliseEnergia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_unidadeParaAnaliseEnergia.FormattingEnabled = true;
            this.comboBox_unidadeParaAnaliseEnergia.Location = new System.Drawing.Point(16, 66);
            this.comboBox_unidadeParaAnaliseEnergia.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_unidadeParaAnaliseEnergia.Name = "comboBox_unidadeParaAnaliseEnergia";
            this.comboBox_unidadeParaAnaliseEnergia.Size = new System.Drawing.Size(227, 29);
            this.comboBox_unidadeParaAnaliseEnergia.TabIndex = 0;
            // 
            // comboBox_enderecoUnidade
            // 
            this.comboBox_enderecoUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_enderecoUnidade.FormattingEnabled = true;
            this.comboBox_enderecoUnidade.Location = new System.Drawing.Point(252, 66);
            this.comboBox_enderecoUnidade.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_enderecoUnidade.Name = "comboBox_enderecoUnidade";
            this.comboBox_enderecoUnidade.Size = new System.Drawing.Size(355, 29);
            this.comboBox_enderecoUnidade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(252, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Endereço";
            // 
            // comboBox_operadoraUnidade
            // 
            this.comboBox_operadoraUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_operadoraUnidade.FormattingEnabled = true;
            this.comboBox_operadoraUnidade.Location = new System.Drawing.Point(16, 128);
            this.comboBox_operadoraUnidade.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_operadoraUnidade.Name = "comboBox_operadoraUnidade";
            this.comboBox_operadoraUnidade.Size = new System.Drawing.Size(227, 29);
            this.comboBox_operadoraUnidade.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Operadora(as)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(252, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Hr. Queda";
            // 
            // maskedTextBox_horarioQuedaCircuito
            // 
            this.maskedTextBox_horarioQuedaCircuito.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.maskedTextBox_horarioQuedaCircuito.Location = new System.Drawing.Point(252, 128);
            this.maskedTextBox_horarioQuedaCircuito.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_horarioQuedaCircuito.Mask = "00:00";
            this.maskedTextBox_horarioQuedaCircuito.Name = "maskedTextBox_horarioQuedaCircuito";
            this.maskedTextBox_horarioQuedaCircuito.Size = new System.Drawing.Size(132, 29);
            this.maskedTextBox_horarioQuedaCircuito.TabIndex = 3;
            this.maskedTextBox_horarioQuedaCircuito.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(393, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "DataRef";
            // 
            // maskedTextBox_dataReferencia
            // 
            this.maskedTextBox_dataReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.maskedTextBox_dataReferencia.Location = new System.Drawing.Point(393, 128);
            this.maskedTextBox_dataReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_dataReferencia.Mask = "00/00/0000";
            this.maskedTextBox_dataReferencia.Name = "maskedTextBox_dataReferencia";
            this.maskedTextBox_dataReferencia.Size = new System.Drawing.Size(213, 29);
            this.maskedTextBox_dataReferencia.TabIndex = 4;
            this.maskedTextBox_dataReferencia.ValidatingType = typeof(System.DateTime);
            // 
            // labelMensagemASerEncaminhada
            // 
            this.labelMensagemASerEncaminhada.AutoSize = true;
            this.labelMensagemASerEncaminhada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelMensagemASerEncaminhada.Location = new System.Drawing.Point(16, 178);
            this.labelMensagemASerEncaminhada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMensagemASerEncaminhada.Name = "labelMensagemASerEncaminhada";
            this.labelMensagemASerEncaminhada.Size = new System.Drawing.Size(243, 23);
            this.labelMensagemASerEncaminhada.TabIndex = 62;
            this.labelMensagemASerEncaminhada.Text = "Mensagem a ser encaminhada";
            // 
            // richTextBox_MensagemASerEncaminhadaAoCliente
            // 
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Location = new System.Drawing.Point(16, 212);
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Name = "richTextBox_MensagemASerEncaminhadaAoCliente";
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Size = new System.Drawing.Size(591, 143);
            this.richTextBox_MensagemASerEncaminhadaAoCliente.TabIndex = 61;
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(1, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(654, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // btnExcluirTodosOsCampos
            // 
            this.btnExcluirTodosOsCampos.AutoSize = true;
            this.btnExcluirTodosOsCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirTodosOsCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirTodosOsCampos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTodosOsCampos.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirTodosOsCampos.Location = new System.Drawing.Point(450, 173);
            this.btnExcluirTodosOsCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirTodosOsCampos.Name = "btnExcluirTodosOsCampos";
            this.btnExcluirTodosOsCampos.Size = new System.Drawing.Size(110, 33);
            this.btnExcluirTodosOsCampos.TabIndex = 103;
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
            this.bntExcluirSelecionado.Location = new System.Drawing.Point(279, 173);
            this.bntExcluirSelecionado.Margin = new System.Windows.Forms.Padding(4);
            this.bntExcluirSelecionado.Name = "bntExcluirSelecionado";
            this.bntExcluirSelecionado.Size = new System.Drawing.Size(164, 33);
            this.bntExcluirSelecionado.TabIndex = 104;
            this.bntExcluirSelecionado.Text = "Excluir selecionado";
            this.bntExcluirSelecionado.UseVisualStyleBackColor = false;
            // 
            // btnAmplicarTexto
            // 
            this.btnAmplicarTexto.AutoSize = true;
            this.btnAmplicarTexto.BackColor = System.Drawing.Color.Transparent;
            this.btnAmplicarTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmplicarTexto.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.btnAmplicarTexto.ForeColor = System.Drawing.Color.Black;
            this.btnAmplicarTexto.Location = new System.Drawing.Point(566, 174);
            this.btnAmplicarTexto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmplicarTexto.Name = "btnAmplicarTexto";
            this.btnAmplicarTexto.Size = new System.Drawing.Size(40, 30);
            this.btnAmplicarTexto.TabIndex = 105;
            this.btnAmplicarTexto.Text = "🔎";
            this.btnAmplicarTexto.UseVisualStyleBackColor = false;
            // 
            // Uc_PossivelQuedaDeEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnAmplicarTexto);
            this.Controls.Add(this.btnExcluirTodosOsCampos);
            this.Controls.Add(this.bntExcluirSelecionado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelMensagemASerEncaminhada);
            this.Controls.Add(this.richTextBox_MensagemASerEncaminhadaAoCliente);
            this.Controls.Add(this.maskedTextBox_dataReferencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_horarioQuedaCircuito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_operadoraUnidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_enderecoUnidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_unidadeParaAnaliseEnergia);
            this.Controls.Add(this.labelUnidade);
            this.Controls.Add(this.btnGerarAlerta);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSalvarECopiar);
            this.Controls.Add(this.btnApagarCampos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_PossivelQuedaDeEnergia";
            this.Size = new System.Drawing.Size(627, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnExcluirTodosOsCampos;
        private System.Windows.Forms.Button bntExcluirSelecionado;
        private System.Windows.Forms.Button btnAmplicarTexto;
    }
}
