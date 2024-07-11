using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД__Теплый_дом_
{
     
    internal static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            form.Show();
            if (form.DialogResult == DialogResult.OK)
            {
                Avtorisate avtorisate = new Avtorisate();
                avtorisate.Icon = form.Icon;
                avtorisate.Font = form.Font;
                avtorisate.BackColor = form.BackColor;
                Application.Run(avtorisate);
            }
        }
    }
}
