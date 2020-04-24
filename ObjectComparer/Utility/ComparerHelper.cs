using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Utility
{
    internal static class ComparerHelper
    {
        static readonly IComparerFactory comparerFactory = new ComparerFactory();
        public static ICustomComparer GetComparer(object obj1, object obj2)
        {           
            return  comparerFactory.GetCustomComparer(obj1, obj2);
        }

    }
}


