using System;

namespace MeuBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuBanco.ContaBanco contaB = new ContaBanco("Diogo", 10000);
            Console.WriteLine($"conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo}");
        }
    }
}
