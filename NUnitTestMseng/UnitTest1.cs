using System;
using NUnit.Framework;

namespace NUnitTestMseng
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(@"a\b")]
        [TestCase(@"c\d")]
        public void TestMethod1(string a)
        {
            
        }

        [TestCase(1)]
        public void Test2(int a)
        {

        }

        [TestCase(5)]
        public void Test3(int a)
        {

        }
    }
}
