using System;
using System.Collections.Generic;
using System.IO;
using BL.Models;

namespace BL.Repositories
{
    public class ReadFile : IReadFile
    {
        public List<Student> ReadCsvFile(string path)
        {
            var studentList = new List<Student>();

            StreamReader sr = new StreamReader(path);
            string s;
            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();

                string[] str = s.Split(',');

                //because the first line is header

                var student = new Student();
                student.Type = str[0].ToLower().ToString();
                student.Name = str[1].ToLower().ToString();
                student.Gender = str[2].ToLower().ToString();
                student.TimeStamp = str[3] == null ? DateTime.ParseExact(str[3], "yyyyMMddHHmmss", null) : DateTime.Now;
                studentList.Add(student);
            }

            return studentList;
        }
    }
}