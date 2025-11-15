using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace NOC_Actions
{
	public partial class UcPendenciaFinanceiraInformes : UserControl
	{
		private readonly string UcPendenciaFinanceiraInformes_arquivoUnidadeComPendenciaFinanceira = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoUnidadeComPendenciaFinanceira.txt");
		
		public UcPendenciaFinanceiraInformes()
		{
			InitializeComponent();
		}
		
		private void MostrarUserControl(UserControl uc)
		{
			this.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			this.Controls.Add(uc);
		}
		
		private string GetCustomerNotificationMessage()
		{
			return "Prezados, identificamos a existência de um bloqueio de caráter administrativo-financeiro no contrato da unidade: " + comboBoxFinBlockUnitName.Text.Trim().ToUpper();
		}

		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			CloseWindow();
		}
		
		void BtnClearFieldsClick(object sender, EventArgs e)
		{
			ClearField();
		}

		void BtnSaveAndCopyClick(object sender, EventArgs e)
		{
			string msn = GetCustomerNotificationMessage();
			Clipboard.SetText(msn);
			ClearField();
		}
		
		void BtnDeletarItemSelecionadoDaListaClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnDeletarListaCompletaClick(object sender, EventArgs e)
		{
			
		}
		
		void checkBoxDetalharFatura_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxDetalharFatura.Checked) {
				labelEditarCampoUnidade.Visible = false;
				checkEditarCampoUnidade.Visible = false;
				txtLabel_campoDeAviso.Visible = true;
				btnDeletarListaCompleta.Visible = false;
				btnDeletarItemSelecionadoDaLista.Visible = false;
				
				btnViewInvoiceDetails.Enabled = checkBoxDetalharFatura.Checked;
				txtLabel_campoDeAviso.Text = "Aviso: ao clicar em “Detalhar a Fatura”, você receberá informações\nadicionais para serem incluídas. Isso pode gerar inconsistências em\nvalores, datas e outros dados. Tenha cuidado ao preencher todos os\ncampos e revise cuidadosamente as informações inseridas.";
			} else
			{
				labelEditarCampoUnidade.Visible = true;
				checkEditarCampoUnidade.Visible = true;
				btnViewInvoiceDetails.Enabled = false;
				txtLabel_campoDeAviso.Visible = false;
			}
		}
		
		void CheckEditarCampoUnidadeCheckedChanged(object sender, EventArgs e)
		{
			if (checkEditarCampoUnidade.Checked) {
				btnDeletarListaCompleta.Visible = true;
				btnDeletarItemSelecionadoDaLista.Visible = true;
				txtLabel_campoDeAviso.Location = new System.Drawing.Point(34, 242);
				txtLabel_campoDeAviso.Visible = true;
				txtLabel_campoDeAviso.Text = "Deletar Lista: Esta ação apagará todos os itens da lista.\nDeletar Selecionado: Esta ação apagará apenas o item atualmente\nselecionado.";
			} else
			{
				btnDeletarListaCompleta.Visible = false;
				btnDeletarItemSelecionadoDaLista.Visible = false;
				txtLabel_campoDeAviso.Location = new System.Drawing.Point(34, 208);
				txtLabel_campoDeAviso.Visible = false;
			}
			
		}
		
		void BtnViewInvoiceDetailsClick(object sender, EventArgs e)
		{
			MostrarUserControl(new UcDetalharFaturaDoCliente());
		}
		
		void ClearField()
		{
			comboBoxFinBlockUnitName.Text="";
		}
		
		void CloseWindow()
		{
			this.FindForm().Close();
		}
	}
}
