using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Multiplode03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 15");

          

            for (int mult = 1; mult <= 100; mult++)
            {
                if(mult % 3 == 0)
                {
                    Console.WriteLine(mult);
                }
                
            }

            Console.ReadLine();
        }
    }
}
