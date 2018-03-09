using NUnit.Framework;

namespace Calculator.Test.Equality
{    
    [TestFixture]
    public class CalculadoraSimplesTests
    {
        [Test]
        public void MustAddTwoNumbers()
        {            
            var sut = new Calculator();

            var result = sut.Addition(5, 5);

            Assert.That(result, Is.EqualTo(10));
        }
                
        [Test]
        public void MustMultiplyTwoNumbers()
        {            
            var sut = new Calculator();

            var resultado = sut.Multiplication(5, 3);

            Assert.That(resultado, Is.EqualTo(15));
        }
                
        [Test]
        public void MustDivideTwoNumbers()
        {
            //SUT
            var sut = new Calculator();

            var resultado = sut.Division(25, 5);

            Assert.That(resultado, Is.EqualTo(5));
        }
                
        [Test]
        public void MustSubtractTwoNumbers()
        {
            //SUT
            var sut = new Calculator();

            var resultado = sut.Subtraction(30, 5);

            Assert.That(resultado, Is.EqualTo(25));
        }

    }
}