using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Queue<char> queue = new Queue<char>();
            foreach (char c in word)
            {
                queue.Enqueue(c);
            }
            bool a = true;
            for (int i = 0; i < queue.Count; i++)
            {
                char front = queue.Dequeue();
                for (int j = 0;j<queue.Count-1; j++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                char back = queue.Dequeue();
                if (front != back)
                {
                    a = false;
                    break;
                }
                queue.Enqueue(front);
            }
            if(a)
            {
                Console.WriteLine($"{word} is parindrom");
            }
            else
            {
                Console.WriteLine($"{word} is not parindrom");
            }

        }
    }
}
