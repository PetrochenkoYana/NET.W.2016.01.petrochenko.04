using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.DDT;

namespace Task1.DDT.Tests
{
    [TestClass()]
    public class CompareSumTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\DataTest.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("C:\\Users\\Yana_Petrochenko\\Documents\\Visual Studio 2015\\Projects\\NET.W.2016.01.petrochenko.04\\Task1.DDT.Tests\\DataTest.xml")]
        [TestMethod]
        public void TestMethod1()
        {
            var arr = Convert.ToString(TestContext.DataRow["Array"]).Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).
          Select(x => int.Parse(x)).ToArray();
            var expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);
            var actual = Convert.ToString(CompareSum.CompareElemSum(arr));
            Assert.AreEqual(expected, actual);
        }
    }
}
