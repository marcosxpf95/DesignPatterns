using System;
namespace TemplatePattern
{
    public abstract class VideoPlayer
    {
        public string FileName { get ; set; }
        
        
        public VideoPlayer(){}
        
        public void PlayVideo(string FileName)
        {
            LoadFile(FileName);
            DecodificarVideo(FileName);
            IniciarPlayer(FileName);
        }

        public virtual void LoadFile(string FileName)
        {
            Console.WriteLine($"Arquivo {FileName} Carregado com sucesso");
        }

        public virtual void IniciarPlayer(string FileName)
        {
            Console.WriteLine($"Arquivo {FileName} iniciado no modo padrão");
        }

        public abstract void DecodificarVideo(string FileName);
    }
}