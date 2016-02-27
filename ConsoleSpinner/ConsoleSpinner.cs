using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSpinner
{
    public class ConsoleSpinner : IDisposable
    {
        private int frameTime = 100;
        private int frameCounter = 0;
        private string[] frames = { "/", "-", @"\", "|" };
        private readonly Timer backgroundWorker;

        public ConsoleSpinner()
        {
            this.backgroundWorker = new Timer(t =>
            {
                string frame = frames[++frameCounter % frames.Length];
                int cursorLeft = Console.CursorLeft;
                int cursorTop = Console.CursorTop;
                if (cursorLeft != 0)
                {
                    cursorLeft--;
                }
                Console.SetCursorPosition(cursorLeft, cursorTop);
                Console.Write(frame);
            });
            this.backgroundWorker.Change(0, frameTime);
        }

        public void Dispose()
        {
            backgroundWorker.Dispose();
            Console.WriteLine();
        }
    }
}
