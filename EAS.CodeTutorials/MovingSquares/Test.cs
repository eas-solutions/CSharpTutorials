using System;
using System.Windows.Forms;

namespace EAS.CodeTutorials.MovingSquares
{
    public static class Test
    {
        static class Programm
        {
            /// <summary>
            /// Der Haupteinstiegspunkt für die Anwendung.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
