using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard
{
    class Data
    {
    
            public static List<Employee> Employees = new List<Employee>();
        public static void Line()
        {
            Console.WriteLine("\n-------------------------------\n");
        }
        public static int PrintAndDeleteEmployee()
        {
            int key = -1, index = -1;
            Console.WriteLine("Please enter the employee Id");
            try
            {
                key = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception caught.\nID can only be an integer!");
                Console.WriteLine("Delete Failed :(");
                return 0;
            }

            index = Employees.FindIndex(Employee => Employee.Id == key);
            if (index < 0)
            {
                Console.WriteLine("Employee ID does not Exist !");
                return 0;

            }
            Console.WriteLine("The following employee has been deleted\n" + Employees.ElementAt(index));
            Employees.RemoveAt(index);
            Line();

            return 0;
        }
        public static void PrintAllEmployees()
        {
            Console.WriteLine("\nEMPLOYEE LIST\n");
            Employees.ForEach(employee => Console.WriteLine(employee + "\n"));
            Line();


        }
        public static int AddEmployee()
        {
            int id, idd = 0, age;
            String name;
            double salary;
            try
            {
                Console.WriteLine("Please enter the employee ID");
                idd = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Format exception caught.\nEnter Integers Only!\nAdding Failed:( ");
                return 0;
            }



            if (Employees.Count != 0)
            {
                for (int p = 0; p < Data.Employees.Count; p++)
                {
                    if (idd == Data.Employees.ElementAt(p).Id)
                    {
                        Console.WriteLine("Duplicate Employee Id");
                        return 0;
                    }

                }

            }

            id = idd;
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            try
            {
                Console.WriteLine("Please enter the employee age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the employee salary");
                salary = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception caught.\nEnter Integers Only!");
                return 1;
            }
            Data.Employees.Add(new Employee(id, age, name, salary));
            Console.WriteLine("Added Succesfully");
            Line();

            return 0;



        }
        public static int EditEmployee()
        {
            int id = 0, age = 0, key = 0;
            String name = "";
            double salary = 0;

            Console.WriteLine("Enter the ID of the employee you want to edit ");
            try
            {
                key = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception caught.\nID can only be an integer!");
                Console.WriteLine("Edit Failed :(");
                return 0;
            }

            int index = Employees.FindIndex(Employee => Employee.Id == key);
            if (index < 0)
            {
                Console.WriteLine("Employee ID does not Exist !");
                return 0;

            }



            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            try
            {
                Console.WriteLine("Please enter the employee age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the employee salary");
                salary = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Format Exception caught.\nEnter Integers Only!");
                return 1;
            }
            Employees.ElementAt(index).Age = age;
            Employees.ElementAt(index).Name = name;
            Employees.ElementAt(index).Salary = salary;

            Line();

            return 0;
        }

    }
}