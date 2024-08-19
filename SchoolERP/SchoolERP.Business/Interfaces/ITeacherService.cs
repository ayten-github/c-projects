using SchoolERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Interfaces
{
    internal interface ITeacherService
    {
        void Create(Teacher teacher);
        List<Teacher> GetAll();
        Teacher?GetTeacher(int Id);
        void Remove(int Id);
    }
}
