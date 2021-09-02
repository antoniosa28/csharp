using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            int idade;
            idade = 22;

            Console.WriteLine(idade);

            idade = 20;
            Console.WriteLine(idade);
            idade = 20 + 8;
            Console.WriteLine(idade);

            idade = 20 + 8 * 3;
            Console.WriteLine(idade);

            idade = (20 + 8) * 3;
            Console.WriteLine("Sua idade é " + idade + "!");
            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
