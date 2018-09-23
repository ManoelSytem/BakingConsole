using System;
using TaoInterativaOrientacaoObjeto_.Servico;
using TaoInterativaOrientacaoObjeto_.Model;
using System.Threading;
using TaoInterativaOrientacaoObjeto_;
using System.Collections.Generic;

namespace TaoInterativaOrientacaoObjeto​
{
    class Program
    {
        static List<Conta> listconta;

        public static void Main(string[] args)
        {
            //Carregamento da Aplicação
            var spinner = new Spinner(10, 10);
            spinner.Start();
            Thread.Sleep(3000);
            spinner.Stop();


            Cliente Manoel = new Cliente("Manoel Carneiro de Oliveira Neto", "061124665-11");

            Cliente Steve = new Cliente("Steve", "061124665-11" );

            Conta CONTA_A = new Conta(Manoel, "15456",273589,"0684-x", 200);

            Conta CONTA_B = new Conta(100);

            CONTA_B.Titular = Steve;
            CONTA_B.NumeroCartao = "1546566";
            CONTA_B.NumeroConta = 124656;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("________________________BANCO CONSOLE______________________\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(CONTA_A.GetInfo());
            Console.WriteLine(CONTA_B.GetInfo());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ____________________BANCO TRÂNSFERÊNCIA SOLICITADA___1___________________\n\n");

            Console.WriteLine("Transferência CONTA_B para CONTA_A, valor R$ 50,00 \n");
            Console.WriteLine("Saldo Atual CONTA_B: "+CONTA_B.RetornarSaldo()+"\n");
            progresso();
            CONTA_B.Transferir(CONTA_A, 50);
            Console.WriteLine("Saldo Atual CONTA_B pós transferência: " + CONTA_B.RetornarSaldo() + "\n");
            Console.WriteLine("Saldo Atual CONTA_A pós transferência: " + CONTA_A.RetornarSaldo());

            Console.WriteLine("\n ____________________BANCO TRÂNSFERÊNCIA SOLICITADA___2___________________\n\n");

            Console.WriteLine("Transferência CONTA_B para CONTA_A, valor R$ 60,00 \n");
            Console.WriteLine("Saldo Atual CONTA_B: " + CONTA_B.RetornarSaldo() + "\nls");
            progresso();
            CONTA_B.Transferir(CONTA_A, 60);
            Console.WriteLine("Saldo Atual CONTA_B pós transferência: " + CONTA_B.RetornarSaldo() + "\n");
            Console.WriteLine("Saldo Atual CONTA_A pós transferência: " + CONTA_A.RetornarSaldo());


            Console.WriteLine("\n ____________________BANCO CONSOLE CRIANDO CONTA______________________\n\n");
            Console.WriteLine("\n Tecle Enter para inicia a operação \n\n");
            Console.ReadKey();


            Console.WriteLine("\n CRIANDO 5 CONTAS BANCÁRIAS... \n\n");

            progresso();
            Cliente Joao = new Cliente("Joao Batista oliveira", "063.718.100-06");
            Cliente Pedro = new Cliente("Pedro Galo Canta", "889.073.160-58");
            Cliente Marcos = new Cliente("Macos Vieira Souza", "156.425.360-01");
            Cliente Tiago = new Cliente("Tiago da Paz Santo", "100.475.140-00");
            Cliente kleber = new Cliente("Kleber Dias Dos Santos", "100.475.140-00");


            Conta CONTA_C = new Conta(Joao, "4545", 56899, "56686", 300);
            Conta CONTA_D = new Conta(Pedro, "57757", 75775, "855577", 300);
            Conta CONTA_E= new Conta(Marcos, "89544", 85757, "85775", 300);
            Conta CONTA_F = new Conta(Tiago, "89645", 8675, "85756", 300);
            Conta CONTA_G = new Conta(kleber, "85668", 8556, "65636", 300);

            Console.WriteLine("\n Contas criada com sucesso!... \n\n");

            Console.WriteLine("\n Listando Contas... \n\n");
            listconta = new List<Conta>();
            listconta.Add(CONTA_C);
            listconta.Add(CONTA_D);
            listconta.Add(CONTA_E);
            listconta.Add(CONTA_F);
            listconta.Add(CONTA_G);

            progresso();
          
            foreach (Conta c in listconta)
            {
                Console.WriteLine("\n"+c.GetInfo());
            }
            Sobre();
            Console.ReadKey();
        }

        public static void Sobre()
        {
            Console.WriteLine("\n Analista de Sistemas: Manoel Neto \n " +
                "Projetos e Desenvolvimento de Sistemas. www.SoftwMicro.com.br");
        }

        public static void progresso()
        {
            var spinner = new Spinner(10, 10);
           
            int count = 0;
            for (int i = 0; i < 3000; i++)
            {

                spinner.progreso(i, 3000);
                count++;
            }

            spinner.progreso(100, 100);

        }
    }
}
