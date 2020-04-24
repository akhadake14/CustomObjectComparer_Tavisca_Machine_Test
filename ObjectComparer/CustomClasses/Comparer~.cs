using ObjectComparer.Utility;
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
        public ICustomComparer comparer { get; set; }

        public Comparer(object obj1 , object obj2)
        {
             comparer = ComparerHelper.GetComparer(obj1, obj2);
        }

        public bool AreSimilar<T>(T obj1, T obj2)
        {
            return comparer.AreSimilar(obj1, obj2);
        }
    }
}
