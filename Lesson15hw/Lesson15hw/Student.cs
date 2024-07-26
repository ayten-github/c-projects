using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15hw
{
    public class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Point { get; set; }
        public Student(string fullname, int point) 
        {
            Fullname=fullname;
            Point=point;
            _id++;
            Id = _id;
        }
        public string StudentInfo() {
            return $"id:{Id} fullname{Fullname} point {Point}";
        }

    }
}
