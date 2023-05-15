using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex002.Entities;
using System.Xml.Serialization;
using System.IO;

namespace Ex002.Repositories
{
    public class ProdutoRepositoryXML
    {
        public void Exportar(Produto produto)
        {
            var xml = new XmlSerializer(produto.GetType());

            var nomeArquivo = $"c:\\temp\\produto_{produto.Nome}.xml";

            using (var streamWriter = new StreamWriter(nomeArquivo))
            {
                xml.Serialize(streamWriter, produto);
            }
        }
    }
}
