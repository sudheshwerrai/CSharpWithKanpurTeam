using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Calculation
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Company
    {
        List<Employee> employeesList;

        public Company()
        {
            employeesList = new List<Employee>
            {
                new Employee(){Id=1,Name="Anubhav",Age=23 },
                new Employee(){Id=2,Name="Ankit",Age=24 }
            };
        }

        //1 Anubhav 2 Ankit
        public string this[int id] 
        {
            get 
            {
                // Select name from tblName where id=2
                return employeesList.Where(e => e.Id == id).FirstOrDefault().Name;
            }
            set
            {
                employeesList.Where(e => e.Id == id).FirstOrDefault().Name = value;
            }
        }
        static void Main()
        {
            Company obj = new Company();
            Console.WriteLine("Before overwriting the value result are:");
            Console.WriteLine(obj[1]); //Anubhav
            Console.WriteLine(obj[2]); //Ankit
            
            obj[1] = "Nitin";
            obj[2] = "Suraj";
            Console.WriteLine("After overwriting the value result are:");
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);


            Console.ReadKey();
        }
    }
}