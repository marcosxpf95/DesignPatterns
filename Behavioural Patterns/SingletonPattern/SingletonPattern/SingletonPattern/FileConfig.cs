using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace SingletonPattern
{
    public class FileConfig
    {
        private static readonly FileConfig instance = new FileConfig();
        
        private FileConfig() { }

        public static FileConfig getFileConfig()
        {            
            return instance;
        }

        public string readFileContent(string file)
        {
            string str = "";
            if (File.Exists(file))
            {
                // Read all the content in one string 
                // and display the string 
                str = File.ReadAllText(file);
            }

            return str;
        }

        public void writeFile(string file, string text)
        {
            // To write all of the text to the file             
            File.WriteAllText(file, text);
        }

    }
}
