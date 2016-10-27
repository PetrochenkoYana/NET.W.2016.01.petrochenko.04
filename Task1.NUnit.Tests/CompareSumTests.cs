using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Task1.DDT;


namespace Task1.NUnit.Tests
{
    [TestFixture]
    public class CompareSumTests
    {
        [Test]
        public void CompareTest1()
        {
            Assert.AreEqual(CompareSum.CompareElemSum(new [] {1,2,3,4,3,2,1}),3);
        }
        [Test]
        public void CompareTest2()
        {
            Assert.AreEqual(CompareSum.CompareElemSum(new[] { 1, 2, 5, 4, 3, 2, 1 }), -1);
        }
        [Test]
        public void CompareTest3()
        {
            Assert.AreEqual(CompareSum.CompareElemSum(new[] { -50,30,68,-40,20 }), 2);
        }
        [Test]
        public void CompareTest4()
        {
            Assert.AreEqual(CompareSum.CompareElemSum(new[] { 0,0,0,0,0,0,0 }), 0);
        }
        [Test]
        public void CompareTest5()
        {
            Assert.AreEqual(CompareSum.CompareElemSum(new[] { 2147483647, 30, 68, -40, 20 }), -1);
        }
        [Test]
        public void CompareTest6()
        {
            Assert.AreEqual(CompareSum.CompareElemSum(new[] { -2147483648, 30, 2147483647,1 }), 1);
        }
    }
}
