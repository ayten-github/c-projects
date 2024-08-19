using SchoolERP.Business.Exceptions;
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
    public class TecaherService : ITeacherService
    {
        public void Create(Teacher teacher)
        {
            SchoolDataBAse<Teacher>.model.Add(teacher);
        }

        public List<Teacher> GetAll()
        {
            return SchoolDataBAse<Teacher>.model;
        }

        public Teacher? GetTeacher(int Id)
        {
            Teacher? wanted=SchoolDataBAse<Teacher>.model.Find(x=>x.Id==Id);
            if (wanted != null) return wanted;
            throw new TeacherNotFound("Tecaher not found");
        
        }

        public void Remove(int Id)
        {
            Teacher? wanted = SchoolDataBAse<Teacher>.model.Find(x => x.Id == Id);
            if (wanted == null)
                throw new TeacherNotFound("Teacher not found");
            SchoolDataBAse<Teacher>.model.Remove(wanted);
            foreach (var item in SchoolDataBAse<Student>.model)
            {
                if (item.TeacherId == Id)
                {
                    item.teacher = null;
                }
            }





        }
    }
}
