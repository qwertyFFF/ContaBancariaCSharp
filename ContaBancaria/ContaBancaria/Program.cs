using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            char escolha;
            double valorInicial = 0.00;
            int operacao = 0;
            int numConta;
            string nomeTit;
            double dep, saq;

            

            Console.WriteLine("------------------------------");
            Console.WriteLine("---BEM VINDO AO BANCO TESTE---");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Criar conta\n2 - Depositar\n3 - Sacar\n4 - Informações da conta\n0 - Sair");
            Console.WriteLine();

            do
            {
                Console.Write("Qual o operação deseja realizar: ");
                operacao = int.Parse(Console.ReadLine());



                switch (operacao)
                {
                    case 1:
                        //Criação da conta
                        Conta conta1;

                        //Informar os dados da conta para ser criada
                        Console.Write("Digite o número da conta: ");
                        numConta = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do titular da conta: ");
                        nomeTit = Console.ReadLine();

                        //Informar se o usuário quer ou não depositar um valor inicialmente
                        Console.Write("Haverá depósito inicial (s/n)? ");
                        escolha = char.Parse(Console.ReadLine());
                        Console.WriteLine();

                            //Valida se o usuário quer depositar o valor inicial na criação da conta
                            if (escolha == 's')
                            {
                                Console.Write("Digite o valor do depósito inicial: ");
                                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                Console.WriteLine();
                            }

                        //Mostra na tela os dados da conta
                        Console.WriteLine(">>>>>>>>>Conta criada<<<<<<<<<");
                        conta1 = new Conta(numConta, nomeTit, valorInicial);
                        Console.WriteLine(conta1);

                        Console.ReadLine();
                        break;

                    case 2:
                        //Informar um valor para depositar na conta
                        Console.WriteLine();
                        Console.Write("Digite um valor para depósito: ");
                        dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta1.Depositar(dep);

                        //Atualiza a conta conforme o depósito na conta
                        Console.WriteLine();
                        Console.WriteLine(">>>>>>>>>Conta atualizada<<<<<<<<<");
                        Console.WriteLine(conta1);

                        Console.ReadLine();
                        break;

                    case 3:
                        //Informar um valor para sacar da conta
                        Console.WriteLine();
                        Console.Write("Digite um valor saque: ");
                        saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta1.Sacar(saq);

                        //Atualiza a conta conforme o saque da conta
                        Console.WriteLine();
                        Console.WriteLine(">>>>>>>>>Conta atualizada<<<<<<<<<");
                        Console.WriteLine(conta1);
                        Console.ReadLine();
                        break;
                }
            }
            while (operacao != 0);

            //Informar um valor para sacar da conta
            //Console.WriteLine();
            //Console.Write("Digite um valor saque: ");
            //saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //conta1.Sacar(saq);

            //Atualiza a conta conforme o saque da conta
            //Console.WriteLine();
            //Console.WriteLine(">>>>>>>>>Conta atualizada<<<<<<<<<");
            //Console.WriteLine(conta1);

            //Aguarda o usuário finalizar o acesso a conta
            //Console.ReadLine();
        }
    }
}
