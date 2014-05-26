using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoop
{
    /// <summary>
    /// Класс программы 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Сборка для игры
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var eventLoop = new CursorEventLoop();
            var game = new GameWithCursor();
            eventLoop.LeftHandler += game.OnLeft;
            eventLoop.RightHandler += game.OnRight;
            eventLoop.UpHandler += game.OnUp;
            eventLoop.DownHandler += game.OnDown;
            eventLoop.Run();
        }
    }
}
