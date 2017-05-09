using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace BL.Repositories
{
    public interface ISearch
    {
        IList<Student> StudentFiltered(Student filter, List<Student> studentList, string arrayGender);
    }
}
