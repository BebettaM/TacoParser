using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.22997, -86.805275, Taco Bell Alabaste...", -86.805275)]
        [InlineData("33.635282,-86.684056,Taco Bell Birmingham...", -86.684056)]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...",-85.499655)]

        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var parser = new TacoParser();
            //Act
            var actual = parser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.587217,-85.057114,Taco Bell Carrollto...", -85.057114)]
        [InlineData("34.196869,-84.135598,Taco Bell Cumming...", -84.135598)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var parser = new TacoParser();

            //Act
            var actual = parser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }





    }
}
