using HotDrinkVendor.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void IsNull()
        {
            object obj = null;
            Assert.That(obj, Is.Null);
        }
        [Test]
        public void GivenTheInputShouldReturnPriceequalstwo()
        {
            var mock = new Mock<ILogger<DrinkFactoryController>>();
            ILogger<DrinkFactoryController> logger = mock.Object;


            logger = Mock.Of<ILogger<DrinkFactoryController>>();

            var controller = new DrinkFactoryController(logger);

            double result = controller.Get("The");
            Assert.AreEqual("2.4", result);
        }

        [Test]
        public void GivenEspressoInputShouldReturnPriceequalsone()
        {
            var mock = new Mock<ILogger<DrinkFactoryController>>();
            ILogger<DrinkFactoryController> logger = mock.Object;


            logger = Mock.Of<ILogger<DrinkFactoryController>>();

            var controller = new DrinkFactoryController(logger);

            double result = controller.Get("Expresso");
            Assert.AreEqual("1.56", result);
        }


        [Test]
        public void GivenChocolateInputShouldReturnPriceequalsthree()
        {
            var mock = new Mock<ILogger<DrinkFactoryController>>();
            ILogger<DrinkFactoryController> logger = mock.Object;


            logger = Mock.Of<ILogger<DrinkFactoryController>>();

            var controller = new DrinkFactoryController(logger);

            double result = controller.Get("Expresso");
            Assert.AreEqual("3.86", result);
        }


        [Test]
        public void GivenCoca_Then_ThrowException()
        {
            var mock = new Mock<ILogger<DrinkFactoryController>>();
            ILogger<DrinkFactoryController> logger = mock.Object;


            logger = Mock.Of<ILogger<DrinkFactoryController>>();

            var controller = new DrinkFactoryController(logger);

            double result = controller.Get("Coca");
            Assert.AreEqual("Unavailable Order", result);
        }
    }    
}