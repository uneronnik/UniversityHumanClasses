using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityHumanClasses.Classes
{
    class Student : Human
    {
        int _course;
        string _group;
        string _faculty;

        public int Course { get => _course; }
        public string Group { get => _group; }
        public string Faculty { get => _faculty; }

        public Student(DateTime birthDay, string name, int course, string group, string faculty)
            : base(birthDay, name)
        {
            _course = course;
            _group = group;
            _faculty = faculty;
        }
        public Student(Human human, int course, string group, string faculty)
            : base(human.BirthDay, human.Name)
        {
            _course = course;
            _group = group;
            _faculty = faculty;
        }
    }
}
