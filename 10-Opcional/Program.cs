using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Opcional
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario > 1903.99 && salario <= 2826.65)
            {
                Console.WriteLine("O IR é de 7.5%");
                Console.WriteLine("Pode deduizr na declaração o valor de R$142");
            }
            else if (salario > 2826.65 && salario <= 3751.05)
            {
                Console.WriteLine("O IR é de 15%");
                Console.WriteLine("Pode deduizr na declaração o valor de R$350");
            }
            else if (salario > 3751.05 && salario <= 4664.68)
            {
                Console.WriteLine("O IR é de 22.5%");
                Console.WriteLine("Pode deduizr na declaração o valor de R$636");
            }
            else if (salario > 4664.68)
            {
                Console.WriteLine("O IR é de 27.5%");
                Console.WriteLine("Pode deduizr na declaração o valor de R$869.36");
            }
                Console.ReadLine();
        }
    }
}
