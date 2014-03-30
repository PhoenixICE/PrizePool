using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizePool
{
    public class PoolUsers
    {
        public string user { get; set; }
        public int pool { get; set; }
        public bool usepoolmax { get; set; }
        public int poolmax { get; set; }
        public DateTime time;
        public PoolUsers(string s, int d, DateTime t, bool b = false, int i = 0)
        {
            user = s;
            pool = d;
            time = t;
            usepoolmax = b;
            poolmax = 0;
        }
    }
}
