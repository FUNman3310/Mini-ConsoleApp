using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ConsoleApp
{
    public class Student
    {
        private static int _counter;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        static Student()
        {
            _counter = 0;
        }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            _counter++;
            Id = _counter;
        }

        public override string ToString()
        {
            return $"Name {Name} Surname {Surname} Id {Id}";
        }
    }
}
