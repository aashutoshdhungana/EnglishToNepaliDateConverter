using NepaliToEnglishDate.Exceptions;
using System.Text.RegularExpressions;

namespace EnglishToNepaliDateConvertor.DateClasses
{
    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Date(string date)
        {
            SplitDate(date);
        }

        private void SplitDate(string date)
        {
            if (!ValidateDate(date))
            {
                throw new InvalidFormatException("Invalid Format");
            }
            var splitDate = date.Split('/');
            Year = Convert.ToInt32(splitDate[0]);
            Month = Convert.ToInt32(splitDate[1]);
            Day = Convert.ToInt32(splitDate[2]);
        }

        private bool ValidateDate(string date)
        {
            return Regex.IsMatch(date, @"^\d{4}\/\d{2}\/\d{2}$");
        }
        public override string ToString()
        {
            string year = Year.ToString("0000");
            string month = Month.ToString("00");
            string day = Day.ToString("00");
            return year + "/" + month + "/" + day;
        }
    }
}
