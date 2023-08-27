using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCO_ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Insira o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? Digite 1 para sim e 2 para não: ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == '1')
            {
                Console.Write("Informe em reais o valor do depósito incial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine($"Conta {conta.Numero}, Titular {conta.Titular}, Saldo {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");


            //Função para deposito
            Console.WriteLine();
            Console.Write("Entre com o valor do depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.deposito(quantia);
            Console.WriteLine("Valor do saldo atualizado: ");
            Console.WriteLine($"Conta {conta.Numero}, Titular {conta.Titular}, Saldo {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            //funcao saque com taxa de 5 reais
            Console.WriteLine();
            Console.Write("Entre com o valor do saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.saque(quantia);
            Console.WriteLine("Valor do saldo atualizado com a taxa do saque: ");
            Console.WriteLine($"Conta {conta.Numero}, Titular {conta.Titular}, Saldo {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");










        }


    }
}
