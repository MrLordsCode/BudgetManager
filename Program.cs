using System;
using System.Windows.Forms;

namespace BudgetManager
{
    class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowMain());
        }
    }
}
