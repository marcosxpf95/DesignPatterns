using System;

namespace TemplatePattern
{
    public class Mkv : VideoPlayer
    {
        public override void DecodificarVideo(string FileName)
        {
            Console.WriteLine($"Arquivo {FileName} decodificado para Mkv");
        }
    }
}