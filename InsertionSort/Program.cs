using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6;
            num1 = 15;
            num2 = 10;
            num3 = 2;
            num4 = 1;
            num5 = 7;
            num6 = 5;

            List<int> unOrderedList = new List<int> { num1, num2, num3, num4, num5, num6 };
            Console.WriteLine("Will sort unordered array: [ {0} {1} {2} {3} {4} {5} ]", num1, num2, num3, num4, num5, num6);
            Console.WriteLine("-----------------------------");
            Console.Write("To ordered ascending array: ");

            int key;

            

            for(int j = 1; j < unOrderedList.Count; j++)
            {
                key = unOrderedList[j];
            
                int i = j - 1;

                while(i >= 0 && unOrderedList[i] > key)
                {
                    unOrderedList[i + 1] = unOrderedList[i];
                    i = i - 1;
                   
                }
                unOrderedList[i + 1] = key;
            }

            Console.Write("[ ");
            foreach(int num in unOrderedList)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine("] ");


        }
    }
}
