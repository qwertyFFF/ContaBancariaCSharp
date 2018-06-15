using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int numero { get; private set; }
        public string titular { get; set; }
        public double saldo { get; private set; }

        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        //Método para depositar na conta uma quantia
        public void Depositar(double quantia)
        {
            saldo = saldo + quantia;
        }

        //Método para sacar uma quantia da conta + taxa (5 reais por saque)
        public void Sacar(double quantia)
        {
            saldo = (saldo - quantia) - 5.00;
        }

        //Método para informar os dados atuais da conta
        public override string ToString()
        {
            return "Número da conta: " + numero + ", Titular da conta: " + titular + ", Saldo: $ " + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
