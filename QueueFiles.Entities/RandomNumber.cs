using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFiles.Entities
{
    internal class RandomNumber
    {
        public int randomNumber(int min, int max)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(min,max+1);
        }
    }
}
