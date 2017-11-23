using System;
using System.Collections.Generic;

namespace WebApp.DAL
{
    using WebApp.DAL.Interface.Student;
    using WebApp.DTO;

    public class StudentDAL : IStudent
    {
        public bool Add(Student obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> Search(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}