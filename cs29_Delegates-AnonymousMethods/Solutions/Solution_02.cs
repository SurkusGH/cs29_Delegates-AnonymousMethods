using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_Delegates_AnonymousMethods.Solutions
{
    public delegate string StringReturnDelegate_Sol2(string one, string two, string three);
    public delegate int TwoNumbersDelegate_Sol2(int number1, int number2);
    public delegate List<int> ListDelegate_Sol2(List<int> list, int step);
    public delegate string GenericTypeDelegate_Sol2<T>(T element);
    public class Solution_02
    {
        public static void Solution_02_pt1()
        {
            Console.WriteLine("Solution_02_pt1!");
            // Sukurkite delegatą, kuris rodys į metodą su string grąžinamuoju tipu ir trimis parametrais:
            // First name, lastName ir age. Iškvieskite delegato metodą
            //var stringReturnDelegate_Sol2 = new StringReturnDelegate_Sol2(Solution_02.ThreeStringMethod_Sol2);
            //Console.WriteLine(stringReturnDelegate_Sol2("Rytas", "Diena", "Naktis"));

            StringReturnDelegate_Sol2 anonymousStringReturnDelegate = delegate (string one, string two, string three) { return one + two + three; };
            Console.WriteLine(anonymousStringReturnDelegate("ANONIMAS", "anonimas", "AnOnImAs"));
            Console.WriteLine();

            //Solution_02.ThreeStringMethod_Sol2( delegate ("ANONIMAS2", "anonimas2", "AnOnImAs2"); )

            Console.WriteLine(Solution_01.ThreeStringMethod("ANONIMAS3", "anonimas3", "AnOnImAs3"));
            Console.WriteLine();
        }

        public static void Solution_02_pt2()
        {
            Console.WriteLine("Solution_02_pt2!");
            // Sukurkite delegatą, kuris rodys į metodą su int grąžinamuoju tipu ir dviem parametrais
            // number1 ir number2. Iškvieskite delegato metodą
            //var twoNumbersDelegate_Sol2 = new TwoNumbersDelegate_Sol2(Solution_02.TwoNumbersMethod_Sol2);
            //Console.WriteLine($"Grąžina sudėtus skaičius 1 ir 2: {twoNumbersDelegate_Sol2(1, 2)}");

            TwoNumbersDelegate_Sol2 anonymousTwoNumbersDelegate = delegate (int number1, int number2) { return number1 + number2; };
            Console.WriteLine($"Grąžina sudėtus skaičius 10 ir 20: {anonymousTwoNumbersDelegate(10, 20)}");
            Console.WriteLine();

            //Console.WriteLine($"Grąžina sudėtus skaičius 100 ir 200: {Solution_02.TwoNumbersMethod_Sol2(100, 200)}"); // <-- ?
            //Console.WriteLine();
        }

        public static void Solution_02_pt3()
        {
            Console.WriteLine("Solution_02_pt3!");
            // Sukurkite delegatą, kuris rodys į metodą su List<int> grąžinamuoju tipu ir dviem parametrais
            // List<int> ir ints step, metodo esmė bus gr1=inti kas kažkelintą elementą (kas kažkelintą nurodo parametras "step")
            // Iškvieskite delegato metodą
            //var listDelegate_Sol2 = new ListDelegate_Sol2(Solution_02.ListMethod_Sol2);
            var list = new List<int>();
            list.Add(1); list.Add(2); list.Add(3); list.Add(4); list.Add(5);
            list.Add(6); list.Add(7); list.Add(8); list.Add(9); list.Add(10);
            //foreach (var item in listDelegate_Sol2(list, 3))
            //{
            //    Console.WriteLine(item);
            //}

            ListDelegate_Sol2 anonymousListDelegate = delegate (List<int> list, int step)
            {
                int indexer = 1;
                var list2 = new List<int>();
                foreach (var item in list)
                {
                    if (indexer % (step) == 0)
                    {
                        list2.Add(item);
                    }
                    indexer++;
                }
                return list2;
            };
            foreach (var item in anonymousListDelegate(list, 2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void Solution_02_pt4()
        {
            Console.WriteLine("Solution_02_pt4!");
            // Sukurkite delegatą, kuris rodys į GetType<T> metodą su grąžinamuoju tipu string ir parametru T element;
            // Metodas spausdins element kintamojo duomenų tipą. Iškvieskite delegato metodą.
            //var GenericTypeDelegate_Sol2 = new GenericTypeDelegate_Sol2<decimal>(Solution_02.GenericTypeMethod_Sol2);
            //Console.WriteLine(GenericTypeDelegate_Sol2(10));

            GenericTypeDelegate_Sol2<dynamic> anonymousGenericTypeDelegate = delegate (dynamic element) { Console.WriteLine($"įvestis {element} tipas: {element.GetType().Name}");
                                                                                                        return $"įvestis {element} tipas: {element.GetType().Name}"; };

        }
    }
}
