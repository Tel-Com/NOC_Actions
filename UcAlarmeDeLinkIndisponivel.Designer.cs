/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 18/07/2025
 * Time: 10:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_Actions
{
	partial class UcAlarmeDeLinkIndisponivel
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
		private System.Windows.Forms.TextBox textBox2_horarioQueda;
		private System.Windows.Forms.TextBox textBox1_nomeOperadora;
		private System.Windows.Forms.Button btnClearFields;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCloseWindow;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2_horarioQueda = new System.Windows.Forms.TextBox();
			this.textBox1_nomeOperadora = new System.Windows.Forms.TextBox();
			this.btnClearFields = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 203);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(391, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "________________________________________________________________";
			// 
			// btnSaveAndCopy
			// 
			this.btnSaveAndCopy.Location = new System.Drawing.Point(339, 316);
			this.btnSaveAndCopy.Name = "btnSaveAndCopy";
			this.btnSaveAndCopy.Size = new System.Drawing.Size(114, 33);
			this.btnSaveAndCopy.TabIndex = 7;
			this.btnSaveAndCopy.Text = "Gravar e Copiar";
			this.btnSaveAndCopy.UseVisualStyleBackColor = true;
			this.btnSaveAndCopy.Click += new System.EventHandler(this.BtnGravarECopiarClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.label4.Location = new System.Drawing.Point(3, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Mensagem a ser exibida";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.label3.Location = new System.Drawing.Point(68, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Horário da Queda";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.label2.Location = new System.Drawing.Point(68, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Operadora";
			// 
			// textBox2_horarioQueda
			// 
			this.textBox2_horarioQueda.Location = new System.Drawing.Point(178, 158);
			this.textBox2_horarioQueda.Name = "textBox2_horarioQueda";
			this.textBox2_horarioQueda.Size = new System.Drawing.Size(196, 20);
			this.textBox2_horarioQueda.TabIndex = 3;
			// 
			// textBox1_nomeOperadora
			// 
			this.textBox1_nomeOperadora.Location = new System.Drawing.Point(178, 126);
			this.textBox1_nomeOperadora.Name = "textBox1_nomeOperadora";
			this.textBox1_nomeOperadora.Size = new System.Drawing.Size(196, 20);
			this.textBox1_nomeOperadora.TabIndex = 2;
			// 
			// btnClearFields
			// 
			this.btnClearFields.Location = new System.Drawing.Point(219, 316);
			this.btnClearFields.Name = "btnClearFields";
			this.btnClearFields.Size = new System.Drawing.Size(114, 33);
			this.btnClearFields.TabIndex = 1;
			this.btnClearFields.Text = "Apagar";
			this.btnClearFields.UseVisualStyleBackColor = true;
			this.btnClearFields.Click += new System.EventHandler(this.BtnApagarCamposClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.label1.Location = new System.Drawing.Point(3, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prezados, bom dia! Identificamos alarme do link da __ (operadora) indisponível as" +
	" ___ (hh:mm). Iremos seguir com acionamento junto ao fornecedor.";
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.Location = new System.Drawing.Point(44, 317);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(114, 33);
			this.btnCloseWindow.TabIndex = 9;
			this.btnCloseWindow.Text = "Fechar";
			this.btnCloseWindow.UseVisualStyleBackColor = true;
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnFecharJanelaClick);
			// 
			// UcAlarmeDeLinkIndisponivel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSaveAndCopy);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2_horarioQueda);
			this.Controls.Add(this.textBox1_nomeOperadora);
			this.Controls.Add(this.btnClearFields);
			this.Controls.Add(this.label1);
			this.Name = "UcAlarmeDeLinkIndisponivel";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
