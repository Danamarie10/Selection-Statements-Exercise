using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            var favNum = 16;
            var r = new Random();
            var favNumber = r.Next(1, 50);

            Console.WriteLine("Try to guess my favorite number between 1 and 50");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNum)
            {
                Console.WriteLine("Number is too low");
            }
            else if (userInput > favNum)
            {
                Console.WriteLine("Number is too High");
            }
            else
            {
                Console.WriteLine("That is Correct!");
            }
            
        }
    }
}
