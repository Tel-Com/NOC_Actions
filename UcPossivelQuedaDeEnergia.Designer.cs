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
	partial class UcPossivelQuedaDeEnergia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSaveAndCopy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClearFields;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnPrevia;
		private System.Windows.Forms.ComboBox comboBox_UnidadeComFaltaDeEnergia;
		private System.Windows.Forms.Button btnDeletarItemSelecionadoDaLista;
		private System.Windows.Forms.Button btnDeletarListaCompleta;
		private System.Windows.Forms.CheckBox checkEditarCampoUnidade;
		private System.Windows.Forms.Label labelAviso;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnClearFields = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.btnPrevia = new System.Windows.Forms.Button();
			this.comboBox_UnidadeComFaltaDeEnergia = new System.Windows.Forms.ComboBox();
			this.btnDeletarItemSelecionadoDaLista = new System.Windows.Forms.Button();
			this.btnDeletarListaCompleta = new System.Windows.Forms.Button();
			this.checkEditarCampoUnidade = new System.Windows.Forms.CheckBox();
			this.labelAviso = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(391, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "________________________________________________________________";
			// 
			// btnSaveAndCopy
			// 
			this.btnSaveAndCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveAndCopy.Location = new System.Drawing.Point(357, 315);
			this.btnSaveAndCopy.Name = "btnSaveAndCopy";
			this.btnSaveAndCopy.Size = new System.Drawing.Size(96, 44);
			this.btnSaveAndCopy.TabIndex = 1;
			this.btnSaveAndCopy.Text = "Gravar e Copiar";
			this.btnSaveAndCopy.UseVisualStyleBackColor = true;
			this.btnSaveAndCopy.Click += new System.EventHandler(this.BtnSaveAndCopyClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.Location = new System.Drawing.Point(3, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 17);
			this.label4.TabIndex = 15;
			this.label4.Text = "Mensagem a ser exibida";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label2.Location = new System.Drawing.Point(79, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "Unidade";
			// 
			// btnClearFields
			// 
			this.btnClearFields.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearFields.Location = new System.Drawing.Point(255, 315);
			this.btnClearFields.Name = "btnClearFields";
			this.btnClearFields.Size = new System.Drawing.Size(96, 44);
			this.btnClearFields.TabIndex = 2;
			this.btnClearFields.Text = "Apagar";
			this.btnClearFields.UseVisualStyleBackColor = true;
			this.btnClearFields.Click += new System.EventHandler(this.BtnClearFieldsClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label1.Location = new System.Drawing.Point(3, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 35);
			this.label1.TabIndex = 9;
			this.label1.Text = "Prezados, poderiam confirmar uma possível queda de energia na loja [UNIDADE]? Con" +
	"statamos que ambos os links encontram-se indisponíveis no momento.";
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseWindow.Location = new System.Drawing.Point(34, 315);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(96, 44);
			this.btnCloseWindow.TabIndex = 3;
			this.btnCloseWindow.Text = "Fechar";
			this.btnCloseWindow.UseVisualStyleBackColor = true;
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
			// 
			// btnPrevia
			// 
			this.btnPrevia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevia.Location = new System.Drawing.Point(153, 315);
			this.btnPrevia.Name = "btnPrevia";
			this.btnPrevia.Size = new System.Drawing.Size(96, 44);
			this.btnPrevia.TabIndex = 18;
			this.btnPrevia.Text = "Prévia";
			this.btnPrevia.UseVisualStyleBackColor = true;
			this.btnPrevia.Click += new System.EventHandler(this.BtnPreviaClick);
			// 
			// comboBox_UnidadeComFaltaDeEnergia
			// 
			this.comboBox_UnidadeComFaltaDeEnergia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBox_UnidadeComFaltaDeEnergia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBox_UnidadeComFaltaDeEnergia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox_UnidadeComFaltaDeEnergia.FormattingEnabled = true;
			this.comboBox_UnidadeComFaltaDeEnergia.Location = new System.Drawing.Point(153, 150);
			this.comboBox_UnidadeComFaltaDeEnergia.Name = "comboBox_UnidadeComFaltaDeEnergia";
			this.comboBox_UnidadeComFaltaDeEnergia.Size = new System.Drawing.Size(237, 25);
			this.comboBox_UnidadeComFaltaDeEnergia.TabIndex = 42;
			// 
			// btnDeletarItemSelecionadoDaLista
			// 
			this.btnDeletarItemSelecionadoDaLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeletarItemSelecionadoDaLista.Location = new System.Drawing.Point(326, 206);
			this.btnDeletarItemSelecionadoDaLista.Name = "btnDeletarItemSelecionadoDaLista";
			this.btnDeletarItemSelecionadoDaLista.Size = new System.Drawing.Size(96, 42);
			this.btnDeletarItemSelecionadoDaLista.TabIndex = 44;
			this.btnDeletarItemSelecionadoDaLista.Text = "Deletar Selecionado";
			this.btnDeletarItemSelecionadoDaLista.UseVisualStyleBackColor = true;
			this.btnDeletarItemSelecionadoDaLista.Visible = false;
			this.btnDeletarItemSelecionadoDaLista.Click += new System.EventHandler(this.BtnDeletarItemSelecionadoDaListaClick);
			// 
			// btnDeletarListaCompleta
			// 
			this.btnDeletarListaCompleta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeletarListaCompleta.Location = new System.Drawing.Point(224, 206);
			this.btnDeletarListaCompleta.Name = "btnDeletarListaCompleta";
			this.btnDeletarListaCompleta.Size = new System.Drawing.Size(96, 42);
			this.btnDeletarListaCompleta.TabIndex = 45;
			this.btnDeletarListaCompleta.Text = "Deletar Lista";
			this.btnDeletarListaCompleta.UseVisualStyleBackColor = true;
			this.btnDeletarListaCompleta.Visible = false;
			this.btnDeletarListaCompleta.Click += new System.EventHandler(this.BtnDeletarListaCompletaClick);
			// 
			// checkEditarCampoUnidade
			// 
			this.checkEditarCampoUnidade.AutoSize = true;
			this.checkEditarCampoUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.checkEditarCampoUnidade.Location = new System.Drawing.Point(45, 216);
			this.checkEditarCampoUnidade.Name = "checkEditarCampoUnidade";
			this.checkEditarCampoUnidade.Size = new System.Drawing.Size(166, 21);
			this.checkEditarCampoUnidade.TabIndex = 46;
			this.checkEditarCampoUnidade.Text = "Editar Campo \'Unidade\'";
			this.checkEditarCampoUnidade.UseVisualStyleBackColor = true;
			this.checkEditarCampoUnidade.CheckedChanged += new System.EventHandler(this.CheckEditarCampoUnidadeCheckedChanged);
			// 
			// labelAviso
			// 
			this.labelAviso.AutoSize = true;
			this.labelAviso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAviso.ForeColor = System.Drawing.Color.Red;
			this.labelAviso.Location = new System.Drawing.Point(45, 261);
			this.labelAviso.Name = "labelAviso";
			this.labelAviso.Size = new System.Drawing.Size(72, 13);
			this.labelAviso.TabIndex = 47;
			this.labelAviso.Text = "Aviso de uso";
			this.labelAviso.Visible = false;
			// 
			// UcPossivelQuedaDeEnergia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelAviso);
			this.Controls.Add(this.checkEditarCampoUnidade);
			this.Controls.Add(this.btnDeletarItemSelecionadoDaLista);
			this.Controls.Add(this.btnDeletarListaCompleta);
			this.Controls.Add(this.comboBox_UnidadeComFaltaDeEnergia);
			this.Controls.Add(this.btnPrevia);
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSaveAndCopy);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClearFields);
			this.Controls.Add(this.label1);
			this.Name = "UcPossivelQuedaDeEnergia";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
