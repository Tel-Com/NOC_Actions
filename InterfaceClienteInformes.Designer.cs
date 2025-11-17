namespace NOC_Actions
{
	partial class InterfaceClienteInformes
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAlarmeLinkIndisponivel;
		private System.Windows.Forms.Button btnChamadoRegistrado;
		private System.Windows.Forms.Button btnLibAcessoSemPrevisao;
		private System.Windows.Forms.Button btnLibAcessoComPrevisao;
		private System.Windows.Forms.Button btnAnaliseEnergia;

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel painelInterface;
		private System.Windows.Forms.Label label_userName;
		private System.Windows.Forms.Button btnPendenciaFinanceira;
		private System.Windows.Forms.Button btnNoTicket;

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
			this.btnAlarmeLinkIndisponivel = new System.Windows.Forms.Button();
			this.btnChamadoRegistrado = new System.Windows.Forms.Button();
			this.btnLibAcessoSemPrevisao = new System.Windows.Forms.Button();
			this.btnLibAcessoComPrevisao = new System.Windows.Forms.Button();
			this.btnAnaliseEnergia = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnNoTicket = new System.Windows.Forms.Button();
			this.btnPendenciaFinanceira = new System.Windows.Forms.Button();
			this.label_userName = new System.Windows.Forms.Label();
			this.painelInterface = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAlarmeLinkIndisponivel
			// 
			this.btnAlarmeLinkIndisponivel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAlarmeLinkIndisponivel.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnAlarmeLinkIndisponivel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnAlarmeLinkIndisponivel.Location = new System.Drawing.Point(0, 0);
			this.btnAlarmeLinkIndisponivel.Name = "btnAlarmeLinkIndisponivel";
			this.btnAlarmeLinkIndisponivel.Size = new System.Drawing.Size(268, 24);
			this.btnAlarmeLinkIndisponivel.TabIndex = 0;
			this.btnAlarmeLinkIndisponivel.Text = "Alarme de Link Indisponível";
			this.btnAlarmeLinkIndisponivel.Click += new System.EventHandler(this.BtnAlarmeLinkIndisponivel_Click);
			// 
			// btnChamadoRegistrado
			// 
			this.btnChamadoRegistrado.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChamadoRegistrado.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnChamadoRegistrado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnChamadoRegistrado.Location = new System.Drawing.Point(0, 24);
			this.btnChamadoRegistrado.Name = "btnChamadoRegistrado";
			this.btnChamadoRegistrado.Size = new System.Drawing.Size(268, 25);
			this.btnChamadoRegistrado.TabIndex = 1;
			this.btnChamadoRegistrado.Text = "Chamado Registrado";
			this.btnChamadoRegistrado.Click += new System.EventHandler(this.BtnChamadoRegistrado_Click);
			// 
			// btnLibAcessoSemPrevisao
			// 
			this.btnLibAcessoSemPrevisao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLibAcessoSemPrevisao.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLibAcessoSemPrevisao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnLibAcessoSemPrevisao.Location = new System.Drawing.Point(0, 49);
			this.btnLibAcessoSemPrevisao.Name = "btnLibAcessoSemPrevisao";
			this.btnLibAcessoSemPrevisao.Size = new System.Drawing.Size(268, 25);
			this.btnLibAcessoSemPrevisao.TabIndex = 2;
			this.btnLibAcessoSemPrevisao.Text = "Liberação de Acesso (Sem Previsão)";
			this.btnLibAcessoSemPrevisao.Click += new System.EventHandler(this.BtnLibAcessoSemPrevisao_Click);
			// 
			// btnLibAcessoComPrevisao
			// 
			this.btnLibAcessoComPrevisao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLibAcessoComPrevisao.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLibAcessoComPrevisao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnLibAcessoComPrevisao.Location = new System.Drawing.Point(0, 74);
			this.btnLibAcessoComPrevisao.Name = "btnLibAcessoComPrevisao";
			this.btnLibAcessoComPrevisao.Size = new System.Drawing.Size(268, 25);
			this.btnLibAcessoComPrevisao.TabIndex = 3;
			this.btnLibAcessoComPrevisao.Text = "Liberação de Acesso (Com Previsão)";
			this.btnLibAcessoComPrevisao.Click += new System.EventHandler(this.BtnLibAcessoComPrevisao_Click);
			// 
			// btnAnaliseEnergia
			// 
			this.btnAnaliseEnergia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnaliseEnergia.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnAnaliseEnergia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnAnaliseEnergia.Location = new System.Drawing.Point(0, 99);
			this.btnAnaliseEnergia.Name = "btnAnaliseEnergia";
			this.btnAnaliseEnergia.Size = new System.Drawing.Size(268, 24);
			this.btnAnaliseEnergia.TabIndex = 4;
			this.btnAnaliseEnergia.Text = "Análise de Energia";
			this.btnAnaliseEnergia.Click += new System.EventHandler(this.BtnAnaliseEnergia_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.splitContainer1.Panel1.Controls.Add(this.btnNoTicket);
			this.splitContainer1.Panel1.Controls.Add(this.btnPendenciaFinanceira);
			this.splitContainer1.Panel1.Controls.Add(this.label_userName);
			this.splitContainer1.Panel1.Controls.Add(this.btnAnaliseEnergia);
			this.splitContainer1.Panel1.Controls.Add(this.btnLibAcessoComPrevisao);
			this.splitContainer1.Panel1.Controls.Add(this.btnLibAcessoSemPrevisao);
			this.splitContainer1.Panel1.Controls.Add(this.btnChamadoRegistrado);
			this.splitContainer1.Panel1.Controls.Add(this.btnAlarmeLinkIndisponivel);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel2.Controls.Add(this.painelInterface);
			this.splitContainer1.Size = new System.Drawing.Size(745, 380);
			this.splitContainer1.SplitterDistance = 268;
			this.splitContainer1.TabIndex = 0;
			// 
			// btnNoTicket
			// 
			this.btnNoTicket.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNoTicket.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNoTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnNoTicket.Location = new System.Drawing.Point(0, 147);
			this.btnNoTicket.Name = "btnNoTicket";
			this.btnNoTicket.Size = new System.Drawing.Size(268, 24);
			this.btnNoTicket.TabIndex = 6;
			this.btnNoTicket.Text = "No-Ticket";
			this.btnNoTicket.Click += new System.EventHandler(this.BtnRegistroDeFalhaInternaClienteClick);
			// 
			// btnPendenciaFinanceira
			// 
			this.btnPendenciaFinanceira.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPendenciaFinanceira.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPendenciaFinanceira.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnPendenciaFinanceira.Location = new System.Drawing.Point(0, 123);
			this.btnPendenciaFinanceira.Name = "btnPendenciaFinanceira";
			this.btnPendenciaFinanceira.Size = new System.Drawing.Size(268, 24);
			this.btnPendenciaFinanceira.TabIndex = 5;
			this.btnPendenciaFinanceira.Text = "Pendência Financeira";
			this.btnPendenciaFinanceira.Click += new System.EventHandler(this.BtnPendenciaFinanceiraClick);
			// 
			// label_userName
			// 
			this.label_userName.AutoSize = true;
			this.label_userName.BackColor = System.Drawing.Color.Transparent;
			this.label_userName.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label_userName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label_userName.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label_userName.Location = new System.Drawing.Point(0, 363);
			this.label_userName.Name = "label_userName";
			this.label_userName.Size = new System.Drawing.Size(68, 17);
			this.label_userName.TabIndex = 0;
			this.label_userName.Text = "userName";
			// 
			// painelInterface
			// 
			this.painelInterface.Dock = System.Windows.Forms.DockStyle.Fill;
			this.painelInterface.Location = new System.Drawing.Point(0, 0);
			this.painelInterface.Name = "painelInterface";
			this.painelInterface.Size = new System.Drawing.Size(473, 380);
			this.painelInterface.TabIndex = 0;
			// 
			// InterfaceClienteInformes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(745, 380);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "InterfaceClienteInformes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "InterfaceClienteInformes";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
