using System;

namespace Random_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program generates a random number between two numbers.");
            GenerateRandomNumber();
        }

        static private void GenerateRandomNumber()
        {
            string input;
            int min = 0;
            int max = 0; 

            while(true)
            {
                Console.WriteLine("Enter a minimum number: ");
                input = Console.ReadLine();

                try
                {
                    min = Int32.Parse(input);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a whole number.");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Error: number was too large.");
                }
            }

            while(true)
            {
                Console.WriteLine("Enter a maximum number: ");
                input = Console.ReadLine();
                try
                {
                    max = Int32.Parse(input);
                    if(max <= min)
                    {
                        Console.WriteLine("Error: this number must be larger than " + min);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Error: Please enter a whole number.");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Error: number was too large.");
                }
            }

            Random rand = new Random();
            Console.WriteLine("Your random number is " + rand.Next(min, max));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
