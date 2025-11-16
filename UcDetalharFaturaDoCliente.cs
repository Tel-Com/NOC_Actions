using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace NOC_Actions
{
	public partial class UcDetalharFaturaDoCliente : UserControl
	{
		public UcDetalharFaturaDoCliente()
		{
			InitializeComponent();
		}
		
		private void MostrarUserControl(UserControl uc)
		{
			this.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			this.Controls.Add(uc);
		}
		
		private string ObterSaudacao()
		{
			int hora = DateTime.Now.Hour;
			
			if (hora >= 5 && hora < 12)
				return "bom dia";
			else if (hora >= 12 && hora < 18)
				return "boa tarde";
			else
				return "boa noite";
		}
		
		private bool AnaliseDeCamposVazios()
		{
			if (string.IsNullOrWhiteSpace(comboBox_UnidadeASerNotificada.Text) &&
			    string.IsNullOrWhiteSpace(textBox_TipoDeOperadoraDoContrato.Text) &&
			    string.IsNullOrWhiteSpace(richTextBox_ObservacaoDaFatura.Text) &&
			    string.IsNullOrWhiteSpace(maskedTextBox_ValorDaFatura.Text) &&
			    string.IsNullOrWhiteSpace(maskedTextBox_VencimentoFatura.Text) &&
			    string.IsNullOrWhiteSpace(textBox_StatusDaFatura .Text) &&
			    string.IsNullOrWhiteSpace(textBox_CodigoDeBarrasDaFatura.Text))
			{
				return true;
			}
			return false;
		}
		
		private string DetalhamentoDeFatura()
		{
			if (AnaliseDeCamposVazios())
			{
				MessageBox.Show("Por favor, preencha todos os campos!");
				return string.Empty;
			}

			string msn = "Prezados, " + ObterSaudacao() + "," + Environment.NewLine +
				"Informamos que foi identificado um bloqueio de caráter administrativo-financeiro no contrato da unidade " +
				comboBox_UnidadeASerNotificada.Text.ToUpper() + "." + Environment.NewLine +
				"A seguir, seguem os detalhes referentes à situação:" + Environment.NewLine + Environment.NewLine;

			string detalheFatura =
				"Operadora: " + textBox_TipoDeOperadoraDoContrato.Text + Environment.NewLine +
				"Valor da Fatura: " + maskedTextBox_ValorDaFatura.Text + Environment.NewLine +
				"Data de Vencimento: " + maskedTextBox_VencimentoFatura.Text + Environment.NewLine +
				"Código de Pagamento: " + textBox_CodigoDeBarrasDaFatura.Text + Environment.NewLine +
				"Status: " + textBox_StatusDaFatura.Text + Environment.NewLine +
				"Observações: " + richTextBox_ObservacaoDaFatura.Text + Environment.NewLine +
				"Religamento por inadimplemento: " + CheckReliguePorConfianca();

			return msn + detalheFatura;
		}

		private string CheckReliguePorConfianca()
		{
			if (religuePorConfianca_Sim.Checked)
			{
				return "O procedimento de religamento por confiança foi realizado pela operadora.";
			}
			else if (religuePorConfianca_Nao.Checked)
			{
				return "O procedimento de religamento por confiança não foi realizado pela operadora.";
			}
			else
			{
				return "O status do religamento por confiança não foi definido.";
			}
		}

		void BtnPreviaClick(object sender, EventArgs e)
		{
			string a = DetalhamentoDeFatura();
			MessageBox.Show(a);
		}
		
		void BtnVoltarClick(object sender, EventArgs e)
		{
			MostrarUserControl(new UcPendenciaFinanceiraInformes());
		}
		
		void BtnGravarECopiarInformacoesDetalhadasClick(object sender, EventArgs e)
		{
			string msn = DetalhamentoDeFatura();
			Clipboard.SetText(msn);
		}
		
		void BtnConfigFormClick(object sender, EventArgs e)
		{
			MostrarUserControl(new Config_UcDetalharFaturaDoCliente());
		}
		
	}
}