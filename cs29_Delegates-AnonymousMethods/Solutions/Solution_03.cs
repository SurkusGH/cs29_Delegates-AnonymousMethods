using System;
using System.Collections.Generic;

namespace cs29_Delegates_AnonymousMethods.Solutions
{
    // (3) Sukurkite delegatą filter, kuris grąžins bool, o per parametrą pasiims Person objektą.
    public delegate bool Filter (Person person);
    public class Solution_03
    {
        public static void Solution_03_Full()
        {
            Console.WriteLine("Solution_03_Full!");
            // (2) Main metode sukurkite sąrąšą žmonių skirtingais vardais ir amžiais
            var peopleList = new List<Person> { new Person(" Vytautas", 17), new Person("  Aurimas", 17), new Person("  Aivaras", 17),
                                                new Person("Mindaugas", 18), new Person("Gediminas", 18), new Person(" Algirdas", 64),
                                                new Person("    Rytis", 65), new Person("  Edvinas", 75), new Person(" Giedrius", 85) };

            // (?) Metodo kvietimas atrodys maždaug taip: "DisplayPeople("Children:", people, IsChild)".
            Console.WriteLine();
            Console.WriteLine("Metodas -> IsChild()");
            Person.DisplayPeople(peopleList, IsChild);
            Console.WriteLine();
            Console.WriteLine("Metodas -> IsAdult()");
            Person.DisplayPeople(peopleList, IsAdult);
            Console.WriteLine();
            Console.WriteLine("Metodas -> IsSenior()");
            Person.DisplayPeople(peopleList, IsSenior);
            Console.WriteLine();
        }
        // (1) Sukurkite klasę Person su string name ir int age
        // (2) Main metode sukurkite sąrąšą žmonių skirtingais vardais ir amžiais

        // (3) Sukurkite delegatą filter, kuris grąžins bool, o per parametrą pasiims Person objektą.

        // (4) Sukurkite tris metodus, kurie grąžins bool reikšmes ir priiminės Peson per parametrą,
        // (4.1) vienas metodas tikrins ar žmogus yra vaikas < 18 metų;
        // (4.2) kitas tikrins ar suaguęs >=18;
        // (4.3) ir trečias tikrins ar senjoras >= 65 metai.
        public static bool IsChild(Person person)
        {
            if (person.Age < 18)
            {
                return true;
            }
            return false;
        }
        public static bool IsAdult(Person person)
        {
            if (person.Age >= 18 && person.Age < 65)
            {
                return true;
            }
            return false;
        }
        public static bool IsSenior(Person person)
        {
            if (person.Age >= 65)
            {
                return true;
            }
            return false;
        }

        // (5) Sukurkite metodą DisplayPeople, su parametrais title, List<Person> ir delegate Filter.
        //     Metodo esmė bus eiti ciklu per asmenys ir paleisdinėti perduotą per parametrus filtrą patikrinti ar žmogus pvz. yra vaikas.

        // (?) Metodo kvietimas atrodys maždaug taip: "DisplayPeople("Children:", people, IsChild)".
    }

    public class Person
    {
        // (1) Sukurkite klasę Person su string name ir int age
        // (2) Main metode sukurkite sąrąšą žmonių skirtingais vardais ir amžiais
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // (4) Sukurkite tris metodus, kurie grąžins bool reikšmes ir priiminės Person per parametrą,
        // (4.1) vienas metodas tikrins ar žmogus yra vaikas < 18 metų;
        // (4.2) kitas tikrins ar suaguęs >=18;
        // (4.3) ir trečias tikrins ar senjoras >= 65 metai.
        public static void DisplayPeople(List<Person> people, Filter filter)
        {
            foreach (var item in people)
            {
                Console.WriteLine($"Asmuo: {item.Name}, kurio amžius yra: {item.Age} (pagal metodą) -> bool(?) {filter(item)}");
            }
        }
    }





}
