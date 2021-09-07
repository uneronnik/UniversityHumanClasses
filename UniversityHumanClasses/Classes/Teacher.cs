using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityHumanClasses.Classes
{
    class Teacher : Human
    {
        string _post;
        string _department;

        public string Post { get => _post; }
        public string Department { get => _department; }

        public Teacher(DateTime birthDay, string name, string post, string department)
            : base(birthDay, name)
        {
            _post = post;
            _department = department;
        }
        public Teacher(Human human, string post, string department)
            : base(human.BirthDay, human.Name)
        {
            _post = post;
            _department = department;
        }
    }
}
