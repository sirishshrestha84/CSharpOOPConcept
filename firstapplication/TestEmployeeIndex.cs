using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class TestEmployeeIndex
    {
        static void Main()
        {
            //Using integer
            EmployeeIndex Emp = new EmployeeIndex(1001, "Sirish", "Manager", 20000, "Sales", "Kathmandu");
            Console.WriteLine("Eno:" + Emp[0]);
            Console.WriteLine("Name:" + Emp[1]);
            Console.WriteLine("Job:" + Emp[2]);
            Console.WriteLine("Salary:" + Emp[3]);
            Console.WriteLine("Department:" + Emp[4]);
            Console.WriteLine("Location:" + Emp[5]);

            //Setter
           Console.WriteLine("");
           Console.BackgroundColor = ConsoleColor.Green;
           Emp[0] = 1002;
            Emp[1] = "Sabin";
            Emp[2] = "Developer";
           Emp[3] = 3000.0;
          Emp[4] = "Management";
          Emp[5] = "Lalitpur";
           Console.WriteLine("Eno:" + Emp[0]);
           Console.WriteLine("Name:" + Emp[1]);
            Console.WriteLine("Job:" + Emp[2]);
           Console.WriteLine("Salary:" + Emp[3]);
            Console.WriteLine("Department:" + Emp[4]);
           Console.WriteLine("Location:" + Emp[5]);                     


            //Using string
            Console.WriteLine("");
            Console.WriteLine("Eno:" + Emp["Eno"]);
            Console.WriteLine("Name:" + Emp["Ename"]);
            Console.WriteLine("Job:" + Emp["Job"]);
            Console.WriteLine("Salary:" + Emp["Salary"]);
            Console.WriteLine("Department:" + Emp["Dname"]);
            Console.WriteLine("location:" + Emp["Location"]);


            //Setter
            Emp["Eno"] = 1003;
            Emp["Ename"] = "Alex";
            Emp["Job"] = "Dev";
            Emp["Salary"] = 5000.0;
            Emp["Dname"] = "Chairman";
            Emp["Location"] = "Bhaktapur";

            Console.WriteLine("");
            Console.WriteLine("Eno:" + Emp["Eno"]);
            Console.WriteLine("Name:" + Emp["Ename"]);
            Console.WriteLine("Job:" + Emp["Job"]);
            Console.WriteLine("Salary:" + Emp["Salary"]);
            Console.WriteLine("Department:" + Emp["Dname"]);
            Console.WriteLine("location:" + Emp["Location"]);
            Console.ReadLine();
        }
    }
}
