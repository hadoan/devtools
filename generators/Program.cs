using System;
using DevTools.Services;
using Microsoft.Extensions.DependencyInjection;

namespace generators
{
    class Program
    {
        private static ServiceProvider serviceProvider;

        static void Main(string[] args)
        {
            Console.WriteLine("Dev-tool generator");
            //setup our DI
            SetupContainer();

            var file = args[0];
            var fileInputHandler = serviceProvider.GetService<IFileInputCommandHandlerService>();
            fileInputHandler.Handle(file);
        }

        private static void SetupContainer()
        {
            serviceProvider = new ServiceCollection()
            .AddSingleton<IFileInputCommandHandlerService, FileInputHandlerService>()
            .AddSingleton<IFileOutputService,FileOutputService>()
             .BuildServiceProvider();
        }
    }
}
