using System.Globalization;


namespace CCO_ContaCorrente
{
    class ContaBancaria
    {
        public int Numero { get; private set; }

        public string Titular { get; set; }

        public double Saldo { get; private set; }
        public object Deposito { get; internal set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;

        }

        public void deposito(double quantia){
            Saldo += quantia;
        }

        public void saque (double quantia)
        {
            Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
            return "Conta"
                + Numero
                + "Titular"
                + Titular
                + "Saldo"
                + Saldo.ToString("F3", CultureInfo.InvariantCulture);


        }
    }
}
