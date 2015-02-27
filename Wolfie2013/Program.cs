#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Wolfie2013
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        private static WolfieGame game;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            game = new WolfieGame();
            game.Run();
        }
    }
}
