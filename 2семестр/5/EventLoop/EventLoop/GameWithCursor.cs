using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoop
{
    /// <summary>
    /// Класс, в котором расписаны методы
    /// </summary>
    public class GameWithCursor
    {
        /// <summary>
        /// Метод кнопки влево
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLeft(object sender, EventArgs args)
        {
            if (Console.CursorLeft != 0)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }

        /// <summary>
        /// Метод кнопки вправо
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft < Console.BufferWidth - 1)
            {
                Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            }
        }

        /// <summary>
        /// Метод, кнопки вверх
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnUp(object sender, EventArgs args)
        {
            if (Console.CursorTop != 0)
            {
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            }
        }

        /// <summary>
        /// Метод кнопки вниз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDown(object sender, EventArgs args)
        {
            if (Console.CursorTop < Console.BufferHeight - 1)
            {
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
            }
        }
    }
}
