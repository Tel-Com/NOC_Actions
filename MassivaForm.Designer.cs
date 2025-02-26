using System;
using System.Drawing;
using System.Windows.Forms;

namespace NOCActions
{
    partial class MassivaForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelCidade;
        private Label labelOperadora;
        private Label labelExemplo;
        private Button buttonCopiar;
        private Button btnGerar;
        private RichTextBox textBoxExemplo;
        private Button btnApagar;
        private Button btnConfig;
        private System.Windows.Forms.ComboBox textBoxCidades;
        private ComboBox textBoxOperadora;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.labelCidade = new System.Windows.Forms.Label();
        	this.labelOperadora = new System.Windows.Forms.Label();
        	this.labelExemplo = new System.Windows.Forms.Label();
        	this.textBoxExemplo = new System.Windows.Forms.RichTextBox();
        	this.btnApagar = new System.Windows.Forms.Button();
        	this.buttonCopiar = new System.Windows.Forms.Button();
        	this.btnGerar = new System.Windows.Forms.Button();
        	this.btnConfig = new System.Windows.Forms.Button();
        	this.textBoxOperadora = new System.Windows.Forms.ComboBox();
        	this.textBoxCidades = new System.Windows.Forms.ComboBox();
        	this.SuspendLayout();
        	// 
        	// labelCidade
        	// 
        	this.labelCidade.AutoSize = true;
        	this.labelCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelCidade.Location = new System.Drawing.Point(12, 15);
        	this.labelCidade.Name = "labelCidade";
        	this.labelCidade.Size = new System.Drawing.Size(58, 21);
        	this.labelCidade.TabIndex = 7;
        	this.labelCidade.Text = "Cidade";
        	// 
        	// labelOperadora
        	// 
        	this.labelOperadora.AutoSize = true;
        	this.labelOperadora.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelOperadora.Location = new System.Drawing.Point(12, 50);
        	this.labelOperadora.Name = "labelOperadora";
        	this.labelOperadora.Size = new System.Drawing.Size(85, 21);
        	this.labelOperadora.TabIndex = 8;
        	this.labelOperadora.Text = "Operadora";
        	// 
        	// labelExemplo
        	// 
        	this.labelExemplo.AutoSize = true;
        	this.labelExemplo.Font = new System.Drawing.Font("Segoe UI", 12F);
        	this.labelExemplo.Location = new System.Drawing.Point(12, 90);
        	this.labelExemplo.Name = "labelExemplo";
        	this.labelExemplo.Size = new System.Drawing.Size(69, 21);
        	this.labelExemplo.TabIndex = 9;
        	this.labelExemplo.Text = "Exemplo";
        	// 
        	// textBoxExemplo
        	// 
        	this.textBoxExemplo.BackColor = System.Drawing.SystemColors.ControlLight;
        	this.textBoxExemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.textBoxExemplo.Enabled = false;
        	this.textBoxExemplo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.textBoxExemplo.Location = new System.Drawing.Point(95, 90);
        	this.textBoxExemplo.Name = "textBoxExemplo";
        	this.textBoxExemplo.ReadOnly = true;
        	this.textBoxExemplo.Size = new System.Drawing.Size(455, 70);
        	this.textBoxExemplo.TabIndex = 3;
        	this.textBoxExemplo.Text = "";
        	// 
        	// btnApagar
        	// 
        	this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.btnApagar.Location = new System.Drawing.Point(450, 170);
        	this.btnApagar.Name = "btnApagar";
        	this.btnApagar.Size = new System.Drawing.Size(100, 30);
        	this.btnApagar.TabIndex = 5;
        	this.btnApagar.Text = "Apagar";
        	this.btnApagar.UseVisualStyleBackColor = true;
        	this.btnApagar.Click += new System.EventHandler(this.BtnApagarClick);
        	// 
        	// buttonCopiar
        	// 
        	this.buttonCopiar.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.buttonCopiar.Location = new System.Drawing.Point(340, 170);
        	this.buttonCopiar.Name = "buttonCopiar";
        	this.buttonCopiar.Size = new System.Drawing.Size(100, 30);
        	this.buttonCopiar.TabIndex = 4;
        	this.buttonCopiar.Text = "Copiar";
        	this.buttonCopiar.UseVisualStyleBackColor = true;
        	this.buttonCopiar.Click += new System.EventHandler(this.ButtonCopiarClick);
        	// 
        	// btnGerar
        	// 
        	this.btnGerar.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.btnGerar.Location = new System.Drawing.Point(230, 170);
        	this.btnGerar.Name = "btnGerar";
        	this.btnGerar.Size = new System.Drawing.Size(100, 30);
        	this.btnGerar.TabIndex = 3;
        	this.btnGerar.Text = "Gerar";
        	this.btnGerar.UseVisualStyleBackColor = true;
        	this.btnGerar.Click += new System.EventHandler(this.BtnGerarClick);
        	// 
        	// btnConfig
        	// 
        	this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.btnConfig.Location = new System.Drawing.Point(490, 15);
        	this.btnConfig.Name = "btnConfig";
        	this.btnConfig.Size = new System.Drawing.Size(60, 30);
        	this.btnConfig.TabIndex = 6;
        	this.btnConfig.Text = "Config";
        	this.btnConfig.UseVisualStyleBackColor = true;
        	this.btnConfig.Click += new System.EventHandler(this.BtnConfigClick);
        	// 
        	// textBoxOperadora
        	// 
        	this.textBoxOperadora.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        	this.textBoxOperadora.FormattingEnabled = true;
        	this.textBoxOperadora.Location = new System.Drawing.Point(95, 50);
        	this.textBoxOperadora.Name = "textBoxOperadora";
        	this.textBoxOperadora.Size = new System.Drawing.Size(180, 25);
        	this.textBoxOperadora.TabIndex = 2;
        	// 
        	// textBoxCidades
        	// 
        	this.textBoxCidades.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        	this.textBoxCidades.FormattingEnabled = true;
        	this.textBoxCidades.Location = new System.Drawing.Point(95, 15);
        	this.textBoxCidades.Name = "textBoxCidades";
        	this.textBoxCidades.Size = new System.Drawing.Size(180, 25);
        	this.textBoxCidades.TabIndex = 10;
        	// 
        	// MassivaForm
        	// 
        	this.ClientSize = new System.Drawing.Size(570, 210);
        	this.Controls.Add(this.textBoxCidades);
        	this.Controls.Add(this.textBoxOperadora);
        	this.Controls.Add(this.btnConfig);
        	this.Controls.Add(this.textBoxExemplo);
        	this.Controls.Add(this.btnGerar);
        	this.Controls.Add(this.buttonCopiar);
        	this.Controls.Add(this.btnApagar);
        	this.Controls.Add(this.labelCidade);
        	this.Controls.Add(this.labelOperadora);
        	this.Controls.Add(this.labelExemplo);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MaximizeBox = false;
        	this.Name = "MassivaForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Abertura de Massiva";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        // ... (Event handlers for buttons, etc.)
    }
}