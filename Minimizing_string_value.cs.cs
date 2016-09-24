using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg_string_Minimizing_string_value
{
    class Array
    {
        public string arr;
        public int k;
        public void AssignValue()
        {
            int ktemp = k;
            int[] val = new int[26];
            for (int i = 0; i < arr.Length; i++)
            {
                val[arr[i] - 97]++;
            }
            for (int i = 0; i < val.Length; i++)
            {
                Console.Write(val[i]);
                Console.Write(" ");
            }
            int max = 0,maxIndex=0;
            while (ktemp != 00)
            {
                for (int i = 0; i < val.Length; i++)
                {
                    if(val[i]>max)
                    {
                        max = val[i];
                        maxIndex = i;
                    }
                }
                val[maxIndex]--;
                ktemp--;
            }
            Console.WriteLine();
            for (int i = 0; i < val.Length; i++)
            {
                Console.Write(val[i]);
                Console.Write(" ");
            }
            
            Console.WriteLine( Count(val));
            Console.Read();
        }
        public int Count(int[] v)
        {
            int c = 0;
            for (int i = 0; i < v.Length; i++)
            {
                c += (v[i] * v[i]);
            }
            return c;
        }


    }

    class Minimizing_string_value
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            Array[] a = new Array[t];
            for (int i = 0; i < t; i++)
            {
                a[i] = new Array();
                a[i].arr = Console.ReadLine();
                a[i].k = int.Parse(Console.ReadLine()); 
            }
            for (int i = 0; i < t; i++)
            {
                a[i].AssignValue();
            }
            Console.Read();
        }
    }
}
