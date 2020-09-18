using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MinerTemplate
{
    public class Txt : Miner
    {
        public Txt(string fileName) : base(fileName)
        {
        }

        public override void LoadFile()
        {
            Console.WriteLine($"{FileName}.txt of the type txt is being loading...");
            Thread.Sleep(2000);
            Console.WriteLine($"{FileName}.txt was imported");
        }

        public override void MinerData()
        {
            for (int cont = 0; cont < 100; cont++)
            {
                Console.WriteLine($"{FileName}.txt minering {cont}%... \n");
                Thread.Sleep(25);
            }
            Console.WriteLine($"{FileName}.txt was minered with success.");
            Thread.Sleep(2000);
        }
    }
}
