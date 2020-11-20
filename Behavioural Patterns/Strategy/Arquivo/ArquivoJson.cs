using Loja;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Arquivo
{
    public class ArquivoJson : Arquivo
    {        
        public string diretorio { get; set; }
        public ArquivoJson(string diretorio)
        {
            this.diretorio = diretorio;
        }

        public Compra ConverterArquivoEmObj()
        {            
            try
            {
                var jsonString = File.ReadAllText(diretorio + "//Compra.json");

                if (!string.IsNullOrEmpty(jsonString))                
                    return JsonSerializer.Deserialize<Compra>(jsonString);                    
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);                
            }

            return null;
        }

        public void GerarArquivo(Compra compra)
        {
            try
            {
                var path = diretorio + "//Compra.json";

                using (FileStream file = File.Create(path))
                {
                    file.Close();
                }

                var json = JsonSerializer.Serialize(compra);

                using (StreamWriter writer = new StreamWriter(diretorio + "//Compra.json", true))
                {
                    writer.WriteLine(json);
                    writer.Close();
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public string PegarArquivo()
        {
            string arquivo = string.Empty;

            try
            {
                 arquivo = File.ReadAllText(diretorio + "//Compra.json");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            return arquivo;
        }
    }
}
