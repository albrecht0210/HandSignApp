using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandSignApp
{
    public static class NetworkHelper
    {
        private static readonly Random rand = new Random();

        public static double GetRandomNumber()
        {
            return rand.Next(-1000, 1000) / 2000;
        }
    }
}
