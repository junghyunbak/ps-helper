using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace popup
{
    static class popupMain
    {
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
            Application.Run(new popupBox());
            mtx.ReleaseMutex();
        }
    }
}
