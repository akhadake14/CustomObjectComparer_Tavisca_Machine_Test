using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectComparer.Tests.TestClasses;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerFixture
    {
       // static readonly IComparerFactory comparerFactory = new ComparerFactory();


        [TestMethod]
        public void Null_values_are_similar_test()
        {
            string first = null, second = null;
            var objectComparer = new ObjectComparer<string>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Any_Null_Value_Similarity_Test()
        {
            string first = null, second = "Test";
            var objectComparer = new ObjectComparer<string>(first, second);
            Assert.IsFalse(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Value_Type_Similarity_Test()
        {
            int first = 123, second = 123;
            var objectComparer = new ObjectComparer<int>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Value_Type_Similarity_Test_With_Datetime()
        {
            DateTime first = DateTime.Now, second = DateTime.Now;
            var objectComparer = new ObjectComparer<DateTime>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Collection_Type_Similarity_Test()
        {
            List<int> first = new List<int> { 1, 3, 2 }, second = new List<int> { 1, 2, 3 };
            var objectComparer = new ObjectComparer<List<int>>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void String_Values_Are_Similar_Test()
        {
            string first = "Test", second = "Test";
            var objectComparer = new ObjectComparer<string>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_Test()
        {
            CustomClassA first = new CustomClassA("Test1", "123"), second = new CustomClassA("Test1", "123");
            var objectComparer = new ObjectComparer<CustomClassA>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_Test_Second()
        {
            CustomClassB first = new CustomClassB("Test1", 123), second = new CustomClassB("Test1", 123);
            var objectComparer = new ObjectComparer<CustomClassB>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_NagativeTest_Second()
        {
            CustomClassB first = new CustomClassB("Test1", 123), second = new CustomClassB("Test1", 1235);
            var objectComparer = new ObjectComparer<CustomClassB>(first, second);
            Assert.IsFalse(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_Test_WithArray()
        {
            ArrayTest first = new ArrayTest("Test1", 123, new int[] { 3, 2, 1 }), second = new ArrayTest("Test1", 123, new int[] { 1, 3, 2 });
            var objectComparer = new ObjectComparer<ArrayTest>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Custom_Objects_Are_Similar_Test_WithNestedObject()
        {
            CustomClassC first = new CustomClassC("Test1", new CustomClassA("Test1", "123")), second = new CustomClassC("Test1", new CustomClassA("Test1", "123"));
            var objectComparer = new ObjectComparer<CustomClassC>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }


        [TestMethod]
        public void Dictionary_Are_Similar_Test()
        {
            Dictionary<int,string> first = new Dictionary<int, string> (), second = new Dictionary<int, string>();
            first.Add(1, "test");
            second.Add(1, "test");
            var objectComparer = new ObjectComparer<Dictionary<int, string>>(first, second);
            Assert.IsTrue(objectComparer.AreSimilar());
        }

        [TestMethod]
        public void Dictionary_Are_Similar_NagativeTest()
        {
            Dictionary<int, string> first = new Dictionary<int, string>(), second = new Dictionary<int, string>();
            first.Add(1, "test");
            second.Add(1, "test1");
            var objectComparer = new ObjectComparer<Dictionary<int, string>>(first, second);
            Assert.IsFalse(objectComparer.AreSimilar());
        }
    }
}
