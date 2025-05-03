using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace NOCActions
{
	// Formulário de configuração de comunicação com o cliente
	public partial class CONFIG_ComunicacaoComCliente : Form
	{
		// Referência para o formulário principal
		private ACAO_ComunicacaoComCliente form_comunicacaoComCliente;

		// Caminhos dos arquivos que armazenam as informações
		private string arquivoEmailRemetente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "email_usuario_remetente.txt");
		private string arquivoEmailCorporativoCc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "email_usuario_empresarial_copy.txt");
		private string arquivoInformacoesContratoCliente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "informacoes_do_contrato_do_cliente.txt");
		private string arquivoEmailCliente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "email_de_clientes.txt");
		private string arquivoNomeCliente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "nome_cliente.txt");
		private string arquivoEnderecoCliente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "endereco_cliente.txt");
		private string arquivoUnidadeCliente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unidade_cliente.txt");
		
		private string arquivoRazaoSocialCliente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "razao_social_cliente.txt");
		private string arquivoClientesAdicionados = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "clientes_adicionados.txt");

		// Construtor do formulário de configuração
		public CONFIG_ComunicacaoComCliente(ACAO_ComunicacaoComCliente form)
		{
			InitializeComponent();  // Inicializa os componentes do formulário
			form_comunicacaoComCliente = form;  // Armazena a referência do formulário principal
			CarregarEmailsSalvosNosComboBox();  // Carrega os e-mails previamente salvos ao abrir o formulário
			CarregarEmailsDeRemetentesSalvos();
			CarregarEmailCorporativoEmCopy();
			CarregarInformacoesDoContratoDoCliente();
			CarregarClientesAdicionados();
			OrganizarTabIndex();
			
			
			btnExcluir.Click += BtnExcluirClick;

		}

		// Evento de clique do botão de salvar
		void BtnSalvarClick(object sender, EventArgs e)
		{
			// Adiciona o cliente à listBox de clientes adicionados
			AdicionarClienteNaListBox();
			
			// Obtém os e-mails dos campos do formulário
			string emailDestinatario1 = comboEmailContratoCliente_01.Text;

			// Concatena os e-mails, separando-os por ponto e vírgula e removendo os vazios
			string concatenarEmails = string.Join(";", new[] { emailDestinatario1}
			                                      .Where(email => !string.IsNullOrWhiteSpace(email)));

			// Verifica se existem e-mails concatenados e os adiciona ao ComboBox do formulário principal
			if (!string.IsNullOrWhiteSpace(concatenarEmails))
			{
				form_comunicacaoComCliente.AdicionarEmailsConcatenados(concatenarEmails);
			}

			// Salva os e-mails no arquivo
			SalvarEmailsNoArquivo(concatenarEmails);

			// Salva as informações do contrato do cliente
			InformacoesDoContratoDoCliente();
		}

		/// <summary>
		/// Métodos relacionados ao envio de e-mails e à gestão de arquivos
		/// </summary>

		// Salva o e-mail do remetente
		private void SalvarEmailRemetente(string email)
		{
			try
			{
				string diretorio = Path.GetDirectoryName(arquivoEmailRemetente);
				if (!Directory.Exists(diretorio))
				{
					Directory.CreateDirectory(diretorio);
				}

				// Adiciona o e-mail ao arquivo de remetentes
				File.AppendAllText(arquivoEmailRemetente, email + Environment.NewLine);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar o e-mail do remetente: " + ex.Message);
			}
		}

		// Evento de clique do botão para salvar e-mail do remetente
		void BtnSalvarRemetenteClick(object sender, EventArgs e)
		{
			string emailRemetente = comboBox_Remetente.Text;
			SalvarEmailRemetente(emailRemetente);
			comboBox_Remetente.Text = string.Empty;  // Limpa o campo após salvar
		}

		// Carrega os e-mails de remetente salvos no arquivo
		private void CarregarEmailsDeRemetentesSalvos()
		{
			if (File.Exists(arquivoEmailRemetente))
			{
				var remetentes = File.ReadAllLines(arquivoEmailRemetente)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.Distinct()  // Evita e-mails duplicados
					.ToList();

				foreach (var remetente in remetentes)
				{
					if (!comboBox_Remetente.Items.Contains(remetente))
					{
						comboBox_Remetente.Items.Add(remetente);
					}
				}
			}
		}

		// Salva o e-mail corporativo em cópia
		private void SalvarEmailCorporativoCopy(string emailCorporativo)
		{
			try
			{
				string diretorio = Path.GetDirectoryName(arquivoEmailCorporativoCc);
				if (!Directory.Exists(diretorio))
				{
					Directory.CreateDirectory(diretorio);
				}

				// Adiciona o e-mail corporativo ao arquivo de cópias
				File.AppendAllText(arquivoEmailCorporativoCc, emailCorporativo + Environment.NewLine);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar o e-mail corporativo: " + ex.Message);
			}
		}

		// Evento de clique do botão para salvar o e-mail corporativo em cópia
		void BtnSalvarEmailCorporativoEmCopyClick(object sender, EventArgs e)
		{
			string emailCorporativo = comboBox_EmailCorporativoEmCopy.Text;
			SalvarEmailCorporativoCopy(emailCorporativo);
			comboBox_EmailCorporativoEmCopy.Text = string.Empty;  // Limpa o campo após salvar
		}

		// Carrega os e-mails corporativos em cópia salvos no arquivo
		private void CarregarEmailCorporativoEmCopy()
		{
			if (File.Exists(arquivoEmailCorporativoCc))
			{
				var emailsCopy = File.ReadAllLines(arquivoEmailCorporativoCc)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.Distinct()  // Evita e-mails duplicados
					.ToList();

				foreach (var email in emailsCopy)
				{
					if (!comboBox_EmailCorporativoEmCopy.Items.Contains(email))
					{
						comboBox_EmailCorporativoEmCopy.Items.Add(email);
					}
				}
			}
		}

		/// <summary>
		/// Métodos relacionados às informações do contrato do cliente
		/// </summary>

		// Salva as informações do contrato do cliente
		private void InformacoesDoContratoDoCliente()
		{
			try
			{
				// Salva as informações do contrato em arquivos
				SalvarInformacoesEmArquivo(arquivoNomeCliente, comboNomeCliente.Text.Trim());
				SalvarInformacoesEmArquivo(arquivoEnderecoCliente, comboEnderecoCliente.Text.Trim());
				SalvarInformacoesEmArquivo(arquivoUnidadeCliente, comboUnidadeDoCliente.Text.Trim());
				SalvarInformacoesEmArquivo(arquivoRazaoSocialCliente, comboRazaoSocialCliente.Text.Trim());

				// Limpa os campos após salvar
				LimparCamposContratoCliente();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar as informações do cliente: " + ex.Message);
			}
		}

		// Salva as informações em arquivo
		private void SalvarInformacoesEmArquivo(string caminhoArquivo, string conteudo)
		{
			if (!string.IsNullOrWhiteSpace(conteudo))
			{
				string diretorio = Path.GetDirectoryName(caminhoArquivo);
				if (!Directory.Exists(diretorio))
				{
					Directory.CreateDirectory(diretorio);
				}

				// Adiciona as informações ao arquivo
				File.AppendAllText(caminhoArquivo, conteudo + Environment.NewLine);
			}
		}

		// Limpa os campos de informações do contrato do cliente
		private void LimparCamposContratoCliente()
		{
			comboNomeCliente.Text = string.Empty;
			comboEnderecoCliente.Text = string.Empty;
			comboUnidadeDoCliente.Text = string.Empty;
			comboRazaoSocialCliente.Text = string.Empty;
		}

		// Carrega as informações do contrato do cliente nos ComboBoxes
		private void CarregarInformacoesDoContratoDoCliente()
		{
			CarregarInformacaoEmComboBox(arquivoNomeCliente, comboNomeCliente);
			CarregarInformacaoEmComboBox(arquivoEnderecoCliente, comboEnderecoCliente);
			CarregarInformacaoEmComboBox(arquivoUnidadeCliente, comboUnidadeDoCliente);
			CarregarInformacaoEmComboBox(arquivoRazaoSocialCliente, comboRazaoSocialCliente);
		}

		// Carrega informações de um arquivo para o ComboBox
		private void CarregarInformacaoEmComboBox(string caminhoArquivo, ComboBox comboBox)
		{
			if (File.Exists(caminhoArquivo))
			{
				var linhas = File.ReadAllLines(caminhoArquivo)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.Distinct()  // Evita informações duplicadas
					.ToList();

				foreach (var linha in linhas)
				{
					if (!comboBox.Items.Contains(linha))
					{
						comboBox.Items.Add(linha);
					}
				}
			}
		}

		/// <summary>
		/// Métodos relacionados aos e-mails dos clientes
		/// </summary>

		// Salva os e-mails no arquivo de clientes
		private void SalvarEmailsNoArquivo(string email)
		{
			try
			{
				string diretorio = Path.GetDirectoryName(arquivoEmailCliente);
				if (!Directory.Exists(diretorio))
				{
					Directory.CreateDirectory(diretorio);
				}

				// Adiciona o e-mail ao arquivo de clientes
				File.AppendAllText(arquivoEmailCliente, email + Environment.NewLine);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar o e-mail: " + ex.Message);
			}
		}

		// Carrega os e-mails salvos nos ComboBoxes
		private void CarregarEmailsSalvosNosComboBox()
		{
			if (File.Exists(arquivoEmailCliente))
			{
				var emails = File.ReadAllLines(arquivoEmailCliente)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.ToList();

				// Adiciona os e-mails nos ComboBoxes
				foreach (var email in emails)
				{
					if (!comboEmailContratoCliente_01.Items.Contains(email))
						comboEmailContratoCliente_01.Items.Add(email);
				}
			}
		}

		// Adiciona um cliente à listBox e salva no arquivo
		private void AdicionarClienteNaListBox()
		{
			string nomeCliente = comboNomeCliente.Text;
			string unidadeCliente = comboUnidadeDoCliente.Text;

			// Concatena os e-mails dos campos
			string emailCliente = string.Join(" | ", new[] {
			                                  	comboEmailContratoCliente_01.Text,
			                                  }.Where(email => !string.IsNullOrWhiteSpace(email)));

			string enderecoCliente = comboEnderecoCliente.Text;
			string razaoSocial = comboRazaoSocialCliente.Text;
			
			// Formata e adiciona o cliente na listBox
			string clienteInfo = string.Format("Cliente: {0} | Unidade: {1} | E-mail: {2} | Endereço: {3} | Razão Social:  {4}", nomeCliente, unidadeCliente, emailCliente, enderecoCliente, razaoSocial);
			listBox_ClientesAdicionados.Items.Add(clienteInfo);

			// Salva o cliente adicionado no arquivo
			SalvarClienteAdicionadosNoArquivo(clienteInfo);
			
			comboEmailContratoCliente_01.Text = "";
			
		}

		// Salva as informações do cliente adicionado no arquivo
		private void SalvarClienteAdicionadosNoArquivo(string clienteInfo)
		{
			try
			{
				string diretorio = Path.GetDirectoryName(arquivoClientesAdicionados);
				if (!Directory.Exists(diretorio))
				{
					Directory.CreateDirectory(diretorio);
				}

				// Adiciona o cliente ao arquivo
				File.AppendAllText(arquivoClientesAdicionados, clienteInfo + Environment.NewLine);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar o cliente adicionado: " + ex.Message);
			}
		}

		// Carrega os clientes adicionados do arquivo para a listBox
		private void CarregarClientesAdicionados()
		{
			if (File.Exists(arquivoClientesAdicionados))
			{
				var clientes = File.ReadAllLines(arquivoClientesAdicionados)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.ToList();

				foreach (var cliente in clientes)
				{
					// Adiciona cada cliente na listBox
					listBox_ClientesAdicionados.Items.Add(cliente);
				}
			}
		}
		
//		responsável por remover o Cliente adicionado no formulário por completo
		void BtnExcluirClick(object sender, EventArgs e)
		{
			string clienteSelecionado = listBox_ClientesAdicionados.SelectedItem != null
				? listBox_ClientesAdicionados.SelectedItem.ToString()
				: string.Empty;

			listBox_ClientesAdicionados.Items.Remove(clienteSelecionado);
			RemoverLinhaDoArquivo(arquivoClientesAdicionados, clienteSelecionado);

			string[] partes = clienteSelecionado.Split('|');
			if (partes.Length >= 3)
			{
				string nome = partes[0].Replace("Cliente:", "").Trim();
				string unidade = partes[1].Replace("Unidade:", "").Trim();
				string[] emails = partes[2].Replace("E-mail:", "").Split(new[] { '|', ';' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(t => t.Trim()).ToArray();
				string endereco = partes.Length >= 4 ? partes[3].Replace("Endereço:", "").Trim() : string.Empty;
				string razaoSocial = partes.Length >= 5 ? partes[4].Replace("Razão Social:", "").Trim() : string.Empty;

				RemoverLinhaDoArquivo(arquivoNomeCliente, nome);
				RemoverLinhaDoArquivo(arquivoUnidadeCliente, unidade);
				RemoverLinhaDoArquivo(arquivoEnderecoCliente, endereco);
				RemoverLinhaDoArquivo(arquivoRazaoSocialCliente, razaoSocial);

				comboNomeCliente.Items.Remove(nome);
				comboUnidadeDoCliente.Items.Remove(unidade);
				comboEnderecoCliente.Items.Remove(endereco);
				comboRazaoSocialCliente.Items.Remove(razaoSocial);

				foreach (string email in emails)
				{
					RemoverLinhaDoArquivo(arquivoEmailCliente, email);
					comboEmailContratoCliente_01.Items.Remove(email);
				}
			}
		}

		private void RemoverLinhaDoArquivo(string caminhoArquivo, string linhaParaRemover)
		{
			if (File.Exists(caminhoArquivo))
			{
				var linhas = File.ReadAllLines(caminhoArquivo)
					.Where(l => !string.Equals(l.Trim(), linhaParaRemover.Trim(), StringComparison.OrdinalIgnoreCase))
					.Distinct()
					.ToList();

				File.WriteAllLines(caminhoArquivo, linhas);
			}
		}
		
		// Função responsável por organizar a navegação entre os controles do formulário
		private void OrganizarTabIndex()
		{
			// Ordem de TabIndex
			comboBox_Remetente.TabIndex = 0;
			btnSalvarRemetente.TabIndex = 1;
			comboBox_EmailCorporativoEmCopy.TabIndex = 2;
			btnSalvarEmailCorporativoEmCopy.TabIndex = 3;

			comboNomeCliente.TabIndex = 4;
			comboEnderecoCliente.TabIndex = 5;
			comboUnidadeDoCliente.TabIndex = 6;
			comboRazaoSocialCliente.TabIndex = 7;

			comboEmailContratoCliente_01.TabIndex = 8;

			btnSalvar.TabIndex = 11;
			btnExcluir.TabIndex = 12;
			
			btnDuvidaGeralDoFormulario.TabIndex = 13;
		}
	}
}
