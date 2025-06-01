/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 26/02/2025
 * Time: 15:19
 */
namespace NOCActions
{
	partial class MenuDeAcesso
	{
		private System.ComponentModel.IContainer components = null;
//		private System.Windows.Forms.Button buttonAvaliacaoComCliente;
		private System.Windows.Forms.Button button1AcaoAberturaDeMassiva;
		private System.Windows.Forms.Button btnEmailAberturaDeReparoParaCliente;
		
		// Adicione no topo da classe
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Button buttonFechar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;

		
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
			this.buttonFechar = new System.Windows.Forms.Button();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.panelTop = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button1AcaoAberturaDeMassiva = new System.Windows.Forms.Button();
			this.btnEmailAberturaDeReparoParaCliente = new System.Windows.Forms.Button();
			this.panelTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonFechar
			// 
			this.buttonFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
			this.buttonFechar.FlatAppearance.BorderSize = 0;
			this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFechar.ForeColor = System.Drawing.Color.White;
			this.buttonFechar.Location = new System.Drawing.Point(275, 5);
			this.buttonFechar.Name = "buttonFechar";
			this.buttonFechar.Size = new System.Drawing.Size(30, 30);
			this.buttonFechar.TabIndex = 1;
			this.buttonFechar.Text = "X";
			this.buttonFechar.UseVisualStyleBackColor = false;
			this.buttonFechar.Click += new System.EventHandler(this.ButtonFecharClick);
			// 
			// labelTitulo
			// 
			this.labelTitulo.AutoSize = true;
			this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.labelTitulo.ForeColor = System.Drawing.Color.White;
			this.labelTitulo.Location = new System.Drawing.Point(10, 10);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(184, 20);
			this.labelTitulo.TabIndex = 0;
			this.labelTitulo.Text = "Menu - Ações Específicas";
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
			this.panelTop.Controls.Add(this.labelTitulo);
			this.panelTop.Controls.Add(this.buttonFechar);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(308, 40);
			this.panelTop.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button1.Location = new System.Drawing.Point(208, 46);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 71);
			this.button1.TabIndex = 5;
			this.button1.Text = "Ação";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button2.Location = new System.Drawing.Point(3, 121);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(97, 71);
			this.button2.TabIndex = 6;
			this.button2.Text = "Ação";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button3.Location = new System.Drawing.Point(106, 121);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 71);
			this.button3.TabIndex = 7;
			this.button3.Text = "Ação";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button4.Location = new System.Drawing.Point(208, 122);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(97, 71);
			this.button4.TabIndex = 8;
			this.button4.Text = "Ação";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button1AcaoAberturaDeMassiva
			// 
			this.button1AcaoAberturaDeMassiva.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button1AcaoAberturaDeMassiva.Location = new System.Drawing.Point(3, 46);
			this.button1AcaoAberturaDeMassiva.Name = "button1AcaoAberturaDeMassiva";
			this.button1AcaoAberturaDeMassiva.Size = new System.Drawing.Size(97, 71);
			this.button1AcaoAberturaDeMassiva.TabIndex = 9;
			this.button1AcaoAberturaDeMassiva.Text = "Abertura de Massiva";
			this.button1AcaoAberturaDeMassiva.UseVisualStyleBackColor = true;
			this.button1AcaoAberturaDeMassiva.Click += new System.EventHandler(this.Button1AcaoAberturaDeMassivaClick);
			// 
			// btnEmailAberturaDeReparoParaCliente
			// 
			this.btnEmailAberturaDeReparoParaCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnEmailAberturaDeReparoParaCliente.Location = new System.Drawing.Point(105, 46);
			this.btnEmailAberturaDeReparoParaCliente.Name = "btnEmailAberturaDeReparoParaCliente";
			this.btnEmailAberturaDeReparoParaCliente.Size = new System.Drawing.Size(97, 71);
			this.btnEmailAberturaDeReparoParaCliente.TabIndex = 10;
			this.btnEmailAberturaDeReparoParaCliente.Text = "Abertura de reparo";
			this.btnEmailAberturaDeReparoParaCliente.UseVisualStyleBackColor = true;
			this.btnEmailAberturaDeReparoParaCliente.Click += new System.EventHandler(this.BtnEmailAberturaDeReparoParaClienteClick);
			// 
			// MenuDeAcesso
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(308, 202);
			this.Controls.Add(this.btnEmailAberturaDeReparoParaCliente);
			this.Controls.Add(this.button1AcaoAberturaDeMassiva);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panelTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MenuDeAcesso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.ResumeLayout(false);

		}

	}
}
