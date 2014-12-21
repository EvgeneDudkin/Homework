using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Класс компьютера в сети
    /// </summary>
    public class Computer
    {
        public OS OS { get; set; }

        public bool Infected { get; set; }

        /// <summary>
        /// Метод для проверки на зараженность 
        /// </summary>
        /// <param name="randomizer"></param>
        public void CheckInfection(Random randomizer)
        {
            if (randomizer.Next(1, 100) <= OS.Probability)
            {
                Infected = true;
            }
        }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="OS"></param>
        /// <param name="infect"></param>
        public Computer(OS OS, bool infect)
        {
            this.OS = OS;
            Infected = infect;
        }
    }
}
