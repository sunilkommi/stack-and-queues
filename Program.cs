using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queues
{
    class Program
    {
        static void Main(string[] args)
        {
           // StackDemo();
            QueueDemo();
        }
        static void StackDemo()
        {
            Stack<int> stac = new Stack<int>();
            stac.Push(10);
            stac.Push(20);
            stac.Push(30);
            stac.Push(40);
            stac.Push(50);

            int length = stac.Count;
            Console.WriteLine("traversing stack");
            for(int i=1;i<=length;i++)
            {
                Console.WriteLine(stac.Pop());
            }
        }
        static void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine("peek:" + queue.Peek());
            Console.WriteLine("dequeue:" + queue.Dequeue());
            Console.WriteLine("peek:" + queue.Peek());

        }

    }
}
