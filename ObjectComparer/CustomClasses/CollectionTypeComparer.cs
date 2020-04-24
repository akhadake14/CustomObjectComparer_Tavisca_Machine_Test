using ObjectComparer.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
     class CollectionTypeComparer : ICustomComparer
    {
        ICustomComparer comparerForRecursiveCall;

        public ICustomComparer ComparerForRecursiveCall { get => comparerForRecursiveCall; set => comparerForRecursiveCall = value; }

        public bool AreSimilar<T>(T obj1, T obj2)
        {
            dynamic collection1 = obj1 as ICollection;
            dynamic collection2 = obj2 as ICollection;

            bool IsSimilar = false;
            if (obj1 != null || obj2 != null)
            {            
                IsSimilar = false;
                foreach (var item in collection1)
                {
                    IsSimilar = false;
                    foreach (var item1 in collection2)
                    {
                        ComparerForRecursiveCall = ComparerHelper.GetComparer(item, item1);
                        if (!ComparerForRecursiveCall.AreSimilar(item, item1))
                            continue;

                        IsSimilar = true;
                        break;
                    }
                    if (!IsSimilar)
                        break;
                }
            }
            return IsSimilar;
        }
    }
}
