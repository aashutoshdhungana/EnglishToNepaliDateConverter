using EnglishToNepaliDateConvertor.DateClasses;

namespace NepaliToEnglishDate
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Date englishDate = new(DateTime.Now.ToString("yyyy/MM/dd"));
                Console.WriteLine("Todays english date: " + englishDate.ToString());
                DateConvertor dateConvertor = new DateConvertor(englishDate);
                Console.WriteLine("Todays nepali date: " + dateConvertor.ConvertToNepali());
            }
            catch (Exception)
            {
                Console.WriteLine("Something horrible happened.");
            }
        }
    }
}