using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Èñêëþ÷åíèå", Math.Geometry.AreaÑircle(-1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(78.53981633974483 , Math.Geometry.AreaÑircle(5));
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            Assert.AreEqual(6, Math.Geometry.AreaTriangle(3, 4, 5));
        }

        [TestMethod]
        public void TestEquilateralTriangle()
        {
            Assert.AreEqual(10.825317547305483, Math.Geometry.AreaTriangle(5, 5, 5));
        }

        [TestMethod]
        public void TestVersatileTriangle()
        {
            Assert.AreEqual(5.332682251925386, Math.Geometry.AreaTriangle(3, 4, 6));
        }

        [TestMethod]
        public void TestIsoscelesTriangle()
        {
            Assert.AreEqual(5.562148865321747, Math.Geometry.AreaTriangle(4, 3, 4));
        }

        [TestMethod]
        public void TestNonexistentTriangle()
        {
            Assert.AreEqual(-1, Math.Geometry.AreaTriangle(4, 3, 45));
        }
    }
}
