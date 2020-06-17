using System;

namespace CsharpTypes {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter first number : ");
            var nbr1AsString = Console.ReadLine();
            var nbr1 = Convert.ToInt32(nbr1AsString);

            Console.Write("Enter second number : ");
            var nbr2AsString = Console.ReadLine();
            var nbr2 = Convert.ToInt32(nbr2AsString);

            var answer = nbr1 + nbr2;

            Console.Write($"{nbr1} plus {nbr2} equals {answer}");

            //Console.Write("Enter some data and press enter: ");
            //var response = Console.ReadLine();
            //Console.WriteLine(response);
        }
    }
}
