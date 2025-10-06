using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NOC_Actions;

namespace NOC_Actions
{
	public partial class MainForm : Form
	{
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;
		
		public MainForm()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
			this.TopMost = true;
			OrdenarTabIndex();

			PointerMouseMove.MouseDown += PointerMouseMovePaint_MouseDown;
		}

		private void PointerMouseMovePaint_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}

//		 Eventos de clique dos botões que copiam mensagens padronizadas para a área de transferência
		void SemEnergiaClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Sem contato com a unidade. Devido queda simultânea dos links, possível queda de energia.");
		}

		void ButtonSemContatoLocalClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Sem contato do local, solicitado auxílio do Cliente na validação interna.");
		}

		void ButtonSemExpedienteClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Devido expediente do cliente, manteremos o link em monitoração até o próximo dia útil.");
		}

		void ButtonInfraOkClienteClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Cliente informa que unidade está com energia e Internet, será acionado fornecedor para verificação do alarme.");
		}

		void ButtonSemContatoOperadoraClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Sem contato com a Operadora, tentaremos novamente mais tarde.");
		}

		void ButtonAberturaDeOsClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Encaminhado e-mail solicitando abertura de chamado ao fornecedor.");
		}

		void ButtonPosicionamentoTecnicoClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Encaminhado e-mail solicitando posicionamento frente ao reparo em aberto junto ao fornecedor.");
		}

		// Método para organizar a ordem de tabulação dos elementos do formulário
		private void OrdenarTabIndex()
		{
			btnAcessosEUtilitarios.TabIndex = 0;
			btnInformesClientes.TabIndex = 1;
			btnAberturaDeMassiva.TabIndex = 2;
			SemEnergia.TabIndex = 3;
			ButtonPosicionamentoTecnico.TabIndex = 4;
			ButtonAberturaDeOs.TabIndex = 5;
			ButtonInfraOkCliente.TabIndex = 6;
			ButtonSemExpediente.TabIndex = 7;
			ButtonSemContatoLocal.TabIndex =8;
		}
		void BtnAberturaDeMassivaClick(object sender, EventArgs e)
		{
			MassivaForm open_window = new MassivaForm();
			open_window.Show();
		}
		void BtnInformesClientesClick(object sender, EventArgs e)
		{
			InterfaceClienteInformes open_window = new InterfaceClienteInformes();
			open_window.Show();
		}
		void BtnAcessosEUtilitariosClick(object sender, EventArgs e)
		{
			var open_window = new Utilitarios();
			open_window.Show();
			foreach (Form frm in Application.OpenForms)
			{
				if (frm is InterfaceClienteInformes)
				{
					frm.Hide();
					break;
				}
			}
		}
	}
}