using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VigenereForm.Controllers;

namespace VigenereForm
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
            VigenereForm vigenereForm = new VigenereForm();
            VigenereFormPresenter vigenereFormPresenter = new VigenereFormPresenter(vigenereForm);
            Application.Run(vigenereForm);
        }
    }
}
