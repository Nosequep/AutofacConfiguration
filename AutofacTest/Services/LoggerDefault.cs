namespace AutofacTest.Services
{
    public class LoggerDefault : ILogger
    {
        private string ERROR = "Error";
        private string WARNING = "Warning";

        public string Error(string message)
        {
            return $"{ERROR}, {message}";
        }

        public string Warning(string message)
        {
            return $"{ERROR}, {message}";
        }
    }
}
