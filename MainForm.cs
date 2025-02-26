using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NOCActions
{
	public partial class MainForm : Form
	{
		// Importação de funções da API do Windows para permitir movimentação da janela sem bordas
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;
		
		public MainForm()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None; // Remove a borda da janela
			this.TopMost = true; // Mantém a janela sempre no topo
			OrdenarTabIndex();
		}

		// Permite mover a janela ao clicar e arrastar com o botão esquerdo do mouse
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}

		// Eventos de clique dos botões que copiam mensagens padronizadas para a área de transferência
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

		// Abre a janela de mensagens massivas ao clicar no botão correspondente
		void ButtonMassivaRegiaoClick(object sender, EventArgs e)
		{
			MassivaForm massiva = new MassivaForm();
			massiva.ShowDialog();
		}
		
		// Método para organizar a ordem de tabulação dos elementos do formulário 
		private void OrdenarTabIndex()
		{
			SemEnergia.TabIndex = 0;
			ButtonSemContatoLocal.TabIndex = 1;
			ButtonSemExpediente.TabIndex = 2;
			ButtonInfraOkCliente.TabIndex = 3;
			ButtonSemContatoOperadora.TabIndex = 4;
			ButtonAberturaDeOs.TabIndex = 5;
			ButtonPosicionamentoTecnico.TabIndex = 6;
		}
	}
}
