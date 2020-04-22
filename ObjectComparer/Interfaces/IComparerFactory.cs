using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public interface IComparerFactory
    {
        ICustomComparer GetCustomComparer(object obj1, object obj2);
    }
}
