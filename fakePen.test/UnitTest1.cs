using System;
using Xunit;

namespace fakePen.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(11, new ValuesService().GetNumber());
        }
    }
}