using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class ComparerFactory : IComparerFactory
    {
        public ICustomComparer GetCustomComparer(object obj1, object obj2)
        {
            ICustomComparer comparer = null;

            if (obj1 == null || obj2 == null)
                return new NullValueComparer();

            if (obj1.GetType().IsValueType)
                return new ValueTypeComparer();

            if (obj1 is string)
                return new StringComparer();

            if (obj1 is ICollection || obj1 is IEnumerable || obj1 is Array)
                return new CollectionTypeComparer();

            if (comparer == null)
                return new ObjectTypeComparer();


            return comparer;
        }
    }
}
