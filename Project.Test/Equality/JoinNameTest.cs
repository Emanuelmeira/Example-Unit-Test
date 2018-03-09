using NUnit.Framework;

namespace Calculator.Test.Igualdade
{
    [TestFixture]
    public class JoinNameTest
    {        
        [Test]
        public void MustJoinTwoNameComplete()
        {
            var sut = new JoinNames();

            var nameComplete = sut.JoinName("Emanuel", "Meira");

            Assert.That(nameComplete, Is.EqualTo("Emanuel Meira"));
        }
        
        [Test]
        public void MustJoinTwoNameComplete_NotEqual()
        {
            var sut = new JoinNames();

            var nomeCompleto = sut.JoinName("Emanuel", "Silva");

            Assert.That(nomeCompleto, Is.Not.EqualTo("Rial Lemos"));
        }
    }


}
