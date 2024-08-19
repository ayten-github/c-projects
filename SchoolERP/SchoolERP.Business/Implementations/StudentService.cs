using SchoolERP.Business.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Implementations
{
    public class StudentService : IStudentService
    {
        public void Create(Student student)
        {
        SchoolDataBAse<Student>.model.Add(student);
        }

        public List<Student> GetAll()
        {
            return SchoolDataBAse<Student>.model;

        }

        public Student GetStudent(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
