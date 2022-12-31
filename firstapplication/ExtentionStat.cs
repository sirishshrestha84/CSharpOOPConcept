using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    static class ExtentionStat
    {
        public static void Test3(this Extentionmethod e)
        {
            Console.WriteLine("Method3");
        }
        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            else if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);

        }
        public static string ToProper(this String OldStr)
        {
            if(OldStr.Trim().Length> 0)
            {
                String NewStr = null;
                OldStr = OldStr.ToLower();
                string[]sarr= OldStr.Split(' ');
                foreach(string str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = Char.ToUpper(carr[0]);
                    if(NewStr == null)
                    {
                        NewStr = new string(carr);
                    }
                    NewStr +=" " + new string(carr);
                }
                return NewStr;
            }
            return OldStr;

        }
    }
}
