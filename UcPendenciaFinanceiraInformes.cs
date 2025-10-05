using System;
using System.Windows.Forms;


namespace NOC_Actions
{
	public partial class UcPendenciaFinanceiraInformes : UserControl
	{
		public UcPendenciaFinanceiraInformes()
		{
			InitializeComponent();
		}
		
		private string GetCustomerNotificationMessage()
		{
			return "Prezados, informamos que foi identificado um bloqueio de natureza administrativo-financeira no contrato da unidade: " + Environment.NewLine + Environment.NewLine + textBox1_UnidadeComBloqueioFinanceiro.Text.Trim();
		}
		
		void BtnGravarECopiarClick(object sender, EventArgs e)
		{
			string msn = GetCustomerNotificationMessage();
			Clipboard.SetText(msn);
			textBox1_UnidadeComBloqueioFinanceiro.Text="";
		}
		
		void BtnApagarCamposClick(object sender, EventArgs e)
		{
			textBox1_UnidadeComBloqueioFinanceiro.Text = "";
		}
		void BtnFecharJanelaClick(object sender, EventArgs e)
		{
			this.FindForm().Close();
		}
		
//		desativado
		void BtnDetalharFaturaClick(object sender, EventArgs e)
		{
			this.Hide();
			var open_userControl_window = new Uc_PendenciaFinanceira_UcDetalhamentoDeFatura();
			this.Parent.Controls.Add(open_userControl_window);
			open_userControl_window.Dock = DockStyle.Fill;
			open_userControl_window.BringToFront();
		}
	}
}
