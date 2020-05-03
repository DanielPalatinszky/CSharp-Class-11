using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Class_11
{
    class Dogv1
    {
        public string name;
        public int age;

        public int numberOfToys;
    }

    // A kutya egy állat, azaz a Dogv2 az Animalv1 egy gyereke vagy leszármazottja. Másképpen a Dogv2-nek az Animalv1 a szülője vagy ősosztálya
    class Dogv2 : Animalv1
    {

    }

    class Dogv3 : Animalv2
    {

    }

    // A protected adattag továbbra is látható a leszármazottban
    class Dogv4 : Animalv3
    {
        private void Method()
        {
            name = "A";
        }
    }

    class Dogv5 : Animalv3
    {
        // A base lényegében ugyanaz mint a this, csak ahelyett hogy az aktuális példányra mutatna, az aktuális példány ősosztályára (ősosztály részére) mutat:
        private void Method()
        {
            Console.WriteLine(base.name);
        }
    }

    class Dogv6 : Animalv4
    {

    }

    class Dogv7 : Animalv4
    {
        public void PrintDog()
        {
            Console.WriteLine("I am a dog!");
        }
    }

    class Dogv8 : Animalv5
    {

    }

    // Nem fordul
    /*class Dogv9 : Animalv6
    {

    }*/

    // Így nem lehet meghívni az ős konstruktorát
    /*class Dogv10 : Animalv6
    {
        public Dogv10(string name, int age)
        {
            Animalv6(name, age);
        }
    }*/

    // A : után a base kulcsszóval és a paraméterek átadásával meghívhatjuk az ős megfelelő konstruktorát
    // Vegyük észre, hogy a leszármazottban levő name és age, ugyanaz mint amit a base-nek adunk át!
    // Vegyük észre azt is, hogy az ősnek azon konstruktora fog meghívódni, aminek az első paramétere egy string (name), a második egy int (age)!
    // Ha fordítva szeretnénk odaadni a paramétereket, azaz előbb a kort, aztán a nevet, akkor az ősnek kéne egy olyan konstruktor, ami előbb egy int-et, aztán egy string-et vesz át!
    class Dogv11 : Animalv6
    {
        public Dogv11(string name, int age) : base(name, age) //base("A", 5) // Ez is működne és akkor minden kutya úgy jönne létre, hogy "A" a neve és 5 a kora, a name és age paramétereket pedig egyszerűen eldobnánk
        {
            //Console.WriteLine(name); // Természetesen a megkapott paramétereket itt is elérjük
        }
    }
}
