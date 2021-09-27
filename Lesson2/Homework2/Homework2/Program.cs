using System;

namespace Homework2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string helloText = "Hello, My name is Karina :)";

            Console.WriteLine(helloText);
            Console.WriteLine("What is Your name?");

            string userAnswer = Console.ReadLine();

            Console.WriteLine("Hello " + userAnswer);

            Console.WriteLine ("=================================================================");

            Console.WriteLine("How old are You?");
            string userAgeText = Console.ReadLine();

            int userAge = int.Parse(userAgeText);
            int ageNextYear = userAge +1;

            bool isAdult = userAge >= 18;

            Console.WriteLine($"Congratulations, next year You will be {ageNextYear}, You are an Adult: {isAdult}");

            Console.WriteLine("=================================================================");

            Console.WriteLine("What is your favourite number?");
            string userText1 = Console.ReadLine();
            int Number1 = int.Parse(userText1);

            Console.WriteLine($"Thank You , {userText1}, please write down another number");

            string userText2 = Console.ReadLine();
            int Number2 = int.Parse (userText2);

            int maxLargest = Math.Max(Number1, Number2);

            Console.WriteLine($"Your Largest favourite number is {maxLargest}");

            Console.WriteLine("=================================================================");

            int minSmallest = Math.Min(Number1, Number2);

            Console.WriteLine($"Your Smallest favourite number is {minSmallest}");

            Console.WriteLine("=================================================================");

            int numLeftOver = Number1 % Number2;

            Console.WriteLine($"Your favourite number's left Over is {numLeftOver}");

            Console.WriteLine("=================================================================");

            if (Number1 % 2 == 0)

            Console.WriteLine("{0} is even" , Number1);

            else
                
            Console.WriteLine("{0} is Odd", Number1);

            if (Number2 % 2 == 0)

                Console.WriteLine("{0} is Even", Number2);

            else

                Console.WriteLine("{0} is Odd", Number2);


            Console.WriteLine("=================================================================");

            Console.WriteLine($"Hello, {userAnswer} ! You are {userAge} years old");
        }
    }
}
