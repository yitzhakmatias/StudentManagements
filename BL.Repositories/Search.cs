using System;
using System.Collections.Generic;
using System.Linq;
using BL.Models;

namespace BL.Repositories
{
    public class Search : ISearch
    {
        public IList<Student> StudentFiltered(Student filter, List<Student> studentList, string arrayGender)
        {
            var result = studentList;

            if (filter.Name != "")
            {
                result = result.Where(i => i.Name == filter.Name).ToList();
            }
            if (filter.Type != "")
            {
                result = result.Where(i => i.Type == filter.Type).ToList();
            }
            if (filter.Gender != "")
            {
                if (arrayGender == "masculine")
                {
                    arrayGender = "m";

                }
                else if (arrayGender == "femenine")
                {
                    arrayGender = "f";

                }

                result = result.Where(i => i.Gender == arrayGender).ToList();
            }

            if (filter.TimeStamp != new DateTime())
            {
                result = result.Where(i => i.TimeStamp == filter.TimeStamp).ToList();
            }

            return result;
        }
    }
}