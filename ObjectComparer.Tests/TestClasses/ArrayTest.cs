using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Tests.TestClasses
{
    internal class ArrayTest
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int[] Arr { get; set; }

        public ArrayTest(string name, int value, int[] arr)
        {
            Name = name;
            Value = value;
            Arr = arr;
        }
    }
}
