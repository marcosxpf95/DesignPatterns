using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MinerTemplate
{
    public class Excel : Miner
    {
        public Excel(string fileName) : base(fileName)
        {
        }

        public override void LoadFile()
        {
            Console.WriteLine($"{FileName}.xls of the type Excel is being loading...");
            Thread.Sleep(2000);
            Console.WriteLine($"{FileName}.xls was imported");
        }

        public override void MinerData()
        {
            for (int cont = 0; cont < 100; cont++)
            {
                Console.WriteLine($"{FileName}.xls minering {cont}%... \n");
                Thread.Sleep(25);
            }
            Console.WriteLine($"{FileName}.xls was minered with success.");
            Thread.Sleep(2000);
        }
    }
}
