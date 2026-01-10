using System;
using System.IO;
using System.Linq;

namespace NOC_Actions.Services
{
    public static class InfraFileService
    {
        private static string AppData =>
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static string ArquivoOperadora =>
            Path.Combine(AppData, "arquivoOperadora.txt");

        public static string ArquivoUnidade =>
            Path.Combine(AppData, "arquivoUnidade.txt");

        public static string ArquivoTipoDeAnalise =>
            Path.Combine(AppData, "arquivoTipoDeAnalise.txt");

        public static string[] LerArquivo(string caminho)
        {
            if (!File.Exists(caminho))
                return Array.Empty<string>();

            return File.ReadAllLines(caminho)
                       .Distinct()
                       .ToArray();
        }

        public static void SalvarArquivo(string caminho, string[] valores)
        {
            File.WriteAllLines(caminho, valores);
        }
    }
}
