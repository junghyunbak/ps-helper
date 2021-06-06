using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modify
{
    static class modifyMain
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // mutex
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String mtxName = Application.ProductName;
            Boolean mtxSuccess;
            Mutex mtx = new Mutex(true, mtxName, out mtxSuccess);
            if (!mtxSuccess) return;
            // form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new modifyForm());
        }
    }
}
