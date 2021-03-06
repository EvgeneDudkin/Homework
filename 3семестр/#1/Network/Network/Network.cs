﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Класс локальной сети 
    /// </summary>
    public class Network
    {
        private GraphOfNetwork Graph { get; set; }
        private Computer[] ArrayOfComputers { get; set; }
        private Random randomizer { get; set; }
        private Queue<int> forTravers { get; set; }

        /// <summary>
        /// Конструктор класса с рандомайзером
        /// </summary>
        /// <param name="inputData"></param>
        /// <param name="numberForRandom"></param>
        public Network(ReadOut inputData, int numberForRandom)
        {
            ArrayOfComputers = inputData.ArrayOfComputer;
            Graph = inputData.Graph;
            randomizer = new Random(numberForRandom);
            forTravers = Graph.CreateBFSQueue();
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="inputData"></param>
        public Network(ReadOut inputData)
        {
            ArrayOfComputers = inputData.ArrayOfComputer;
            Graph = inputData.Graph;
            randomizer = new Random();
        }

        /// <summary>
        /// Класс одного такта 
        /// </summary>
        public void OneTact()
        {
            int nodeInTop = forTravers.Dequeue();
            for (int i = 0; i < Graph.NumberOfVertex; i++)
            {
                if (Graph.CheckEdge(nodeInTop, i))
                {
                    if (!ArrayOfComputers[nodeInTop].Infected && ArrayOfComputers[i].Infected)
                    {
                        ArrayOfComputers[nodeInTop].CheckInfection(randomizer);
                    }
                    if (ArrayOfComputers[nodeInTop].Infected && !ArrayOfComputers[i].Infected)
                    {
                        ArrayOfComputers[i].CheckInfection(randomizer);
                    }
                    forTravers.Enqueue(nodeInTop);
                }
            }
        }

        /// <summary>
        /// Вывод информации на экран
        /// </summary>
        /// <returns></returns>
        public string GetInformation()
        {
            string result = "";
            for (int i = 0; i < Graph.NumberOfVertex; i++)
            {
                result += Convert.ToString(i) + ' ' + ArrayOfComputers[i].OS.Name + ' ' + ArrayOfComputers[i].Infected + '\n';
            }
            return result;
        }
    }
}
