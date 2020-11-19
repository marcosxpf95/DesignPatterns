using Loja;
using System;

namespace Arquivo
{
    class Program
    {        
        static string DIRETORIO = "file";        
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
                        compra = iniciarCompra();                    
                    else
                        Console.WriteLine("Já existe compra iniciada");

                    Console.WriteLine("Compra iniciada com sucesso");                    
                    break;

                case 2:                    
                    compra = recuperarCompraArquivoXml();
                    
                    if (compra != null)
                    {
                        Console.WriteLine("Dados carregados com sucesso.\nDados do Arquivo:\n" + recuperarTextoArquivoXml());                            
                    }
                    break;

                case 3:
                    Console.WriteLine("not implemented");
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
                        gravarCompraArquivoXML(compra);

                    break;

                case 7:
                    Console.WriteLine("not implemented");

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

        private static string recuperarTextoArquivoXml()
        {
            GerenciadorArquivoCompra gerenciadorArquivoCompraXML = new GerenciadorArquivoCompra(new ArquivoXML(DIRETORIO));
            return gerenciadorArquivoCompraXML.RecuperarTextoArquivoDeCompra();
        }

        private static void gravarCompraArquivoXML(Compra compra)
        {
            GerenciadorArquivoCompra gerenciadorArquivoCompraXML = new GerenciadorArquivoCompra(new ArquivoXML(DIRETORIO));
            gerenciadorArquivoCompraXML.GerarArquivoDeCompra(compra);
        }

        private static void alterarValor(Compra compra)
        {
            Console.WriteLine("Novo valor compra:");
            compra.setValor(Convert.ToDouble(Console.ReadLine()));
        }

        private static Compra recuperarCompraArquivoXml()
        {
            GerenciadorArquivoCompra gerenciadorArquivoCompraXML = new GerenciadorArquivoCompra(new ArquivoXML(DIRETORIO));
            return gerenciadorArquivoCompraXML.RetornarCompraDeArquivo();
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
            Console.WriteLine("\t---MENU---");
            Console.WriteLine("\t1-INICIAR COMPRA");
            Console.WriteLine("\t2-RECUPERAR COMPRA ARQUIVO XML");
            Console.WriteLine("\t3-RECUPERAR COMPRA ARQUIVO JSON");
            Console.WriteLine("\t4-ALTERAR VALOR COMPRA");
            Console.WriteLine("\t5-EXIBIR VALOR COMPRA");
            Console.WriteLine("\t6-GRAVAR COMPRA EM ARQUIVO XML");
            Console.WriteLine("\t7-GRAVAR COMPRA EM ARQUIVO JSON");
            Console.WriteLine("\t8-FINLIZAR COMPRA");
            Console.WriteLine("\t0-LIMPAR TELA");
        }

    }
}
