/*

Author: Joseph Heirendt

Program Title: Temperature Converter

File Description:

For test 2, this program will take in input and convert its temperature to either kelvin or fahrenheit.

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heirendt_Joseph_CSC317_Test2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
