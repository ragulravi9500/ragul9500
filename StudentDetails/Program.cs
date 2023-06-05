using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDetails.BL;
namespace StudentDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("         Welcome to SRM College Of Engineering        ");
                Console.WriteLine();
                Console.WriteLine("1. To Add the Student Details");
                Console.WriteLine("2. To Update the Student Details");
                Console.WriteLine("2. To View the Student Details");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.WriteLine("Select Your option");
                int option;

                if (int.TryParse(Console.ReadLine(), out option) && StudentDetailsService.IsValidOption(option) == true)
                {
                    switch (option)
                    {
                        case 1:
                            busService.AddPassenger();
                            break;
                        case 2:
                            busService.AddBooking();
                            /*usService.AddBooking();*/
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }


            }
    }
}
