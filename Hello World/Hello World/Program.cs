using System;
using System.Collections.Generic;
using System.Linq;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var n = r.Next(1, 99);
            Console.WriteLine(n);
        }
    }
}
