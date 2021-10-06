using System;

namespace Part_6___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompter

            int min;
            int max;
            int input;

            Console.WriteLine("Please Enter Your Minimum Value");
            if (Int32.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You Did Not Enter a Number!!!");
            }
                

            Console.WriteLine("Please Enter Your Maximum Value");
            if (Int32.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You Did Not Enter a Number!!!");
            }
                

            Console.WriteLine("Please Enter a Number Between " + min + " and " + max);
            if (Int32.TryParse(Console.ReadLine(), out input))
            {

                while ((input <= min) || (input >= max))
                {
                    Console.WriteLine("Error: You Did Not Enter a Number Between " + min + " and " + max);
                    Console.WriteLine("Please Enter a Number Between " + min + " and " + max);
                    input = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("You Did Not Enter a Number!!!");
            }
             
            Console.WriteLine("Good Job");
            Console.WriteLine("");

            //Percent Passing

            int numTest;
            int numTestEntered = 0;
            int passed = 0;
            int failed = 0;
            int testScore;
            double average;

            Console.WriteLine("Please Enter How Many Test Scores You Have");
            Int32.TryParse(Console.ReadLine(), out numTest);
            Console.WriteLine("");

            Console.WriteLine("Please Type In All Of Your Test Scores");

            while (numTestEntered != numTest)
            {
                testScore = Convert.ToInt32(Console.ReadLine());
                numTestEntered = numTestEntered + 1;
                
                if (testScore < 70)
                {
                    failed = failed + 1;
                }
                else if (testScore >= 70)
                {
                    passed = passed + 1;
                }

            }

            average = (((double)passed / numTest) * 100);
            Console.WriteLine(average + "% Tests Have a Passing Grade");
            Console.WriteLine("");



                //Odd Sum

                int userInput = 1;

            Console.WriteLine("Please Enter a Number");
            if (Int32.TryParse(Console.ReadLine(), out userInput))
            {
                for (int i = 1; i < userInput; i = i + 2)
                {
                    Console.WriteLine(Convert.ToString(i));
                }

            }
            else
            {
                Console.WriteLine("You Did Not Enter a Number!!!");
            }

            Console.WriteLine();


            //Random Numbers

            int[] numbers = new int[25];
            Random rnd = new Random();
            int minimum;
            int maximum;

            Console.WriteLine("Please Enter a Minimum Value");
            minimum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Please Enter a Maximum Value");
            maximum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");


            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = rnd.Next(minimum, maximum);
                Console.WriteLine(numbers[i]);

            }

            Console.WriteLine();
        }
    }
}
