using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Ex002.Entities;

namespace Ex002.Repositories
{
    public class ProdutoRepositoryJSON
    {
        public void Exportar(Produto produto)
        {
            var json = JsonConvert.SerializeObject(produto, Formatting.Indented);

            var nomeArquivo = $"c:\\temp\\produto_{produto.Nome}.json";

            using ( var streamWriter = new StreamWriter(nomeArquivo))
            {
                streamWriter.WriteLine(json);
            }
        }

    }
}
