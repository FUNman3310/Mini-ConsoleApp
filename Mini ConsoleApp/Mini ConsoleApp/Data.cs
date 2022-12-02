using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ConsoleApp
{
    public class Data
    {
        public static Classroom[] classrooms = new Classroom[0];

        public static void Addclassrooms(Classroom classroom)
        {
            Array.Resize(ref classrooms, classrooms.Length + 1);
            classrooms[classrooms.Length - 1] = classroom;
        }


    }
}
