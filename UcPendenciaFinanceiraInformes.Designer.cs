/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 21/07/2025
 * Time: 10:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_Actions
{
	partial class UcPendenciaFinanceiraInformes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1_UnidadeComBloqueioFinanceiro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSaveAndCopy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClearFields;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnViewInvoiceDetails;
		
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
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1_UnidadeComBloqueioFinanceiro = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSaveAndCopy = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnClearFields = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.btnViewInvoiceDetails = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(50, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 13);
			this.label6.TabIndex = 35;
			this.label6.Text = "Unidade";
			// 
			// textBox1_UnidadeComBloqueioFinanceiro
			// 
			this.textBox1_UnidadeComBloqueioFinanceiro.Location = new System.Drawing.Point(165, 126);
			this.textBox1_UnidadeComBloqueioFinanceiro.Name = "textBox1_UnidadeComBloqueioFinanceiro";
			this.textBox1_UnidadeComBloqueioFinanceiro.Size = new System.Drawing.Size(237, 20);
			this.textBox1_UnidadeComBloqueioFinanceiro.TabIndex = 34;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(391, 13);
			this.label5.TabIndex = 31;
			this.label5.Text = "________________________________________________________________";
			// 
			// btnSaveAndCopy
			// 
			this.btnSaveAndCopy.Location = new System.Drawing.Point(357, 315);
			this.btnSaveAndCopy.Name = "btnSaveAndCopy";
			this.btnSaveAndCopy.Size = new System.Drawing.Size(96, 44);
			this.btnSaveAndCopy.TabIndex = 29;
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
			this.label4.TabIndex = 28;
			this.label4.Text = "Mensagem a ser exibida";
			// 
			// btnClearFields
			// 
			this.btnClearFields.Location = new System.Drawing.Point(255, 315);
			this.btnClearFields.Name = "btnClearFields";
			this.btnClearFields.Size = new System.Drawing.Size(96, 44);
			this.btnClearFields.TabIndex = 27;
			this.btnClearFields.Text = "Apagar";
			this.btnClearFields.UseVisualStyleBackColor = true;
			this.btnClearFields.Click += new System.EventHandler(this.BtnApagarCamposClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 35);
			this.label1.TabIndex = 26;
			this.label1.Text = "\t\t\tPrezados, constatamos a existência de um bloqueio administrativo-financeiro no" +
	" contrato da unidade...";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(391, 42);
			this.label2.TabIndex = 38;
			this.label2.Text = "Você pode escolher \"detalhar\" para aprimorar e adicionar informações referente ao" +
	" Bloqueio Financeiro no respectivo contrato.";
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.Location = new System.Drawing.Point(34, 315);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(96, 44);
			this.btnCloseWindow.TabIndex = 39;
			this.btnCloseWindow.Text = "Fechar";
			this.btnCloseWindow.UseVisualStyleBackColor = true;
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnFecharJanelaClick);
			// 
			// btnViewInvoiceDetails
			// 
			this.btnViewInvoiceDetails.Enabled = false;
			this.btnViewInvoiceDetails.Location = new System.Drawing.Point(153, 315);
			this.btnViewInvoiceDetails.Name = "btnViewInvoiceDetails";
			this.btnViewInvoiceDetails.Size = new System.Drawing.Size(96, 44);
			this.btnViewInvoiceDetails.TabIndex = 40;
			this.btnViewInvoiceDetails.Text = "Detalhar ...";
			this.btnViewInvoiceDetails.UseVisualStyleBackColor = true;
			this.btnViewInvoiceDetails.Click += new System.EventHandler(this.BtnDetalharFaturaClick);
			// 
			// UcPendenciaFinanceiraInformes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnViewInvoiceDetails);
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox1_UnidadeComBloqueioFinanceiro);
			this.Controls.Add(this.btnSaveAndCopy);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnClearFields);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Name = "UcPendenciaFinanceiraInformes";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
