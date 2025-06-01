/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 08/07/2024
 * Hora: 06:37
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOCActions
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.ButtonSemContatoLocal = new System.Windows.Forms.Button();
			this.ButtonSemExpediente = new System.Windows.Forms.Button();
			this.ButtonInfraOkCliente = new System.Windows.Forms.Button();
			this.ButtonSemContatoOperadora = new System.Windows.Forms.Button();
			this.ButtonAberturaDeOs = new System.Windows.Forms.Button();
			this.ButtonPosicionamentoTecnico = new System.Windows.Forms.Button();
			this.SemEnergia = new System.Windows.Forms.Button();
			this.buttonMaisAcoes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonSemContatoLocal
			// 
			this.ButtonSemContatoLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSemContatoLocal.Location = new System.Drawing.Point(203, 5);
			this.ButtonSemContatoLocal.Name = "ButtonSemContatoLocal";
			this.ButtonSemContatoLocal.Size = new System.Drawing.Size(97, 59);
			this.ButtonSemContatoLocal.TabIndex = 2;
			this.ButtonSemContatoLocal.Text = "Sem contato Local";
			this.ButtonSemContatoLocal.UseVisualStyleBackColor = true;
			this.ButtonSemContatoLocal.Click += new System.EventHandler(this.ButtonSemContatoLocalClick);
			// 
			// ButtonSemExpediente
			// 
			this.ButtonSemExpediente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSemExpediente.Location = new System.Drawing.Point(303, 5);
			this.ButtonSemExpediente.Name = "ButtonSemExpediente";
			this.ButtonSemExpediente.Size = new System.Drawing.Size(97, 59);
			this.ButtonSemExpediente.TabIndex = 3;
			this.ButtonSemExpediente.Text = "Sem Expediente";
			this.ButtonSemExpediente.UseVisualStyleBackColor = true;
			this.ButtonSemExpediente.Click += new System.EventHandler(this.ButtonSemExpedienteClick);
			// 
			// ButtonInfraOkCliente
			// 
			this.ButtonInfraOkCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonInfraOkCliente.Location = new System.Drawing.Point(403, 5);
			this.ButtonInfraOkCliente.Name = "ButtonInfraOkCliente";
			this.ButtonInfraOkCliente.Size = new System.Drawing.Size(97, 59);
			this.ButtonInfraOkCliente.TabIndex = 4;
			this.ButtonInfraOkCliente.Text = "(Cliente) Infra OK";
			this.ButtonInfraOkCliente.UseVisualStyleBackColor = true;
			this.ButtonInfraOkCliente.Click += new System.EventHandler(this.ButtonInfraOkClienteClick);
			// 
			// ButtonSemContatoOperadora
			// 
			this.ButtonSemContatoOperadora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSemContatoOperadora.Location = new System.Drawing.Point(503, 5);
			this.ButtonSemContatoOperadora.Name = "ButtonSemContatoOperadora";
			this.ButtonSemContatoOperadora.Size = new System.Drawing.Size(97, 59);
			this.ButtonSemContatoOperadora.TabIndex = 5;
			this.ButtonSemContatoOperadora.Text = "Operadora Não Atende";
			this.ButtonSemContatoOperadora.UseVisualStyleBackColor = true;
			this.ButtonSemContatoOperadora.Click += new System.EventHandler(this.ButtonSemContatoOperadoraClick);
			// 
			// ButtonAberturaDeOs
			// 
			this.ButtonAberturaDeOs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAberturaDeOs.Location = new System.Drawing.Point(603, 5);
			this.ButtonAberturaDeOs.Name = "ButtonAberturaDeOs";
			this.ButtonAberturaDeOs.Size = new System.Drawing.Size(97, 59);
			this.ButtonAberturaDeOs.TabIndex = 6;
			this.ButtonAberturaDeOs.Text = "(Frase E-mail) Abertura de OS";
			this.ButtonAberturaDeOs.UseVisualStyleBackColor = true;
			this.ButtonAberturaDeOs.Click += new System.EventHandler(this.ButtonAberturaDeOsClick);
			// 
			// ButtonPosicionamentoTecnico
			// 
			this.ButtonPosicionamentoTecnico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonPosicionamentoTecnico.Location = new System.Drawing.Point(703, 5);
			this.ButtonPosicionamentoTecnico.Name = "ButtonPosicionamentoTecnico";
			this.ButtonPosicionamentoTecnico.Size = new System.Drawing.Size(97, 59);
			this.ButtonPosicionamentoTecnico.TabIndex = 7;
			this.ButtonPosicionamentoTecnico.Text = "(E-mail) Posiciona. OS";
			this.ButtonPosicionamentoTecnico.UseVisualStyleBackColor = true;
			this.ButtonPosicionamentoTecnico.Click += new System.EventHandler(this.ButtonPosicionamentoTecnicoClick);
			// 
			// SemEnergia
			// 
			this.SemEnergia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SemEnergia.Location = new System.Drawing.Point(103, 5);
			this.SemEnergia.Name = "SemEnergia";
			this.SemEnergia.Size = new System.Drawing.Size(97, 59);
			this.SemEnergia.TabIndex = 8;
			this.SemEnergia.Text = "Sem Energia";
			this.SemEnergia.UseVisualStyleBackColor = true;
			this.SemEnergia.Click += new System.EventHandler(this.SemEnergiaClick);
			// 
			// buttonMaisAcoes
			// 
			this.buttonMaisAcoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMaisAcoes.Location = new System.Drawing.Point(3, 5);
			this.buttonMaisAcoes.Name = "buttonMaisAcoes";
			this.buttonMaisAcoes.Size = new System.Drawing.Size(97, 59);
			this.buttonMaisAcoes.TabIndex = 9;
			this.buttonMaisAcoes.Text = "Ações Específicas";
			this.buttonMaisAcoes.UseVisualStyleBackColor = true;
			this.buttonMaisAcoes.Click += new System.EventHandler(this.ButtonMaisAcoesClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(787, 75);
			this.Controls.Add(this.buttonMaisAcoes);
			this.Controls.Add(this.SemEnergia);
			this.Controls.Add(this.ButtonPosicionamentoTecnico);
			this.Controls.Add(this.ButtonAberturaDeOs);
			this.Controls.Add(this.ButtonSemContatoOperadora);
			this.Controls.Add(this.ButtonInfraOkCliente);
			this.Controls.Add(this.ButtonSemExpediente);
			this.Controls.Add(this.ButtonSemContatoLocal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button SemEnergia;
		private System.Windows.Forms.Button ButtonPosicionamentoTecnico;
		private System.Windows.Forms.Button ButtonAberturaDeOs;
		private System.Windows.Forms.Button ButtonSemContatoOperadora;
		private System.Windows.Forms.Button ButtonInfraOkCliente;
		private System.Windows.Forms.Button ButtonSemExpediente;
		private System.Windows.Forms.Button ButtonSemContatoLocal;
		private System.Windows.Forms.Button buttonMaisAcoes;
		
	}
}
