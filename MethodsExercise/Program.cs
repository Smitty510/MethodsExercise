using System.ComponentModel;
using System.Threading.Channels;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int product = Methods.Multiply(7, 9);
            Console.WriteLine(product);
            double quotient = Methods.Divide(7, 9);
            Console.WriteLine(quotient);
            int difference = Methods.Subtract(7,9);
            Console.WriteLine(difference);
            int sum = Methods.Add(7,9);
            Console.WriteLine(sum);
            int sumMultiple = Methods.AddMultiple(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(sumMultiple);
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine(); // input
            Console.WriteLine("What is your favorite color");
            var color = Console.ReadLine(); //input
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine(); //input
            Console.WriteLine($"Hello. My name is {name} and I love the color {color}, especially on my favorite animal, the {animal}");
        }


            }
}
