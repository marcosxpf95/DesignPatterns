using System;

namespace TemplatePattern
{
    public class MP4 : VideoPlayer
    {
        public override void DecodificarVideo(string FileName)
        {
            Console.WriteLine($"Arquivo {FileName} decodificado para MP4");
        }

        public override void IniciarPlayer(String FileName)
        {
            Console.WriteLine($"Arquivo {FileName} iniciado no modo particular para MP4");
        }
    }
}