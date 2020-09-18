using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MinerTemplate
{
    public class Word : Miner
    {
        public Word(string fileName) : base(fileName)
        {
        }

        public override void LoadFile()
        {
            Console.WriteLine($"{FileName}.docx of the type Word is being loading...");
            Thread.Sleep(2000);
            Console.WriteLine($"{FileName}.docx was imported");
        }

        public override void MinerData()
        {
            for (int cont = 0; cont < 100; cont++)
            {
                Console.WriteLine($"{FileName}.docx minering {cont}%... \n");
                Thread.Sleep(25);
            }
            Console.WriteLine($"{FileName}.docx was minered with success.");
            Thread.Sleep(2000);
        }
    }
}
