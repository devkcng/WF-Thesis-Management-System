﻿using System;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms;

namespace WFThesisManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FLogin());
        }
    }
}
