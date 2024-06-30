using System.ComponentModel.DataAnnotations;

namespace VSCode_Projects;

class Practice
{
    static void Main(string[] args)
    {
        Random numberGen = new Random();

        float cash;
        int betAttempts;

        int roll1 = 0;
        int roll2 = -1;

        int attempts = 0;

        Console.WriteLine("Welcome to the VS Casino, guessing your attempts accucately will triple your earnings! \nLet's see how long it takes to get a two of a kind! \nPlace your betting cash!");
        cash = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("You deposited: " + cash + "$!");
        Console.WriteLine("Place your bet on attempts!");
        betAttempts = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Awesome! " + betAttempts + " attempts with " + cash + "$! Let's get rolling! \nPress Enter to roll!");

        while (roll1 != roll2)
        {
            Console.ReadKey();

            roll1 = numberGen.Next(1, 7);
            roll2 = numberGen.Next(1, 7);
            Console.WriteLine("You rolled a " + roll1 + " and a " + roll2 + "!");

            attempts++;
        }

        betAttempts = attempts - betAttempts;

        if (attempts > betAttempts)
        {
            Console.WriteLine("It took you " + attempts + " attempts to get a two of a kind! \nThat's more than your guess!");
            Console.WriteLine("Unlucky! Losers get half their earnings back. Here's your payout.");
            Console.WriteLine("You recieved " + (cash / 2) + "$ back.");
        }
        else if (attempts == betAttempts)
        {
            Console.WriteLine("It took you " + attempts + " attempts to get a two of a kind! \nThat's right on your guess!");
            Console.WriteLine("You serendipitous savant! Winners like you get triple their earnings back! Here's your payout.");
            Console.WriteLine("You recieved " + (cash * 3) + "$ back.");
        }
        else if (attempts < betAttempts)
        {
            Console.WriteLine("It took you " + attempts + " attempts to get a two of a kind! \nThat's less than your guess!");
            Console.WriteLine("Caution isn't well advised in our casino. Losers like you get half their earnings back. Here's your payout.");
            Console.WriteLine("You recieved " + (cash / 2) + "$ back.");
        }

        

        cash = attempts * 5;


        Console.ReadKey();
    }

}
