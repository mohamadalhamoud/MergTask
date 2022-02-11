using System;
using System.Linq;

namespace RepoTask
{
    class Program
    {
        public static int SumEvenNum(int [] arrayNum)
        {
            int result = 0;
            for(int i=0;i<arrayNum.Length;i++)
            {
                if(arrayNum[i]%2==0)
                {
                    result += arrayNum[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
           
            int[] array = new[] { 1, 12, 8, 7, 5, 6, 9 };
            var maxNumber = array.Max();
            Console.WriteLine("Max Number Of this Array:"+maxNumber);
            Console.WriteLine(SumEvenNum(array));
        }
    }
}
