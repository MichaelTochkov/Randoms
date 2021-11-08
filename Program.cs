using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 17);
            }
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.ReadLine();
        }
    }
}
