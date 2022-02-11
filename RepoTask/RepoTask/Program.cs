using System;
using System.Linq;

namespace RepoTask
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] array = new[] { 1, 12, 38, 49, 5, 6, 7, 86, 9 };
            var maxNumber = array.Max();
            Console.WriteLine("Max Number Of this Array:"+maxNumber);
        }
    }
}
