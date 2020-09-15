using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {               
            VideoPlayer videoPlayer;

            videoPlayer = new Mkv();
            
            videoPlayer.PlayVideo("MKv");

            videoPlayer = new MP4();

            videoPlayer.PlayVideo("MP4");   
        }
    }
}
