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
			string getValueCarrierName = textBoxCarrierName.Text;
			string getValueHorario_Queda = textBoxDowntime.Text;
			return "Prezados, bom dia! Identificamos alarme do link da " + getValueCarrierName + " indisponível às " + getValueHorario_Queda + ". Iremos seguir com acionamento junto ao fornecedor.";
		}
		
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			CloseWindow();
		}
		
		void BtnClearFieldsClick(object sender, EventArgs e)
		{
			ClearField();
		}
		
		void BtnSaveAndCopyClick(object sender, EventArgs e)
		{
			string msn = GetCustomerNotificationMessage();
			Clipboard.SetText(msn);
			ClearField();
		}
		
		void ClearField()
		{
			textBoxCarrierName.Text = "";
			textBoxDowntime.Text = "";
		}
		
		void CloseWindow()
		{
			this.FindForm().Close();
		}
	}
}
