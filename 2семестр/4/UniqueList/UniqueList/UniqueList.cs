using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueListNamespace
{
    public class UniqueList<T> : List<T>
    {
        public override void AddToHead(T value)
        {
            if (Exist(value))
            {
                throw new DublicateElementException();
            }
            else
            {
                base.AddToHead(value);
            }
        }
    }
}
