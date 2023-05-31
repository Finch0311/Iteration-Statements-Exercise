using System.ComponentModel.Design;
using System.Xml;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void TwoThousand()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

       

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintThrees()
        {
            for (int y = 3; y <= 999; y+=3)
            {
                Console.WriteLine(y);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool CounterTwo(int a, int b)
        {
            {
                var check = (a == b)? true : false;
                return check;
            }
        }

        //Write a method to check whether a given number is even or odd

        public static bool OddOrEven()

        {
            Console.WriteLine("Please input a number to evaulate whether it is even or odd.");

           var userNum = int.Parse(Console.ReadLine());
            
            if (userNum % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

                return true;

        }

        //Write a method to check whether a given number is positive or negative

        public static void Vibes()
        {

            Console.WriteLine("Please input a number to check whether it is negative or positive.");

            var singleNum = int.Parse(Console.ReadLine());

            if (singleNum < 0)
            {
                Console.WriteLine("Your number is negative.");
            }
            else if (singleNum > 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else
            {
                Console.WriteLine("Your number is 0. Your guess is as good as mine since it doesn't hold value.");
            }
        }     
        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void LegalVoting()
        {

            Console.WriteLine("Please input your age.");

            var userInput = int.Parse(Console.ReadLine());
            if (userInput < 18)
            {
                Console.WriteLine("You are to young to vote.");
            }
            else 
            {
                Console.WriteLine("You can vote!");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void SmallTarget()
        {
            Console.WriteLine("You are trying to hit a small range of numbers. Lets see if you hit it. Please input a number.");

            var targetRange = int.Parse(Console.ReadLine());

            if ((targetRange >= -10) && (targetRange <= 10))
            {

                Console.WriteLine("Congradulations you hit the targeted range! The range was -10 to 10. Congradulations!");

            }
            else
            { 
                
                Console.WriteLine("I'm sorry that was not within the range I was looking for. The range was between -10 and 10. Sorry!");

            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void TableOfMultiplication()
        {
            Console.WriteLine("Please input a number between 1 and 12.");

            int userInput, multiplier;

            userInput = int.Parse(Console.ReadLine());

            for (multiplier = 1; multiplier <= 12;  multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}", userInput, multiplier, (userInput * multiplier));
            }
          
           

            Console.WriteLine("These are all the multiples for your number up to 12.");


        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            TwoThousand();

            PrintThrees();

            Console.WriteLine(CounterTwo(1, 2));

            OddOrEven();

            LegalVoting();

            SmallTarget();

            Vibes();

            TableOfMultiplication();
        }
    }
}
