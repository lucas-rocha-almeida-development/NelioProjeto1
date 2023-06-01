using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NelioProjeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo:" );
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Qual sua idade:");
            int Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua graduação? ");
            string Graduacao = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nomeCompleto + " você tem " + Idade + " anos " + " é vejo que você cursa " + Graduacao);

            Console.ReadKey();
        }
    }
}
