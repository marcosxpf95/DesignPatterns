using Loja;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arquivo
{
    public interface Arquivo
    {
        public string diretorio { get; set; }
        public string PegarArquivo();
        public void GerarArquivo(Compra compra);
        public Compra ConverterArquivoEmObj();
    }
}
