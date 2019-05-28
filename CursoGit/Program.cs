using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CursoGit
{
    class Program
    {


        //Menu


        static void Main(string[] args)
        {
            //Call
            Random r = new Random();

            for(int i = 0; i < 100; i++)
            {
                Console.Write("#");
                Thread.Sleep(r.Next(100,300));
            }

            Console.WriteLine("Hello World Again, second commit");
            Console.ReadKey();




        }
    }
}
