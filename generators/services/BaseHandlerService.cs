using System;

namespace DevTools.Services
{
    public abstract class BaseHandlerService
    {
        private readonly IFileOutputService fileOutputService;

        public BaseHandlerService(IFileOutputService fileOutputService)
        {
            this.fileOutputService = fileOutputService;
        }

        protected void Help()
        {

        }
        protected void ProcessCommand(Command command)
        {

            if (command.Type == CommandType.Generate)//generate
            {
                if(command.SubType == CommandSubType.GenerateProps)
                {
                    foreach (var item in command.data)
                    {
                        var line =$"public {item.type} {item.property} {{get;set;}}";
                        Console.WriteLine(line);
                        fileOutputService.AppendLine(line);
                    }
                    
                    fileOutputService.SaveToFile();
                
                    return;        
                }
            }
            
            Console.WriteLine("Invalid command, use --help to list all command.");   

        }
    }

}