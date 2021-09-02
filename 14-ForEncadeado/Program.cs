using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 14");

           // *
           // **
           // ***
           // ****
           // *****

            //Escrevendo asteriscos com o break
            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                     Console.WriteLine();
            }

            //Uma forma diferente de fazer a forma de astericos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                
                    Console.Write("*");
                   
                
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
