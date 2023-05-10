using NepaliToEnglishDate;

namespace EnglishToNepaliDateConvertor.DateClasses
{
    public class DateConvertor
    {
        Date Date { get; set; }

        private readonly string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Static/NepaliMonths.json");
        public DateTime MinEnglishDate { get; } = new DateTime(1944, 01, 01);
        public Date MinNepaliDate { get; } = new Date("2000/09/17");
        public DateConvertor(Date date)
        {
            Date = date;
        }

        public int GetDayDifference()
        {
            var givenDate = new DateTime(Date.Year, Date.Month, Date.Day);
            var dateDiff = givenDate.Subtract(MinEnglishDate);
            return dateDiff.Days;
        }

        public string ConvertToNepali()
        {
            var monthData = Utilities.ReadJsonToDict(dirPath);
            var diff = GetDayDifference();
            while (diff > 0)
            {
                int daysInMonth = monthData[MinNepaliDate.Year.ToString()][MinNepaliDate.Month - 1];
                MinNepaliDate.Day += 1;
                if (MinNepaliDate.Day > daysInMonth)
                {
                    MinNepaliDate.Day = 1;
                    MinNepaliDate.Month++;
                }
                if (MinNepaliDate.Month > 12)
                {
                    MinNepaliDate.Month = 1;
                    MinNepaliDate.Year++;
                }
                diff -= 1;
            }
            return MinNepaliDate.ToString();
        }
    }
}
