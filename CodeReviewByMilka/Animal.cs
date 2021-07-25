using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReviewByMilka
{
    class Animal
    {
        public Animal()
            :this("no name", 0) { }

        public Animal(string name, int numberOfLegs)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
        }

        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }
}
