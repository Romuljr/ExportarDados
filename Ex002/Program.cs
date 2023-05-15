using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex002.Entities;
using Ex002.Repositories;
using Ex002.Inputs;


namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("\n ~ EXPORTADOR DE DADOS ~ \n");

			try
			{
                var produto = new Produto();
                produto.IdProduto = Guid.NewGuid();
                produto.Nome = ProdutoInput.LerNome();
                produto.Preco = ProdutoInput.LerPreco();
                produto.Quantidade = ProdutoInput.LerQuantide();

                Console.Write("\nINFORME O TIPO DE ARQUIVO QUE VOCÊ DESEJA GERAR [JSON/XML]");
                var tipo = Console.ReadLine();

                if (tipo.Equals("xml", StringComparison.OrdinalIgnoreCase))
                {
                    var produtoRepositoryXML = new ProdutoRepositoryXML();
                    produtoRepositoryXML.Exportar(produto);

                    Console.WriteLine("ARQUIVO XML GERADO COM SUCESSO");
                }
                else if (tipo.Equals("json", StringComparison.OrdinalIgnoreCase))
                {
                    var produtoRepositoryJSON = new ProdutoRepositoryJSON();
                    produtoRepositoryJSON.Exportar(produto);

                    Console.Write("ARQUIVO JSON CRIADO COM SUCESSO");
                }

                else
                {

                }
                    
            }
			catch (Exception e)
			{

				Console.WriteLine("OCORREU UM ERRO: " + e.Message); 
			}

			Console.ReadKey();
        }
    }
}
