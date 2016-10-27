using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
using NUnit.Framework;

namespace Task2.NUnit.Tests
{
    [TestFixture]
    public class ConcatStringAlphabetTests
    {
        [Test]
        public void ConcatTest1()
        {
            Assert.AreEqual(ConcatStringAlphabet.Longest("abcdefghijklmnopqrstuvwxyz","vgkkcyfggkg"), "abcdefghijklmnopqrstuvwxyz");
        }
        [Test]
        public void ConcatTest2()
        {
            Assert.AreEqual(ConcatStringAlphabet.Longest("abcdefghijkl", "mnopqrstuvwxyz"), "abcdefghijklmnopqrstuvwxyz");
        }
        [Test]
        public void ConcatTest3()
        {
            Assert.Throws(typeof(FormatException), () => ConcatStringAlphabet.Longest("", ""), "");
        }
        [Test]
      
        public void ConcatTest4()
        {

            Assert.Throws(typeof(ArgumentNullException),()=>ConcatStringAlphabet.Longest(null, "vgkkcyfggkg"));
        }
        [Test]
        public void ConcatTest5()
        {
            
            Assert.Throws(typeof(FormatException), () => ConcatStringAlphabet.Longest("тмлуамутмут", "abcdefghijklmnopqrstvwxyz"));
        }
    }
}
