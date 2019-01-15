// Executing Conditional statements if-else and also use try catch
using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking user input for sales value
            Console.WriteLine("Please enter a sales amount");

            //Using try catch for error handling
            try
            {
                string input = Console.ReadLine(); // input variable will take up user sales input
                decimal sales = decimal.Parse(input); // sales variable stores the parsed decimal sales value
                decimal bonus = 0; // variable to store calculated bonus value
                //int years_in_sales = 0; // variable to take user input on years in sales

                /*
                   Calculating bonus based on sales amount using if else conditional statements
                   Switch conditional statements are used to display messages based on years of experience in sales
                */
                if (sales < 1000)
                {
                    // Calculating 5% bonus
                    bonus += 0.5m * sales;

                    //Displaying the bonus
                    Console.WriteLine("Your 5% bonus is:" + String.Format("{0:C}"),bonus);

                } // end of if(sales) 

                else if ((sales > 1000) && (sales < 3000))
                {
                    // Calculating 6% bonus
                    bonus += 0.6m * sales;

                    //Displaying the bonus
                    Console.WriteLine("Your 6% bonus is:" + String.Format("{0:C}"),bonus);

                } // end of else-if ((sales > 1000)) && (sales < 3000)

                else
                {
                    // Calculating 7% bonus
                    bonus += 0.7m * sales;

                    //Displaying the bonus
                    Console.WriteLine("Your 7% bonus is:" + String.Format("{0:C}"),bonus);
                } // end of else

            } // end of try

            catch
            {
                // Display error message
                Console.WriteLine("Please enter valid decimal value for sales amount next time");

                // display exit message
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } // end of catch

        } // end of main
    } // end of class
} // end of namespace
