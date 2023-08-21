using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCO_ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero da conta");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial?");
            char resposta = char.Parse(Console.ReadLine());
        }
    }
}
