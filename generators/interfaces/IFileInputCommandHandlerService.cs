namespace DevTools.Services
{

    public interface IFileInputCommandHandlerService
    {
        void SetFileName(string fileName);
        void Handle(string fileName);
    }
}