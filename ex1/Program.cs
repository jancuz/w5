using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ex1
{
    class Program
    {
        static bool Is_Heap(int[] arr, int n)
        {
            for (int i = 1; i < n/2; i++)
            {
                int pos = 2 * i;
                if (pos <= n && arr[i] > arr[pos])
                    return false;
                else
                    if (pos + 1 <= n && arr[i] > arr[pos + 1])
                        return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            var input = new StreamReader("input.txt");
            var n = Convert.ToInt32(input.ReadLine()) + 1;
            var arrStr = input.ReadLine().Split().ToArray();
            var arr = new int[n];
            input.Close();

            for (int i = 1; i <= n-1; i++)
                arr[i] = Convert.ToInt32(arrStr[i - 1]);

            var output = new StreamWriter("output.txt");
            if (Is_Heap(arr, n))
                output.WriteLine("YES");
            else
                output.WriteLine("NO");
            output.Close();
        }
    }
}
