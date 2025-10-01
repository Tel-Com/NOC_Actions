///*
// * Criado por SharpDevelop.
// * Usuário: fjstavares
// * Data: 28/09/2025
// * Hora: 11:37
// * 
// * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
// */
//namespace NOC_Actions
//{
//	partial class MainForm
//	{
//		/// <summary>
//		/// Designer variable used to keep track of non-visual components.
//		/// </summary>
//		private System.ComponentModel.IContainer components = null;
//		
//		/// <summary>
//		/// Disposes resources used by the form.
//		/// </summary>
//		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//		protected override void Dispose(bool disposing)
//		{
//			if (disposing) {
//				if (components != null) {
//					components.Dispose();
//				}
//			}
//			base.Dispose(disposing);
//		}
//		
//		/// <summary>
//		/// This method is required for Windows Forms designer support.
//		/// Do not change the method contents inside the source code editor. The Forms designer might
//		/// not be able to load this method if it was changed manually.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			this.SuspendLayout();
//			// 
//			// MainForm
//			// 
//			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//			this.ClientSize = new System.Drawing.Size(839, 284);
//			this.Name = "MainForm";
//			this.Text = "MainForm";
//			this.ResumeLayout(false);
//
//		}
//	}
//}

/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 08/07/2024
 * Hora: 06:37
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
 
 
namespace NOC_Actions
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
			this.btnAberturaDeMassiva = new System.Windows.Forms.Button();
			this.btnInformesClientes = new System.Windows.Forms.Button();
			this.btnAcessosEUtilitarios = new System.Windows.Forms.Button();
			this.PointerMouseMove = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// ButtonSemContatoLocal
			// 
			this.ButtonSemContatoLocal.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonSemContatoLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSemContatoLocal.Location = new System.Drawing.Point(883, 0);
			this.ButtonSemContatoLocal.Name = "ButtonSemContatoLocal";
			this.ButtonSemContatoLocal.Size = new System.Drawing.Size(97, 292);
			this.ButtonSemContatoLocal.TabIndex = 2;
			this.ButtonSemContatoLocal.Text = "Sem contato local";
			this.ButtonSemContatoLocal.UseVisualStyleBackColor = true;
			this.ButtonSemContatoLocal.Click += new System.EventHandler(this.ButtonSemContatoLocalClick);
			// 
			// ButtonSemExpediente
			// 
			this.ButtonSemExpediente.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonSemExpediente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSemExpediente.Location = new System.Drawing.Point(786, 0);
			this.ButtonSemExpediente.Name = "ButtonSemExpediente";
			this.ButtonSemExpediente.Size = new System.Drawing.Size(97, 292);
			this.ButtonSemExpediente.TabIndex = 3;
			this.ButtonSemExpediente.Text = "Sem expediente";
			this.ButtonSemExpediente.UseVisualStyleBackColor = true;
			this.ButtonSemExpediente.Click += new System.EventHandler(this.ButtonSemExpedienteClick);
			// 
			// ButtonInfraOkCliente
			// 
			this.ButtonInfraOkCliente.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonInfraOkCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonInfraOkCliente.Location = new System.Drawing.Point(689, 0);
			this.ButtonInfraOkCliente.Name = "ButtonInfraOkCliente";
			this.ButtonInfraOkCliente.Size = new System.Drawing.Size(97, 292);
			this.ButtonInfraOkCliente.TabIndex = 4;
			this.ButtonInfraOkCliente.Text = "(Cliente) Infra OK";
			this.ButtonInfraOkCliente.UseVisualStyleBackColor = true;
			this.ButtonInfraOkCliente.Click += new System.EventHandler(this.ButtonInfraOkClienteClick);
			// 
			// ButtonSemContatoOperadora
			// 
			this.ButtonSemContatoOperadora.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonSemContatoOperadora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSemContatoOperadora.Location = new System.Drawing.Point(592, 0);
			this.ButtonSemContatoOperadora.Name = "ButtonSemContatoOperadora";
			this.ButtonSemContatoOperadora.Size = new System.Drawing.Size(97, 292);
			this.ButtonSemContatoOperadora.TabIndex = 5;
			this.ButtonSemContatoOperadora.Text = "Operadora não atende";
			this.ButtonSemContatoOperadora.UseVisualStyleBackColor = true;
			this.ButtonSemContatoOperadora.Click += new System.EventHandler(this.ButtonSemContatoOperadoraClick);
			// 
			// ButtonAberturaDeOs
			// 
			this.ButtonAberturaDeOs.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonAberturaDeOs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAberturaDeOs.Location = new System.Drawing.Point(495, 0);
			this.ButtonAberturaDeOs.Name = "ButtonAberturaDeOs";
			this.ButtonAberturaDeOs.Size = new System.Drawing.Size(97, 292);
			this.ButtonAberturaDeOs.TabIndex = 6;
			this.ButtonAberturaDeOs.Text = "Abertura de OS";
			this.ButtonAberturaDeOs.UseVisualStyleBackColor = true;
			this.ButtonAberturaDeOs.Click += new System.EventHandler(this.ButtonAberturaDeOsClick);
			// 
			// ButtonPosicionamentoTecnico
			// 
			this.ButtonPosicionamentoTecnico.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonPosicionamentoTecnico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonPosicionamentoTecnico.Location = new System.Drawing.Point(398, 0);
			this.ButtonPosicionamentoTecnico.Name = "ButtonPosicionamentoTecnico";
			this.ButtonPosicionamentoTecnico.Size = new System.Drawing.Size(97, 292);
			this.ButtonPosicionamentoTecnico.TabIndex = 7;
			this.ButtonPosicionamentoTecnico.Text = "Posiciona. OS";
			this.ButtonPosicionamentoTecnico.UseVisualStyleBackColor = true;
			this.ButtonPosicionamentoTecnico.Click += new System.EventHandler(this.ButtonPosicionamentoTecnicoClick);
			// 
			// SemEnergia
			// 
			this.SemEnergia.Dock = System.Windows.Forms.DockStyle.Right;
			this.SemEnergia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SemEnergia.Location = new System.Drawing.Point(301, 0);
			this.SemEnergia.Name = "SemEnergia";
			this.SemEnergia.Size = new System.Drawing.Size(97, 292);
			this.SemEnergia.TabIndex = 8;
			this.SemEnergia.Text = "Sem energia";
			this.SemEnergia.UseVisualStyleBackColor = true;
			this.SemEnergia.Click += new System.EventHandler(this.SemEnergiaClick);
			// 
			// btnAberturaDeMassiva
			// 
			this.btnAberturaDeMassiva.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAberturaDeMassiva.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAberturaDeMassiva.Location = new System.Drawing.Point(204, 0);
			this.btnAberturaDeMassiva.Name = "btnAberturaDeMassiva";
			this.btnAberturaDeMassiva.Size = new System.Drawing.Size(97, 292);
			this.btnAberturaDeMassiva.TabIndex = 11;
			this.btnAberturaDeMassiva.Text = "Massiva";
			this.btnAberturaDeMassiva.UseVisualStyleBackColor = true;
			this.btnAberturaDeMassiva.Click += new System.EventHandler(this.BtnAberturaDeMassivaClick);
			// 
			// btnInformesClientes
			// 
			this.btnInformesClientes.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnInformesClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInformesClientes.Location = new System.Drawing.Point(107, 0);
			this.btnInformesClientes.Name = "btnInformesClientes";
			this.btnInformesClientes.Size = new System.Drawing.Size(97, 292);
			this.btnInformesClientes.TabIndex = 12;
			this.btnInformesClientes.Text = "Informes";
			this.btnInformesClientes.UseVisualStyleBackColor = true;
			this.btnInformesClientes.Click += new System.EventHandler(this.BtnInformesClientesClick);
			// 
			// btnAcessosEUtilitarios
			// 
			this.btnAcessosEUtilitarios.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAcessosEUtilitarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcessosEUtilitarios.Location = new System.Drawing.Point(10, 0);
			this.btnAcessosEUtilitarios.Name = "btnAcessosEUtilitarios";
			this.btnAcessosEUtilitarios.Size = new System.Drawing.Size(97, 292);
			this.btnAcessosEUtilitarios.TabIndex = 13;
			this.btnAcessosEUtilitarios.Text = "Utilitários";
			this.btnAcessosEUtilitarios.UseVisualStyleBackColor = true;
			this.btnAcessosEUtilitarios.Click += new System.EventHandler(this.BtnAcessosEUtilitariosClick);
			// 
			// PointerMouseMove
			// 
			this.PointerMouseMove.BackColor = System.Drawing.Color.SteelBlue;
			this.PointerMouseMove.Dock = System.Windows.Forms.DockStyle.Left;
			this.PointerMouseMove.Location = new System.Drawing.Point(0, 0);
			this.PointerMouseMove.Name = "PointerMouseMove";
			this.PointerMouseMove.Size = new System.Drawing.Size(10, 292);
			this.PointerMouseMove.TabIndex = 14;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(980, 292);
			this.Controls.Add(this.PointerMouseMove);
			this.Controls.Add(this.btnAcessosEUtilitarios);
			this.Controls.Add(this.btnInformesClientes);
			this.Controls.Add(this.btnAberturaDeMassiva);
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
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button SemEnergia;
		private System.Windows.Forms.Button ButtonPosicionamentoTecnico;
		private System.Windows.Forms.Button ButtonAberturaDeOs;
		private System.Windows.Forms.Button ButtonSemContatoOperadora;
		private System.Windows.Forms.Button ButtonInfraOkCliente;
		private System.Windows.Forms.Button ButtonSemExpediente;
		private System.Windows.Forms.Button ButtonSemContatoLocal;
		private System.Windows.Forms.Button btnAberturaDeMassiva;
		private System.Windows.Forms.Button btnInformesClientes;
		private System.Windows.Forms.Button btnAcessosEUtilitarios;
		private System.Windows.Forms.Panel PointerMouseMove;
		
	}
}

