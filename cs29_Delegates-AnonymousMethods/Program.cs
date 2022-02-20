using cs29_Delegates_AnonymousMethods.Solutions;
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

        #region For anonymous method example
        public delegate int NumberChangerX(int n);
        public delegate void NumberChangerZ(int n);
        #endregion

        //public delegate string StringReturnDelegateAnonymous(string one, string two, string three);
        //public delegate int TwoNumbersDelegateAnonymous(int number1, int number2);

        static void Main(string[] args)
        {
            Console.WriteLine("cs29_PASKAITA_Delegates_AnonymousMethods!");

            #region TEORIJA - Delegates
            Console.WriteLine("TEORIJA");
            // KAs yra delegatai
            // Kas yra anonimin4s funkcijos

            // Delegatas tai kaip klasės objektas yra reference duomenys atmintyje

            var numberChanger = new NumberChanger(AddNumber);
            Console.WriteLine(numberChanger(5));

            var numberChanger2 = new NumberChanger(SubstractNumber);
            Console.WriteLine(numberChanger2(10));

            var printer = new PrinterDelegate(PrintText);
            printer("text");
            Console.WriteLine();
            #endregion

            #region Solution_01
            Solution_01.Solution_01_pt1();
            Solution_01.Solution_01_pt2();
            Solution_01.Solution_01_pt3();
            Solution_01.Solution_01_pt4();
            #endregion

            #region Solution_02
            Solution_02.Solution_02_pt1();
            Solution_02.Solution_02_pt2();
            Solution_02.Solution_02_pt3();
            Solution_02.Solution_02_pt4();
            #endregion

            #region Solution_03
            Solution_03.Solution_03_Full();
            #endregion

            #region TEORIJA II - Anonymous Delegates
            Console.WriteLine("TEORIJA II");
            // Anoniminiai metodai, tai metodai be pavadinimo
            // Sukuriame delegate reaktažodį, ir priskirti galima delagate tipo kintamiesiems
            // Pirma sukuriame delegatą
            NumberChangerX changerX = delegate (int number)
            {
                number++;
                return number;
            };

            // Anoniminiai metodai mato išorinio scope kintamuosius
            // Anoniminis metodas taip pat gali būti perduodamas kaip parametras
            int x = 5;
            ExecuteNumberChangerWithValue(x, delegate (int value)
            {
                Console.WriteLine(value);
            });
            Console.WriteLine();
            #endregion

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

        #region Examples II
        public static int ChangerX(int number)
        {
            number++;
            return number;
        }

        public static void ExecuteNumberChangerWithValue(int val, NumberChangerZ numberChangerZ)
        {
            val += 10;
            numberChangerZ(val);
        }
        #endregion




    }
}

