using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    internal class CustomComparer : ICustomComparer
    {
        public bool AreSimilar<T>(T obj1, T obj2)
        {
            if (obj1 == null && obj2 == null)
                return true;
            else if (obj1 != null && obj2 != null)
            {
                #region Checking Value types
                if (obj1.GetType().IsValueType)
                    return CheckValueTypes(obj1, obj2);
                #endregion

                #region Checking String values
                else if (obj1 is string)
                    return obj1.Equals(obj2);
                #endregion

                #region Checking collection and Array type
                else if (obj1 is ICollection || obj1 is IEnumerable || obj1 is Array)
                    return CheckCollectionAndArrayTypes(obj1, obj2);
                #endregion 

                else
                {
                    #region checking Objects and Nested Objects
                    var listOfPropertiesToCheck = obj1.GetType().GetProperties();
                    foreach (var property in listOfPropertiesToCheck)
                    {
                        var obj1_value = property.GetValue(obj1);
                        var obj2_value = property.GetValue(obj2);

                        if (!AreSimilar(obj1_value, obj2_value))
                            return false;
                        else
                            continue;
                    }
                    return true;
                    #endregion 
                }
            }
            return false;
        }

        #region Private Methods
        private bool CheckCollectionAndArrayTypes(object obj1_value, object obj2_value)
        {
            dynamic collection1 = obj1_value as ICollection;
            dynamic collection2 = obj2_value as ICollection;

            bool IsSimilar = false;
            if (obj1_value != null || obj2_value != null)
            {
                 IsSimilar = false;
                foreach (var item in collection1)
                {
                    IsSimilar = false;
                    foreach (var item1 in collection2)
                    {
                        if (!AreSimilar(item, item1))
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

        private bool CheckValueTypes(object obj1_value, object obj2_value)
        {
                return obj1_value.Equals(obj2_value);
        // enum and struct not considered for now
        }
        #endregion
    }
}
