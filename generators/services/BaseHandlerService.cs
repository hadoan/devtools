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
                    var obj = command.CommandParams;
                        
                    return;        
                }
            }
            
            Console.WriteLine("Invalid command, use --help to list all command.");   

        }
    }

}