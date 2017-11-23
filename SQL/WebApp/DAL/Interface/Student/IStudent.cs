using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DAL.Interface.Student
{
    using WebApp.DTO;
    public interface IStudent : IAction<Student, int>
    {
        // wirte code orther student
        IEnumerable<Student> Search(string name);
    }
}
