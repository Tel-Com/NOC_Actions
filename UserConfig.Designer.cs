/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 01/02/2025
 * Time: 02:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOCActions
{
	partial class UserConfig
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAdicionarOperadora;
		private System.Windows.Forms.Button btnAdicionarOperadora;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxOperadoraJaAdicionadas;
		private System.Windows.Forms.Button btnDeletarOperadora;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonDeletarCidade;
		private System.Windows.Forms.ComboBox comboBoxCidadeAdicionada;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonAdicionarCidade;
		private System.Windows.Forms.TextBox textBoxAdicionarCidade;
		private System.Windows.Forms.Label label5;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxAdicionarOperadora = new System.Windows.Forms.TextBox();
			this.btnAdicionarOperadora = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxOperadoraJaAdicionadas = new System.Windows.Forms.ComboBox();
			this.btnDeletarOperadora = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonDeletarCidade = new System.Windows.Forms.Button();
			this.comboBoxCidadeAdicionada = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonAdicionarCidade = new System.Windows.Forms.Button();
			this.textBoxAdicionarCidade = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adicionar Operadora";
			// 
			// textBoxAdicionarOperadora
			// 
			this.textBoxAdicionarOperadora.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAdicionarOperadora.Location = new System.Drawing.Point(165, 85);
			this.textBoxAdicionarOperadora.Name = "textBoxAdicionarOperadora";
			this.textBoxAdicionarOperadora.Size = new System.Drawing.Size(172, 22);
			this.textBoxAdicionarOperadora.TabIndex = 1;
			// 
			// btnAdicionarOperadora
			// 
			this.btnAdicionarOperadora.Location = new System.Drawing.Point(345, 85);
			this.btnAdicionarOperadora.Name = "btnAdicionarOperadora";
			this.btnAdicionarOperadora.Size = new System.Drawing.Size(77, 23);
			this.btnAdicionarOperadora.TabIndex = 2;
			this.btnAdicionarOperadora.Text = "Adicionar";
			this.btnAdicionarOperadora.UseVisualStyleBackColor = true;
			this.btnAdicionarOperadora.Click += new System.EventHandler(this.BtnAdicionarOperadoraClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Opers. adicionadas";
			// 
			// comboBoxOperadoraJaAdicionadas
			// 
			this.comboBoxOperadoraJaAdicionadas.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxOperadoraJaAdicionadas.FormattingEnabled = true;
			this.comboBoxOperadoraJaAdicionadas.Location = new System.Drawing.Point(165, 113);
			this.comboBoxOperadoraJaAdicionadas.Name = "comboBoxOperadoraJaAdicionadas";
			this.comboBoxOperadoraJaAdicionadas.Size = new System.Drawing.Size(172, 24);
			this.comboBoxOperadoraJaAdicionadas.TabIndex = 4;
			// 
			// btnDeletarOperadora
			// 
			this.btnDeletarOperadora.Location = new System.Drawing.Point(345, 111);
			this.btnDeletarOperadora.Name = "btnDeletarOperadora";
			this.btnDeletarOperadora.Size = new System.Drawing.Size(77, 23);
			this.btnDeletarOperadora.TabIndex = 5;
			this.btnDeletarOperadora.Text = "Deletar";
			this.btnDeletarOperadora.UseVisualStyleBackColor = true;
			this.btnDeletarOperadora.Click += new System.EventHandler(this.BtnDeletarOperadoraClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label3.Location = new System.Drawing.Point(0, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(463, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "_________________________________________________________________";
			// 
			// buttonDeletarCidade
			// 
			this.buttonDeletarCidade.Location = new System.Drawing.Point(345, 39);
			this.buttonDeletarCidade.Name = "buttonDeletarCidade";
			this.buttonDeletarCidade.Size = new System.Drawing.Size(77, 23);
			this.buttonDeletarCidade.TabIndex = 12;
			this.buttonDeletarCidade.Text = "Deletar";
			this.buttonDeletarCidade.UseVisualStyleBackColor = true;
			this.buttonDeletarCidade.Click += new System.EventHandler(this.ButtonDeletarCidadeClick);
			// 
			// comboBoxCidadeAdicionada
			// 
			this.comboBoxCidadeAdicionada.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxCidadeAdicionada.FormattingEnabled = true;
			this.comboBoxCidadeAdicionada.Location = new System.Drawing.Point(165, 41);
			this.comboBoxCidadeAdicionada.Name = "comboBoxCidadeAdicionada";
			this.comboBoxCidadeAdicionada.Size = new System.Drawing.Size(172, 24);
			this.comboBoxCidadeAdicionada.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Cidades adicionadas";
			// 
			// buttonAdicionarCidade
			// 
			this.buttonAdicionarCidade.Location = new System.Drawing.Point(345, 13);
			this.buttonAdicionarCidade.Name = "buttonAdicionarCidade";
			this.buttonAdicionarCidade.Size = new System.Drawing.Size(77, 23);
			this.buttonAdicionarCidade.TabIndex = 9;
			this.buttonAdicionarCidade.Text = "Adicionar";
			this.buttonAdicionarCidade.UseVisualStyleBackColor = true;
			this.buttonAdicionarCidade.Click += new System.EventHandler(this.ButtonAdicionarCidadeClick);
			// 
			// textBoxAdicionarCidade
			// 
			this.textBoxAdicionarCidade.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAdicionarCidade.Location = new System.Drawing.Point(165, 13);
			this.textBoxAdicionarCidade.Name = "textBoxAdicionarCidade";
			this.textBoxAdicionarCidade.Size = new System.Drawing.Size(172, 22);
			this.textBoxAdicionarCidade.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Adicionar Cidade";
			// 
			// UserConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 148);
			this.Controls.Add(this.buttonDeletarCidade);
			this.Controls.Add(this.comboBoxCidadeAdicionada);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonAdicionarCidade);
			this.Controls.Add(this.textBoxAdicionarCidade);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnDeletarOperadora);
			this.Controls.Add(this.comboBoxOperadoraJaAdicionadas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAdicionarOperadora);
			this.Controls.Add(this.textBoxAdicionarOperadora);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "UserConfig";
			this.Text = "Configurações";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
