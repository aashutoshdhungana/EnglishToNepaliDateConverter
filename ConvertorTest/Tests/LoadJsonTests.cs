using NepaliToEnglishDate;

namespace ConvertorTest.Tests
{
    public class LoadJsonTests
    {
        [Fact]
        public void HandlesFileNotFound()
        {
            string fileName = "hello.json";
            Assert.NotNull(Utilities.ReadJsonToDict(fileName));
        }

        [Fact]
        public void OpensExistingFile()
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Static/NepaliMonths.json");
            Assert.NotNull(Utilities.ReadJsonToDict(fileName));
        }

        [Fact]
        public void LoadsDictionaryProperly()
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Static/NepaliMonths.json");
            var dict = Utilities.ReadJsonToDict(fileName);
            var list = dict["2000"];
            Assert.Collection(list,
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32),
                x => Assert.True(x <= 32));
        }
    }
}
