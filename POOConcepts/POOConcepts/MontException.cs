
namespace POOConcepts
{
    [Serializable]
    internal class MontException : Exception
    {
        public MontException()
        {
        }

        public MontException(string? message) : base(message)
        {
        }

        public MontException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}