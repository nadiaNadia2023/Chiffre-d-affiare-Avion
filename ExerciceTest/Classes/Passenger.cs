using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project.Classes
{
    public class Passenger
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool RequiresExtraSeat { get; set; }
        public bool IsChild { get; set; }
        public bool IsAdult { get; set; }
        public int FamilyNumber { get; set; }
       

        public Passenger(string name, int age, bool requiresExtraSeat = false, bool isChild = false)
        {
            Name = name;
            Age = age;
            RequiresExtraSeat = requiresExtraSeat;
            IsChild = isChild;
            IsAdult = !isChild;
         
        }

    }
}