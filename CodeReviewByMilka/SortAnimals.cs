using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeReviewByMilka
{    
    class SortAnimals
    {        
        public List<Animal> AnimalsSort(List<Animal> animals)
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

            Console.WriteLine("Przed sortowaiem:");
            Console.Write("Imie: ");
            Console.WriteLine(string.Join(", ", temp.Select(x => x.Name)));
            Console.Write("Ilosc nog: ");
            Console.WriteLine(string.Join(", ", temp.Select(x => x.NumberOfLegs)));

            temp = temp
                .OrderBy(x => x.NumberOfLegs)
                .ThenBy(x => x.Name)
                .ToList();

            Console.WriteLine("Po sortowaniu:");
            Console.Write("Imie: ");
            Console.WriteLine(string.Join(", ", temp.Select(x => x.Name)));
            Console.Write("Ilosc nog: ");
            Console.WriteLine(string.Join(", ", temp.Select(x => x.NumberOfLegs)));



            return temp;
        }
    }
}
