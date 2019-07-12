using System;

namespace DevTools.Services
{
    public abstract class BaseHandlerService
    {

        public BaseHandlerService()
        {

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
                        Console.WriteLine($"public {item.type} {item.property} {{get;set;}}");
                    }
                
                    return;        
                }
            }
            
            Console.WriteLine("Invalid command, use --help to list all command.");   

        }
    }

}