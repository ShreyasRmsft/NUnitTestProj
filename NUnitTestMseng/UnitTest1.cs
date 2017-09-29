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
    }
}
