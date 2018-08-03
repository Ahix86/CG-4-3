using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the use to input 30 names.
            Console.WriteLine("Please enter thirty (30) names. Hit enter after each name.");
            Console.Write("Enter the first name here:  ");

            // now we set the array for how many 'items' we'll have.
            var names = new String[30];
            var numberallnames = 0;

            // here we are starting at zero and going up to thiry, the max. ths i++ tells the loop to add one to the total each time till it hits 30
            for (int i = 0; i < 30; i++)
            {
                //we need to put the users names into a string
                var userInput = Console.ReadLine();
                //in case they don't put in all 30 names we want to keep the game going so we will break at a blank space
                if (string.IsNullOrWhiteSpace(userInput)) break;
                names[i] = userInput;
                numberallnames = i;

            }

            // this sets it up to draw a name at random from the thirty names the user inputs.
            var rnd = new Random();
            var winner = rnd.Next(numberallnames);

            // the write line will display the random name
            Console.WriteLine(names[numberallnames] + " is the winner!");

            Console.WriteLine("Sorry, the below did not win.");
            // here we are loopping the names again but this time skipping the winner to list the losers
            for (int n = 0; n <= numberallnames; n++)
            {
                if (n == winner) continue;
                Console.WriteLine(names[n]);
            }

            Console.Read();
        }
    }
}