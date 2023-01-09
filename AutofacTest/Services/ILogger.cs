namespace AutofacTest.Services
{
    public interface ILogger
    {
        string Error(string message);
        string Warning(string message);
    }
}