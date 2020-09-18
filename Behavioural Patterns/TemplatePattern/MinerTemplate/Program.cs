using System;

namespace MinerTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Miner wordMiner = new Word("arquivo");
            Miner excelMiner = new Excel("arquivo");
            Miner txtMiner = new Txt("arquivo");

            wordMiner.MinerData();
            excelMiner.MinerData();
            txtMiner.MinerData();
        }
    }
}
