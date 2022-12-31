using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);
    internal class GenericDelegates
    {
        public static double AddNum1(int x,float y,double z)
        {
            return x+ y + z;
        }
        public static void AddNum2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            else
                return false;
        }
        static void Main()
        {
            Func<int, float, double, double> Obj1 = AddNum1;
            double result = Obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(result);

            Action<int, float, double> Obj2 = AddNum2;
            Obj2.Invoke(100, 34.5f, 193.465);

            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello world");
            Console.WriteLine(status);
            Console.ReadLine();
            
        }
    }
}
