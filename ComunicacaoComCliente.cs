using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NOCActions
{
	public partial class ACAO_ComunicacaoComCliente : Form
	{
		private const string RegistroChave = "SOFTWARE\\NOCActions\\Cliente";

		public ACAO_ComunicacaoComCliente()
		{
			InitializeComponent();
			OrdenarTabIndex();
			CarregarDadosCliente(); // Carregar dados ao iniciar
		}

		public ACAO_ComunicacaoComCliente(string nomeCliente, string enderecoCliente, string unidadeCliente, string razaoSocialCliente, string emailContatoCliente)
		{
			InitializeComponent();
			OrdenarTabIndex();
			SalvarDadosCliente(nomeCliente, enderecoCliente, unidadeCliente, razaoSocialCliente, emailContatoCliente);
			CarregarDadosCliente();
		}

		private void SalvarDadosCliente(string nome, string endereco, string unidade, string razaoSocial, string email)
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistroChave);
				
				
				string dadosSalvos = key.GetValue("DadosCliente", "").ToString();
				
				
				SalvarDadoNoRegistro(key, "NomeClientes", nome);
				SalvarDadoNoRegistro(key, "Enderecos", endereco);
				SalvarDadoNoRegistro(key, "Unidades", unidade);
				SalvarDadoNoRegistro(key, "RazoesSociais", razaoSocial);
				SalvarDadoNoRegistro(key, "Emails", email);
				
				
//				List<string> dadosCliente = dadosSalvos.Split('|').ToList();
//
//				if (!dadosCliente.Contains(nome)) dadosCliente.Add(nome);
//				if (!dadosCliente.Contains(endereco)) dadosCliente.Add(endereco);
//				if (!dadosCliente.Contains(unidade)) dadosCliente.Add(unidade);
//				if (!dadosCliente.Contains(razaoSocial)) dadosCliente.Add(razaoSocial);
//				if (!dadosCliente.Contains(email)) dadosCliente.Add(email);
//
//				dadosCliente.Sort();
//
//				key.SetValue("DadosCliente", string.Join("|", dadosCliente));
				
				
				key.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar os dados do cliente: " + ex.Message);
			}
		}

		
		private void SalvarDadoNoRegistro(RegistryKey key, string chave, string valor)
		{
			string dadosSalvos = key.GetValue(chave, "").ToString();
			List<string> listaDados = dadosSalvos.Split('|').ToList();
			
			if(!listaDados.Contains(valor) && !string.IsNullOrWhiteSpace(valor))
			{
				listaDados.Add(valor);
				listaDados.Sort();
				key.SetValue(chave, string.Join("|", listaDados));
			}
			
		}
		private void CarregarDadosCliente()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistroChave);

				if (key != null)
				{
					// Carregar os dados certos para cada ComboBox
					CarregarDadosParaComboBox(key, "NomeClientes", comboBox1De);
					CarregarDadosParaComboBox(key, "Enderecos", comboBox2Para);
					CarregarDadosParaComboBox(key, "Unidades", comboBox3Cc);

					key.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
			}
		}

		// Método auxiliar para carregar dados de uma chave específica do registro para um ComboBox
		private void CarregarDadosParaComboBox(RegistryKey key, string chave, ComboBox comboBox)
		{
			string dadosSalvos = key.GetValue(chave, "").ToString();
			string[] dadosArray = dadosSalvos.Split('|');

			foreach (string dado in dadosArray)
			{
				if (!string.IsNullOrWhiteSpace(dado) && !comboBox.Items.Contains(dado))
				{
					comboBox.Items.Add(dado);
				}
			}
			comboBox.Sorted = true;
		}

		
//		private void CarregarDadosCliente()
//		{
//			try
//			{
//				RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistroChave);
//
//				if (key != null)
//				{
//					string dadosSalvos = key.GetValue("DadosCliente", "").ToString();
//					string[] dadosCliente = dadosSalvos.Split('|');
//
//					foreach (string dado in dadosCliente)
//					{
//						if (!string.IsNullOrWhiteSpace(dado))
//						{
//							if (!comboBox1De.Items.Contains(dado))
//							{
//								comboBox1De.Items.Add(dado);
//							}
//
//							if (!comboBox2Para.Items.Contains(dado))
//							{
//								comboBox2Para.Items.Add(dado);
//							}
//
//							if (!comboBox3Cc.Items.Contains(dado))
//							{
//								comboBox3Cc.Items.Add(dado);
//							}
//						}
//					}
//
//					// Ordenar os itens nos ComboBox
//					comboBox1De.Sorted = true;
//					comboBox2Para.Sorted = true;
//					comboBox3Cc.Sorted = true;
//
//					key.Close();
//				}
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
//			}
//		}
		
		private void OrdenarTabIndex()
		{
			comboBox1De.TabIndex = 1;
			comboBox2Para.TabIndex = 2;
			comboBox3Cc.TabIndex = 3;
			textBox1EmailAssunto.TabIndex = 4;
			richTextBox1Descricao.TabIndex = 5;
			btnInformarCliente.TabIndex = 6;
			btnPreviaEmail.TabIndex = 7;
			btnEnviar.TabIndex = 8;
			btnDeletar.TabIndex = 9;
		}

		void BtnConfiguracoesClick(object sender, EventArgs e)
		{
			CONFIG_ComunicacaoComCliente openAbrirGerenciamentoEConfiguracaoDeRegistros = new CONFIG_ComunicacaoComCliente();
			openAbrirGerenciamentoEConfiguracaoDeRegistros.ShowDialog();
			AtualizarListaClientes();
		}
		
		public void AtualizarListaClientes()
		{
			CarregarDadosCliente();
		}
	}
}
