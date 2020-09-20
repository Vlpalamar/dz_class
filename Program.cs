using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            Lighter l = new Lighter();
            Lighter d = new Lighter();
            Lighter w = new Lighter();
            Lighter f = new Lighter();
            Lighter x = new Lighter();
            Lighter[] arr = new Lighter[5];
            arr[0] = l;
            arr[1] = d;
            arr[2] = w;
            arr[3] = f;
            arr[4] = x;

            l.Hello();// из дополнительного класса 

            Console.Read();
           
        }
    }
}
