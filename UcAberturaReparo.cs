using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NOC_Actions
{
	public partial class UcAberturaDeReparo : UserControl
	{
		public UcAberturaDeReparo()
		{
			InitializeComponent();
		}
		
		private string GetCustomerNotificationMessage()
		{
			string getNumeroChamado = textBox1_ChamadoOperadora.Text.Trim();
			string getHorarioDeRegistro = textBox2_horarioDoRegistroChamado.Text.Trim();
			return "Prezados, chamado " + getNumeroChamado + " registrado às " + getHorarioDeRegistro + " junto ao fornecedor.";
		}
		
		void BtnGravarECopiarClick(object sender, EventArgs e)
		{
			string msn = GetCustomerNotificationMessage();
			Clipboard.SetText(msn); 
			
			textBox1_ChamadoOperadora.Text = "";
			textBox2_horarioDoRegistroChamado.Text = "";

		}
		void BtnApagarCamposClick(object sender, EventArgs e)
		{
			textBox1_ChamadoOperadora.Text = "";
			textBox2_horarioDoRegistroChamado.Text = "";
		}
		void BtnFecharJanelaClick(object sender, EventArgs e)
		{
			this.FindForm().Close();
		}
	}
}
