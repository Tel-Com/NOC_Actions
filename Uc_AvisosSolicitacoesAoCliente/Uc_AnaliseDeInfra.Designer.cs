namespace NOC_Actions
{
	partial class Uc_AnaliseDeInfra
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnSalvarECopiar;
		private System.Windows.Forms.Button btnApagarCampos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_unidade;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label_aviso;
		private System.Windows.Forms.ComboBox comboBox_tipoDeAnalise;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBox_MensagemASerEncaminhadaAoCliente;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnGerarAlerta;
		private System.Windows.Forms.ComboBox comboBox_OperadoraDaUnidade;

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
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnSalvarECopiar = new System.Windows.Forms.Button();
            this.btnApagarCampos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_OperadoraDaUnidade = new System.Windows.Forms.ComboBox();
            this.comboBox_unidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_aviso = new System.Windows.Forms.Label();
            this.comboBox_tipoDeAnalise = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_MensagemASerEncaminhadaAoCliente = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGerarAlerta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCloseWindow.ForeColor = System.Drawing.Color.Black;
            this.btnCloseWindow.Location = new System.Drawing.Point(48, 394);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(128, 54);
            this.btnCloseWindow.TabIndex = 6;
            this.btnCloseWindow.Text = "Fechar";
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            // 
            // btnSalvarECopiar
            // 
            this.btnSalvarECopiar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarECopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarECopiar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvarECopiar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarECopiar.Location = new System.Drawing.Point(480, 394);
            this.btnSalvarECopiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarECopiar.Name = "btnSalvarECopiar";
            this.btnSalvarECopiar.Size = new System.Drawing.Size(128, 54);
            this.btnSalvarECopiar.TabIndex = 4;
            this.btnSalvarECopiar.Text = "Gravar e Copiar";
            this.btnSalvarECopiar.UseVisualStyleBackColor = false;
            this.btnSalvarECopiar.Click += new System.EventHandler(this.btnSalvarECopiar_Click_1);
            // 
            // btnApagarCampos
            // 
            this.btnApagarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnApagarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarCampos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnApagarCampos.ForeColor = System.Drawing.Color.Black;
            this.btnApagarCampos.Location = new System.Drawing.Point(184, 394);
            this.btnApagarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnApagarCampos.Name = "btnApagarCampos";
            this.btnApagarCampos.Size = new System.Drawing.Size(152, 54);
            this.btnApagarCampos.TabIndex = 5;
            this.btnApagarCampos.Text = "Apagar campos";
            this.btnApagarCampos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mensagem - Análise de infra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Operadora";
            // 
            // comboBox_OperadoraDaUnidade
            // 
            this.comboBox_OperadoraDaUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_OperadoraDaUnidade.FormattingEnabled = true;
            this.comboBox_OperadoraDaUnidade.Location = new System.Drawing.Point(15, 52);
            this.comboBox_OperadoraDaUnidade.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_OperadoraDaUnidade.Name = "comboBox_OperadoraDaUnidade";
            this.comboBox_OperadoraDaUnidade.Size = new System.Drawing.Size(200, 29);
            this.comboBox_OperadoraDaUnidade.TabIndex = 0;
            // 
            // comboBox_unidade
            // 
            this.comboBox_unidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_unidade.FormattingEnabled = true;
            this.comboBox_unidade.Location = new System.Drawing.Point(239, 52);
            this.comboBox_unidade.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_unidade.Name = "comboBox_unidade";
            this.comboBox_unidade.Size = new System.Drawing.Size(368, 29);
            this.comboBox_unidade.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(239, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Unidade";
            // 
            // label_aviso
            // 
            this.label_aviso.AutoSize = true;
            this.label_aviso.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label_aviso.ForeColor = System.Drawing.Color.Red;
            this.label_aviso.Location = new System.Drawing.Point(15, 85);
            this.label_aviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_aviso.Name = "label_aviso";
            this.label_aviso.Size = new System.Drawing.Size(575, 23);
            this.label_aviso.TabIndex = 20;
            this.label_aviso.Text = "Aviso: A designação ficará atrelada à unidade e a outras informações dela.";
            this.label_aviso.Visible = false;
            // 
            // comboBox_tipoDeAnalise
            // 
            this.comboBox_tipoDeAnalise.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_tipoDeAnalise.FormattingEnabled = true;
            this.comboBox_tipoDeAnalise.Location = new System.Drawing.Point(15, 132);
            this.comboBox_tipoDeAnalise.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_tipoDeAnalise.Name = "comboBox_tipoDeAnalise";
            this.comboBox_tipoDeAnalise.Size = new System.Drawing.Size(200, 29);
            this.comboBox_tipoDeAnalise.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo de análise";
            // 
            // richTextBox_MensagemASerEncaminhadaAoCliente
            // 
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Location = new System.Drawing.Point(15, 204);
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Name = "richTextBox_MensagemASerEncaminhadaAoCliente";
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Size = new System.Drawing.Size(592, 149);
            this.richTextBox_MensagemASerEncaminhadaAoCliente.TabIndex = 3;
            this.richTextBox_MensagemASerEncaminhadaAoCliente.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mensagem a ser encaminhada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(1, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(654, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(224, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnGerarAlerta
            // 
            this.btnGerarAlerta.BackColor = System.Drawing.Color.Transparent;
            this.btnGerarAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarAlerta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnGerarAlerta.ForeColor = System.Drawing.Color.Black;
            this.btnGerarAlerta.Location = new System.Drawing.Point(344, 394);
            this.btnGerarAlerta.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarAlerta.Name = "btnGerarAlerta";
            this.btnGerarAlerta.Size = new System.Drawing.Size(128, 54);
            this.btnGerarAlerta.TabIndex = 28;
            this.btnGerarAlerta.Text = "Gerar";
            this.btnGerarAlerta.UseVisualStyleBackColor = false;
            // 
            // Uc_AnaliseDeInfra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnGerarAlerta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_MensagemASerEncaminhadaAoCliente);
            this.Controls.Add(this.comboBox_tipoDeAnalise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_aviso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_unidade);
            this.Controls.Add(this.comboBox_OperadoraDaUnidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSalvarECopiar);
            this.Controls.Add(this.btnApagarCampos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_AnaliseDeInfra";
            this.Size = new System.Drawing.Size(627, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
