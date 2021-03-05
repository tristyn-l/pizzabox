using Xunit;
using PizzaBox.Domain.Models;

namespace PizzaBox.Testing.Tests
{
    public class StoreTest
    {
        public void Test_ChicagoPizza_Fact()
        {
            // arrange
            var sut = new ChicagoPizza();
            var expected = "Chicago Pizza";

            // act
            var actual = sut.Name;
            
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Chicago Pizza")]
        [InlineData("")]
        public void Test_ChicagoPizza_Theory(string expected)
        {
            // arrange
            var sut = new ChicagoPizza();

            // act
            var actual = sut.Name;
            
            // assert
            Assert.Equal(expected, actual);
        }
    }
}