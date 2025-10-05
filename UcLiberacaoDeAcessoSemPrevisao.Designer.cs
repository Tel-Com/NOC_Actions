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
		private System.Windows.Forms.Button btnSaveAndCopy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClearFields;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1_DadosTecnicos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnMessagePreview;
		
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
			this.btnSaveAndCopy = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnClearFields = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1_DadosTecnicos = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.btnMessagePreview = new System.Windows.Forms.Button();
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
			// btnSaveAndCopy
			// 
			this.btnSaveAndCopy.Location = new System.Drawing.Point(339, 316);
			this.btnSaveAndCopy.Name = "btnSaveAndCopy";
			this.btnSaveAndCopy.Size = new System.Drawing.Size(114, 33);
			this.btnSaveAndCopy.TabIndex = 16;
			this.btnSaveAndCopy.Text = "Gravar e Copiar";
			this.btnSaveAndCopy.UseVisualStyleBackColor = true;
			this.btnSaveAndCopy.Click += new System.EventHandler(this.BtnGravarECopiarClick);
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
			// btnClearFields
			// 
			this.btnClearFields.Location = new System.Drawing.Point(219, 316);
			this.btnClearFields.Name = "btnClearFields";
			this.btnClearFields.Size = new System.Drawing.Size(114, 33);
			this.btnClearFields.TabIndex = 10;
			this.btnClearFields.Text = "Apagar";
			this.btnClearFields.UseVisualStyleBackColor = true;
			this.btnClearFields.Click += new System.EventHandler(this.BtnApagarCamposClick);
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
			// btnCloseWindow
			// 
			this.btnCloseWindow.Location = new System.Drawing.Point(39, 316);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(60, 33);
			this.btnCloseWindow.TabIndex = 20;
			this.btnCloseWindow.Text = "Fechar";
			this.btnCloseWindow.UseVisualStyleBackColor = true;
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnFecharJanelaClick);
			// 
			// btnMessagePreview
			// 
			this.btnMessagePreview.Location = new System.Drawing.Point(122, 316);
			this.btnMessagePreview.Name = "btnMessagePreview";
			this.btnMessagePreview.Size = new System.Drawing.Size(91, 33);
			this.btnMessagePreview.TabIndex = 21;
			this.btnMessagePreview.Text = "Prévia";
			this.btnMessagePreview.UseVisualStyleBackColor = true;
			this.btnMessagePreview.Click += new System.EventHandler(this.BtnPreviaDaMensagemClick);
			// 
			// UcLiberacaoDeAcessoSemPrevisao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.btnMessagePreview);
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox1_DadosTecnicos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSaveAndCopy);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClearFields);
			this.Controls.Add(this.label1);
			this.Name = "UcLiberacaoDeAcessoSemPrevisao";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
