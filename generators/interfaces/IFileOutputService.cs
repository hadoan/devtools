namespace DevTools.Services
{
    public interface IFileOutputService
    {
        void AppendLine(string line);
        void SaveToFile();
    }
}