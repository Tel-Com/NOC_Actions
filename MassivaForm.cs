/*
 * Criado com SharpDevelop.
 * Usuário: fjstavares
 * Data: 06/12/2024
 * Hora: 09:37
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace NOCActions
{
	public partial class MassivaForm : Form
	{
		// Caminhos para os arquivos de operadoras e cidades armazenados no diretório de dados do usuário
		private string caminhoArquivoOperadoras = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "operadoras.txt");
		private string caminhoArquivoCidades = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "cidades.txt");

		// Construtor do formulário
		public MassivaForm()
		{
			this.TopMost = true; // Mantém a janela sempre no topo
			InitializeComponent();
			CarregarOperadorasSalvasNoForm(); // Carrega a lista de operadoras ao iniciar o formulário
			CarregarCidadesSalvasNoForm(); // Carrega a lista de cidades ao iniciar o formulário
			OrdenarTabIndex();
		}

		// Carrega as cidades salvas no arquivo e adiciona à lista no formulário
		private void CarregarCidadesSalvasNoForm()
		{
			if (File.Exists(caminhoArquivoCidades))
			{
				string[] cidadesSalvas = File.ReadAllLines(caminhoArquivoCidades);
				CidadesSalvasPeloUsuario(cidadesSalvas);
			}
		}

		// Carrega as operadoras salvas no arquivo e adiciona à lista no formulário
		private void CarregarOperadorasSalvasNoForm()
		{
			if (File.Exists(caminhoArquivoOperadoras))
			{
				string[] operadorasSalvas = File.ReadAllLines(caminhoArquivoOperadoras);
				OperadorasSalvasPeloUsuario(operadorasSalvas);
			}
		}

		// Atualiza a lista de cidades no formulário com os valores carregados
		public void CidadesSalvasPeloUsuario(string[] cidades)
		{
			textBoxCidades.Items.Clear();
			textBoxCidades.Items.AddRange(cidades);
			if (textBoxCidades.Items.Count > 0)
			{
				textBoxCidades.SelectedIndex = 0; // Seleciona a primeira cidade como padrão
			}
		}

		// Atualiza a lista de operadoras no formulário com os valores carregados
		public void OperadorasSalvasPeloUsuario(string[] operadoras)
		{
			textBoxOperadora.Items.Clear();
			textBoxOperadora.Items.AddRange(operadoras);
			if (textBoxOperadora.Items.Count > 0)
			{
				textBoxOperadora.SelectedIndex = 0; // Seleciona a primeira operadora como padrão
			}
		}

		// Evento acionado ao clicar no botão "Gerar"
		private void BtnGerarClick(object sender, EventArgs e)
		{
			GerarMensagemDeMassiva();
		}

		// Gera uma mensagem de possível massiva com base nos valores selecionados
		private void GerarMensagemDeMassiva()
		{
			textBoxExemplo.Clear();
			string cidadeAfetada = textBoxCidades.Text.Trim();
			string operadoraAfetada = textBoxOperadora.Text.Trim();

			// Verifica se os campos obrigatórios foram preenchidos
			if (string.IsNullOrWhiteSpace(cidadeAfetada) || string.IsNullOrWhiteSpace(operadoraAfetada))
			{
				MessageBox.Show("Por favor, preencha as informações de cidade e operadora antes de gerar a mensagem.",
				                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Formata a mensagem informando uma possível falha na operadora
			string mensagemDeMassiva = string.Format("Possível massiva na região de {0} devido a ambos os links da {1} caírem simultaneamente.", cidadeAfetada, operadoraAfetada);
			textBoxExemplo.Text = mensagemDeMassiva;
		}

		// Evento acionado ao clicar no botão "Copiar"
		private void ButtonCopiarClick(object sender, EventArgs e)
		{
			// Copia o conteúdo da mensagem para a área de transferência
			if (!string.IsNullOrWhiteSpace(textBoxExemplo.Text))
			{
				Clipboard.SetText(textBoxExemplo.Text);
			}
		}

		// Evento acionado ao clicar no botão "Apagar"
		private void BtnApagarClick(object sender, EventArgs e)
		{
			// Limpa os campos do formulário
			textBoxCidades.Text = string.Empty;
			textBoxOperadora.Text = string.Empty;
			textBoxExemplo.Clear();
		}

		// Evento acionado ao clicar no botão "Configurações"
		private void BtnConfigClick(object sender, EventArgs e)
		{
			// Abre a janela de configuração para seleção de arquivos
			using (UserConfig config = new UserConfig())
			{
				config.ShowDialog();
				// Se um novo arquivo válido for selecionado, recarregar as listas de operadoras e cidades
				if (!string.IsNullOrEmpty(config.CaminhoArquivo) && File.Exists(config.CaminhoArquivo))
				{
					CarregarCidadesSalvasNoForm();
					CarregarOperadorasSalvasNoForm();
				}
			}
		}

		// Método para organizar a ordem de tabulação dos elementos do formulário
		private void OrdenarTabIndex()
		{
			textBoxCidades.TabIndex = 0;
			textBoxOperadora.TabIndex = 1;
			btnGerar.TabIndex = 2;
			buttonCopiar.TabIndex = 3;
			btnApagar.TabIndex = 4;
			btnConfig.TabIndex = 5;
		}
	}
}
