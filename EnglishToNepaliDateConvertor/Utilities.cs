using System.Text;
using System.Text.Json;

namespace NepaliToEnglishDate
{
    public static class Utilities
    {
        public static Dictionary<string, List<int>> ReadJsonToDict(string filePath)
        {
            Dictionary<string, List<int>> data;
            try
            {
                string jsonStr = File.ReadAllText(filePath, Encoding.UTF8) ?? string.Empty;
                data = JsonSerializer.Deserialize<Dictionary<string, List<int>>>(jsonStr) ?? new();
                return data;
            } 
            catch 
            {
                data = new();
                return data;
            }

        }
    }
}
