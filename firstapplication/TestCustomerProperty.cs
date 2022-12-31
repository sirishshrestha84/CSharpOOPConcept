using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class TestCustomerProperty
    {
        static void Main()
        {
            CustomerProperty obj = new CustomerProperty(101, false, "Sirish", 5000);
            Console.WriteLine("CustomerID:" + obj.Custid);
            obj.Custid = 102;
            Console.WriteLine("New CustomerID:" + obj.Custid);
            if (obj.Status == true)
                Console.WriteLine("Customer Status:Active");
            else
                Console.WriteLine("Customer Status:InActive");
            Console.WriteLine("Customer Name:"+obj.Cname);
            obj.Cname += "Shrestha"; //Modification of name wont take place if status is false
            Console.WriteLine("Customer New Name:" + obj.Cname);
            Console.WriteLine("Current Balance:" + obj.Balance);
            obj.Balance -= 1000;//No change takes places as status is inactive or false
            Console.WriteLine("New Balance:" + obj.Balance);

            //Condition where Status is true.
            obj.Status = true;
            if (obj.Status == true)
                Console.WriteLine("Customer Status:Active");
            else
                Console.WriteLine("Customer Status:InActive");
            obj.Cname += "Shrestha"; //Modification of name take place successfully.
            Console.WriteLine("Customer New Name:" + obj.Cname);
            obj.Balance -= 4000;//Change takes place as status is active 
            Console.WriteLine("New Balance:" + obj.Balance);
            Console.ReadLine();
        }
    }
}
