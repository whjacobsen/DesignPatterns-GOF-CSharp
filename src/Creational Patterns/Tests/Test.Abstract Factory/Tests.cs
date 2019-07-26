using Abstract_Factory;
using Abstract_Factory.Implementations;
using System;
using Xunit;

namespace Test.Abstract_Factory
{
    public class Tests
    {
        [Fact]
        public void InitConcreteFactory1Test()
        {
            // Arrange
            IAbstractFactory factory = new ConcreteFactory1();
            // Assert
            Assert.NotNull(factory);
        }

        [Fact]
        public void InitConcreteFactory2Test()
        {
            // Arrange
            IAbstractFactory factory = new ConcreteFactory2();
            // Assert
            Assert.NotNull(factory);
        }

        [Fact]
        public void CreateProductA1Test()
        {
            // Arrange
            IAbstractFactory factory = new ConcreteFactory1();
            var product = factory.CreateProductA();
            // Act
            var result = product.UsefulFunctionA();
            // Assert
            Assert.Equal("The result of the product A1.", result);
        }

        [Theory]
        [InlineData("The result of the product B1.")]     
        public void CreateProductB1Test(string value)
        {
            // Arrange
            IAbstractFactory factory = new ConcreteFactory1();
            var product = factory.CreateProductB();
            // Act
            var result = product.UsefulFunctionB();
            // Assert
            Assert.Equal(value, result);
        }
    }
}
