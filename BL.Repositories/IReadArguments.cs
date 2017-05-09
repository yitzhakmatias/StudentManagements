using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace BL.Repositories
{
    public interface IReadArguments
    {
        Student SearchArguments(string[] arguments);
    }
}
