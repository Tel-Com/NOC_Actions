using System;
using System.Drawing;
using System.Windows.Forms;

namespace NOC_Actions
{
	public partial class AvisosSolicitacoesAoCliente : Form
	{
		public AvisosSolicitacoesAoCliente()
		{
			InitializeComponent();
		}
		
		private void MostrarUserControl(UserControl uc)
		{
			splitContainer.Panel2.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			splitContainer.Panel2.Controls.Add(uc);
		}
		
		void BtnAnaliseDeInfraClick(object sender, EventArgs e)
		{
			MostrarUserControl(new Uc_AnaliseDeInfra());
		}
		
		void BtnLiberacaoDeAcessoClick(object sender, EventArgs e)
		{
			MostrarUserControl(new Uc_LiberacaoDeAcesso());
		}
		
		void BtnPossivelQuedaDeEnergiaClick(object sender, EventArgs e)
		{
			MostrarUserControl(new Uc_PossivelQuedaDeEnergia());
		}
		
		void BtnBloqueioFinanceiroClick(object sender, EventArgs e)
		{
			MostrarUserControl(new Uc_BloqueioFinanceiro());
		}
	}
}
