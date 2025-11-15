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
			string getNumeroChamado = txtOperatorCallID.Text.Trim();
			string getHorarioDeRegistro = textBoxCallRegistrationTime.Text.Trim();
			return "Prezados, o chamado " + getNumeroChamado + " foi registrado às " + getHorarioDeRegistro + " junto ao fornecedor.";
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
			txtOperatorCallID.Text = "";
			textBoxCallRegistrationTime.Text = "";
		}
		
		void CloseWindow()
		{
			this.FindForm().Close();
		}
	}
}
