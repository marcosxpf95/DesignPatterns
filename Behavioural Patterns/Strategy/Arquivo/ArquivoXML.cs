using Loja;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Arquivo
{
    public class ArquivoXML : Arquivo
    {
        public string diretorio { get; set; }

        public ArquivoXML(string diretorio)
        {
            this.diretorio = diretorio;
        }

        public Compra ConverterArquivoEmObj()
        {
            try
            {
                FileStream stream = new FileStream(diretorio + "//Compra.xml", FileMode.Open);                
                
                XmlSerializer desserializador = new XmlSerializer(typeof(Compra));
                
                Compra compra = (Compra)desserializador.Deserialize(stream);
                
                stream.Close();

                return compra;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            return null;
        }

        public void GerarArquivo(Compra compra)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(Compra));
                var path = diretorio + "//Compra.xml";

                FileStream file = File.Create(path);

                writer.Serialize(file, compra);
                
                file.Close();            
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        public string PegarArquivo()
        {
            string arquivo = string.Empty;

            try
            {
                arquivo = File.ReadAllText(diretorio + "//Compra.xml");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            return arquivo;
        }
    }
}
