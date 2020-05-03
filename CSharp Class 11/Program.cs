using System;

namespace CSharp_Class_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Szeretnénk különféle állatok adatait és viselkedését reprezentálni
            // Készítsünk osztályokat nekik:
            var dog1 = new Dogv1();
            var cat1 = new Catv1();

            // Szeretnénk készíteni egy hörcsög osztályt is
            // Megint írjuk bele a nevet és a kort?
            // Minden egyes alkalommal amikor egy állatot létre akarok hozni, akkor a nevet és a kort be kell írnom?
            // Mi van akkor ha minden állatot bővíteni szertnék egy új adattal? Mindegyikbe bele kell írnom?
            // Nem! Használjunk öröklést!

            // Mi a közös kód szinten a kutyában és a macskában? A két adattag: név és kor!
            // Mi a közös a való világban a kutyában és a macskában? Mindketten állatok!

            // Hozzunk létre egy állat osztályt, ahol minden állatnak van neve és kora:
            var animal1 = new Animalv1();

            // Ettől még nem lettünk okosabbak. Valahogy meg kéne mondani, hogy a kutya és a macska egy állat!
            // Hát mondjuk meg:
            var dog2 = new Dogv2();
            var cat2 = new Catv2();

            // A gyerekek öröklik a szülők adattagjait (kicsit mint a biológiában vagy egy családfa esetén):
            dog2.age = 2;
            cat2.name = "A";

            // Innentől fogva pillanatok alatt tetszőleges állattal bővíthetjük az állatok "családfáját", azaz az osztályhierarchiát!
            // Sőt, saját adatokkal is bővíthetjük a leszármazottakat:
            var zebra1 = new Zebrav1();
            zebra1.name = "B";
            zebra1.numberOfStripes = 10;

            // Természetesen a leszármazottban elhelyezett új adattagok nem érhetőek el más leszármazottakban:
            var dog3 = new Dogv2();
            //dog3.numberOfStripes = 15; // Nem megy

            // Mi van akkor, ha az ősosztály adata privát? Akkor is örökli a leszármazott?
            // Igen is, meg nem is! Örökli, azaz a leszármazottnak lesz olyan adattagja, de nem fogja látni, hiszen privát az ősosztályban, azaz csak ott látszik:
            var dog4 = new Dogv3();
            //dog4.name = "A"; // Nem megy

            // Mi van akkor, ha szeretném, hogy látszódjon a leszármazottaiban az adattag, de kívülről továbbra sem szeretném elérhetővé tenni?
            // Használjuk a harmadik láthatóság módosítót a private és a public mellett, azaz a protectedet:
            var dog5 = new Dogv4();
            //dog5.name = "A"; // Kívülről nem látszik, de a leszármazottaiban igen

            // Hányszor örökölhetek? Mondhatom azt, hogy a Dog a GermanShepard őse?
            // Természetesen! Bárhány szintem lehet! A GermanShepard örökli az Animal és a Dog adattagjait is:
            var germanShepard1 = new GermanShepardv1();

            // Tetszőlegesen mélységben és szélességben örökölhetünk!

            // Egy osztály örökölhet több osztályból is?
            // C#-ban nem, de vannak nyelvek (pl. C++), ahol megengedett. Alapvetően azonban komplex problémákat vet fel (pl. diamond problem), illetve az esetek nagy többségében nincs is rá szükség! Ha igen, akkor valószínűleg valamit elrontottunk!

            // Beszéltünk a this kulcsszóról, ahol a this az aktuális példányra mutat.
            // Van egy másik hasonló kulcsszó is, a base:
            var dog6 = new Dogv5();

            //--------------------------------------------------

            // Azt már láttuk, hogy az adattagok öröklődnek. Így van ez a metódusokkal is?
            // Igen és a gyereken természetesen nyugodtan meghívhatjuk az ősosztály metódusát:
            var dog7 = new Dogv6();
            dog7.PrintAnimal();

            // A láthatóság is pont ugyanúgy működik, mint az adattagoknál!
            // Azaz, ha a metódus private, akkor csak az ősosztályban látható!
            // Ha public, akkor az ősosztályban, a leszármazottaiban és kívülről is!
            // Ha protected, akkor pedig csak az ősosztályban és a leszármazottaiban!

            // A gyereket nyugodtan bővíthetjük új metódusokkal is:
            var dog8 = new Dogv7();
            dog8.PrintDog();

            //--------------------------------------------------

            // Ha az adattagok és a metódusok öröklődnek, akkor felmerül a kérdés, hogy a tulajdonságok is?
            // Miből áll egy tulajdonság a háttérben? Metódusokból és adattagokból!
            // Tehát öröklődik:
            var dog9 = new Dogv8();
            dog9.Name = "A";

            // A láthatóságok továbbra is úgy működnek mint az adattagok vagy metódusok esetén, mind a teljes tulajdonságra, mind a getterre és setterre nézve!

            //--------------------------------------------------

            // Mi történik akkor, ha az ősosztály kap egy konstruktort?
            // Lásd: Dogv9

            // Nem fordul a kódunk, mert valami gond van a leszármazottakkal, de mi a gond?!
            // Eddig azért működött a kód, mert a háttérben a leszármazottak automatikusan meghívták az ős alapértelmezett konstruktorát!
            // Azonban azáltal, hogy az ősnek létrehoztunk egy konstruktort, az automatikus hívás már nem működik!

            // Mit tehetünk? Hát hozzunk létre a leszármazottban egy konstruktort, ami meghívja az ős konstruktorát!
            // Ehhez természetesen a gyerek konstruktorának át kell vennie azokat a paramétereket, amiket az ősnek kell odaadni (name és age)!
            // Azonban hogyan hívjuk meg az ős konstruktorát? Az alábbi nem megy:
            // Lásd: Dogv10

            // Használjuk a base kulcsszót:
            var dog10 = new Dogv11("A", 5);

            // Felmerülhet a kérdés, hogy milyen sorrendben hívódnak meg a konstruktorok? Előbb a gyerek, aztán az ős vagy előbb az ős, aztán a gyerek?
            // Gondoljuk végig! Ahhoz, hogy a gyerek dolgozhasson az ős adataival, előbb szükség van arra, hogy az ős létrejöjjön! Tehát, előbb az ős konstruktorának kell lefutnia, aztán jöhet csak a gyerek!
            // Mi van, akkor ha egy hosszabb osztályhierarchiánk van? Mondjuk A-ból leszármazik B, majd B-ből C.
            // Gondoljuk végig! C-hez kell B, B-hez viszont kell A! Tehát előbb A-nak kell létrejönnie, majd B-nek, végül C-nek!
            // Tehát előbb A konstruktora hívódik meg, majd B, majd C (lásd: Example.cs):
            var c = new C(1, 2, 3);

            //--------------------------------------------------

            // Valójában a konstruktorok egy osztályon belül is hívhatják egymást a this kulcsszó segítségével, hasonlóan ahogy a leszármazott hívja az ős konstruktorát (lásd: Example.cs):
            var test = new Test(1, 2, 3);

            // Ezzel elkerülhető a különböző konstruktorokban a kód duplikációja!
        }
    }
}
