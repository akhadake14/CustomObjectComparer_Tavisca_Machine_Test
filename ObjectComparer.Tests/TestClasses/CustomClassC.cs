using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Tests.TestClasses
{
    public class CustomClassC
    {
        public string Name { get; set; }

        public CustomClassA TestA { get; set; }

        public CustomClassC(string name , CustomClassA testA)
        {
            Name = name;
            TestA = testA;
        }
    }
}
