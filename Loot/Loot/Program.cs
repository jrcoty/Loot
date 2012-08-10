using System;

namespace Loot
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Main game = new Main())
            {
                game.IsFixedTimeStep = false; 
                game.Run();
            }
        }
    }
#endif
}

