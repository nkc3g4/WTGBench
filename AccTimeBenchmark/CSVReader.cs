using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccTimeBenchmark
{
    class CSVReader
    {
        public static Scenario Read(string fileName)
        {
            Scenario sce = new Scenario();
            var reader = new StreamReader(File.OpenRead(fileName));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                List<int> IOSizes = new List<int>();
                for(int i = 0; i < 10; i++)
                {
                    int iosize = int.Parse(values[i]);
                    if (iosize > 16777216)
                        iosize = 16777216;
                    IOSizes.Add(iosize);
                }
                float writeProportion = float.Parse(values[10]);
                float seqNess = float.Parse(values[11]);
                int threads = int.Parse(values[12]);
                if (threads > 32)
                    threads = 32;
               
                Scenario.TestLine testLine = new Scenario.TestLine(IOSizes.ToArray(),writeProportion,seqNess, threads);
                sce.TestLines.Add(testLine);
            }
            return sce;
        }
    }

}
