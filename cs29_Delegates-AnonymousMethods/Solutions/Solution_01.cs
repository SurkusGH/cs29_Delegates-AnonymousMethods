using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_Delegates_AnonymousMethods
{
    public delegate string StringReturnDelegate(string one, string two, string three);
    public delegate int TwoNumbersDelegate(int number1, int number2);
    public delegate List<int> ListDelegate(List<int> list, int step);
    public delegate string GenericTypeDelegate<T>(T element);
    public class Solution_01
    {
        #region RunMethods
        public static void Solution_01_pt1()
        {
            Console.WriteLine("Solution_01_pt1!");
            // Sukurkite delegatą, kuris rodys į metodą su string grąžinamuoju tipu ir trimis parametrais:
            // First name, lastName ir age. Iškvieskite delegato metodą
            var stringReturnDelegate = new StringReturnDelegate(ThreeStringMethod);
            Console.WriteLine(stringReturnDelegate("Rytas", "Diena", "Naktis"));
            Console.WriteLine();
        }

        public static void Solution_01_pt2()
        {
            Console.WriteLine("Solution_01_pt2!");
            // Sukurkite delegatą, kuris rodys į metodą su int grąžinamuoju tipu ir dviem parametrais
            // number1 ir number2. Iškvieskite delegato metodą
            var twoNumbersDelegate = new TwoNumbersDelegate(TwoNumbersMethod);
            Console.WriteLine($"Grąžina sudėtus skaičius 1 ir 2: {twoNumbersDelegate(1, 2)}");
            Console.WriteLine();
        }

        public static void Solution_01_pt3()
        {
            Console.WriteLine("Solution_01_pt3!");
            // Sukurkite delegatą, kuris rodys į metodą su List<int> grąžinamuoju tipu ir dviem parametrais
            // List<int> ir ints step, metodo esmė bus gr1=inti kas kažkelintą elementą (kas kažkelintą nurodo parametras "step")
            // Iškvieskite delegato metodą
            var listDelegate = new ListDelegate(ListMethod);
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
            var GenericTypeDelegate = new GenericTypeDelegate<decimal>(GenericTypeMethod);
            Console.WriteLine(GenericTypeDelegate(10));
            Console.WriteLine();
        }
#endregion
        #region Methods
        // Sukurkite delegatą, kuris rodys į metodą su string grąžinamuoju tipu ir trimis parametrais:
        // first name, lastName ir age. Iškvieskite delegato metodą
        public static string ThreeStringMethod(string firstName, string lastName, string age)
        {
            return firstName + lastName + age + " yra gražinamas delegato stringas";
        }

        // Sukurkite delegatą, kuris rodys į metodą su int grąžinamuoju tipu ir dviem parametrais
        // number1 ir number2. Iškvieskite delegato metodą
        public static int TwoNumbersMethod(int input1, int input2)
        {
            return input1 + input2;
        }

        // Sukurkite delegatą, kuris rodys į metodą su List<int> grąžinamuoju tipu ir dviem parametrais
        // List<int> ir ints step, metodo esmė bus grąžinti kas kažkelintą elementą (kas kažkelintą nurodo parametras "step")
        // Iškvieskite delegato metodą
        public static List<int> ListMethod(List<int> list, int step)
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
        }

        // Sukurkite delegatą, kuris rodys į GetType<T> metodą su grąžinamuoju tipu string ir parametru T element;
        // Metodas spausdins element kintamojo duomenų tipą. Iškvieskite delegato metodą.
        public static string GenericTypeMethod<T>(T element)
        {
            return $"įvestis {element} tipas: {element.GetType().Name}";
        }
        #endregion
    }
}
