using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Enqueue(5);
            numbers.Enqueue(6);
            numbers.Enqueue(7);
            numbers.Enqueue(8);
            numbers.Enqueue(9);
            numbers.Enqueue(10);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            int[] n = new int[10];
            int index = 0;
            while (numbers.Count > 0)
            {
                n[index++] = numbers.Dequeue();
            }
            for (int i = n.Length - 1; i >= 0; i--)
            {
                Console.Write(n[i] + " ");
            }
        }
    }
}
