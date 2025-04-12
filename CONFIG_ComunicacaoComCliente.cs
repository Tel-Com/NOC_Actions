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


namespace NOCActions
{
	public partial class CONFIG_ComunicacaoComCliente : Form
	{
		private Timer timer;
		
		public CONFIG_ComunicacaoComCliente()
		{
			InitializeComponent();
			OrdenarTabIndex();
			TimerGeneratorReload();
			CarregarInformacoesDeRegistro(); // Carrega os dados ao iniciar
		}
		
		public CONFIG_ComunicacaoComCliente(string V1, string V2, string V3, string V4, string V5)
		{
			InitializeComponent();
			
			comboNomeCliente.Text = V1;
			comboEnderecoCliente.Text = V2;
			comboUnidadeDoCliente.Text = V3;
			comboRazaoSocialCliente.Text = V4;
			comboEmailContratoCliente.Text = V5;
		}

//		Button responsável por salvar as informações do contrato
		private void SalvarInformacoesDoFormulario()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NOCActions\Cliente");

				SalvarDadoNaLista(key, "NomeClientes", comboNomeCliente.Text);
				SalvarDadoNaLista(key, "Enderecos", comboEnderecoCliente.Text);
				SalvarDadoNaLista(key, "Unidades", comboUnidadeDoCliente.Text);
				SalvarDadoNaLista(key, "RazoesSociais", comboRazaoSocialCliente.Text);
				SalvarDadoNaLista(key, "Emails", comboEmailContratoCliente.Text);

				key.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar os dados: " + ex.Message);
			}
		}

		private void SalvarDadoNaLista(RegistryKey KeyDown, string chave, string valor)
			
		{
			string dadosSalvos = KeyDown.GetValue(chave, "").ToString();
			List<string> lista = dadosSalvos.Split('|').ToList();
			
			if(!lista.Contains(valor) && !string.IsNullOrWhiteSpace(valor))
			{
				lista.Add(valor);
				lista.Sort();
				KeyDown.SetValue(chave, string.Join("|", lista.ToArray()));
			}
		}
		
		
		private void CarregarInformacoesDeRegistro()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NOCActions\Cliente");

				if (key != null)
				{
					CarregarListaNoComboBox(key, "NomeClientes", comboNomeCliente);
					CarregarListaNoComboBox(key, "Enderecos", comboEnderecoCliente);
					CarregarListaNoComboBox(key, "Unidades", comboUnidadeDoCliente);
					CarregarListaNoComboBox(key, "RazoesSociais", comboRazaoSocialCliente);
					CarregarListaNoComboBox(key, "Emails", comboEmailContratoCliente);

					key.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
			}
		}
		
		
		private void CarregarListaNoComboBox(RegistryKey key, string chave, ComboBox comboBox)
		{
			string dados = key.GetValue(chave, "").ToString();
			string[] itens = dados.Split('|');

			comboBox.Items.Clear();
			foreach (string item in itens)
			{
				if (!string.IsNullOrWhiteSpace(item))
				{
					comboBox.Items.Add(item);
				}
			}

			comboBox.Sorted = true;
		}
		
//		organiza o TAB
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
		
		private void TimerGeneratorReload()
		{
			timer = new Timer();
			timer.Interval = 2000; // Intervalo de 2 segundos
			timer.Tick += Timer_Tick;
			timer.Start();
		}
		
		private void GerarIDUnico()
		{
			string uniqueID = "T&C" + Guid.NewGuid().ToString("N").Substring(0, 10); // Pega os 10 primeiros caracteres
			maskedTextBox1UserID.Text = uniqueID;
		}
		
		private void Timer_Tick(object sender, EventArgs e)
		{
			GerarIDUnico();
			timer.Stop(); // Para o timer após a geração do ID
		}
		
//		button responsável por salvar informações do novo contrato
		void BtnSalvarClick(object sender, EventArgs e)
		{
			SalvarInformacoesDoFormulario();
			
			string nomeCliente = comboNomeCliente.Text;
			string enderecoCliente = comboEnderecoCliente.Text;
			string unidadeCliente = comboUnidadeDoCliente.Text;
			string razaoSocialCliente = comboRazaoSocialCliente.Text;
			string emailContatoCliente = comboEmailContratoCliente.Text;
			
			ACAO_ComunicacaoComCliente acaoForm = new ACAO_ComunicacaoComCliente(nomeCliente, enderecoCliente, unidadeCliente, razaoSocialCliente, emailContatoCliente);
			this.Close();
		}
		void ListaDeClientesSalvosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}