using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Tests.TestClasses
{
    public class CustomClassA
    {
        public string Name { get; }
        public string Value { get; }

        public CustomClassA(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
