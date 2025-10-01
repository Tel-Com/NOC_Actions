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
		
		private string MenagemDeNotificacaoAoCliente()
		{
			return "Prezados, é necessário acionar a loja para a liberação de acesso do(s) técnico(s) abaixo. Ainda não foi repassada a previsão de chegada; assim que a obtivermos, atualizaremos a thread."
				+ Environment.NewLine + Environment.NewLine
				+ richTextBox1_DadosTecnicos.Text;
		}
		
		void BtnGravarECopiarClick(object sender, EventArgs e)
		{
			string msn = MenagemDeNotificacaoAoCliente();
			Clipboard.SetText(msn);
			richTextBox1_DadosTecnicos.Text = "";
		}
		
		void BtnApagarCamposClick(object sender, EventArgs e)
		{
			richTextBox1_DadosTecnicos.Text = "";
		}
		void BtnFecharJanelaClick(object sender, EventArgs e)
		{
			this.FindForm().Close();
		}
		
		void BtnPreviaDaMensagemClick(object sender, EventArgs e)
		{
			string msn = MenagemDeNotificacaoAoCliente();
			MessageBox.Show(msn, "Prévia da Mensagem");
		}
	}
}
