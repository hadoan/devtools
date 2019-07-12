using System;

namespace DevTools.Services
{
    public class Command
    {
        public CommandType Type{get;set;}
        public CommandSubType SubType{get;set;}

        public dynamic CommandParams{get;set;}

    }

}