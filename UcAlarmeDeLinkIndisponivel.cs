using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace NOC_Actions
{
	public partial class UcAlarmeDeLinkIndisponivel : UserControl
	{
		private readonly string Uc_AlarmeDeLinkIndisponivel_arquivoOperadora  = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "registroDeOperadoraEmArquivo.txt");
		
		public UcAlarmeDeLinkIndisponivel()
		{
			InitializeComponent();
			CarregarComboBoxItems();
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
		
		private string GetCustomerNotificationMessage()
		{
			string getValueCarrierName = comboBoxCarrierName.Text;
			string getValueHorario_Queda = textBoxDowntime.Text;
			return "Prezados, " + ObterSaudacao() + "! Identificamos que o link da operadora "
				+ getValueCarrierName + " está indisponível às " + getValueHorario_Queda
				+ ". Daremos sequência ao acionamento junto ao fornecedor.";
		}
		
		private void SalvarArquivoOperadoraDoCliente()
		{
			string adicionarOperadoraDoClienteEmLista = comboBoxCarrierName.Text.Trim();

			if (!string.IsNullOrWhiteSpace(adicionarOperadoraDoClienteEmLista) && !comboBoxCarrierName.Items.Contains(adicionarOperadoraDoClienteEmLista))
			{
				comboBoxCarrierName.Items.Add(adicionarOperadoraDoClienteEmLista);
				comboBoxCarrierName.Text = "";

				RegistrarNoArquivo(comboBoxCarrierName, Uc_AlarmeDeLinkIndisponivel_arquivoOperadora);
				
			}
		}

		private void RegistrarNoArquivo(ComboBox comboBox, string caminhoArquivo)
		{
			try
			{
				File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
			} catch (Exception ex) {
				MessageBox.Show("Erro ao realizar este procedimento. \n\n" + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void CarregarComboBoxItems()
		{
			if (File.Exists(Uc_AlarmeDeLinkIndisponivel_arquivoOperadora))
			{
				string[] itens = File.ReadAllLines(Uc_AlarmeDeLinkIndisponivel_arquivoOperadora);
				comboBoxCarrierName.Items.AddRange(itens);
			}
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
			SalvarArquivoOperadoraDoCliente();
			ClearField();
		}
		
		void ClearField()
		{
			comboBoxCarrierName.Text = "";
			textBoxDowntime.Text = "";
		}
		
		void CloseWindow()
		{
			this.FindForm().Close();
		}
	}
}


// declarado variavel para armazenamento em 'txt' das operadoras no UcAlarmeDeLinkIndisponivel
// adicionado parametros para salvar e dar vida ao sistema de autocomplete no UcAlarmeDeLinkIndisponivel