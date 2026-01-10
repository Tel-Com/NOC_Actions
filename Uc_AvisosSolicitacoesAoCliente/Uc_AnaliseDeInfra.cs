//using NOC_Actions.Uc_AvisosSolicitacoesAoCliente;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOC_Actions
{
    public partial class Uc_AnaliseDeInfra : UserControl
    {
        private readonly string arquivo_operadora = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoOperadora.txt");
        private readonly string arquivo_unidade = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoUnidade.txt");
        private readonly string arquivo_tipoDeAnalise = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoTipoDeAnalise.txt");
        public Uc_AnaliseDeInfra()
        {
            InitializeComponent();
            CarregarItens(arquivo_operadora, comboBox_OperadoraDaUnidade);
            CarregarItens(arquivo_unidade, comboBox_unidade);
            CarregarItens(arquivo_tipoDeAnalise, comboBox_statusObtidoPelaOperadora);
        }

        // responsável por salvar a operadora no arquivo
        private void SalvarOperadoraNoArquivoRespectivo()
        {
            string armazenamento = comboBox_OperadoraDaUnidade.Text.Trim();

            if (!string.IsNullOrWhiteSpace(armazenamento) && !comboBox_OperadoraDaUnidade.Items.Contains(armazenamento))
            {
                comboBox_OperadoraDaUnidade.Items.Add(armazenamento);
                SalvarItensArquivo(comboBox_OperadoraDaUnidade, arquivo_operadora);
            }
        }

        private void SalvarUnidadeNoArquivo()
        {
            string armazenamento = comboBox_unidade.Text.Trim();
            if (!string.IsNullOrWhiteSpace(armazenamento) && !comboBox_unidade.Items.Contains(armazenamento))
            {
                comboBox_unidade.Items.Add(armazenamento);
                SalvarItensArquivo(comboBox_unidade, arquivo_unidade);
            }
        }
        private void SalvarTipoDeAnalise()
        {
            string armazenamento = comboBox_statusObtidoPelaOperadora.Text.Trim();
            if (!string.IsNullOrWhiteSpace(armazenamento) && !comboBox_statusObtidoPelaOperadora.Items.Contains(armazenamento))
            {
                comboBox_statusObtidoPelaOperadora.Items.Add(armazenamento);
                SalvarItensArquivo(comboBox_statusObtidoPelaOperadora, arquivo_tipoDeAnalise);
            }
        }

        private void SalvarItensArquivo(ComboBox comboBox, string caminhoArquivo)
        {
            try
            {
                File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o procedimento " + ex);
            }
        }

        private void CarregarItens(string arquivo, ComboBox comboBoxLoad)
        {
            if (!File.Exists(arquivo)) return;

            comboBoxLoad.Items.Clear();
            comboBoxLoad.Items.AddRange(
                File.ReadAllLines(arquivo)
                    .Distinct()
                    .ToArray()
            );
        }

        // Responsável por Salvar e Gravar informações como um todo
        private void btnSalvarECopiar_Click_1(object sender, EventArgs e)
        {
            richTextBox_MensagemASerEncaminhadaAoCliente.Text = "";
            SalvarOperadoraNoArquivoRespectivo();
            SalvarUnidadeNoArquivo();
            SalvarTipoDeAnalise();
            ClearField();
        }

        private void btnGerarAlerta_Click(object sender, EventArgs e)
        {

            richTextBox_MensagemASerEncaminhadaAoCliente.Text = "";

            string operadora = comboBox_OperadoraDaUnidade.Text;
            string unidade = comboBox_unidade.Text;
            string tipoDeAnaliseInterna = comboBox_statusObtidoPelaOperadora.Text;

            GerarMensagemDeUso(operadora, unidade, tipoDeAnaliseInterna);
        }

        // Parâmetro responsável por excluir valores de campos selecionados
        private void btnEditarInformacoes_Click(object sender, EventArgs e)
        {
            bool algumExcluido = false;

            algumExcluido |= ExcluirSelecionado(comboBox_OperadoraDaUnidade, arquivo_operadora);
            algumExcluido |= ExcluirSelecionado(comboBox_unidade, arquivo_unidade);
            algumExcluido |= ExcluirSelecionado(comboBox_statusObtidoPelaOperadora, arquivo_tipoDeAnalise);

            if (!algumExcluido)
            {
                MessageBox.Show("Selecione ao menos um item para excluir.");
                return;
            }
            MessageBox.Show("Item(ns) excluído(s) com sucesso!");
        }


        private bool ExcluirSelecionado(ComboBox combo, string caminhoArquivo)
        {
            if (combo.SelectedItem == null)
                return false;

            string valor = combo.SelectedItem.ToString();

            if (!File.Exists(caminhoArquivo))
                return false;

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();

            bool removido = linhas.Remove(valor);

            if (removido)
            {
                File.WriteAllLines(caminhoArquivo, linhas);
                combo.Items.Remove(valor);
                combo.SelectedItem = -1;
            }
            return removido;
        }
        private void btnApagarCampos_Click(object sender, EventArgs e)
        {
            richTextBox_MensagemASerEncaminhadaAoCliente.Text = "";
            ClearField();
        }

        void ClearField()
        {
            comboBox_OperadoraDaUnidade.Text = "";
            comboBox_unidade.Text = "";
            comboBox_statusObtidoPelaOperadora.Text = "";
        }
        private void GerarMensagemDeUso(string operadora, string unidade, string tipoDeAnalise)
        {
            richTextBox_MensagemASerEncaminhadaAoCliente.Text =
                $"Prezados, {SaudacaoAoDia()}.\n\n" +
                $"Faço parte do NOC da Tel&Com e estou realizando uma análise interna na {unidade}.\n\n" +
                $"Poderiam, por gentileza, verificar o serviço da {operadora}? " +
                $"Conforme  identificado pela fornecedora, o serviço encontra-se com o seguinte status: {tipoDeAnalise}.\n\n" +
                $"Fico no aguardo.\n" +
                $"Obrigado.";
        }

        private string SaudacaoAoDia()
        {
            int horaAtual = DateTime.Now.Hour;

            if (horaAtual >= 5 && horaAtual <= 12)
                return "bom dia";
            else if (horaAtual >= 12 && horaAtual <= 18)
                return "boa tarde";
            else
                return "boa noite";
        }


    }
}

