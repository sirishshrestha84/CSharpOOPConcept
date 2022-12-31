using System;
namespace firstapplication
{
    struct MyStruct
    {
        public void Display()
        {
            Console.WriteLine("Method in class");
        }
        static void Main()
        {
            MyStruct myStruct = new MyStruct();
            myStruct.Display();
            Console.ReadLine();
        }
    }
}