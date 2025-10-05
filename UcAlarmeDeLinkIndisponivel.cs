using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NOC_Actions
{
	public partial class UcAlarmeDeLinkIndisponivel : UserControl
	{
		public UcAlarmeDeLinkIndisponivel()
		{
			InitializeComponent();
		}
		
		private string GetCustomerNotificationMessage()
		{
			string getValueTextBox_NomeOperadora = textBox1_nomeOperadora.Text;
			string getValueHorario_Queda = textBox2_horarioQueda.Text;
			return "Prezados, bom dia! Identificamos alarme do link da " + getValueTextBox_NomeOperadora + " indisponível às " + getValueHorario_Queda + ". Iremos seguir com acionamento junto ao fornecedor.";
		}
		
		void BtnGravarECopiarClick(object sender, EventArgs e)
		{
			string msn = GetCustomerNotificationMessage();
			Clipboard.SetText(msn);
			textBox1_nomeOperadora.Text = "";
			textBox2_horarioQueda.Text = "";
			
		}
		void BtnApagarCamposClick(object sender, EventArgs e)
		{
			textBox1_nomeOperadora.Text = "";
			textBox2_horarioQueda.Text = "";
		}
		void BtnFecharJanelaClick(object sender, EventArgs e)
		{
			this.FindForm().Close();
		}
	}
}
