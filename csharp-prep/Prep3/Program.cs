using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //Console.Write("What is the magic number? ");
        //int magic_number = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}