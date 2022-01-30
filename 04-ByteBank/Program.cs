using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo Atual: " + contaDoBruno.saldo);
            contaDoBruno.Sacar(50);
            Console.WriteLine("Saldo Após o saquie: "+ contaDoBruno.saldo);
            Console.ReadLine();
        }
    }
}
