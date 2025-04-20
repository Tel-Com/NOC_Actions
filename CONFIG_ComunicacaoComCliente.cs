using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace NOCActions
{
    // Formulário de configuração de comunicação com o cliente
    public partial class CONFIG_ComunicacaoComCliente : Form
    {
        private ACAO_ComunicacaoComCliente form_comunicacaoComCliente;

        public CONFIG_ComunicacaoComCliente(ACAO_ComunicacaoComCliente form)
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            form_comunicacaoComCliente = form; // Recebe a referência do formulário principal
        }

        void BtnSalvarClick(object sender, EventArgs e)
        {
            string emailDestinatario1 = comboEmailContratoCliente_01.Text;
            string emailDestinatario2 = comboEmailContratoCliente_02.Text;
            string emailDestinatario3 = comboEmailContratoCliente_03.Text;

            // Concatena os e-mails usando ';' e remove os que estiverem vazios
            string concatenarEmails = string.Join(";", new[] {
                emailDestinatario1,
                emailDestinatario2,
                emailDestinatario3
            }.Where(email => !string.IsNullOrWhiteSpace(email)));

            // Adiciona ao ComboBox no formulário principal
            if (!string.IsNullOrWhiteSpace(concatenarEmails))
            {
                form_comunicacaoComCliente.AdicionarEmailsConcatenados(concatenarEmails);
            }

            this.Close(); // Fecha o formulário de configuração
        }
    }
}
