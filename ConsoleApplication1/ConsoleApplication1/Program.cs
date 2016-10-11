using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            student A = new student();
            A.name = "ashley moncrieft";
            A.hometown = "orangeburg, SC";
            A.age = 30;
            student B = new student();
            B.name = "cecil sharp";
            B.hometown = "somewhere else";
            B.age = 31;

            Console.WriteLine(A);

            student C = new student();
            Console.WriteLine("what's your name?");
            C.name = Console.ReadLine();
            Console.WriteLine("where are you from?");
            C.hometown = Console.ReadLine();
            Console.WriteLine("?cuantos anos tienes?");
            C.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("here is your info\n" + C);
            if (A.Equals(C))
            { Console.WriteLine("pass"); }
            else
            {
                Console.WriteLine("fail");
            }

            Console.ReadLine();
         
        }
    }
}
