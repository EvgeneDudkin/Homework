﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculatorNamespace
{
    /// <summary>
    /// Интерфейс стэка
    /// </summary>
    public interface IStack
    {
        void Push(double value);

        void Pop();

        int Size();

        double Top();

        void Clear();

        string Write();
    }
}
