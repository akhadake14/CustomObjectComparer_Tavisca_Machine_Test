using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Tests.TestClasses
{
    public class CustomClassB
    {
        public string Name { get; }
        public int Value { get; }

        public CustomClassB(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
