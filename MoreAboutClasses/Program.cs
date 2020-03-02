using System;

namespace MoreAboutClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Fancy.Write("This program uses classes to ","divide"," a number by 2.\n", pause: 500, afterPause: 500);

            DivBy2 div = new DivBy2();

            bool loop = true;
            while (loop)
            {
                // Get the number to be divided by 2
                int number = 0;
                bool badNumber = true;
                while (badNumber)
                {
                    Fancy.Write("Enter an integer:  ");
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        badNumber = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter an INTEGER, please...\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unknown exception: {0}", e.GetType());
                    }
                }

                Fancy.Write(String.Format("\n\tYour number divided by Two: {0} / 2 = ", number));
                div.Divide(number);

                Fancy.Write("This is how many times we could divide " + number + " Before we are less than 2: ");

                // Getting the out parameter
                int divisions = 0;
                div.Divide(number, out divisions);

                Fancy.Write(divisions + "\n", 100, afterPause: 250);

                // Go again?
                Fancy.Write("\nDo you want to enter a new number? (y or n) ", 5);
                string loopChoice = Console.ReadLine();
                if (loopChoice != "y")
                {
                    loop = false;
                }
            }
        }
    }
}
