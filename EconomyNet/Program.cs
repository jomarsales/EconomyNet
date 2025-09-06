using System;
using System.Windows.Forms;
using EconomyNet.UI;

namespace EconomyNet
{
    static class Program
    {
        public static string UserName;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Autenticar()) return;
            
            Application.Run(new FrmRoot());
        }

        private static bool Autenticar()
        {
            var frm = new FrmLogin();
            frm.ShowDialog();

            UserName = frm.User;

            return frm.Authenticated;
        }
    }
}
