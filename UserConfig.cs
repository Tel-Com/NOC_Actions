/*
 * Criado com SharpDevelop.
 * Usuário: fjstavares
 * Data: 01/02/2025
 * Hora: 02:42
 */

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOCActions
{
	public partial class UserConfig : Form
	{
		// Caminho do arquivo onde as operadoras serão salvas
		private string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "operadoras.txt");
		private string caminhoArquivo1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "cidades.txt");
		
		public string CaminhoArquivo { get { return caminhoArquivo; } }
		
		public UserConfig()
		{
			InitializeComponent();
			CarregarOperadoraSalvas(); // Carrega as operadoras salvas no ComboBox ao abrir o formulário
			CarregarCidadeSalvas();
			this.TopMost = true; // Mantém a janela no topo
			ordenarTabIndex();
		}
		
		// Eventos dos botões que chamam os métodos correspondentes
		
		void BtnAdicionarOperadoraClick(object sender, EventArgs e)
		{
			AdicionarOperadora();
		}
		void BtnDeletarOperadoraClick(object sender, EventArgs e)
		{
			DeletarOperadoraListada();
		}
		void ButtonAdicionarCidadeClick(object sender, EventArgs e)
		{
			AdicionarCidade();
		}
		void ButtonDeletarCidadeClick(object sender, EventArgs e)
		{
			DeletarCidadeAdicionada();
		}

		//		Adiciona uma nova Cidade à lista
		private void AdicionarCidade()
		{
			string adicionarCidadeEmLista = textBoxAdicionarCidade.Text.Trim();
			if (!string.IsNullOrWhiteSpace(adicionarCidadeEmLista) && !comboBoxCidadeAdicionada.Items.Contains(adicionarCidadeEmLista)) {
				comboBoxCidadeAdicionada.Items.Add(adicionarCidadeEmLista);
				textBoxAdicionarCidade.Clear();
				SalvarCidadeNoArquivo();
			} else {
				MessageBox.Show("Essa Cidade já foi adicionada ou o campo está vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		private void SalvarCidadeNoArquivo()
		{
			try {
				File.WriteAllLines(caminhoArquivo1, comboBoxCidadeAdicionada.Items.Cast<string>());
			} catch (Exception ex) {
				MessageBox.Show(string.Format("Erro ao salvar os dados: {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void DeletarCidadeAdicionada()
		{
			if (comboBoxCidadeAdicionada.SelectedItem == null) {
				MessageBox.Show("Por favor, selecione uma operadora para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			var resultadoDeConfirmacao = MessageBox.Show("Você tem certeza que deseja excluir esta operadora?",
			                                             "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultadoDeConfirmacao == DialogResult.Yes) {
				comboBoxCidadeAdicionada.Items.Remove(comboBoxCidadeAdicionada.SelectedItem);
				SalvarCidadeNoArquivo();
			}
		}
		
		// Adiciona uma nova operadora à lista, evitando duplicatas
		private void AdicionarOperadora()
		{
			string adicionarOperadoraEmLista = textBoxAdicionarOperadora.Text.Trim();
			
			if (!string.IsNullOrWhiteSpace(adicionarOperadoraEmLista) && !comboBoxOperadoraJaAdicionadas.Items.Contains(adicionarOperadoraEmLista)) {
				comboBoxOperadoraJaAdicionadas.Items.Add(adicionarOperadoraEmLista);
				textBoxAdicionarOperadora.Clear();
				SalvarOperadorasNoArquivo(); // Salva a lista atualizada no arquivo
			} else {
				MessageBox.Show("Essa operadora já foi adicionada ou o campo está vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		// Salva as operadoras da lista no arquivo
		private void SalvarOperadorasNoArquivo()
		{
			try {
				File.WriteAllLines(caminhoArquivo, comboBoxOperadoraJaAdicionadas.Items.Cast<string>());
			} catch (Exception ex) {
				MessageBox.Show(string.Format("Erro ao salvar os dados: {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		// Remove a operadora selecionada da lista e atualiza o arquivo
		private void DeletarOperadoraListada()
		{
			if (comboBoxOperadoraJaAdicionadas.SelectedItem == null) {
				MessageBox.Show("Por favor, selecione uma operadora para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var resultadoDeConfirmacao = MessageBox.Show("Você tem certeza que deseja excluir esta operadora?",
			                                             "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultadoDeConfirmacao == DialogResult.Yes) {
				comboBoxOperadoraJaAdicionadas.Items.Remove(comboBoxOperadoraJaAdicionadas.SelectedItem);
				SalvarOperadorasNoArquivo();
			}
		}
		
		// Carrega as operadoras salvas no arquivo para o ComboBox ao abrir o formulário
		private void CarregarOperadoraSalvas()
		{
			if (File.Exists(caminhoArquivo)) {
				string[] operadorasSalvas = File.ReadAllLines(caminhoArquivo);
				comboBoxOperadoraJaAdicionadas.Items.AddRange(operadorasSalvas);
			}
		}
		
		private void CarregarCidadeSalvas()
		{
			if (File.Exists(caminhoArquivo1)) {
				string[] cidadesSalvas = File.ReadAllLines(caminhoArquivo1);
				comboBoxCidadeAdicionada.Items.AddRange(cidadesSalvas);
			}
			
		}
		
		// Método para organizar a ordem de tabulação dos elementos do formulário
		private void ordenarTabIndex()
		{
			textBoxAdicionarCidade.TabIndex = 0;
			comboBoxCidadeAdicionada.TabIndex = 1;
			buttonAdicionarCidade.TabIndex = 2;
			buttonDeletarCidade.TabIndex = 3;
			textBoxAdicionarOperadora.TabIndex = 4;
			comboBoxOperadoraJaAdicionadas.TabIndex = 5;
			btnAdicionarOperadora.TabIndex = 6;
			btnDeletarOperadora.TabIndex = 7;
		}
	}
}
