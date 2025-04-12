/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 26/02/2025
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOCActions
{
    partial class ACAO_ComunicacaoComCliente
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox3Cc;
        private System.Windows.Forms.ComboBox comboBox1De;
        private System.Windows.Forms.ComboBox comboBox2Para;
        private System.Windows.Forms.TextBox textBox1EmailAssunto;
        private System.Windows.Forms.RichTextBox richTextBox1Descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInformarCliente;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnPreviaEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        
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
        	this.comboBox2Para = new System.Windows.Forms.ComboBox();
        	this.comboBox1De = new System.Windows.Forms.ComboBox();
        	this.comboBox3Cc = new System.Windows.Forms.ComboBox();
        	this.textBox1EmailAssunto = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.richTextBox1Descricao = new System.Windows.Forms.RichTextBox();
        	this.btnDeletar = new System.Windows.Forms.Button();
        	this.btnEnviar = new System.Windows.Forms.Button();
        	this.btnInformarCliente = new System.Windows.Forms.Button();
        	this.btnConfiguracoes = new System.Windows.Forms.Button();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.label7 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.btnPreviaEmail = new System.Windows.Forms.Button();
        	this.panel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// comboBox2Para
        	// 
        	this.comboBox2Para.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
        	this.comboBox2Para.FormattingEnabled = true;
        	this.comboBox2Para.Location = new System.Drawing.Point(97, 50);
        	this.comboBox2Para.Name = "comboBox2Para";
        	this.comboBox2Para.Size = new System.Drawing.Size(619, 26);
        	this.comboBox2Para.TabIndex = 1;
        	// 
        	// comboBox1De
        	// 
        	this.comboBox1De.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
        	this.comboBox1De.FormattingEnabled = true;
        	this.comboBox1De.Location = new System.Drawing.Point(97, 21);
        	this.comboBox1De.Name = "comboBox1De";
        	this.comboBox1De.Size = new System.Drawing.Size(619, 26);
        	this.comboBox1De.TabIndex = 2;
        	// 
        	// comboBox3Cc
        	// 
        	this.comboBox3Cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
        	this.comboBox3Cc.FormattingEnabled = true;
        	this.comboBox3Cc.Location = new System.Drawing.Point(97, 79);
        	this.comboBox3Cc.Name = "comboBox3Cc";
        	this.comboBox3Cc.Size = new System.Drawing.Size(619, 26);
        	this.comboBox3Cc.TabIndex = 3;
        	// 
        	// textBox1EmailAssunto
        	// 
        	this.textBox1EmailAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
        	this.textBox1EmailAssunto.Location = new System.Drawing.Point(97, 119);
        	this.textBox1EmailAssunto.Multiline = true;
        	this.textBox1EmailAssunto.Name = "textBox1EmailAssunto";
        	this.textBox1EmailAssunto.Size = new System.Drawing.Size(619, 27);
        	this.textBox1EmailAssunto.TabIndex = 4;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.label1.Location = new System.Drawing.Point(46, 21);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(29, 21);
        	this.label1.TabIndex = 6;
        	this.label1.Text = "De";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.label4.Location = new System.Drawing.Point(48, 79);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(27, 21);
        	this.label4.TabIndex = 9;
        	this.label4.Text = "Cc";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.label5.Location = new System.Drawing.Point(35, 50);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(40, 21);
        	this.label5.TabIndex = 10;
        	this.label5.Text = "Para";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.label2.Location = new System.Drawing.Point(25, 121);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(66, 21);
        	this.label2.TabIndex = 11;
        	this.label2.Text = "Assunto";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.label3.Location = new System.Drawing.Point(14, 149);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(77, 21);
        	this.label3.TabIndex = 12;
        	this.label3.Text = "Descrição";
        	// 
        	// richTextBox1Descricao
        	// 
        	this.richTextBox1Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
        	this.richTextBox1Descricao.Location = new System.Drawing.Point(97, 153);
        	this.richTextBox1Descricao.Name = "richTextBox1Descricao";
        	this.richTextBox1Descricao.Size = new System.Drawing.Size(619, 257);
        	this.richTextBox1Descricao.TabIndex = 13;
        	this.richTextBox1Descricao.Text = "";
        	// 
        	// btnDeletar
        	// 
        	this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.btnDeletar.Location = new System.Drawing.Point(592, 480);
        	this.btnDeletar.Name = "btnDeletar";
        	this.btnDeletar.Size = new System.Drawing.Size(124, 51);
        	this.btnDeletar.TabIndex = 14;
        	this.btnDeletar.Text = "Deletar";
        	this.btnDeletar.UseVisualStyleBackColor = true;
        	// 
        	// btnEnviar
        	// 
        	this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.btnEnviar.Location = new System.Drawing.Point(446, 480);
        	this.btnEnviar.Name = "btnEnviar";
        	this.btnEnviar.Size = new System.Drawing.Size(124, 51);
        	this.btnEnviar.TabIndex = 15;
        	this.btnEnviar.Text = "Enviar";
        	this.btnEnviar.UseVisualStyleBackColor = true;
        	// 
        	// btnInformarCliente
        	// 
        	this.btnInformarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnInformarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.btnInformarCliente.Location = new System.Drawing.Point(186, 480);
        	this.btnInformarCliente.Name = "btnInformarCliente";
        	this.btnInformarCliente.Size = new System.Drawing.Size(124, 51);
        	this.btnInformarCliente.TabIndex = 17;
        	this.btnInformarCliente.Text = "Informar Cliente";
        	this.btnInformarCliente.UseVisualStyleBackColor = true;
        	// 
        	// btnConfiguracoes
        	// 
        	this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnConfiguracoes.Location = new System.Drawing.Point(734, 12);
        	this.btnConfiguracoes.Name = "btnConfiguracoes";
        	this.btnConfiguracoes.Size = new System.Drawing.Size(60, 30);
        	this.btnConfiguracoes.TabIndex = 22;
        	this.btnConfiguracoes.Text = "Config";
        	this.btnConfiguracoes.UseVisualStyleBackColor = true;
        	this.btnConfiguracoes.Click += new System.EventHandler(this.BtnConfiguracoesClick);
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.label7);
        	this.panel1.Controls.Add(this.label6);
        	this.panel1.Controls.Add(this.btnPreviaEmail);
        	this.panel1.Controls.Add(this.btnInformarCliente);
        	this.panel1.Controls.Add(this.btnEnviar);
        	this.panel1.Controls.Add(this.btnDeletar);
        	this.panel1.Controls.Add(this.btnConfiguracoes);
        	this.panel1.Controls.Add(this.richTextBox1Descricao);
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Controls.Add(this.label2);
        	this.panel1.Controls.Add(this.label5);
        	this.panel1.Controls.Add(this.label4);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Controls.Add(this.textBox1EmailAssunto);
        	this.panel1.Controls.Add(this.comboBox3Cc);
        	this.panel1.Controls.Add(this.comboBox1De);
        	this.panel1.Controls.Add(this.comboBox2Para);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(806, 588);
        	this.panel1.TabIndex = 1;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.ForeColor = System.Drawing.Color.Red;
        	this.label7.Location = new System.Drawing.Point(60, 451);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(307, 15);
        	this.label7.TabIndex = 10006;
        	this.label7.Text = "Primeiro editar as configurações e depois o 02";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.ForeColor = System.Drawing.Color.Red;
        	this.label6.Location = new System.Drawing.Point(60, 438);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(21, 13);
        	this.label6.TabIndex = 10005;
        	this.label6.Text = "02";
        	// 
        	// btnPreviaEmail
        	// 
        	this.btnPreviaEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnPreviaEmail.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.btnPreviaEmail.Location = new System.Drawing.Point(316, 480);
        	this.btnPreviaEmail.Name = "btnPreviaEmail";
        	this.btnPreviaEmail.Size = new System.Drawing.Size(124, 51);
        	this.btnPreviaEmail.TabIndex = 23;
        	this.btnPreviaEmail.Text = "Prévia do Email";
        	this.btnPreviaEmail.UseVisualStyleBackColor = true;
        	this.btnPreviaEmail.Click += new System.EventHandler(this.BtnPreviaEmailClick);
        	// 
        	// ACAO_ComunicacaoComCliente
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(806, 588);
        	this.Controls.Add(this.panel1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.MaximizeBox = false;
        	this.Name = "ACAO_ComunicacaoComCliente";
        	this.Text = "Cliente - Comunicação";
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.ResumeLayout(false);

        }
    }
}
