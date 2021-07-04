using System;
using System.Collections.Generic;
using System.Linq;

namespace FairRation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> citList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = fairRations(citList);
            if (result == -1)
            {
                Console.WriteLine("NO");

            }
            else 
                Console.WriteLine(result);

        }

        private static int fairRations(List<int> citList)
        {
            int distCount = 0;
            for (int i = 0; i < citList.Count-1; i++)
            {
                if(citList[i] % 2 == 1)
                {
                    citList[i]++;
                    citList[i + 1]++;

                    distCount += 2;

                }

                while(i<citList.Count-1 && citList[i+1] % 2 == 0)
                {
                    i++;
                }             

            }
            if (citList[citList.Count - 1] % 2 == 1)
            {
                return -1;
            }
            else
            {
                return distCount;
            }

        }
    }
}
