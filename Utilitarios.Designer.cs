/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 29/09/2025
 * Hora: 10:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Actions
{
	partial class Utilitarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox_TextoUtilitario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btnClose;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.richTextBox_TextoUtilitario = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox_TextoUtilitario
			// 
			this.richTextBox_TextoUtilitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox_TextoUtilitario.Location = new System.Drawing.Point(6, 28);
			this.richTextBox_TextoUtilitario.Name = "richTextBox_TextoUtilitario";
			this.richTextBox_TextoUtilitario.Size = new System.Drawing.Size(644, 563);
			this.richTextBox_TextoUtilitario.TabIndex = 0;
			this.richTextBox_TextoUtilitario.Text = "";
//			this.richTextBox_TextoUtilitario.TextChanged += new System.EventHandler(this.RichTextBox_TextoUtilitarioTextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(655, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "Informações utilitárias de uso diário";
			// 
			// btnClose
			// 
			this.btnClose.AutoSize = true;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(631, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(19, 21);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "X";
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// Utilitarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(655, 604);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.richTextBox_TextoUtilitario);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Utilitarios";
			this.Text = "Utilitarios";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
