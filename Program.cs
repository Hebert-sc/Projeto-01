using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Dono = "Fran";
            
            conta.setNumero("1234");
            conta.Limite = 100;


    // conta.Deposita(5000);

    conta.Saque(500);
    Console.WriteLine(conta.Dono + "Saldo apos Deposito " + conta.getSaldo());

   // conta.Saque(3500);
 //   Console.WriteLine("Saldo apos Saque " + conta.saldo);



        }
    }
}
