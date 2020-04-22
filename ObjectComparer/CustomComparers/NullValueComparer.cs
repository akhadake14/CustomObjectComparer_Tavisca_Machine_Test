using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    class NullValueComparer : ICustomComparer
    {
        public bool AreSimilar<T>(T obj1, T obj2)
        {
            if (obj1 == null && obj2 == null)
                return true;
            else
                return false;
        }
    }
}
