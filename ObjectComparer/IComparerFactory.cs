using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public abstract class IComparerFactory
    {
        public abstract ICustomComparer GetCustomComparer();
    }
}
