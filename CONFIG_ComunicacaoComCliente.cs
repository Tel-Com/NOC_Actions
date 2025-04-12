/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 26/02/2025
 * Time: 15:54
 */

using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace NOCActions
{
	public partial class CONFIG_ComunicacaoComCliente : Form
	{
		private Timer timer; // Timer para gerar ID único
		private ToolTip toolTip = new ToolTip(); // ToolTip para exibir detalhes ao passar o mouse

		// Construtor inicial que carrega os dados e configura eventos
		public CONFIG_ComunicacaoComCliente()
		{
			InitializeComponent();
			OrdenarTabIndex(); // Organiza os controles para navegação com Tab
			TimerGeneratorReload(); // Inicia o timer para gerar ID único
			CarregarInformacoesDeRegistro(); // Carrega dados da chave de registro ao iniciar
			this.listBox_ClientesAdicionados.MouseMove += new MouseEventHandler(ListBox_ClientesAdicionados_MouseMove); // Evento de movimentação do mouse no ListBox
			
			// Carregar lista de clientes salvos localmente
			CarregarListaLocalmente();
			
			this.listBox_ClientesAdicionados.SelectedIndexChanged += listBox_ClientesAdicionados_SelectedIndexChanged;
			
		}

		// Construtor que preenche os campos do formulário com dados fornecidos
		public CONFIG_ComunicacaoComCliente(string V1, string V2, string V3, string V4, string V5)
		{
			InitializeComponent();
			comboNomeCliente.Text = V1;
			comboEnderecoCliente.Text = V2;
			comboUnidadeDoCliente.Text = V3;
			comboRazaoSocialCliente.Text = V4;
			comboEmailContratoCliente.Text = V5;
		}

		// Método que salva as informações preenchidas no formulário no registro do Windows
		private void SalvarInformacoesDoFormulario()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NOCActions\Cliente");

				// Salva os dados de cada campo no registro
				SalvarDadoNaLista(key, "NomeClientes", comboNomeCliente.Text);
				SalvarDadoNaLista(key, "Enderecos", comboEnderecoCliente.Text);
				SalvarDadoNaLista(key, "Unidades", comboUnidadeDoCliente.Text);
				SalvarDadoNaLista(key, "RazoesSociais", comboRazaoSocialCliente.Text);
				SalvarDadoNaLista(key, "Emails", comboEmailContratoCliente.Text);

				key.Close(); // Fecha a chave após salvar
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar os dados: " + ex.Message); // Exibe mensagem de erro
			}
		}

		// Método que salva os dados na lista no registro
		private void SalvarDadoNaLista(RegistryKey KeyDown, string chave, string valor)
		{
			string dadosSalvos = KeyDown.GetValue(chave, "").ToString();
			List<string> lista = dadosSalvos.Split('|').ToList();
			
			// Adiciona o valor à lista se não estiver presente e não for vazio
			if (!lista.Contains(valor) && !string.IsNullOrWhiteSpace(valor))
			{
				lista.Add(valor);
				lista.Sort(); // Ordena a lista
				KeyDown.SetValue(chave, string.Join("|", lista.ToArray())); // Salva de volta no registro
			}
		}

		// Método que carrega os dados salvos no registro para os ComboBox
		private void CarregarInformacoesDeRegistro()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NOCActions\Cliente");

				if (key != null)
				{
					// Carrega as listas para os ComboBox a partir do registro
					CarregarListaNoComboBox(key, "NomeClientes", comboNomeCliente);
					CarregarListaNoComboBox(key, "Enderecos", comboEnderecoCliente);
					CarregarListaNoComboBox(key, "Unidades", comboUnidadeDoCliente);
					CarregarListaNoComboBox(key, "RazoesSociais", comboRazaoSocialCliente);
					CarregarListaNoComboBox(key, "Emails", comboEmailContratoCliente);

					key.Close(); // Fecha a chave após carregar
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar os dados: " + ex.Message); // Exibe mensagem de erro
			}
		}

		// Método que carrega as listas de um chave do registro para um ComboBox
		private void CarregarListaNoComboBox(RegistryKey key, string chave, ComboBox comboBox)
		{
			string dados = key.GetValue(chave, "").ToString();
			string[] itens = dados.Split('|');

			comboBox.Items.Clear(); // Limpa os itens do ComboBox
			foreach (string item in itens)
			{
				if (!string.IsNullOrWhiteSpace(item))
				{
					comboBox.Items.Add(item); // Adiciona itens ao ComboBox
				}
			}

			comboBox.Sorted = true; // Ordena os itens do ComboBox
		}

		// Organiza a navegação com Tab para os controles
		private void OrdenarTabIndex()
		{
			comboNomeCliente.TabIndex = 0;
			comboEnderecoCliente.TabIndex = 1;
			comboUnidadeDoCliente.TabIndex = 2;
			comboRazaoSocialCliente.TabIndex = 3;
			btnSalvar.TabIndex = 4;
			btnExcluir.TabIndex = 5;
			btnSair.TabIndex = 6;
		}

		// Inicia o timer que gera o ID único
		private void TimerGeneratorReload()
		{
			timer = new Timer();
			timer.Interval = 100; // Intervalo de 100ms
			timer.Tick += Timer_Tick; // Evento de tick do timer
			timer.Start();
		}

		// Gera um ID único e exibe no campo de texto
		private void GerarIDUnico()
		{
			string uniqueID = "T&C" + Guid.NewGuid().ToString("N").Substring(0, 10); // Gera um ID único de 10 caracteres
			maskedTextBox1UserID.Text = uniqueID;
		}

		// Evento que é disparado pelo timer para gerar o ID único
		private void Timer_Tick(object sender, EventArgs e)
		{
			GerarIDUnico();
			timer.Stop(); // Para o timer após gerar o ID
		}

		// Método para salvar as informações de um novo contrato
		void BtnSalvarClick(object sender, EventArgs e)
		{
			SalvarInformacoesDoFormulario(); // Salva os dados no registro

			string nomeCliente = comboNomeCliente.Text;
			string enderecoCliente = comboEnderecoCliente.Text;
			string unidadeCliente = comboUnidadeDoCliente.Text;
			string razaoSocialCliente = comboRazaoSocialCliente.Text;
			string emailContatoCliente = comboEmailContratoCliente.Text;

			// Cria uma nova instância do formulário de ação
			ACAO_ComunicacaoComCliente acaoForm = new ACAO_ComunicacaoComCliente(nomeCliente, enderecoCliente, unidadeCliente, razaoSocialCliente, emailContatoCliente);

			// Verifica se os campos obrigatórios estão preenchidos antes de adicionar ao ListBox
			if (!string.IsNullOrWhiteSpace(nomeCliente) &&
			    !string.IsNullOrWhiteSpace(razaoSocialCliente) &&
			    !string.IsNullOrWhiteSpace(enderecoCliente))
			{
				string textoCliente = ("Cliente: " + nomeCliente + " | Razão Social: " + razaoSocialCliente + "| Endereço: " + enderecoCliente).ToUpper();

				// Adiciona o item ao ListBox, se não estiver presente
				if (!string.IsNullOrWhiteSpace(textoCliente) && !listBox_ClientesAdicionados.Items.Contains(textoCliente))
				{
					listBox_ClientesAdicionados.Items.Add(textoCliente);
					SalvarListaLocalmente(); // Salva a lista localmente
				}
			}
			else
			{
				MessageBox.Show("Por favor, preencha todos os campos obrigatórios antes de adicionar o cliente.",
				                "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que mostra o ToolTip com as informações do item ao passar o mouse
		private void ListBox_ClientesAdicionados_MouseMove(object sender, MouseEventArgs e)
		{
			int index = listBox_ClientesAdicionados.IndexFromPoint(e.Location);
			
			// Verifica se o mouse está sobre um item válido
			if (index >= 0 && index < listBox_ClientesAdicionados.Items.Count)
			{
				string itemText = listBox_ClientesAdicionados.Items[index].ToString();
				
				// Atualiza o ToolTip com o texto do item
				if (toolTip.GetToolTip(listBox_ClientesAdicionados) != itemText)
				{
					toolTip.SetToolTip(listBox_ClientesAdicionados, itemText);
				}
			}
			else
			{
				// Limpa o ToolTip quando o mouse não estiver sobre um item válido
				toolTip.SetToolTip(listBox_ClientesAdicionados, "");
			}
		}

		// Método para salvar a lista de clientes localmente em um arquivo
		private void SalvarListaLocalmente()
		{
			try
			{
				string caminhoArquivoLista = "lista_de_clientes_salvos.txt";
				
				// Salva cada item do ListBox no arquivo, um por linha
				using (StreamWriter sw = new StreamWriter(caminhoArquivoLista, false))
				{
					foreach (var item in listBox_ClientesAdicionados.Items)
					{
						sw.WriteLine(item.ToString());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar os dados no arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Método para carregar a lista de clientes do arquivo local para o ListBox
		private void CarregarListaLocalmente()
		{
			try
			{
				string caminhoArquivoLista = "lista_de_clientes_salvos.txt";
				
				// Verifica se o arquivo existe antes de tentar carregar
				if (File.Exists(caminhoArquivoLista))
				{
					using (StreamReader sr = new StreamReader(caminhoArquivoLista))
					{
						string linha;
						while ((linha = sr.ReadLine()) != null)
						{
							if (!string.IsNullOrWhiteSpace(linha))
							{
								// Adiciona cada linha lida do arquivo no ListBox
								listBox_ClientesAdicionados.Items.Add(linha);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar os dados do arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void BtnExcluirClick(object sender, EventArgs e)
		{
			{
				if (listBox_ClientesAdicionados.SelectedItem != null)
				{
					var resultado = MessageBox.Show("Deseja realmente excluir o cliente selecionado?",
					                                "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (resultado == DialogResult.Yes)
					{
						

						string itemSelecionado = listBox_ClientesAdicionados.SelectedItem.ToString();
						
						listBox_ClientesAdicionados.Items.Remove(itemSelecionado);
						
						
						RemoverItemDoRegistro(comboNomeCliente.Text, "NomeClientes");
						RemoverItemDoRegistro(comboEnderecoCliente.Text, "Enderecos");
						RemoverItemDoRegistro(comboUnidadeDoCliente.Text, "Unidades");
						RemoverItemDoRegistro(comboRazaoSocialCliente.Text, "RazoesSociais");
						RemoverItemDoRegistro(comboEmailContratoCliente.Text, "Emails");

						
						comboNomeCliente.Text = "";
						comboEnderecoCliente.Text = "";
						comboUnidadeDoCliente.Text = "";
						comboRazaoSocialCliente.Text = "";
						comboEmailContratoCliente.Text = "";
						maskedTextBox1UserID.Text = "";
						
						CarregarInformacoesDeRegistro();
						SalvarListaLocalmente();
						
					}
				}
				else
				{
					MessageBox.Show("Selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		
		
		private void RemoverItemDoRegistro(string valor, string chave)
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NOCActions\Cliente", true);

				if (key != null)
				{
					string dados = key.GetValue(chave, "").ToString();
					List<string> lista = dados.Split('|').ToList();

					if (lista.Contains(valor))
					{
						lista.Remove(valor);
						key.SetValue(chave, string.Join("|", lista.ToArray()));
					}

					key.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao remover item do registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void listBox_ClientesAdicionados_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox_ClientesAdicionados.SelectedItem != null)
			{
				string textoSelecionado = listBox_ClientesAdicionados.SelectedItem.ToString();

				// Exemplo: "CLIENTE: NOME | RAZÃO SOCIAL: RS LTDA | ENDEREÇO: RUA TAL, 123"
				try
				{
					string[] partes = textoSelecionado.Split('|');

					string nome = partes[0].Replace("CLIENTE:", "").Trim();
					string razao = partes[1].Replace("RAZÃO SOCIAL:", "").Trim();
					string endereco = partes[2].Replace("ENDEREÇO:", "").Trim();

					comboNomeCliente.Text = nome;
					comboRazaoSocialCliente.Text = razao;
					comboEnderecoCliente.Text = endereco;
				}
				catch
				{
					MessageBox.Show("Formato inválido do item selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
