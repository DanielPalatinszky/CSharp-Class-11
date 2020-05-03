using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Class_11
{
    class Animalv1
    {
        public string name;
        public int age;
    }

    class Animalv2
    {
        private string name;
        private int age;
    }

    // Ügyeljünk arra, hogy ha lehet akkor az adattagok továbbra is maradjanak privátak
    // Csak a legszükségesebb esetben használjuk a protected-et
    class Animalv3
    {
        protected string name;
        protected int age;
    }

    class Animalv4
    {
        private string name;
        private int age;

        public void PrintAnimal()
        {
            Console.WriteLine("I am an animal!");
        }
    }

    class Animalv5
    {
        public string Name { get; set; }
    }

    class Animalv6
    {
        private string name;
        private int age;

        public Animalv6(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
