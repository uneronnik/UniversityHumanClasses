using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityHumanClasses.Classes
{
    class Human
    {
        private DateTime _birthDay;
        private string _name;

        public DateTime BirthDay { get => _birthDay; }
        public string Name { get => _name; }

        public Human(DateTime birthDay, string name)
        {
            _birthDay = birthDay;
            _name = name;
        }
    }
}
