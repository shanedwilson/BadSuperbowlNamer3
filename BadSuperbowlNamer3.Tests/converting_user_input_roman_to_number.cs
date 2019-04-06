using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BadSuperbowlNamer3.Tests
{
    public class converting_user_input_roman_to_number
    {
        [Theory]
        [InlineData ("I", 1)]
        [InlineData("IV", 4)]
        public void convert_Roman_to_int(string input, int expectedResult)
        {
            //Arrange
            var convertor = new RomanToNumberConvertor();

            //Act
            var actualResult = convertor.ToNumber(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
