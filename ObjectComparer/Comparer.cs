using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class Comparer : ICustomComparer
    {
        public bool AreSimilar<T>(T obj1, T obj2)
        {
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer(obj1, obj2);

            return comparer.AreSimilar(obj1, obj2);
        }
    }
}
