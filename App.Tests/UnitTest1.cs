using System;
using Xunit;

namespace App.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EvenFunction_ReturnsTrueIfEven()
        {
            //Arrange
            int evenNumber = 2;

            //Act
            bool actualEven = Program.Even(evenNumber);

            //Assert

            Assert.True(actualEven);





        }
        [Fact]
        public void EvenFunction_ReturnsFalseIfUneven()
        {
            //Arrange
            int unevenNumber = 3;

            //Act
            bool actualUneven = Program.Even(unevenNumber);

            //Assert

            Assert.False(actualUneven);

        }
    }
}
