using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeReviewByMilka
{

    class TestClass
    {
        [Test]
        public void SortAnimals()
        {
            var animals = new List<Animal>
        {
        new Animal {Name = "Cat", NumberOfLegs = 4},
        new Animal {Name = "Snake", NumberOfLegs = 0},
        new Animal {Name = "Dog", NumberOfLegs = 4},
        new Animal {Name = "Pig", NumberOfLegs = 4},
        new Animal {Name = "Human", NumberOfLegs = 2},
        new Animal {Name = "Bird", NumberOfLegs = 2}
        };
            var output = new SortAnimals().AnimalsSort(animals);
            Assert.AreEqual(output[0].Name, "Snake");
            Assert.AreEqual(output[3].Name, "Cat");
        }
    }
}
