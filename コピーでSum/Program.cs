using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace コピーでGoKei
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new 答フォーム());
            }
            catch(Exception ex) { }
        }

    }
}
