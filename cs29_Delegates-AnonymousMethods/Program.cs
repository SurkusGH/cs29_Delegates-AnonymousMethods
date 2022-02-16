using System;
using System.Collections.Generic;

namespace cs29_Delegates_AnonymousMethods
{
    internal class Program
    {
        #region Delegate example
        public delegate int NumberChanger(int number);
        public delegate void PrinterDelegate(string text);
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("cs29_PASKAITA_DelegataiAnoniminiaiMetodai!");

            #region TEORIJA

            // KAs yra delegatai
            // Kas yra anonimin4s funkcijos

            // Delegatas tai kaip klasės objektas yra reference duomenys atmintyje

            var numberChanger = new NumberChanger(AddNumber);
            Console.WriteLine(numberChanger(5));

            var numberChanger2 = new NumberChanger(SubstractNumber);
            Console.WriteLine(numberChanger2(10));

            var printer = new PrinterDelegate(PrintText);
            printer("text");
            #endregion

            Solution_01_pt1();
            Solution_01_pt2();
            Solution_01_pt3();
            Solution_01_pt4();
        }

        public static void Solution_01_pt1()
        {
            Console.WriteLine("Solution_01_pt1!");
            // Sukurkite delegatą, kuris rodys į metodą su string grąžinamuoju tipu ir trimis parametrais:
            // First name, lastName ir age. Iškvieskite delegato metodą
            var stringReturnDelegate = new StringReturnDelegate(Solution_01.ThreeStringMethod);
            Console.WriteLine(stringReturnDelegate("Rytas", "Diena", "Naktis"));
            Console.WriteLine();
        }

        public static void Solution_01_pt2()
        {
            Console.WriteLine("Solution_01_pt2!");
            // Sukurkite delegatą, kuris rodys į metodą su int grąžinamuoju tipu ir dviem parametrais
            // number1 ir number2. Iškvieskite delegato metodą
            var twoNumbersDelegate = new TwoNumbersDelegate(Solution_01.TwoNumbersMethod);
            Console.WriteLine($"Grąžina sudėtus skaičius 1 ir 2: {twoNumbersDelegate(1, 2)}");
            Console.WriteLine();
        }

        public static void Solution_01_pt3()
        {
            Console.WriteLine("Solution_01_pt3!");
            // Sukurkite delegatą, kuris rodys į metodą su List<int> grąžinamuoju tipu ir dviem parametrais
            // List<int> ir ints step, metodo esmė bus gr1=inti kas kažkelintą elementą (kas kažkelintą nurodo parametras "step")
            // Iškvieskite delegato metodą
            var listDelegate = new ListDelegate(Solution_01.ListMethod);
            var list = new List<int>();
            list.Add(1); list.Add(2); list.Add(3); list.Add(4); list.Add(5);
            list.Add(6); list.Add(7); list.Add(8); list.Add(9); list.Add(10);
            foreach (var item in listDelegate(list, 3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void Solution_01_pt4()
        {
            Console.WriteLine("Solution_01_pt4!");
            // Sukurkite delegatą, kuris rodys į GetType<T> metodą su grąžinamuoju tipu string ir parametru T element;
            // Metodas spausdins element kintamojo duomenų tipą. Iškvieskite delegato metodą.
            var GenericTypeDelegate = new GenericTypeDelegate<decimal>(Solution_01.GenericTypeMethod);
            Console.WriteLine(GenericTypeDelegate(10));
            Console.WriteLine();
        }

        #region Examples
        public static int AddNumber(int number)
        {
            return number + 5;
        }

        public static int SubstractNumber(int number)
        {
            return number - 5;
        }

        public static void PrintText(string text)
        {
            Console.WriteLine(text);
        }

        #endregion



    }
}

