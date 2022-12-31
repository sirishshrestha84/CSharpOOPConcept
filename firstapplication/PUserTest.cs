using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    //Parent name is PUserReg
    internal class PUserTest
    {
        static void Main()
        {
            PUserReg p = new PUserReg(101,true,"Sirish",5000,Town.kathmandu);
            Console.WriteLine("The user Id is:" + p.Userid);

            if (p.Status == true)
                Console.WriteLine("The user status is Active");
            else
                Console.WriteLine("The user status is Inactive");

            Console.WriteLine("The user name is:" + p.Cname);
            p.Cname += "Shrestha";
            Console.WriteLine("The user name is:" + p.Cname);

            Console.WriteLine("The balance is:" + p.Balance);
            p.Balance -= 500;
            Console.WriteLine("The new balance is:" + p.Balance);

            Console.WriteLine("The city is:" + p.City);
            p.City = Town.lalitpur;
            Console.WriteLine("The new city is:" + p.City);


            //When user status is inactive 
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            p.Status = false;
            Console.WriteLine("The user Id is:" + p.Userid);

            if (p.Status == true)
                Console.WriteLine("The user status is Active");
            else
                Console.WriteLine("The user status is Inactive");

            Console.WriteLine("The user name is:" + p.Cname);
            p.Cname += "Shrestha";
            Console.WriteLine("The user name is:" + p.Cname);

            Console.WriteLine("The balance is:" + p.Balance);
            p.Balance -= 2000;
            Console.WriteLine("The new balance is:" + p.Balance);

            Console.WriteLine("The city is:" + p.City);
            p.City = Town.lalitpur;
            Console.WriteLine("The new city is:" + p.City);
            Console.ReadLine();

        }
    }
}
