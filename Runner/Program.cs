using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4.model;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Puppy("Beethoven");
            Console.WriteLine(puppy.Voice());
            Console.WriteLine(puppy.Bite());
            Console.WriteLine(puppy.Jump());
            Console.WriteLine(puppy.Run());
            Console.ReadKey();
        }
    }
}
