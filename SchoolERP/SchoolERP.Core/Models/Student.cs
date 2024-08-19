using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Core.Models
{
    public class Student:BaseModel
    {
        private static int _id = 0;
        public Student() {
            ++_id;
            Id= _id;
        }
        public int Id { get; set; }
        public double Grade { get; set; }
        public Teacher teacher { get;set; }
        public int TeacherId
        {
            get
            {
                return teacher.Id;
            }
            private set { }
        }
        public override string ToString()
        {
            if(teacher is not null)
                return $"{Name}---{Grade}---{teacher.Name}";
            return $"{Name}---{Grade}--teacher hasn't been assigned";
        }


    }
    }
