using System.Runtime.Serialization;

namespace NepaliToEnglishDate.Exceptions
{
    [Serializable]
    public class InvalidFormatException : Exception
    {
        public InvalidFormatException(string message) : base(message) { }

        protected InvalidFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
