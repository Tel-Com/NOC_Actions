namespace NOC_Actions
{
	partial class UcDetalharFaturaDoCliente
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox_ObservacaoDaFatura;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_CodigoDeBarrasDaFatura;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox religuePorConfianca_Sim;
		private System.Windows.Forms.CheckBox religuePorConfianca_Nao;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnGravarECopiarInformacoesDetalhadas;
		private System.Windows.Forms.Button btnApagarOsCampos;
		private System.Windows.Forms.Button btnAnexar;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_VencimentoFatura;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_OperadoraDaUnidade;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_ValorDaFatura;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox textBox_StatusDaFatura;
		private System.Windows.Forms.Label btnConfigForm;
		private System.Windows.Forms.ComboBox textBox_TipoDeOperadoraDoContrato;
		private System.Windows.Forms.ComboBox comboBox_UnidadeASerNotificada;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox_ObservacaoDaFatura = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_CodigoDeBarrasDaFatura = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.religuePorConfianca_Sim = new System.Windows.Forms.CheckBox();
			this.religuePorConfianca_Nao = new System.Windows.Forms.CheckBox();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnGravarECopiarInformacoesDetalhadas = new System.Windows.Forms.Button();
			this.btnApagarOsCampos = new System.Windows.Forms.Button();
			this.btnAnexar = new System.Windows.Forms.Button();
			this.maskedTextBox_VencimentoFatura = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox_OperadoraDaUnidade = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.maskedTextBox_ValorDaFatura = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox_StatusDaFatura = new System.Windows.Forms.ComboBox();
			this.btnConfigForm = new System.Windows.Forms.Label();
			this.textBox_TipoDeOperadoraDoContrato = new System.Windows.Forms.ComboBox();
			this.comboBox_UnidadeASerNotificada = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Detalhamento de Fatura";
			// 
			// richTextBox_ObservacaoDaFatura
			// 
			this.richTextBox_ObservacaoDaFatura.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.richTextBox_ObservacaoDaFatura.Location = new System.Drawing.Point(3, 98);
			this.richTextBox_ObservacaoDaFatura.Name = "richTextBox_ObservacaoDaFatura";
			this.richTextBox_ObservacaoDaFatura.Size = new System.Drawing.Size(464, 57);
			this.richTextBox_ObservacaoDaFatura.TabIndex = 1;
			this.richTextBox_ObservacaoDaFatura.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label2.Location = new System.Drawing.Point(3, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Observação";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label3.Location = new System.Drawing.Point(3, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Valor da Fatura";
			// 
			// textBox_CodigoDeBarrasDaFatura
			// 
			this.textBox_CodigoDeBarrasDaFatura.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.textBox_CodigoDeBarrasDaFatura.Location = new System.Drawing.Point(3, 231);
			this.textBox_CodigoDeBarrasDaFatura.MaxLength = 327670000;
			this.textBox_CodigoDeBarrasDaFatura.Name = "textBox_CodigoDeBarrasDaFatura";
			this.textBox_CodigoDeBarrasDaFatura.Size = new System.Drawing.Size(464, 25);
			this.textBox_CodigoDeBarrasDaFatura.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.Location = new System.Drawing.Point(3, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Código de Barras";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label5.Location = new System.Drawing.Point(121, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Vencimento";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label6.Location = new System.Drawing.Point(3, 265);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "Aplicado Religue?";
			// 
			// religuePorConfianca_Sim
			// 
			this.religuePorConfianca_Sim.AutoSize = true;
			this.religuePorConfianca_Sim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.religuePorConfianca_Sim.Location = new System.Drawing.Point(8, 286);
			this.religuePorConfianca_Sim.Name = "religuePorConfianca_Sim";
			this.religuePorConfianca_Sim.Size = new System.Drawing.Size(48, 21);
			this.religuePorConfianca_Sim.TabIndex = 10;
			this.religuePorConfianca_Sim.Text = "Sim";
			this.religuePorConfianca_Sim.UseVisualStyleBackColor = true;
			// 
			// religuePorConfianca_Nao
			// 
			this.religuePorConfianca_Nao.AutoSize = true;
			this.religuePorConfianca_Nao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.religuePorConfianca_Nao.Location = new System.Drawing.Point(60, 286);
			this.religuePorConfianca_Nao.Name = "religuePorConfianca_Nao";
			this.religuePorConfianca_Nao.Size = new System.Drawing.Size(52, 21);
			this.religuePorConfianca_Nao.TabIndex = 11;
			this.religuePorConfianca_Nao.Text = "Não";
			this.religuePorConfianca_Nao.UseVisualStyleBackColor = true;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnVoltar.Location = new System.Drawing.Point(43, 326);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(96, 44);
			this.btnVoltar.TabIndex = 15;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.BtnVoltarClick);
			// 
			// btnGravarECopiarInformacoesDetalhadas
			// 
			this.btnGravarECopiarInformacoesDetalhadas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnGravarECopiarInformacoesDetalhadas.Location = new System.Drawing.Point(366, 326);
			this.btnGravarECopiarInformacoesDetalhadas.Name = "btnGravarECopiarInformacoesDetalhadas";
			this.btnGravarECopiarInformacoesDetalhadas.Size = new System.Drawing.Size(96, 44);
			this.btnGravarECopiarInformacoesDetalhadas.TabIndex = 12;
			this.btnGravarECopiarInformacoesDetalhadas.Text = "Gravar e Copiar";
			this.btnGravarECopiarInformacoesDetalhadas.UseVisualStyleBackColor = true;
			this.btnGravarECopiarInformacoesDetalhadas.Click += new System.EventHandler(this.BtnGravarECopiarInformacoesDetalhadasClick);
			// 
			// btnApagarOsCampos
			// 
			this.btnApagarOsCampos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnApagarOsCampos.Location = new System.Drawing.Point(264, 326);
			this.btnApagarOsCampos.Name = "btnApagarOsCampos";
			this.btnApagarOsCampos.Size = new System.Drawing.Size(96, 44);
			this.btnApagarOsCampos.TabIndex = 13;
			this.btnApagarOsCampos.Text = "Apagar";
			this.btnApagarOsCampos.UseVisualStyleBackColor = true;
			// 
			// btnAnexar
			// 
			this.btnAnexar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnAnexar.Location = new System.Drawing.Point(162, 326);
			this.btnAnexar.Name = "btnAnexar";
			this.btnAnexar.Size = new System.Drawing.Size(96, 44);
			this.btnAnexar.TabIndex = 16;
			this.btnAnexar.Text = "Prévia";
			this.btnAnexar.UseVisualStyleBackColor = true;
			// 
			// maskedTextBox_VencimentoFatura
			// 
			this.maskedTextBox_VencimentoFatura.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.maskedTextBox_VencimentoFatura.Location = new System.Drawing.Point(121, 179);
			this.maskedTextBox_VencimentoFatura.Mask = "00/00/0000";
			this.maskedTextBox_VencimentoFatura.Name = "maskedTextBox_VencimentoFatura";
			this.maskedTextBox_VencimentoFatura.Size = new System.Drawing.Size(110, 25);
			this.maskedTextBox_VencimentoFatura.TabIndex = 18;
			this.maskedTextBox_VencimentoFatura.ValidatingType = typeof(System.DateTime);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label7.Location = new System.Drawing.Point(239, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 17);
			this.label7.TabIndex = 19;
			this.label7.Text = "Operadora";
			// 
			// textBox_OperadoraDaUnidade
			// 
			this.textBox_OperadoraDaUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.textBox_OperadoraDaUnidade.Location = new System.Drawing.Point(239, 49);
			this.textBox_OperadoraDaUnidade.MaxLength = 327670000;
			this.textBox_OperadoraDaUnidade.Name = "textBox_OperadoraDaUnidade";
			this.textBox_OperadoraDaUnidade.Size = new System.Drawing.Size(228, 25);
			this.textBox_OperadoraDaUnidade.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label8.Location = new System.Drawing.Point(3, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 17);
			this.label8.TabIndex = 22;
			this.label8.Text = "Unidade";
			// 
			// maskedTextBox_ValorDaFatura
			// 
			this.maskedTextBox_ValorDaFatura.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.maskedTextBox_ValorDaFatura.Location = new System.Drawing.Point(3, 179);
			this.maskedTextBox_ValorDaFatura.Mask = "$0000000";
			this.maskedTextBox_ValorDaFatura.Name = "maskedTextBox_ValorDaFatura";
			this.maskedTextBox_ValorDaFatura.Size = new System.Drawing.Size(110, 25);
			this.maskedTextBox_ValorDaFatura.TabIndex = 23;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label9.Location = new System.Drawing.Point(237, 159);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 17);
			this.label9.TabIndex = 24;
			this.label9.Text = "Status do Contrato";
			// 
			// textBox_StatusDaFatura
			// 
			this.textBox_StatusDaFatura.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.textBox_StatusDaFatura.FormattingEnabled = true;
			this.textBox_StatusDaFatura.Location = new System.Drawing.Point(239, 179);
			this.textBox_StatusDaFatura.Name = "textBox_StatusDaFatura";
			this.textBox_StatusDaFatura.Size = new System.Drawing.Size(228, 25);
			this.textBox_StatusDaFatura.TabIndex = 25;
			// 
			// btnConfigForm
			// 
			this.btnConfigForm.AutoSize = true;
			this.btnConfigForm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConfigForm.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnConfigForm.Location = new System.Drawing.Point(450, 0);
			this.btnConfigForm.Name = "btnConfigForm";
			this.btnConfigForm.Size = new System.Drawing.Size(26, 17);
			this.btnConfigForm.TabIndex = 27;
			this.btnConfigForm.Text = "⚙️";
			this.btnConfigForm.Click += new System.EventHandler(this.BtnConfigFormClick);
			// 
			// textBox_TipoDeOperadoraDoContrato
			// 
			this.textBox_TipoDeOperadoraDoContrato.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.textBox_TipoDeOperadoraDoContrato.FormattingEnabled = true;
			this.textBox_TipoDeOperadoraDoContrato.Location = new System.Drawing.Point(239, 49);
			this.textBox_TipoDeOperadoraDoContrato.Name = "textBox_TipoDeOperadoraDoContrato";
			this.textBox_TipoDeOperadoraDoContrato.Size = new System.Drawing.Size(228, 25);
			this.textBox_TipoDeOperadoraDoContrato.TabIndex = 28;
			// 
			// comboBox_UnidadeASerNotificada
			// 
			this.comboBox_UnidadeASerNotificada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox_UnidadeASerNotificada.FormattingEnabled = true;
			this.comboBox_UnidadeASerNotificada.Location = new System.Drawing.Point(3, 49);
			this.comboBox_UnidadeASerNotificada.Name = "comboBox_UnidadeASerNotificada";
			this.comboBox_UnidadeASerNotificada.Size = new System.Drawing.Size(228, 25);
			this.comboBox_UnidadeASerNotificada.TabIndex = 29;
			// 
			// UcDetalharFaturaDoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.comboBox_UnidadeASerNotificada);
			this.Controls.Add(this.textBox_TipoDeOperadoraDoContrato);
			this.Controls.Add(this.btnConfigForm);
			this.Controls.Add(this.textBox_StatusDaFatura);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.maskedTextBox_ValorDaFatura);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox_OperadoraDaUnidade);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.maskedTextBox_VencimentoFatura);
			this.Controls.Add(this.btnAnexar);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnGravarECopiarInformacoesDetalhadas);
			this.Controls.Add(this.btnApagarOsCampos);
			this.Controls.Add(this.religuePorConfianca_Nao);
			this.Controls.Add(this.religuePorConfianca_Sim);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_CodigoDeBarrasDaFatura);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox_ObservacaoDaFatura);
			this.Controls.Add(this.label1);
			this.Name = "UcDetalharFaturaDoCliente";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
