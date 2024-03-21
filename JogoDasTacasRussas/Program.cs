using System;
using System.Windows.Forms;

namespace GobbletGame
{
    static class Program
    {
        /** ************************************************************************
        * \brief Fun��o Main.
        * \details Entrypoint da aplica��o.  
        ***************************************************************************/
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormBoard());
        }
    }
}
