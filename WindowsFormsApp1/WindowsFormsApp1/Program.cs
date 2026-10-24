using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitSistemi
{
    internal static class Program
    {
        public static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string combineForPath = Path.Combine(docPath, "KayitSistemi");
        public static string mainPath = Directory.CreateDirectory(combineForPath).FullName;
        public static string mainFileName, adSoyad, ePosta, sifre;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
