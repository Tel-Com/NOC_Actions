using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace NOC_Actions
{
	public partial class UcPossivelQuedaDeEnergia : UserControl
	{
		private readonly string UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoUnidadeComQuedaDeEnergia.txt");
		
		public UcPossivelQuedaDeEnergia()
		{
			InitializeComponent();
			CarregarItensEmLista();
			
		}
		
		private string GetCustomerNotificationMessage()
		{
			string getValueUnidadeComQueda = comboBox_UnidadeComFaltaDeEnergia.Text.Trim();
			const string msnValidacao = "Prezados, poderiam confirmar uma possível queda de energia na loja ";
			return msnValidacao
				+ getValueUnidadeComQueda.ToUpper() + "? Constatamos que ambos os links encontram-se indisponíveis no momento.";
		}

		private void SalvarItensArquivo()
		{
			string adicionarUnidadeComFaltaDeEnergiaEmLista = comboBox_UnidadeComFaltaDeEnergia.Text.Trim();
			if (!string.IsNullOrWhiteSpace(adicionarUnidadeComFaltaDeEnergiaEmLista) && !comboBox_UnidadeComFaltaDeEnergia.Items.Contains(adicionarUnidadeComFaltaDeEnergiaEmLista))
			{
				comboBox_UnidadeComFaltaDeEnergia.Items.Add(adicionarUnidadeComFaltaDeEnergiaEmLista);
				GravarItensNoArquivo(comboBox_UnidadeComFaltaDeEnergia, UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia );
				comboBox_UnidadeComFaltaDeEnergia.Text = "";
			}
		}

		private void CarregarItensEmLista()
		{
			if (File.Exists(UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia)) {
				string[] unidade = File.ReadAllLines(UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia);
				comboBox_UnidadeComFaltaDeEnergia.Items.AddRange(unidade);
			}
		}
		
		private void GravarItensNoArquivo(ComboBox comboBox, string caminhoArquivo)
		{
			try {
				File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
			} catch (Exception ex) {
				MessageBox.Show("Erro ao realizar este procedimento. \n\n" + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		void CheckEditarCampoUnidadeCheckedChanged(object sender, EventArgs e)
		{
			if (checkEditarCampoUnidade.Checked) {
				labelAviso.Visible = true;
				labelAviso.Text = "Deletar Lista: Esta ação apagará todos os itens da lista.\nDeletar Selecionado: Esta ação apagará apenas o item atualmente selecionado.";
				btnDeletarListaCompleta.Visible = true;
				btnDeletarItemSelecionadoDaLista.Visible = true;
			} else
			{
				labelAviso.Visible = false;
				btnDeletarListaCompleta.Visible = false;
				btnDeletarItemSelecionadoDaLista.Visible = false;
			}
		}
		
		void BtnDeletarItemSelecionadoDaListaClick(object sender, EventArgs e)
		{
			if (comboBox_UnidadeComFaltaDeEnergia != null)
			{
				comboBox_UnidadeComFaltaDeEnergia.Items.Remove(comboBox_UnidadeComFaltaDeEnergia.SelectedItem);
				GravarItensNoArquivo(comboBox_UnidadeComFaltaDeEnergia, UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia);
			}
		}
		void BtnDeletarListaCompletaClick(object sender, EventArgs e)
		{
			if (comboBox_UnidadeComFaltaDeEnergia.Items.Count > 0)
			{
				comboBox_UnidadeComFaltaDeEnergia.Items.Clear();
				GravarItensNoArquivo(comboBox_UnidadeComFaltaDeEnergia, UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia);
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
		
		void BtnPreviaClick(object sender, EventArgs e)
		{
			string msn_previa = GetCustomerNotificationMessage();
			MessageBox.Show (msn_previa, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		void BtnSaveAndCopyClick(object sender, EventArgs e)
		{
			string msn = GetCustomerNotificationMessage();
			Clipboard.SetText(msn);
			SalvarItensArquivo();
			ClearField();
		}
		
		void ClearField()
		{
			comboBox_UnidadeComFaltaDeEnergia.Text = "";
		}
		
		void CloseWindow()
		{
			this.FindForm().Close();
		}
		
		void DesabilitarComponente()
		{
			
		}
		
	}
}