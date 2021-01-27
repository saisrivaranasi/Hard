﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard
{

    class Employee : IComparable<Employee>
    {


        int id, age, idd;
        string name;
        double salary;

        public Employee()
        {
        }

        public int CompareTo(Employee other)
        {
            if (this.Salary < other.Salary)
            {
                return 1;
            }
            else if (this.Salary > other.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }



        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public int TakeEmployeeDetailsFromUser()
        {
            Console.WriteLine("Please enter the employee ID");
            idd = Convert.ToInt32(Console.ReadLine());
            for (int p = 0; p < Data.Employees.Count; p++)
            {
                if (idd == Data.Employees.ElementAt(p).id)
                    return 1;
            }
            id = idd;
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Data.Employees.Add(new Employee(Id, Age, Name, Salary));
            return 0;

        }

        public override string ToString()
        {

            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary;
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }

}

