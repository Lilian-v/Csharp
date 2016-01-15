using System;

namespace Puissance4
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Puissance4 game = new Puissance4())
            {
                game.Run();
            }
        }
    }
#endif
}

