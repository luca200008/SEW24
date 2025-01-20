using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_ReactionTime
{
    internal class Stopwatch
    {
        private DateTime ;

        public Stopwatch()
        {
            start = DateTime.Now;
        }

        public TimeSpan Elapse()
        {
            return DateTime.Now - start;

        }
    }
}
