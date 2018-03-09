using NUnit.Framework;

namespace Calculator.Test.Number
{
    [TestFixture]
    public class NumberTest
    {
        [Test]
        public void MustBeDifferent()
        {
            var sut  = new Numbers();

            var different = sut.CheckDifferent(10, 20);

            Assert.IsTrue(different);
        }

        [Test]
        public void MustBeEquals()
        {
            var sut = new Numbers();

            var different = sut.CheckDifferent(10, 10);

            Assert.IsFalse(different);
        }
    }
}
