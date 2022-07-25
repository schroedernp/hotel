using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    internal static class Program
    {
        //VARIÁVEIS GLOBAIS
        public static string chamadaProdutos;
        public static string nomeProduto;
        public static string estoqueProduto;
        public static Models.Fornecedores fornecedor;
        public static int idProduto;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
