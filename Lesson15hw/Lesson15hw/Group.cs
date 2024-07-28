using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15hw
{
    public class Group
    {
        private int limit;
        private string _gropno;
        public string GropNo
        {
            get
            {

                return _gropno;
            }
            set
            {
                if (CheckGroupNo(value) == true)
                {
                    _gropno = value;
                }
            }
        }
        public int StudentLimit
        {
            get
            {
                return limit;
            }
            set
            {
                if (value >= 5 && value <= 18)
                {
                    limit = value;
                }
            }
        }
        private Student[] students = Array.Empty<Student>();
        public Group(string groupNo, int sudentLimit)
        {
            GropNo = groupNo;
            StudentLimit = sudentLimit;

        }
        public bool? CheckGroupNo(string gropno)
        {
            if (gropno == null) return null;
            if (char.IsUpper(gropno[0]) && char.IsUpper(gropno[1]) && char.IsDigit(gropno[2]) && char.IsDigit(gropno[3]) && char.IsDigit(gropno[4])) return true;
            return false;
        }
        public void AddStudent(Student student)
        {
            if (students.Length < 18) Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public Student? GetStudent(int id)
        {
            Student? searched = null;
            foreach (var student in students)
            {
                if (student.Id == id) searched=student;
            
            }
            if (searched == null) throw new NullReferenceException("Student not found");

            return searched;
        }
        public Student[] GetAllStudent()
        {
            return students;
        }


    }
}

