using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ConsoleApp
{
    public class Classroom
    {
        private static int _counter;
        public int Id { get; set; }
        public  string Name { get; set; }
        public Enums Type { get; set; }
        static int StudentLimit { get; set; }

        public static Student[] students = new Student[0];

        static Classroom()
        {
                _counter=0;
        }

        public Classroom(string name, Enums type)
        {
            this.Name = name;
            this.Type = type;

            if (type == Enums.BackEnd)
            {

                StudentLimit = 20;
            }
            else
            {
                StudentLimit = 15;
            }

            _counter++;
            this.Id = _counter; 

        }
        public static void StudentAdd(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
        }
    }
}
