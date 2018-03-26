using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRDepartment.BL;

namespace HRDepartment
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            fmMain form = new fmMain();
            MessageService service = new MessageService();

            MainPresenter presenter = new MainPresenter(form, service);

            Application.Run(form);
        }
    }
}
