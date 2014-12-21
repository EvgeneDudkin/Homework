using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Класс ОС MacOS
    /// </summary>
    public class MacOS : OS
    {
        public override string Name { get; protected set; }
        public override double Probability { get; protected set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public MacOS()
        {
            Name = "MacOS";
            Probability = 10.5;
        }
    }
}
