using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoInterativaOrientacaoObjeto_.Exceptions;

namespace TaoInterativaOrientacaoObjeto_.Model
{
    public class Conta
    {
        public int NumeroConta {get; set; }
        public Cliente Titular { get; set; }
        public  string NumeroCartao {get;  set; }
        public double saldo { get;  set; }
        public string agencia { get; set; }


        public Conta(Cliente titular, string numeroCartao, int numeroConta, string agencia, double saldo )
        {
            this.Titular = titular;
            this.NumeroCartao = numeroCartao;
            this.NumeroConta = numeroConta;
            this.agencia = agencia;
            this.saldo = saldo;
        }
       
        public Conta(double Deposito)
        {
            Depositar(Deposito);
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public double RetornarSaldo()
        {
            return this.saldo;
        }

        public void Transferir(Conta destino, double valor)
        {
            try
            {
                if (valor > this.saldo)
                    throw new SaldoInsuficienteException();
                this.saldo -= valor;
                destino.saldo += valor;
                Console.WriteLine("\n Transferência Realizada com sucesso! \n");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }

        public void Sacar(double valor)
        {
            if (valor > this.saldo)
                throw new SaldoInsuficienteException();
            this.saldo -= valor;
        }

        public string GetInfo()
        {
            return "O Titular " + this.Titular.Nome + "\n com o " + "CPF " + this.Titular.CPF + ", possui " +
                   "Saldo " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", RetornarSaldo()) + ", na conta de numeração "+this.NumeroConta+".";
        }
    }
}
