using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NOCActions
{
	public partial class ACAO_ComunicacaoComCliente : Form
	{
		public List<string> ListaDeEmailsConcatenados;

		public ACAO_ComunicacaoComCliente()
		{
			InitializeComponent();
			ListaDeEmailsConcatenados = new List<string>();
		}

		public void AdicionarEmailsConcatenados(string emails)
		{
			if (!string.IsNullOrWhiteSpace(emails))
			{
				ListaDeEmailsConcatenados.Add(emails);
				AtualizarComboBox();
			}
		}

		public void AtualizarComboBox()
		{
			comboBox2Para.Items.Clear();
			foreach (var emails in ListaDeEmailsConcatenados)
			{
				comboBox2Para.Items.Add(emails);
			}
		}
		void BtnConfiguracaoDeContratoEUsuarioPadraoClick(object sender, EventArgs e)
		{
			CONFIG_ComunicacaoComCliente formConfig = new CONFIG_ComunicacaoComCliente(this);
			formConfig.ShowDialog();
		}
	}
}
