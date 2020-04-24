using ObjectComparer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
     class ObjectTypeComparer : ICustomComparer
    {

        ICustomComparer comparerForRecursiveCall;

        public ICustomComparer ComparerForRecursiveCall { get => comparerForRecursiveCall; set => comparerForRecursiveCall = value; }
        public bool AreSimilar<T>(T obj1, T obj2)
        {
            var listOfPropertiesToCheck = obj1.GetType().GetProperties();
            foreach (var property in listOfPropertiesToCheck)
            {
                var obj1_value = property.GetValue(obj1);
                var obj2_value = property.GetValue(obj2);
                ComparerForRecursiveCall = ComparerHelper.GetComparer(obj1_value, obj2_value);

                if (!ComparerForRecursiveCall.AreSimilar(obj1_value, obj2_value))
                    return false;
                else
                    continue;
            }
            return true;
        }
    }
}
