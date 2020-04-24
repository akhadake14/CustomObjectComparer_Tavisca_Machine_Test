using ObjectComparer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class ObjectComparer<T>
    {
        T first;
        T second;
        ICustomComparer comparer;

        public T First { get => first; set => first = value; }
        public T Second { get => second; set => second = value; }
        public ICustomComparer Comparer { get => comparer; set => comparer = value; }

        public ObjectComparer(T first, T second)
        {
            First = first;
            Second = second;
            Comparer = ComparerHelper.GetComparer(first, second);
        }

        public bool AreSimilar()
        {
            return Comparer.AreSimilar(first, second);
        }
    }
}
