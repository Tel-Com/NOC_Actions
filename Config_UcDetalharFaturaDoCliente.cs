using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace NOC_Actions
{
	public partial class Config_UcDetalharFaturaDoCliente : UserControl
	{
		private readonly string caminhoArquivoUnidadeCliente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unidade_cliente.txt");
		private readonly string caminhoArquivoOperadora = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "operadora.txt");
		private readonly string caminhoArquivoStatus = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "statusDoCaso.txt");
		
		public Config_UcDetalharFaturaDoCliente()
		{
			InitializeComponent();
			
			CarregarUnidadeClienteSalva();
			CarregarOperadoraSalva();
			CarregarStatusDoContratoSalvo();
		}
		
		private void MostrarUserControl(UserControl uc)
		{
			this.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			this.Controls.Add(uc);
		}
		
		void BtnSalvarUnidadeClienteClick(object sender, EventArgs e)
		{
			SalvarItensNoArquivo_UnidadeCliente();
		}
		
		void BtnSalvarOperadoraClick(object sender, EventArgs e)
		{
			SalvarItensNoArquivo_Operadora();
		}
		
		void BtnSalvarStatusDoContratoClick(object sender, EventArgs e)
		{
			SalvarItensNoArquivo_StatusDoContrato();
		}
		
		private void SalvarItensNoArquivo_UnidadeCliente()
		{
			string adicionarClienteUnidadeEmLista = comboBox_UnidadeCliente.Text.Trim();
			if (!string.IsNullOrWhiteSpace(adicionarClienteUnidadeEmLista) && !comboBox_UnidadeCliente.Items.Contains(adicionarClienteUnidadeEmLista)) {
				comboBox_UnidadeCliente.Items.Add(adicionarClienteUnidadeEmLista);
				comboBox_UnidadeCliente.Text = "";
				RegistrarNoArquivo(comboBox_UnidadeCliente, caminhoArquivoUnidadeCliente);
			}
		}
		
		private void SalvarItensNoArquivo_Operadora()
		{
			string adicionarOperadoraEmLista = comboBox_OperadoraDoContrato.Text.Trim();
			if(!string.IsNullOrWhiteSpace(adicionarOperadoraEmLista) && !comboBox_OperadoraDoContrato.Items.Contains(adicionarOperadoraEmLista) )
			{
				comboBox_OperadoraDoContrato.Items.Add(adicionarOperadoraEmLista);
				comboBox_OperadoraDoContrato.Text = "";
				RegistrarNoArquivo(comboBox_OperadoraDoContrato, caminhoArquivoOperadora);
				
			} else
			{
				MessageBox.Show("Essa operadora já foi adicionada ou o campo está vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		private void SalvarItensNoArquivo_StatusDoContrato()
		{
			string adicionarStatusDoContratoEmLista = comboBox_StatusDoContrato.Text.Trim();
			if (!string.IsNullOrWhiteSpace(adicionarStatusDoContratoEmLista) && !comboBox_StatusDoContrato.Items.Contains(adicionarStatusDoContratoEmLista))
			{
				comboBox_StatusDoContrato.Items.Add(adicionarStatusDoContratoEmLista);
				comboBox_StatusDoContrato.Text = "";
				RegistrarNoArquivo(comboBox_StatusDoContrato, caminhoArquivoStatus);
			}
		}
		
		private void RegistrarNoArquivo(ComboBox comboBox, string caminhoArquivo)
		{
			try {
				File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
			} catch (Exception ex) {
				MessageBox.Show("Erro ao realizar este procedimento. \n\n" + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		private void CarregarUnidadeClienteSalva()
		{
			if (File.Exists(caminhoArquivoUnidadeCliente))
			{
				string[] unidadeCliente = File.ReadAllLines(caminhoArquivoUnidadeCliente);
				comboBox_UnidadeCliente.Items.AddRange(unidadeCliente);
			}
		}
		
		private void CarregarOperadoraSalva()
		{
			if (File.Exists(caminhoArquivoOperadora))
			{
				string[] operadora =  File.ReadAllLines(caminhoArquivoOperadora);
				comboBox_OperadoraDoContrato.Items.AddRange(operadora);
			}
		}
		
		private void CarregarStatusDoContratoSalvo()
		{
			if (File.Exists(caminhoArquivoStatus)) {
				string[] statusDoContrato = File.ReadAllLines(caminhoArquivoStatus);
				comboBox_StatusDoContrato.Items.AddRange(statusDoContrato);
			}
		}
		
		void BtnVoltarClick(object sender, EventArgs e)
		{
			MostrarUserControl(new UcDetalharFaturaDoCliente());
		}
	}
}