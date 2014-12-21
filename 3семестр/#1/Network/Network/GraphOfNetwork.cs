using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Класс для создания матрицы смежности 
    /// </summary>
    public class GraphOfNetwork
    {
        public int NumberOfVertex { get; private set; }

        public bool[,] Matrix { get; private set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="numberOfVertex"></param>
        public GraphOfNetwork(int numberOfVertex)
        {
            this.NumberOfVertex = numberOfVertex;
            Matrix = new bool[numberOfVertex, numberOfVertex];
        }

        /// <summary>
        /// Создание ребра между двумя вершинами 
        /// </summary>
        /// <param name="firstVertex"></param>
        /// <param name="secondVertex"></param>
        public void CreateEdge(int firstVertex, int secondVertex)
        {
            if (firstVertex >= NumberOfVertex || secondVertex >= NumberOfVertex || firstVertex < 0 || secondVertex < 0)
            {
                throw new IncorrectInputDataException();
            }
            Matrix[firstVertex, secondVertex] = true;
            Matrix[secondVertex, firstVertex] = true;
        }

        /// <summary>
        /// Проверка на существование ребра между вершинами 
        /// </summary>
        /// <param name="firstVertex"></param>
        /// <param name="secondVertex"></param>
        /// <returns></returns>
        public bool CheckEdge(int firstVertex, int secondVertex)
        {
            return Matrix[firstVertex, secondVertex];
        }

        /// <summary>
        /// Создание очереди для обхода 
        /// </summary>
        /// <returns></returns>
        public Queue<int> CreateBFSQueue()
        {
            if (NumberOfVertex == 0)
            {
                throw new IncorrectInputDataException();
            }
            Queue<int> forSearch = new Queue<int>();
            Queue<int> result = new Queue<int>();
            bool[] visited = new bool[NumberOfVertex];
            forSearch.Enqueue(0);
            visited[0] = true;
            while (forSearch.Count != 0)
            {
                int numberOfTop = forSearch.Dequeue();
                result.Enqueue(numberOfTop);
                for (int i = 0; i < NumberOfVertex; i++)
                {
                    if (Matrix[numberOfTop, i])
                    {
                        if (!visited[i])
                        {
                            forSearch.Enqueue(i);
                            visited[i] = true;
                        }
                    }
                }
            }
            return result;
        }
    }
}
