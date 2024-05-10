using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_07
{
abstract class Animal
        {
            public abstract void MakeSound();
        }
        class Lion : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("The lion roars.");
            }
        }
        class Tiger : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("The tiger growls.");
            }
        }
        class Elephant : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("The elephant trumpets.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Animal> animals = new List<Animal>();
                animals.Add(new Lion());
                animals.Add(new Tiger());
                animals.Add(new Elephant());
                Console.Write("Enter the type of animal to add (Lion/Tiger/Elephant): ");
                string animalType = Console.ReadLine();

                Animal newAnimal = null;
                switch (animalType.ToLower())
                {
                    case "lion":
                        newAnimal = new Lion();
                        break;
                    case "tiger":
                        newAnimal = new Tiger();
                        break;
                    case "elephant":
                        newAnimal = new Elephant();
                        break;
                    default:
                        Console.WriteLine("Invalid animal type.");
                        break;
                }

                if (newAnimal != null)
                {
                    animals.Add(newAnimal);
                    Console.WriteLine("New animal added to the zoo.");
                }
                Console.WriteLine("\nAnimals in the zoo:");
                foreach (Animal animal in animals)
                {
                    animal.MakeSound();
                }

                Console.ReadLine();
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
    }
    

  
        

