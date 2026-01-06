/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 18/07/2025
 * Time: 09:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_Actions
{
	partial class UcLiberacaoDeAcessoComPrevisao
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSaveAndCopy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClearFields;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBoxTechnicalData;
		private System.Windows.Forms.TextBox textBoxEstimatedArrival;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnPreviewMessage;
		
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
            this.btnSaveAndCopy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxTechnicalData = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEstimatedArrival = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnPreviewMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveAndCopy
            // 
            this.btnSaveAndCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAndCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSaveAndCopy.Location = new System.Drawing.Point(476, 388);
            this.btnSaveAndCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveAndCopy.Name = "btnSaveAndCopy";
            this.btnSaveAndCopy.Size = new System.Drawing.Size(128, 54);
            this.btnSaveAndCopy.TabIndex = 2;
            this.btnSaveAndCopy.Text = "Gravar e Copiar";
            this.btnSaveAndCopy.UseVisualStyleBackColor = true;
            this.btnSaveAndCopy.Click += new System.EventHandler(this.BtnSaveAndCopyClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mensagem a ser exibida";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFields.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClearFields.Location = new System.Drawing.Point(340, 388);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(128, 54);
            this.btnClearFields.TabIndex = 3;
            this.btnClearFields.Text = "Apagar";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.BtnClearFieldsClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 101);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prezados, necessário acionamento com a loja para liberação de acesso do(s) técnic" +
    "o(s) abaixo. Previsão de chegada as __ (hh) OU no período da manhã/tarde/noite.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(60, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 43);
            this.label3.TabIndex = 23;
            this.label3.Text = "No campo acima, adicione as informações pessoais da equipe técnica (NOME, RG, CPF" +
    " e outros documentos necessários para acesso).";
            // 
            // richTextBoxTechnicalData
            // 
            this.richTextBoxTechnicalData.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.richTextBoxTechnicalData.Location = new System.Drawing.Point(76, 123);
            this.richTextBoxTechnicalData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxTechnicalData.Name = "richTextBoxTechnicalData";
            this.richTextBoxTechnicalData.Size = new System.Drawing.Size(477, 117);
            this.richTextBoxTechnicalData.TabIndex = 0;
            this.richTextBoxTechnicalData.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(36, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(539, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "____________________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Equipe Técnica (Dados):";
            // 
            // textBoxEstimatedArrival
            // 
            this.textBoxEstimatedArrival.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxEstimatedArrival.Location = new System.Drawing.Point(244, 316);
            this.textBoxEstimatedArrival.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEstimatedArrival.Name = "textBoxEstimatedArrival";
            this.textBoxEstimatedArrival.Size = new System.Drawing.Size(315, 29);
            this.textBoxEstimatedArrival.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(60, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Previsão de Chagada";
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCloseWindow.Location = new System.Drawing.Point(45, 388);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(128, 54);
            this.btnCloseWindow.TabIndex = 5;
            this.btnCloseWindow.Text = "Fechar";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
            // 
            // btnPreviewMessage
            // 
            this.btnPreviewMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviewMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPreviewMessage.Location = new System.Drawing.Point(204, 388);
            this.btnPreviewMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviewMessage.Name = "btnPreviewMessage";
            this.btnPreviewMessage.Size = new System.Drawing.Size(128, 54);
            this.btnPreviewMessage.TabIndex = 4;
            this.btnPreviewMessage.Text = "Prévia";
            this.btnPreviewMessage.UseVisualStyleBackColor = true;
            this.btnPreviewMessage.Click += new System.EventHandler(this.BtnPreviewMessageClick);
            // 
            // UcLiberacaoDeAcessoComPrevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnPreviewMessage);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEstimatedArrival);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxTechnicalData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveAndCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcLiberacaoDeAcessoComPrevisao";
            this.Size = new System.Drawing.Size(627, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
