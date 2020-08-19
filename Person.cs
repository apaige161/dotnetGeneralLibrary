using System;
using System.Collections.Generic;
using static System.ValueTuple;

namespace Packt.Shared
{
    public partial class Person : object
    {

        //fields
        public string name;
        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();

        //can never be reassigned
        public const string Species = "Homo Sapien";

        public readonly string HomePlanet = "Earth";

        public readonly DateTime Instantiated;

        //constructors
        public Person()
        {
            //set default values
            name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        //Methods
        public void WriteToConsole() //void method, does something
        {
            Console.WriteLine($"{name} was born on a {DateOfBirth:dddd}");
        }

        public string GetOrigin()  //specify return type and return something
        {
            return $"{name} was born on {HomePlanet}";
        }

        //tuples
        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }
        public (string Name, int Number) GetNamedFruit()
        {
            return(Name: "Pears", Number:4);
        }

        //static method to multiply
        public static Person Procreate(Person p1, Person p2)
        {
            //create new person
            var baby = new Person()
            {
                name = $"baby of {p1.name} and {p2.name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        //instance method to multiply
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
    }
}
