using Loja;
using System;

namespace Arquivo
{
    class Program
    {        
        static string DIRETORIO = "file";
        static GerenciadorArquivoCompra gerenciadorArquivoXml = new GerenciadorArquivoCompra(new ArquivoXML(DIRETORIO));
        static GerenciadorArquivoCompra gerenciadorArquivoJson = new GerenciadorArquivoCompra(new ArquivoJson(DIRETORIO));     
        static void Main(string[] args)
        {
            Compra compra = null;
            
            
            while(true)
            {
                gerarMenu();
                
                try
                {
                    var opcao = Convert.ToInt32(Console.ReadLine());
                    processarOpcao(ref compra, opcao);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Não foi possível capturar opção selecionada. Motivo: " + ex.Message);
                    Console.Clear();
                    continue;
                }                               
            }
        }

        private static void processarOpcao(ref Compra compra, int opcao)
        {                                   
            switch(opcao)
            {
                case 1:
                    if (compra == null)
                    {
                        compra = iniciarCompra();                    
                        Console.WriteLine("Compra iniciada com sucesso"); 
                    }
                    else
                        Console.WriteLine("Já existe compra iniciada");
                                    
                    break;

                case 2:                    
                    compra = gerenciadorArquivoXml.RetornarCompraDeArquivo();
                    
                    if (compra != null)
                        Console.WriteLine("Dados carregados com sucesso.\nDados do Arquivo:\n" + gerenciadorArquivoXml.RecuperarTextoArquivoDeCompra());                            
                    
                    break;

                case 3:
                    compra = gerenciadorArquivoJson.RetornarCompraDeArquivo();

                    if (compra != null)
                        Console.WriteLine("Dados carregados com sucesso.\n Dados do Arquivo \n" + gerenciadorArquivoJson.RecuperarTextoArquivoDeCompra());

                    break;

                case 4:
                    if (compra != null)
                        alterarValor(compra);

                    break;

                case 5:
                    if (compra != null)
                        Console.WriteLine($"R$ {compra.valor}");

                    break;


                case 6:
                    if (compra != null)
                        gerenciadorArquivoXml.GerarArquivoDeCompra(compra);

                    break;

                case 7:
                    if (compra != null)
                        gerenciadorArquivoJson.GerarArquivoDeCompra(compra);

                    break;

                case 8:
                    compra = null;
                    break;
                case 0:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção não existe");
                    break;
            }
        }

        private static void alterarValor(Compra compra)
        {
            Console.WriteLine("Novo valor compra:");
            compra.setValor(Convert.ToDouble(Console.ReadLine()));
        }

        private static Compra recuperarCompraArquivoXml()
        {
            return gerenciadorArquivoXml.RetornarCompraDeArquivo();
        }

        private static Compra iniciarCompra()
        {
            Compra compra = null;
            Console.WriteLine("1-Desconto Natal");
            Console.WriteLine("2-Desconto Pascoa");

            int tipoDesconto = Convert.ToInt32(Console.ReadLine());

            if (tipoDesconto == 1)
                compra = new Compra(new DescontoNatal());
            else if (tipoDesconto == 2)
                compra = new Compra(new DescontoPascoa());

            return compra;
        }

        public static void gerarMenu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("1-INICIAR COMPRA");
            Console.WriteLine("2-RECUPERAR COMPRA ARQUIVO XML");
            Console.WriteLine("3-RECUPERAR COMPRA ARQUIVO JSON");
            Console.WriteLine("4-ALTERAR VALOR COMPRA");
            Console.WriteLine("5-EXIBIR VALOR COMPRA");
            Console.WriteLine("6-GRAVAR COMPRA EM ARQUIVO XML");
            Console.WriteLine("7-GRAVAR COMPRA EM ARQUIVO JSON");
            Console.WriteLine("8-FINLIZAR COMPRA");
            Console.WriteLine("0-LIMPAR TELA");
        }

    }
}
