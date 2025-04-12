/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 08/07/2024
 * Hora: 06:37
 * 
 */
 
using System;
using System.Windows.Forms;

namespace NOCActions
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ACAO_ComunicacaoComCliente());
		}
	}
}