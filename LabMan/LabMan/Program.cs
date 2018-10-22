using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMan
{
    

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        public static DialogResult rslt;

        public static DialogResult rsltt
        {
            get
            {
                return rslt;
            }
            set
            {
                rslt = value;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                Application.Run(new frmLogin());
                if (DialogResult.OK == rslt)
                {
                    Application.Run(new frmParent());
                }
                if (DialogResult.Abort == rslt)
                {
                    Application.Exit();
                    break;
                }
                //Application.ExitThread();
                Application.Exit();
                
            }

        }
    }
}
