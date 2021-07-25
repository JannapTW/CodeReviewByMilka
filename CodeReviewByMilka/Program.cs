using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReviewByMilka
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>
            {
                new Animal("Kicia", 4),
                new Animal("Kangur", 2),
                new Animal("zolw", 4),
                new Animal("Slimak", 1),
                new Animal("kos", 2)
            };
            var output = new SortAnimals().AnimalsSort(animalList);
            

            Console.ReadLine();
        }
    }
}
