using SchoolERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Interfaces
{
    internal interface IStudentService
    {
       public void Create(Student student);
       public List<Student> GetAll();
        public Student GetStudent(int Id);
        void Remove(int  Id);

    }
}
