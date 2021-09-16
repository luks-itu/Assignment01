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

        [Fact]

        public void SplitLineFunction_Returns_Hi_42_23Me_hello()
        {
            var lines = new List<string> {"Hi    88$","A@1","42 23Me","hello" };
            var expected = new List<string>{"Hi","42","23Me","hello"};
            var actual = Program.SplitLine(lines);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ResolutionsFunction_ReturnsOnly_FHD_720p()
        {
            var lines = new List<string> {"1920x1080","1024x768","138x21 213x213", " 23x23","4 5 3x2", "ax300","1ax2b","@10x23"};
            var expected = new List<(int, int)> {(1920, 1080), (1024, 768), (138, 21), (213, 213), (23, 23), (3, 2)};

            var actual = Program.Resolutions(lines);
            
            Assert.Equal(expected,actual);
    
            

        }

        
    }
}
