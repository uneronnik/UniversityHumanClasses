using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityHumanClasses.Classes;

namespace UniversityHumanClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();

            Human human = new Human(new DateTime(2005, 01, 02), "Nikita Fomenko");
            Applicant applicant = new Applicant(human, 5);
            Student student = new Student(human, 2, "П91", "Гриффиндор");
            Teacher teacher = new Teacher(human, "Преподаватель", "Факультет");

            writer.Write(human);
            Console.WriteLine();

            writer.Write(applicant);
            Console.WriteLine();

            writer.Write(student);
            Console.WriteLine();

            writer.Write(teacher);

            Console.ReadKey();
        }
    }
}
