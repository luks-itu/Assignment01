using System;
using Xunit;
using System.Collections.Generic;

namespace App.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Flatten_given_1_2_5_and_8_9_returns_1_2_5_8_9()
        {
            //Arrange
            var stream1 = new List<int>(){1,2,5};
            var stream2 = new List<int>(){8,9};
            var input = new List<List<int>>(){stream1, stream2};


            //Act
            var output = Program.Flatten(input);
            
            //Assert
            Assert.Equal(new List<int>(){1,2,5,8,9},output);
    
        }

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

        [Fact]
        public void FilterFunction_ReturnsOnly_2_4_6()
        {
            var expected = new List<int> {2,4,6};
            Predicate<int> even = Program.Even;
            var input = new List<int> {1,2,3,4,5,6};
            var actual = Program.Filter(input, even);

            Assert.Equal(expected,actual);
        }

        
    }
}
