using Dayvo.Bubble.Controllers.Bubble;
using NUnit.Framework;
using System.Collections.Generic;

namespace Dayvo.Test
{
    [TestFixture]
    public class Tests
    {
        private BubbleController controller;

        [SetUp]
        public void Setup()
        {
            // Arrange
            controller = new BubbleController();
        }

        [Test]
        public void TestAscendente()
        {
            // Arrange
            //BubbleController controller = new BubbleController();
            string Cadena = "50000,6,0,1,9";
            bool Asc = true;
            
            var expected = new[] { "ZeRo", "ONE","six","NINE", "50000" };
            // Act

            IEnumerable<string> result = controller.OrderBurbuja(Asc, Cadena); //as ViewResult;

            // Assert
            
            Assert.That(result, Is.EqualTo(expected));


        }
        [Test]
        public void TestDescendente()
        {
            
            string Cadena = "50000,6,0,1,9";
            bool Asc = false;

            var expected = new[] { "50000", "NINE", "six",  "ONE", "ZeRo" };
            // Act

            IEnumerable<string> result = controller.OrderBurbuja(Asc, Cadena); //as ViewResult;

            // Assert
            Assert.That(result, Is.EqualTo(expected));


        }
    }
}