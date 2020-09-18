using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MinerTemplate
{
    public abstract class Miner
    {
        public string FileName;
        public Miner(string fileName)
        {
            this.FileName = fileName;
        }

        public void StartToMiner()
        {
            LoadFile();
            MinerData();
        }

        public abstract void LoadFile();
        public abstract void MinerData();
    }
}
