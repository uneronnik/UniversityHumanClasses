using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityHumanClasses.Classes
{
    class Applicant : Human
    {
        private int _markNumber;

        public int MarkNumber { get => _markNumber; }

        public Applicant(DateTime birthDay, string name, int markNumber)
            : base(birthDay, name)
        {
            _markNumber = markNumber;
        }
        public Applicant(Human human, int markNumber)
            : base(human.BirthDay, human.Name)
        {
            _markNumber = markNumber;
        }
    }
}
