using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectComparer.Tests.TestClasses;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerFixture
    {
        [TestMethod]
        public void Null_values_are_similar_test()
        {
            string first = null, second = null;
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Any_Null_Value_Similarity_Test()
        {
            string first = null, second = "Test";
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsFalse(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Value_Type_Similarity_Test()
        {
            int first = 123, second = 123;
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Value_Type_Similarity_Test_With_Datetime()
        {
            DateTime first = DateTime.Now, second = DateTime.Now;
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Collection_Type_Similarity_Test()
        {
            List<int> first = new List<int> { 1,3,2}, second = new List<int> { 1, 2, 3 };
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void String_Values_Are_Similar_Test()
        {
            string first = "Test", second = "Test";
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_Test()
        {
            CustomClassA first = new CustomClassA("Test1", "123"), second = new CustomClassA("Test1", "123");
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_Test_Second()
        {
            CustomClassB first = new CustomClassB("Test1", 123), second = new CustomClassB("Test1", 123);
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_NagativeTest_Second()
        {
            CustomClassB first = new CustomClassB("Test1", 123), second = new CustomClassB("Test1", 1235);
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsFalse(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_Test_WithArray()
        {
            ArrayTest first = new ArrayTest("Test1", 123 , new int[] { 3,2,1}), second = new ArrayTest("Test1", 123, new int[] { 1, 3, 2});
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_Test_WithNestedObject()
        {
            CustomClassC first = new CustomClassC("Test1", new CustomClassA("Test1", "123")), second = new CustomClassC("Test1", new CustomClassA("Test1", "123"));
            IComparerFactory comparerFactory = new ComparerFactory();
            ICustomComparer comparer = comparerFactory.GetCustomComparer();
            Assert.IsTrue(comparer.AreSimilar(first, second));
        }

    }
}
