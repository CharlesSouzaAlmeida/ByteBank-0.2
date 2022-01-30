using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela Costa";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo referência: "+(contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmVez));

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Atribuir a referencia das duas contas: "+(contaDaGabriela == contaDaGabrielaCosta));
            // Ambas a variaveis apontam pro mesmo objeto 
            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabrielaCosta.saldo);
            Console.WriteLine(contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
