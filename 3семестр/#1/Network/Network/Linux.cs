﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Класс ОС Linux
    /// </summary>
    public class Linux : OS
    {
        public override string Name { get; protected set; }
        public override double Probability { get; protected set; }

        /// <summary>
        /// Конструктор 
        /// </summary>
        public Linux()
        {
            Name = "Linux";
            Probability = 67.3;
        }
    }
}
