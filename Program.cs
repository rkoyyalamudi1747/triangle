using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{


    class Program
    {

       public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
               Console.WriteLine("1=Get Triangle Sides");
                Console.WriteLine("2=exit");
               Console.WriteLine("Please select an option, by entering a number:\n");
                userInput = Console.ReadLine();
                if (userInput != "1" &&
                    userInput != "2")

                {
                  Console.WriteLine("That's not a valid option, please try again:\n");
              }
                else
               {
                   validMenuSelect = true;
                }
            }
            Console.WriteLine();
           return int.Parse(userInput);
        }
        public static int ValidateUserInput(string triSide)
        {
            int number = 1;
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine($"Please enter {triSide} of your triangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                bool result = int.TryParse(userInput, out number);
                if (result == false)
                {
                    Console.WriteLine("thats not a valid input Please try again.\n");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("number cannot be less than 0 please try again.\n");
                }
                else
                {
                    Console.WriteLine($"The {triSide} of triangle is now {number}.\n ");
                    isValid = true;

                }
            }
            return number;

        }

        static void Main(string[] args)
        {
           // Trianglesolver r = new Trianglesolver();

            bool validTriangleSelect = false;
            string triangleSelection;
            int selection;

            while (validTriangleSelect == false)
            {
                Console.WriteLine("1 = enter the sides of the triangle\n");
                Console.WriteLine("2 = exit\n");

                Console.WriteLine("Choose a menu item to begin:");
                triangleSelection = Console.ReadLine();
                Console.WriteLine();
                if ((triangleSelection != "1") && (triangleSelection != "2"))
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                else if (int.Parse(triangleSelection) == 1)
                {
                    
                    int s1;
                    int s2;
                    int s3;
                    s1 = ValidateUserInput("s1");
                    s2 = ValidateUserInput("s2");
                    s3 = ValidateUserInput("s3");
                    Console.WriteLine($"Your sides of a triangle are  {s1}, {s2} and {s3}.\n");
                    Trianglesolver.Analyze(s1,s2, s3);
                        
                   
                   
                }
                else if(int.Parse(triangleSelection) == 2)
                {
                  
                   break;
                }

            }



            selection = ValidateMenuSelection();
        }
           

       

        









}

}
