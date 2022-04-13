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
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", -84.913185)]
        [InlineData("33.587217,-85.057114,Taco Bell Carrollto...", -85.057114)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", -86.97191)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location
            var tacoParser = new TacoParser();
            //Arrange
            double result = tacoParser.ShouldParseLongitude(line);
            //var actual = tester.Parse(line).Location.Logitude
            //Act
            Assert.Equal(result, expected);
            //Assert
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", 34.376395)]
        [InlineData("33.587217,-85.057114,Taco Bell Carrollto...", 33.587217)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", 34.795116)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            double result = tacoParser.ShouldParseLatitude(line);

            //Assert
            Assert.Equal(result, expected);
        }



        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...",   " Taco Bell Acwort...")]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", "Taco Bell Adairsvill...")]
        [InlineData("33.587217,-85.057114,Taco Bell Carrollto...",  "Taco Bell Carrollto...")]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", "Taco Bell Athens...")]
        public void ShouldParseName(string line, string expected)
        {
            var tacoParser = new TacoParser();

            var result = tacoParser.ShouldParseName(line);

            Assert.Equal(result, expected);
        }



    }
}
