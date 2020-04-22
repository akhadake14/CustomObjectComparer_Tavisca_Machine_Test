using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
     class DefaultComparer : ICustomComparer
    {
        public bool AreSimilar<T>(T obj1, T obj2)
        {
            return false;
        }
    }
}
