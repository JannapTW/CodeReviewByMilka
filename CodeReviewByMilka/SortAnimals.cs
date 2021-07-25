using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReviewByMilka
{
    class SortAnimals
    {
        public static List<Animal> AnimalsSort(List<Animal> animals)
        {
            if(animals == null)
            {
                return null;
            }
            if(!animals.Any())
            {
                return animals;
            }

            var temp = new List<Animal>(animals);

            temp = temp
                .OrderBy(x => x.NumberOfLegs)
                .ThenBy(x => x.Name)
                .ToList();



            //Console.Write("Przed sortowaiem:");
            //Console.WriteLine(string.Join(", ", animals.Select(x => x.Name)));

            return temp;
        }
    }
}
