using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSpinner
{
    class Program
    {
        /// <summary>
        /// Defines the program entry point.
        /// </summary>
        /// <param name="args">An array of <see cref="T:System.String"/> containing command line parameters.</param>
        private static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        /// <summary>
        /// The async main method body.
        /// </summary>
        /// <param name="args">An array of <see cref="T:System.String"/> containing command line parameters.</param>
        /// <returns>Waitable <see cref="T:System.Threading.Tasks.Task"/></returns>
        private static async Task MainAsync(string[] args)
        {
            using (new ConsoleSpinner())
            {
                await Task.Delay(2000);
            }
        }
    }
}
