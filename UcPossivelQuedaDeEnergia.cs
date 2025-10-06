using System;
using System.Windows.Forms;

namespace NOC_Actions
{
	public partial class UcPossivelQuedaDeEnergia : UserControl
	{
		public UcPossivelQuedaDeEnergia()
		{
			InitializeComponent();
		}
		
		private string GetCustomerNotificationMessage()
		{
			string getValueUnidadeComQueda = txtUnitName.Text.Trim();
			const string prezadosPoderiamConfirmarPossívelQuedaDeEnergiaNaLoja = "Prezados, poderiam confirmar possível queda de energia na loja ";
			return prezadosPoderiamConfirmarPossívelQuedaDeEnergiaNaLoja
			+ getValueUnidadeComQueda + "? Constatamos que ambos os links estão indisponíveis neste momento.";
		}
		
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			this.FindForm().Close();
		}
		
		void BtnClearFieldsClick(object sender, EventArgs e)
		{
			txtUnitName.Text = "";
		}
		
		void BtnSaveAndCopyClick(object sender, EventArgs e)
		{
			string msn = GetCustomerNotificationMessage();
			Clipboard.SetText(msn);
			txtUnitName.Text = "";
		}
	}
}