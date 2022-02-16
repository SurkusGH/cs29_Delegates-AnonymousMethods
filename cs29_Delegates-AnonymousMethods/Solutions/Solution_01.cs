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
    }
}
