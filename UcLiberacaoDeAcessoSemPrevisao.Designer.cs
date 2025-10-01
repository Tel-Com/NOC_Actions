/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 18/07/2025
 * Time: 09:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_Actions
{
	partial class UcLiberacaoDeAcessoSemPrevisao
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnGravarECopiar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnApagarCampos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1_DadosTecnicos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnFecharJanela;
		private System.Windows.Forms.Button btnPreviaDaMensagem;
		
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
			this.label5 = new System.Windows.Forms.Label();
			this.btnGravarECopiar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnApagarCampos = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1_DadosTecnicos = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnFecharJanela = new System.Windows.Forms.Button();
			this.btnPreviaDaMensagem = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 211);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(391, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "________________________________________________________________";
			// 
			// btnGravarECopiar
			// 
			this.btnGravarECopiar.Location = new System.Drawing.Point(339, 316);
			this.btnGravarECopiar.Name = "btnGravarECopiar";
			this.btnGravarECopiar.Size = new System.Drawing.Size(114, 33);
			this.btnGravarECopiar.TabIndex = 16;
			this.btnGravarECopiar.Text = "Gravar e Copiar";
			this.btnGravarECopiar.UseVisualStyleBackColor = true;
			this.btnGravarECopiar.Click += new System.EventHandler(this.BtnGravarECopiarClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Mensagem a ser exibida";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Equipe Técnica (Dados)";
			// 
			// btnApagarCampos
			// 
			this.btnApagarCampos.Location = new System.Drawing.Point(219, 316);
			this.btnApagarCampos.Name = "btnApagarCampos";
			this.btnApagarCampos.Size = new System.Drawing.Size(114, 33);
			this.btnApagarCampos.TabIndex = 10;
			this.btnApagarCampos.Text = "Apagar";
			this.btnApagarCampos.UseVisualStyleBackColor = true;
			this.btnApagarCampos.Click += new System.EventHandler(this.BtnApagarCamposClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 35);
			this.label1.TabIndex = 9;
			this.label1.Text = "\t\tPrezados, necessário acionamento com a loja para liberação de acesso do(s) técn" +
	"ico(s) abaixo. Ainda não foi repassado previsão de chegada, assim que obtivermos" +
	" iremos atualizar a thread.";
			// 
			// richTextBox1_DadosTecnicos
			// 
			this.richTextBox1_DadosTecnicos.Location = new System.Drawing.Point(62, 107);
			this.richTextBox1_DadosTecnicos.Name = "richTextBox1_DadosTecnicos";
			this.richTextBox1_DadosTecnicos.Size = new System.Drawing.Size(359, 96);
			this.richTextBox1_DadosTecnicos.TabIndex = 18;
			this.richTextBox1_DadosTecnicos.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(391, 35);
			this.label3.TabIndex = 19;
			this.label3.Text = "No campo acima, adicione as informações pessoais da equipe técnica (NOME, RG, CPF" +
	" e outros documentos).";
			// 
			// btnFecharJanela
			// 
			this.btnFecharJanela.Location = new System.Drawing.Point(39, 316);
			this.btnFecharJanela.Name = "btnFecharJanela";
			this.btnFecharJanela.Size = new System.Drawing.Size(60, 33);
			this.btnFecharJanela.TabIndex = 20;
			this.btnFecharJanela.Text = "Fechar";
			this.btnFecharJanela.UseVisualStyleBackColor = true;
			this.btnFecharJanela.Click += new System.EventHandler(this.BtnFecharJanelaClick);
			// 
			// btnPreviaDaMensagem
			// 
			this.btnPreviaDaMensagem.Location = new System.Drawing.Point(122, 316);
			this.btnPreviaDaMensagem.Name = "btnPreviaDaMensagem";
			this.btnPreviaDaMensagem.Size = new System.Drawing.Size(91, 33);
			this.btnPreviaDaMensagem.TabIndex = 21;
			this.btnPreviaDaMensagem.Text = "Prévia";
			this.btnPreviaDaMensagem.UseVisualStyleBackColor = true;
			this.btnPreviaDaMensagem.Click += new System.EventHandler(this.BtnPreviaDaMensagemClick);
			// 
			// UcLiberacaoDeAcessoSemPrevisao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.btnPreviaDaMensagem);
			this.Controls.Add(this.btnFecharJanela);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox1_DadosTecnicos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGravarECopiar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnApagarCampos);
			this.Controls.Add(this.label1);
			this.Name = "UcLiberacaoDeAcessoSemPrevisao";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
