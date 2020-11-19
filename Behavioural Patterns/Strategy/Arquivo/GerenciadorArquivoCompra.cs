using Loja;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arquivo
{
    public class GerenciadorArquivoCompra
    {
        private Arquivo arquivo { get; set; }
        public GerenciadorArquivoCompra(Arquivo arquivo)
        {
            this.arquivo = arquivo;
        }

        public Compra RetornarCompraDeArquivo()
        {
            Compra compra = arquivo.ConverterArquivoEmObj();

            return compra;
        }

        public void GerarArquivoDeCompra(Compra compra)
        {
            arquivo.GerarArquivo(compra);
        }

        public string RecuperarTextoArquivoDeCompra()
        {
            return arquivo.PegarArquivo();
        }
    }
}
