using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ending_Balance
{
    static class Program
    {
        /// <summary>
        /// 應用程式的進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows 樣式並啟動主表單。
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
