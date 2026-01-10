//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using NOC_Actions.Services;

//namespace NOC_Actions.Uc_AvisosSolicitacoesAoCliente
//{
//    public partial class Config_AnaliseDeInfra : Form
//    {
//        public Config_AnaliseDeInfra()
//        {
//            InitializeComponent();
//        }
//        private void Config_AnaliseDeInfra_Load(object sender, EventArgs e)
//        {
//            comboBoxOperadora.Items.AddRange(
//                InfraFileService.LerArquivo(InfraFileService.ArquivoOperadora));

//            comboBoxUnidade.Items.AddRange(
//                InfraFileService.LerArquivo(InfraFileService.ArquivoUnidade));

//            comboBoxTipoAnalise.Items.AddRange(
//                InfraFileService.LerArquivo(InfraFileService.ArquivoTipoDeAnalise));
//        }

//    }
//}
