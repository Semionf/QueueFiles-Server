using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueFiles.MODEL;

namespace QueueFiles.Entities
{
    public class MyQueue
    {
        private Queue<Item> myQueue = new Queue<Item>();

        public Item Pop()
        {
            if(myQueue.Count == 0) return null;
            return myQueue.Dequeue();
        }

        public void Push(Item newItem)
        {
            this.myQueue.Enqueue(newItem);
        }
    }
}
