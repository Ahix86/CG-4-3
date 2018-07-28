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
            String[] myArray = new String[30];

            // here we are starting at zero and going up to thiry, the max. ths i++ tells the loop to add one to the total each time till it hits 30
            for (int i = 0; i < 30; i++)
            {
                myArray[i] = Console.ReadLine();
            }

            // this sets it up to draw a name at random from the thirty names the user inputs.
                        Random rnd = new Random();
            int randomNameIndex = rnd.Next(30);

            // the write line will display the random name
            Console.WriteLine(myArray[randomNameIndex]);
            Console.Read();
        }
    }
}
