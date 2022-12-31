using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class PTestCustomer //Parents class is PCustomer.cs
    {
        static void Main()
        {
            PCustomer c = new PCustomer(101,false,"Sirish",5000,Cities.Kathmandu,"Bagmati","Nepal");
            Console.WriteLine("The current id is:" + c.Custid);
            if (c.Status == true)
            Console.WriteLine("The current Status is: Active");
            else
            Console.WriteLine("The current Status is: InActive");//If else statement to know weather the status is active or inactive.

            Console.WriteLine("The current name is:" + c.CName);

            c.CName += "Shrestha";
            Console.WriteLine("The new name is:" + c.CName);// Since the status is false / inactive, the changes does not take place.

            Console.WriteLine("The current balance is:" + c.Balance);
            c.Balance -= 2000;
            Console.WriteLine("The new balance is:" + c.Balance);// Since the status is false / inactive, the changes does not take place.
                                                                 //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The current city is:" + c.City);
            c.City = Cities.Pokhara;
            Console.WriteLine("The current city is:" + c.City);//Since the status is false, the change does not take place.
            Console.WriteLine("The pradesh is:" + c.Pradesh);
            c.Pradesh = "Gandaki";
            Console.WriteLine("The modified  pradesh is:" + c.Pradesh);//Since the status is false, the change does not take place.
            Console.WriteLine("The Country is:" + c.Country);

            //Now where status is active 
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            c.Status = true;
            if (c.Status == true)
                Console.WriteLine("The current Status is: Active");
            else
                Console.WriteLine("The current Status is: InActive");//If else statement to know weather the status is active or inactive.

            Console.WriteLine("The current name is:" + c.CName);

            c.CName += "Shrestha";
            Console.WriteLine("The new name is:" + c.CName);// Since the status is true / active, the changes takes place.

            Console.WriteLine("The current balance is:" + c.Balance);
            c.Balance -= 3600; // Since the value meets minimum balance the change is performed.
            Console.WriteLine("The new balance is:" + c.Balance);// Since the status is true /active, the changes takes place.
            c.Balance -= 5600; // Since the value is less than the minimum balance the change is not performed.
            Console.WriteLine("The new balance is:" + c.Balance);// Since the status is true /active but does not meet minimum balance condition, the changes does not take place.
           

            Console.WriteLine("The current city is:" + c.City);
            c.City = Cities.Pokhara;
            Console.WriteLine("The current city is:" + c.City);// Since the status is true /active, the changes takes place.
            Console.WriteLine("The pradesh is:" + c.Pradesh);
            c.Pradesh = "Gandaki";
            Console.WriteLine("The modified pradesh is:" + c.Pradesh);// Since the status is true /active, the changes takes place.
            Console.WriteLine("The Country is:" + c.Country);


            Console.ReadLine();
        }
    }
}
