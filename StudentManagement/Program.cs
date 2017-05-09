using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Repositories;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            IReadFile readFile = new ReadFile();

            var studentList =readFile.ReadCsvFile(args[0]);

            IReadArguments readArguments = new ReadArguments();

            var filter = readArguments.SearchArguments(args);

            ISearch search = new Search();

            var result = search.StudentFiltered(filter, studentList, filter.Gender);


            foreach (var res in result)
            {
                Console.WriteLine(res.Name + ", " + res.Type + ", " + res.Gender + " ," + res.TimeStamp + "\n");
            }

            Console.ReadLine();
        }
    }
}
