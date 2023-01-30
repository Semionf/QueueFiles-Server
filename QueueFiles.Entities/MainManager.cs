using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QueueFiles.Entities
{
    public class MainManager
    {
        private static readonly MainManager _Instance = new MainManager();
        private MainManager() {
        
        }

        public static MainManager Instance { get { return _Instance; } }

        public MyQueue MyQueue;
        public void Init()
        {
            MyQueue = new MyQueue();
        }

       public int randomNum(int min, int max)
        {
            RandomNumber rnd = new RandomNumber();
            return rnd.randomNumber(min, max);
        }
    }
}
