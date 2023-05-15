using Ex002.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex002.Inputs
{
    public class ProdutoInput
    {
        public static string LerNome()
        {

            Console.Write("DIGITE O NOME DO PRODUTO: ");
            return Console.ReadLine();
        }

        public static decimal LerPreco()
        {
            Console.Write("DIGITE O PREÇO DO PRODUTO: ");
            return decimal.Parse(Console.ReadLine());

        }

        public static int LerQuantide()
        {
            Console.Write("DIGITE A QUANTIDADE DO PRODUTO: ");
            return int.Parse(Console.ReadLine());

        }
    }
}
