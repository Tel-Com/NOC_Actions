using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace NOC_Actions
{
	public partial class Uc_AnaliseDeInfra : UserControl
	{
		private readonly string arquivo_operadora = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoOperadora.txt");
		private readonly string arquivo_unidade = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoUnidade.txt");
        private readonly string arquivo_tipoDeAnalise = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoTipoDeAnalise.txt");

		public Uc_AnaliseDeInfra()
		{
			InitializeComponent();
            CarregarItens(arquivo_operadora, comboBox_OperadoraDaUnidade);
			CarregarItens(arquivo_unidade, comboBox_unidade);
			CarregarItens(arquivo_tipoDeAnalise, comboBox_tipoDeAnalise);
        }

		// responsável por salvar a operadora no arquivo
		private void SalvarOperadoraNoArquivoRespectivo()
		{
			string armazenamento = comboBox_OperadoraDaUnidade.Text.Trim();

            if (!string.IsNullOrWhiteSpace(armazenamento) && !comboBox_OperadoraDaUnidade.Items.Contains(armazenamento))
            {
				comboBox_OperadoraDaUnidade.Items.Add(armazenamento);
				SalvarItensArquivo(comboBox_OperadoraDaUnidade, arquivo_operadora);
            }
        }

		private void SalvarUnidadeNoArquivo()
		{
			string armazenamento = comboBox_unidade.Text.Trim();
			if (!string.IsNullOrWhiteSpace(armazenamento) && !comboBox_unidade.Items.Contains(armazenamento))
			{
				comboBox_unidade.Items.Add(armazenamento);
				SalvarItensArquivo(comboBox_unidade, arquivo_unidade);
			}
		}
		private void SalvarTipoDeAnalise()
		{
			string armazenamento = comboBox_tipoDeAnalise.Text.Trim();
			if(!string.IsNullOrWhiteSpace(armazenamento) && !comboBox_tipoDeAnalise.Items.Contains(armazenamento))
			{
				comboBox_tipoDeAnalise.Items.Add(armazenamento);
				SalvarItensArquivo(comboBox_tipoDeAnalise, arquivo_tipoDeAnalise);
			}
		}

		private void SalvarItensArquivo(ComboBox comboBox, string caminhoArquivo)
		{
			try
			{
				File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
			} catch (Exception ex)
			{
				MessageBox.Show("Erro ao realizar o procedimento " + ex);
			}
		}

        private void CarregarItens(string arquivo, ComboBox comboBoxLoad)
        {
            if (!File.Exists(arquivo)) return;

            comboBoxLoad.Items.Clear();
            comboBoxLoad.Items.AddRange(
                File.ReadAllLines(arquivo)
                    .Distinct()
                    .ToArray()
            );
        }

        // Responsável por Salvar e Gravar informações como um todo
        private void btnSalvarECopiar_Click_1(object sender, EventArgs e)
        {
			SalvarOperadoraNoArquivoRespectivo();
			SalvarUnidadeNoArquivo();
			SalvarTipoDeAnalise();
			MessageBox.Show("Salvo!");
        }
    }
}