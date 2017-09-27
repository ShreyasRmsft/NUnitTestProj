using System;
using NUnit.Framework;

namespace NUnitTestMseng
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(@"Space Test\space test.txt", @"Space Test\space test.txt")]
        [TestCase(@"Space Test/space test.txt", @"Space Test/space test.txt")]
        [TestCase(@"Assets\%20 test %20.txt", @"Assets\%2520 test %2520.txt")]
        public void TestMethod1()
        {
            
        }
    }
}
