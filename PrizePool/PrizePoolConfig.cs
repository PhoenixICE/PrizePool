using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrizePool
{
    public class PrizePoolConfig
    {
        public int defaultAmount = 1000;
        public int daysrefresh = 1;
        public List<PoolUsers> PrizePoolUsers = new List<PoolUsers>();
        public static PrizePoolConfig Read(string path)
        {
            if (!File.Exists(path))
                return new PrizePoolConfig();
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return Read(fs);
            }
        }
        public static PrizePoolConfig Read(Stream stream)
        {
            using (var sr = new StreamReader(stream))
            {
                var cf = JsonConvert.DeserializeObject<PrizePoolConfig>(sr.ReadToEnd());
                if (ConfigRead != null)
                    ConfigRead(cf);
                return cf;
            }
        }

        public void Write(string path)
        {
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                Write(fs);
            }
        }

        public void Write(Stream stream)
        {
            var str = JsonConvert.SerializeObject(this, Formatting.Indented);
            using (var sw = new StreamWriter(stream))
            {
                sw.Write(str);
            }
        }
        public static Action<PrizePoolConfig> ConfigRead;
    }
}