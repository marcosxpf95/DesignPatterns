using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileContent = string.Empty;
            string fileContent2 = string.Empty;
            
            string file = @"C:\Users\User\Documents\Dev_pessoal\DesignPatterns\Behavioural Patterns\SingletonPattern\SingletonPattern\SingletonPattern\arquivoConfig.txt";

            FileConfig fileConfig = FileConfig.getFileConfig();


            //Reading and writing... 1st time.

            fileContent = fileConfig.readFileContent(file);

            fileConfig.writeFile(file, "Writing the first Time");

            fileContent = fileConfig.readFileContent(file);

            Console.WriteLine($"File content {fileContent}");

            //Reading and writing... 2nd time.
            FileConfig fileConfig2 = FileConfig.getFileConfig();

            fileContent2 += fileConfig.readFileContent(file);

            fileContent2 += "Writing the second Time";

            fileConfig2.writeFile(file, fileContent2);

            fileContent2 = fileConfig.readFileContent(file);

            Console.WriteLine($"File content {fileContent2}");

        }
    }
}
