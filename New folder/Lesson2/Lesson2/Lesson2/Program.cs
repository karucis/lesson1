using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloText = "My Name is Karina";
            int myNumber = 254;
            double myDouble = 14.5;
            bool isCool = true;
            char myLetter = 'D';

            Console.WriteLine(helloText);
            Console.WriteLine(myNumber);
            Console.WriteLine(myDouble);
            Console.WriteLine(isCool);
            Console.WriteLine(myLetter);

            int number1 = 5;
            int number2 = 7;
            int numSum = number1 + number2;
            Console.WriteLine(numSum);


            int number3 = 10;
            int number4 = 3;
            int numSum2 = number3 / number4;
            Console.WriteLine(numSum2);

            double number5 = 10;
            int number6 = 3;
            double numSum3 = number5 / number6;
            Console.WriteLine(numSum3);

            bool isEqual = 15 == 17;
            Console.WriteLine(isEqual);

            bool isNotEqual = !isEqual;
            Console.WriteLine(isNotEqual);

            bool isSmaller = 15 <= 17;
            Console.WriteLine(isSmaller);


            bool iAmTrue = true;
            bool iAmFalse = false;

            bool result1 = iAmTrue && iAmFalse;
            bool result2 = iAmTrue || iAmFalse;

            Console.WriteLine(result1);
        

            Console.WriteLine("========================================");

            int myNumber7 = 15;
            myNumber7 += 4;
            Console.WriteLine(myNumber7);


            Console.WriteLine("Ievadi savu vārdu?");
            string userAnswer = Console.ReadLine();

            Console.WriteLine("Hello " + userAnswer);


            Console.WriteLine("Ievadi savu vecumu?");
            string userAgeText = Console.ReadLine();


            int userAge = int.Parse(userAgeText);
            int fullAge = userAge + 100; 

            Console.WriteLine("Hello " + fullAge);


            int maxNumber1 = 4;
            int maxNumber2 = 5;
            int maxLargest = Math.Max(maxNumber1, maxNumber2);

            Console.WriteLine(maxLargest);
        }


    }
}
