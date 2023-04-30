using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BProb
{
    public interface IAnimal
    {
        void MakeSound();
        string GetSpecies();
    }

    public class Dogs : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public string GetSpecies()
        {
            return "Canine";
        }
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public string GetSpecies()
        {
            return "Feline";
        }
    }
}
