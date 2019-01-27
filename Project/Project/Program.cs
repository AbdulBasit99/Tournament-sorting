using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        public int min;
        static void Main(string[] args)
        {
            Program p = new Program();
            int n;
            Console.Write("How many Elements You Want to Sort: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] arr= new int[2*n+1];
            for (int i = n; i < 2*n; i++)
            {
                    Console.Write("Element-[{0}]: ", i-n);
                    arr[i] = Convert.ToInt16(Console.ReadLine());

            }
            p.min = arr[n-1];
            for (int j = 2 * n - 2; j >= 1; j -= 2)
                arr[j / 2] = p.max(arr[j], arr[j + 1]);

            Console.WriteLine("/nSorted Array Is: ");
            for (int i = 1; i <= n; i++)
             {
               Console.WriteLine(arr[i]);
               p.GetNext(arr, p.min, n);
             } 

        }

            public void GetNext(int[] arr, int min, int n)
            {
                int i = 2;
                for (i = 2; i <= 2 * n - 1;)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        arr[i] = min;
                        i = (i + 1) * 2;

                    }
                    else
                    {
                        arr[i+1] = min;
                        i = i * 2;
                    }
                }
                for (i = i / 2; i >= 1; i = i / 2)
                {
                    if (i % 2 == 0)
                        arr[i / 2] = max(arr[i], arr[i + 1]);

                    else
                        arr[i / 2] = max(arr[i], arr[i - 1]);
                }
            }
            public int max(int a, int b)
            {
                if (a > b)
                {
                    if (min > b)
                        min = b;
                    return a;
                }
                else
                {
                    if (min > a)
                        min = a;
                    return b;
                }
            }
        }
    }
