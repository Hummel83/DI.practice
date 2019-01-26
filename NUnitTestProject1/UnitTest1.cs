using appveyor.netcore;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private object _bla;

        [SetUp]
        public void Setup()
        {
            _bla = new Class1();
        }

        [Test]
        public void Test1()
        {
            Assert.IsNotNull(_bla);
        }
    }
}