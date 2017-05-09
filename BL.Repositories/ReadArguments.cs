using System;
using System.Linq;
using BL.Models;

namespace BL.Repositories
{
    public class ReadArguments : IReadArguments
    {
        public Student SearchArguments(string[] arguments)
        {
            var arrayName = Array.Find(arguments, n => n.Contains("name")); ;
            var arrayType = Array.Find(arguments, n => n.Contains("type")); ;
            var arrayGender = Array.Find(arguments, n => n.Contains("gender"));


            var arrayTimeStamp = Array.Find(arguments, n => n.Contains("timeStamp")); ;


            CommandLineArgs.I.parseArgs(arguments.Skip(1).ToArray(), arrayName + " " + arrayType + " " + arrayGender + " " + arrayTimeStamp);
            

            var studentSearch = new Student();
            studentSearch.Name = CommandLineArgs.I.argAsString("name");
            studentSearch.Type = CommandLineArgs.I.argAsString("type");
            studentSearch.Gender = CommandLineArgs.I.argAsString("gender");
            studentSearch.TimeStamp = CommandLineArgs.I.argAsString("timeStamp") != "" ? DateTime.ParseExact(CommandLineArgs.I.argAsString("timeStamp"), "yyyyMMddHHmmss", null) : new DateTime();


            return studentSearch;
        }
    }
}