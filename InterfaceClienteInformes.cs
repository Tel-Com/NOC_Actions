using System;
using System.Drawing;
using System.Windows.Forms;

namespace NOC_Actions
{
	public partial class InterfaceClienteInformes : Form
	{
		public InterfaceClienteInformes()
		{
			InitializeComponent();
		}
		
		private void MostrarUserControl(UserControl uc)
		{
			painelInterface.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			painelInterface.Controls.Add(uc);
		}
		
		private void BtnAlarmeLinkIndisponivel_Click(object sender, EventArgs e)
		{
//			Prezados, bom dia! Identificamos alarme do link da __ (operadora) indisponível as ___ (hh:mm). Iremos seguir com acionamento junto ao fornecedor.
			MostrarUserControl(new UcAlarmeDeLinkIndisponivel());
		}

		private void BtnChamadoRegistrado_Click(object sender, EventArgs e)
		{
//			Prezados, chamado ___ registrado as ___ (hh:mm) junto ao fornecedor.
			MostrarUserControl(new UcAberturaDeReparo());
		}

		private void BtnLibAcessoSemPrevisao_Click(object sender, EventArgs e)
		{
//			Prezados, necessário acionamento com a loja para liberação de acesso do(s) técnico(s) abaixo. Ainda não foi repassado previsão de chegada, assim que obtivermos iremos atualizar a thread.
			MostrarUserControl(new UcLiberacaoDeAcessoSemPrevisao());
		}

		private void BtnLibAcessoComPrevisao_Click(object sender, EventArgs e)
		{
//		Prezados, necessário acionamento com a loja para liberação de acesso do(s) técnico(s) abaixo. Previsão de chegada as __ (hh) OU no período da manhã/tarde/noite.
			MostrarUserControl(new UcLiberacaoDeAcessoComPrevisao());
		}

		private void BtnAnaliseEnergia_Click(object sender, EventArgs e)
		{
//			Prezados, poderiam confirmar possível queda de energia na loja CE___? Constatamos que ambos os links estão indisponíveis neste momento.
			MostrarUserControl(new UcPossivelQuedaDeEnergia());
		}

		void BtnQuedaEnergiaClick(object sender, EventArgs e)
		{
//			Prezados, poderiam confirmar possível queda de energia na loja CE___? Constatamos que ambos os links estão indisponíveis neste momento.
			MostrarUserControl(new UcPossivelQuedaDeEnergia());
		}
		void Button1Click(object sender, EventArgs e)
		{
//			Prezados, constatamos a existência de um bloqueio administrativo-financeiro no contrato da unidade...
			MostrarUserControl (new UcPendenciaFinanceiraInformes());
		}
		void BtnPendenciaFinanceiraClick(object sender, EventArgs e)
		{
//				Prezados, [SAUDAÇÃO]! Identificamos um Bloqueio Administratrivo Financeiro no Circuito XXXX. Poderiam checar? 
			MostrarUserControl(new UcPendenciaFinanceiraInformes());
		}
		void BtnRegistroDeFalhaInternaClienteClick(object sender, EventArgs e)
		{
			
		}
	}
}
