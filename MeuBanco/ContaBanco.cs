using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    public class ContaBanco
    {
        public string Numero { get; }
        public string Dono { get; set; }
        public decimal Saldo
        {
            get
            {
                decimal saldo = 0;
                foreach (var item in todasTransacoes)
                {
                    saldo += item.Valor;
                }
                return saldo;
            }
        }

        public static int numeroConta = 1234567890;

        private List<Transacao> todasTransacoes = new List<Transacao>();


        public ContaBanco(string nome, decimal valor)
        {
            this.Dono= nome;
            this.Saldo= valor;

            numeroConta++;

            this.Numero= numeroConta.ToString();
        }
        public void Depositar()
        {
        }
        public void Sacar()
            {

            
        }
    }
}
