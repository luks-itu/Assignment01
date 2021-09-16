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

        [Fact]

        public void InnertextFunction_Returns_Expected_Sample_output_with_tag_a()
        {
            string input = "<div>  <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=/wiki/Theoretical_computer_science title=Theoretical computer science>theoretical computer science</a> and <a href=/wiki/Formal_language title=Formal language>formal language</a> theory, a sequence of <a href=/wiki/Character_(computing) title=Character (computing)>characters</a> that define a <i>search <a href=/wiki/Pattern_matching title=Pattern matching>pattern</a></i>. Usually this pattern is then used by <a href=/wiki/String_searching_algorithm title=String searching algorithm>string searching algorithms</a> for find or find and replace operations on <a href=/wiki/String_(computer_science) title=String (computer science)>strings</a>.</p></div> <p>hejsa</p>";
            var expected = new List<string> {"theoretical computer science","formal language","characters", "pattern", "string searching algorithms", "strings"} ;
            var actual = Program.InnerText(input, "a");

            Assert.Equal(expected,actual);
        }


        [Fact]
        public void InnertextFunction_Returns_Expected_Sample_output_with_tag_p()
        {
            string input = "<div>  <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=/wiki/Theoretical_computer_science title=Theoretical computer science>theoretical computer science</a> and <a href=/wiki/Formal_language title=Formal language>formal language</a> theory, a sequence of <a href=/wiki/Character_(computing) title=Character (computing)>characters</a> that define a <i>search <a href=/wiki/Pattern_matching title=Pattern matching>pattern</a></i>. Usually this pattern is then used by <a href=/wiki/String_searching_algorithm title=String searching algorithm>string searching algorithms</a> for find or find and replace operations on <a href=/wiki/String_(computer_science) title=String (computer science)>strings</a>.</p></div> <p>hejsa</p>";
            var expected = new List<string> {"A regular expression, regex or regexp (sometimes called a rational expression) is, in theoretical computer science and formal language theory, a sequence of characters that define a search pattern. Usually this pattern is then used by string searching algorithms for find or find and replace operations on strings.","hejsa"};
            var actual = Program.InnerText(input, "p");

            Assert.Equal(expected,actual);
        }



        
    }
}
