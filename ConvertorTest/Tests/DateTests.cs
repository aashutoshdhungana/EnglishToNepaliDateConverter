using EnglishToNepaliDateConvertor.DateClasses;
using NepaliToEnglishDate.Exceptions;

namespace ConvertorTest.Tests
{
    public class DateTests
    {
        [Theory]
        [InlineData("0000/00/00")]
        [InlineData("2000/01/01")]
        [InlineData("2014/22/33")]
        public void ToString_ReturnValidFormat(string input)
        {
            // Arrange
            var date = new Date(input);
            // Act
            string dateStr = date.ToString();
            // Assert
            Assert.Matches(@"^\d{4}\/\d{2}\/\d{2}$", dateStr);
        }

        [Fact]
        public void Date_Constructor_Assigns_Year()
        {
            // Arrange
            var date = new Date("2000/10/01");

            // Act
            var year = date.Year;

            // Asert
            Assert.Equal(2000, year);
        }

        [Fact]
        public void Date_Constructor_Assigns_Month()
        {
            // Arrange
            var date = new Date("2000/10/01");

            // Act
            var month = date.Month;

            // Asert
            Assert.Equal(10, month);
        }

        [Fact]
        public void Date_Constructor_Assigns_Day()
        {
            // Arrange
            var date = new Date("2000/10/01");

            // Act
            var day = date.Day;

            // Asert
            Assert.Equal(01, day);
        }

        [Theory]
        [InlineData("")]
        [InlineData("00/00/14")]
        [InlineData("2000-10-12")]
        public void Date_Constructor_ThrowsInvalidFormatException_ForInvalidFormat(string date)
        {
            Assert.Throws<InvalidFormatException>(() => new Date(date));
        }
    }
}
