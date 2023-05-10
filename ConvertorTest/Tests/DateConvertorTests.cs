using EnglishToNepaliDateConvertor.DateClasses;

namespace ConvertorTest.Tests
{
    public class DateConvertorTests
    {
        [Fact]
        public void GetDifference_WorksForLeapYear()
        {
            // Arrange
            Date nextYear = new Date("1945/01/01");
            DateConvertor dateConvertor = new(nextYear);
            // Act
            int days = dateConvertor.GetDayDifference();

            // Assert
            // Minimum supported date is 1944/01/01
            // As 1944 is a leap year should return 366
            Assert.Equal(366, days);
        }

        [Fact]
        public void GetDifference_ReturnsCorrect()
        {
            Date nextDay = new Date("1944/01/02");
            DateConvertor dateConvertor = new(nextDay);
            // Act
            int days = dateConvertor.GetDayDifference();

            // Assert 
            Assert.Equal(1, days);
        }

        [Fact]
        public void ConvertTo_NepaliWorksForTheMinimumDate()
        {
            Date minDate = new Date("1944/01/01");
            DateConvertor dateConvertor = new(minDate);

            string expected = dateConvertor.MinNepaliDate.ToString();
            string actual = dateConvertor.ConvertToNepali();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2023/05/10", "2080/01/27")]
        [InlineData("2000/11/19", "2057/08/04")]
        public void ConvertTo_NepaliWorksForOtherDates(string input, string expected)
        {
            DateConvertor dateConvertor = new(new Date(input));

            string nepaliDate = dateConvertor.ConvertToNepali();

            Assert.Equal(expected, nepaliDate);
        }
    }
}
