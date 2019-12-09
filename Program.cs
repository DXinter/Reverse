using System;

namespace Reverse
{
    /*
     *функциия Reverse(string input), которая возвращает обратную строку (Reverse("ABCD") -> "DCBA") 
     */

    class Program
    {
        static void Main(string[] args)
        {

            DoReverse reverse = new DoReverse();
            Console.WriteLine("Введите строку: ");
            string someString = Console.ReadLine();
            string result = reverse.Reverse(someString);
            Console.WriteLine($"{result}");
           
        }
    }
}
