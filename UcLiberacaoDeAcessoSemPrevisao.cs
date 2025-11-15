using System;
using System.Windows.Forms;

namespace NOC_Actions
{
	public partial class UcLiberacaoDeAcessoSemPrevisao : UserControl
	{
		public UcLiberacaoDeAcessoSemPrevisao()
		{
			InitializeComponent();
		}
		
		private string GetCustomerNotificationMessage()
		{
			return "Prezados, é necessário acionar a loja para a liberação de acesso do(s) técnico(s) listados abaixo. Ainda não recebemos a previsão de chegada; assim que obtivermos essa informação, atualizaremos a thread."
				+ Environment.NewLine + Environment.NewLine
				+ richTextBoxTechDetails.Text;
		}
		
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			CloseWindow();
		}
		
		void BtnMessagePreviewClick(object sender, EventArgs e)
		{
			string msn = GetCustomerNotificationMessage();
			MessageBox.Show(msn, "Prévia da Mensagem");
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
		
		void ClearField()
		{
			richTextBoxTechDetails.Text = "";
		}
		
		void CloseWindow()
		{
			this.FindForm().Close();
		}
	}
}
