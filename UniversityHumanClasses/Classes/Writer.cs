using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityHumanClasses.Classes;

namespace UniversityHumanClasses.Classes
{
    class Writer
    {
        public void Write(Human human)
        {
            Console.WriteLine(human.Name);
            Console.WriteLine(human.BirthDay.ToShortDateString());
        }
        public void Write(Student student)
        {
            Write(new Human(student.BirthDay, student.Name));
            Console.WriteLine($"Факультет: {student.Faculty}");
            Console.WriteLine($"Курс: {student.Course}");
            Console.WriteLine($"Группа: {student.Group}");
        }
        public void Write(Applicant applicant)
        {
            Write(new Human(applicant.BirthDay, applicant.Name));
            Console.WriteLine($"Количество баллов: {applicant.MarkNumber}");
        }
        public void Write(Teacher teacher)
        {
            Write(new Human(teacher.BirthDay, teacher.Name));
            Console.WriteLine($"Должность: {teacher.Post}");
            Console.WriteLine($"Кафедра: {teacher.Department}");
        }
        

    }
}
