using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard
{
    class Program
    {
        
            public static void DisplayMenu()
            {
                Data.Line();
                Console.WriteLine("Please enter the option\n1.Add an employee\n2.Modify an employee detail\n3.Print all employee's details\n4.Print an employee detail\n5.Exit");
                Data.Line();
            }


            static void Main(string[] args)
            {

                for (int i = 0; ; i++)
                {
                    DisplayMenu();
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Data.AddEmployee();
                            break;
                        case 2:
                            Data.EditEmployee();
                            break;
                        case 3:
                            Data.PrintAllEmployees();
                            break;
                        case 4:
                            Data.PrintAndDeleteEmployee();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("invalid input \nSelect again ");
                            break;

                    }



                }

            }
        }
}
