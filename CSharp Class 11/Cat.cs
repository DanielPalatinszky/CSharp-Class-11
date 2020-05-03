using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Class_11
{
    class Catv1
    {
        public string name;
        public int age;

        public int numberOfLives = 9;
    }

    // A macska egy állat, azaz a Catv2 az Animalv1 egy gyereke vagy leszármazottja. Másképpen a Catv2-nek az Animalv1 a szülője vagy ősosztálya
    class Catv2 : Animalv1
    {

    }
}
