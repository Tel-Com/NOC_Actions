using NOC_Actions.Uc_AvisosSolicitacoesAoCliente;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOC_Actions
{
    public partial class Uc_LiberacaoDeAcesso : UserControl
    {
        #region Caminhos dos Arquivos

        private readonly string arquivoOperadoraSolicitacaoVisita =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "operadoraSolicitacaoVisita.txt");

        private readonly string arquivoPrevisaoDeChegadaTecnica =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "previsaoDeChegadaTecnica.txt");

        private readonly string arquivoUnidadeRespectivaParaVisita =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unidadeRespectivaParaVisita.txt");

        private readonly string arquivoEnderecoDaUnidade =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unidadeEnderecoParaVisitaTecnica.txt");

        #endregion

        #region Construtor

        public Uc_LiberacaoDeAcesso()
        {
            InitializeComponent();
            CarregarDadosIniciais();
            btnAmplicarTexto.Click += btnAmplicarTexto_Click;
        }

        #endregion

        #region Inicialização

        private void CarregarDadosIniciais()
        {
            CarregarItens(arquivoOperadoraSolicitacaoVisita, comboBox_operadoraResponsavel);
            CarregarItens(arquivoPrevisaoDeChegadaTecnica, comboBox_previaoDeChegada);
            CarregarItens(arquivoUnidadeRespectivaParaVisita, comboBox_unidadeParaLiberacaoDeAcesso);
            CarregarItens(arquivoEnderecoDaUnidade, comboBox_enderecoDaUnidadeResponsavel);
        }

        #endregion

        #region Persistência (Salvar / Carregar)

        private void SalvarItem(ComboBox comboBox, string caminhoArquivo)
        {
            string valor = comboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
                return;

            if (!comboBox.Items.Contains(valor))
            {
                comboBox.Items.Add(valor);
                File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
            }
        }

        private void CarregarItens(string caminhoArquivo, ComboBox comboBox)
        {
            if (!File.Exists(caminhoArquivo))
                return;

            comboBox.Items.Clear();
            comboBox.Items.AddRange(
                File.ReadAllLines(caminhoArquivo)
                    .Distinct()
                    .ToArray()
            );
        }

        #endregion

        #region Eventos de Botão

        private void btnSalvarECopiar_Click(object sender, EventArgs e)
        {
            string mensagem = GerarMensagem();

            SalvarItem(comboBox_operadoraResponsavel, arquivoOperadoraSolicitacaoVisita);
            SalvarItem(comboBox_previaoDeChegada, arquivoPrevisaoDeChegadaTecnica);
            SalvarItem(comboBox_unidadeParaLiberacaoDeAcesso, arquivoUnidadeRespectivaParaVisita);
            SalvarItem(comboBox_enderecoDaUnidadeResponsavel, arquivoEnderecoDaUnidade);

            Clipboard.SetText(mensagem);
            ClearField();
        }

        private void btnGerarAlerta_Click(object sender, EventArgs e)
        {
            richTextBox_mensagemASerEncaminhadaAoCliente.Text = "";
            richTextBox_mensagemASerEncaminhadaAoCliente.Text = GerarMensagem();
        }

        #endregion

        #region Mensagem

        private string SanitizarTextoLinhaUnica(string texto)
        {
            return texto?
                .Replace("\r", "")
                .Replace("\n", "")
                .Trim();
        }

        private string GerarMensagem()
        {
            string equipeTecnica =
                string.IsNullOrWhiteSpace(textBox_nomeEquipeTecnica.Text) &&
                string.IsNullOrWhiteSpace(textBox_credenciaisDePessoaFisica.Text)
                    ? string.Empty
                    : $"Equipe técnica: {SanitizarTextoLinhaUnica(textBox_nomeEquipeTecnica.Text)} | " +
                      $"{SanitizarTextoLinhaUnica(textBox_credenciaisDePessoaFisica.Text)}\n";

            return
                $"Prezados, {ObterSaudacao()}.\n\n" +
                $"Faço parte do NOC da Tel&Com e solicito, por gentileza, a liberação de acesso para visita técnica.\n\n" +
                $"Operadora responsável: {comboBox_operadoraResponsavel.Text}\n" +
                $"Unidade: {comboBox_unidadeParaLiberacaoDeAcesso.Text}\n" +
                $"Endereço: {comboBox_enderecoDaUnidadeResponsavel.Text}\n" +
                equipeTecnica +
                $"Previsão de chegada do técnico: {comboBox_previaoDeChegada.Text}\n\n" +
                $"Fico no aguardo da confirmação.\n" +
                $"Obrigado.\n\n" +
                $"Atenciosamente,\n" +
                $"Network Operations Center (NOC)\n" +
                $"Tel&Com Telecomunicações";
        }

        #endregion

        #region Saudação

        private string ObterSaudacao()
        {
            int hora = DateTime.Now.Hour;

            if (hora >= 5 && hora < 12) return "bom dia";
            if (hora >= 12 && hora < 18) return "boa tarde";
            return "boa noite";
        }

        private void btnAmplicarTexto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox_mensagemASerEncaminhadaAoCliente.Text))
            {
                MessageBox.Show(
                    "Não há mensagem para ampliar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            using (var form = new AmpliarMensagemDeTexto_LiberacaoDeAcesso(
                richTextBox_mensagemASerEncaminhadaAoCliente.Text))
            {
                form.ShowDialog(this.FindForm());
            }
        }

        private void btnApagarCampos_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        void ClearField()
        {
            textBox_nomeEquipeTecnica.Text = "";
            textBox_credenciaisDePessoaFisica.Text = "";
            comboBox_operadoraResponsavel.Text = "";
            comboBox_previaoDeChegada.Text = "";
            comboBox_unidadeParaLiberacaoDeAcesso.Text = "";
            comboBox_enderecoDaUnidadeResponsavel.Text = "";
            richTextBox_mensagemASerEncaminhadaAoCliente.Text = "";
        }


        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        void CloseWindow()
        {
            this.FindForm().Close();
        }

        #endregion

        private void Uc_LiberacaoDeAcesso_Load(object sender, EventArgs e)
        {

        }
    }
}
    