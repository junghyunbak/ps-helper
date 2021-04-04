using System;
using System.Threading;
using System.Windows.Forms;

namespace stopwatch
{
    static class stopwatchMain
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
            Application.Run(new stopwatchForm());
            mtx.ReleaseMutex();
        }
    }
}
