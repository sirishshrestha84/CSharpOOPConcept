using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class EnumTest
    {
        public enum Days
        {
            Monday=1,
            Tuesday=2,
            Wednesday=54,
            Thursday=6,
            Friday=10
        }

        public static Days MeetingDate
        {
            get; set;
        } =(Days)1;
        static void Main()
        {
            Console.WriteLine(MeetingDate);
            MeetingDate =Days.Friday;
            Console.WriteLine(MeetingDate);
            Console.ReadLine();
              /*  foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i + ":" +(Days)i);
                foreach (string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s);
                Console.ReadLine();*/
        }

    }
}
