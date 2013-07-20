using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Input;
namespace Decoder
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
            //Create and show the form
            Form1 controllerTestForm = new Form1();
            controllerTestForm.Show();
            
            //Game Loop
            while (controllerTestForm.Created)
            {
                //Update the XBOX 360 controller state
                controllerTestForm.UpdateController();
                //Let applications handle messages
                Application.DoEvents();
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
