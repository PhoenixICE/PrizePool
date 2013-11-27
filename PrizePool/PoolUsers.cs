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
        public DateTime time;
        public PoolUsers(string s, int d, DateTime t)
        {
            user = s;
            pool = d;
            time = t;
        }
    }
}
