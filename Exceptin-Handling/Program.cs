using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptin_Handling
{
    class ExceptHandle : Exception
    {
        public ExceptHandle(string Message) : base(Message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int c = a / b;
            //    Console.WriteLine(c);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block");
            //}
            //Console.WriteLine("Rest Of the code");


            //int age = 8;
            //try
            //{
            //    if (age < 18) {
            //        throw new ExceptHandle("Age > 18 is applicable");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You can apply for license");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //unchecked
            //{
            //int val = int.MaxValue;
            //Console.WriteLine(val +2);
            //}


            try
            {
                int[] arr = new int[5];
                arr[10] = 10;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Data);
            }
            Console.WriteLine("Other code");

            Console.Read();
        }
    }
}
