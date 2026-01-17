using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NOC_Actions
{
    public partial class Uc_AnaliseDeInfra : UserControl
    {
        #region Constantes / Caminhos de Arquivo

        private readonly string arquivoOperadora =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoOperadora.txt");

        private readonly string arquivoUnidade =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoUnidade.txt");

        private readonly string arquivoTipoDeAnalise =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "arquivoTipoDeAnalise.txt");

        #endregion

        #region Construtor

        public Uc_AnaliseDeInfra()
        {
            InitializeComponent();
            CarregarDadosIniciais();
        }

        #endregion

        #region Inicialização

        private void CarregarDadosIniciais()
        {
            CarregarItens(arquivoOperadora, comboBox_OperadoraDaUnidade);
            CarregarItens(arquivoUnidade, comboBox_unidade);
            CarregarItens(arquivoTipoDeAnalise, comboBox_statusObtidoPelaOperadora);
        }

        #endregion

        #region Persistência (Salvar / Carregar)

        private void SalvarOperadora()
        {
            SalvarItem(comboBox_OperadoraDaUnidade, arquivoOperadora);
        }

        private void SalvarUnidade()
        {
            SalvarItem(comboBox_unidade, arquivoUnidade);
        }

        private void SalvarTipoDeAnalise()
        {
            SalvarItem(comboBox_statusObtidoPelaOperadora, arquivoTipoDeAnalise);
        }

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

        private void CarregarItens(string arquivo, ComboBox comboBox)
        {
            if (!File.Exists(arquivo))
                return;

            comboBox.Items.Clear();
            comboBox.Items.AddRange(
                File.ReadAllLines(arquivo)
                    .Distinct()
                    .ToArray()
            );
        }

        #endregion

        #region Exclusão de Itens

        private bool ExcluirSelecionado(ComboBox comboBox, string caminhoArquivo)
        {
            if (comboBox.SelectedItem == null || !File.Exists(caminhoArquivo))
                return false;

            string valor = comboBox.SelectedItem.ToString();
            List<string> linhas = File.ReadAllLines(caminhoArquivo).ToList();

            if (!linhas.Remove(valor))
                return false;

            File.WriteAllLines(caminhoArquivo, linhas);
            comboBox.Items.Remove(valor);
            comboBox.SelectedIndex = -1;

            return true;
        }

        #endregion

        #region Eventos de Botões

        private void btnSalvarECopiar_Click_1(object sender, EventArgs e)
        {
            richTextBox_MensagemASerEncaminhadaAoCliente.Clear();

            string operadora = comboBox_OperadoraDaUnidade.Text;
            string unidade = comboBox_unidade.Text;
            string status = comboBox_statusObtidoPelaOperadora.Text;


            SalvarOperadora();
            SalvarUnidade();
            SalvarTipoDeAnalise();
            LimparCampos();

            string mensagem = GerarMensagem(operadora, unidade, status);
            Clipboard.SetText(mensagem);
        }

        private void btnGerarAlerta_Click(object sender, EventArgs e)
        {
            richTextBox_MensagemASerEncaminhadaAoCliente.Clear();

            GerarMensagemDeUso(
                comboBox_OperadoraDaUnidade.Text,
                comboBox_unidade.Text,
                comboBox_statusObtidoPelaOperadora.Text
            );
        }


        private void bntExcluirSelecionado_Click(object sender, EventArgs e)
        {
            bool excluiuAlgo = false;

            excluiuAlgo |= ExcluirSelecionado(comboBox_OperadoraDaUnidade, arquivoOperadora);
            excluiuAlgo |= ExcluirSelecionado(comboBox_unidade, arquivoUnidade);
            excluiuAlgo |= ExcluirSelecionado(comboBox_statusObtidoPelaOperadora, arquivoTipoDeAnalise);

            MessageBox.Show(
                excluiuAlgo ? "Item(ns) excluído(s) com sucesso!" : "Selecione ao menos um item para excluir."
            );
        }

        private void btnApagarCampos_Click(object sender, EventArgs e)
        {
            richTextBox_MensagemASerEncaminhadaAoCliente.Clear();
            LimparCampos();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        #endregion

        #region Utilitários

        private void LimparCampos()
        {

            MessageBox.Show("Mensagem apagada!");
            comboBox_OperadoraDaUnidade.Text = string.Empty;
            comboBox_unidade.Text = string.Empty;
            comboBox_statusObtidoPelaOperadora.Text = string.Empty;
         }

        private void GerarMensagemDeUso(string operadora, string unidade, string tipoDeAnalise)
        {
            richTextBox_MensagemASerEncaminhadaAoCliente.Text =
                $"Prezados, {ObterSaudacao()}.\n\n" +
                $"Faço parte do NOC da Tel&Com e estou realizando uma análise interna na {unidade}.\n\n" +
                $"Poderiam, por gentileza, verificar o serviço da {operadora}? " +
                $"Conforme identificado pela fornecedora, o serviço encontra-se com o seguinte status: {tipoDeAnalise}.\n\n" +
                $"Fico no aguardo.\n" +
                $"Obrigado.";
        }

        private string GerarMensagem(string operadora, string unidade, string tipoDeAnalise)
        {
            return
                $"Prezados, {ObterSaudacao()}.\n\n" +
                $"Faço parte do NOC da Tel&Com e estou realizando uma análise interna na {unidade}.\n\n" +
                $"Poderiam, por gentileza, verificar o serviço da {operadora}? " +
                $"Conforme identificado pela fornecedora, o serviço encontra-se com o seguinte status: {tipoDeAnalise}.\n\n" +
                $"Fico no aguardo.\n" +
                $"Obrigado.";
        }


        private string ObterSaudacao()
        {
            int hora = DateTime.Now.Hour;

            if (hora >= 5 && hora < 12) return "bom dia";
            if (hora >= 12 && hora < 18) return "boa tarde";
            return "boa noite";
        }

        private void btnExcluirTodosOsCampos_Click(object sender, EventArgs e)
        {
            bool excluiuAlgo = false;

            excluiuAlgo |= ExcluirTodos(comboBox_OperadoraDaUnidade, arquivoOperadora);
            excluiuAlgo |= ExcluirTodos(comboBox_unidade, arquivoUnidade);
            excluiuAlgo |= ExcluirTodos(comboBox_statusObtidoPelaOperadora, arquivoTipoDeAnalise);

            richTextBox_MensagemASerEncaminhadaAoCliente.Clear();

            MessageBox.Show(
                excluiuAlgo
                    ? "Todos os itens foram excluídos com sucesso!"
                    : "Não havia itens para excluir."
            );
        }

        private bool ExcluirTodos(ComboBox comboBox, string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
                return false;

            try
            {
                File.WriteAllText(caminhoArquivo, string.Empty); // limpa o arquivo
                comboBox.Items.Clear();
                comboBox.SelectedIndex = -1;
                comboBox.Text = string.Empty;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir todos os itens: " + ex.Message);
                return false;
            }
        }

        void CloseWindow()
        {
            this.FindForm().Close();
        }

        private void Uc_AnaliseDeInfra_Load(object sender, EventArgs e)
        {

        }
    }
    #endregion
}