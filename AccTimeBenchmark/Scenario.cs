using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccTimeBenchmark
{
    public class Scenario
    {
        public Scenario()
        {
            TestLines = new List<TestLine>();
        }
        public class TestLine
        {
            public TestLine()
            {

            }
            public TestLine(int[] IO, float wp, float seq,int t)
            {
                IOSizes = IO;
                WriteProportion = wp;
                SeqNess = seq;
                Threads = t;
            }
            public int[] IOSizes { get; set; }
            public float WriteProportion { get; set; }
            public float SeqNess { get; set; }
            public int Threads { get; set; }
        }
        public List<TestLine> TestLines { get; set; }
    }
}
