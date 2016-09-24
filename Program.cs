using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg_string_Reverse_Strings
{
    class StrArray
    {
        public string[] s;
       

        public void Reverse()
        {
            string[] sReversed = new string[s.Length];
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < s.Length; i++)
            {
                sReversed[i] = s[s.Length-1 - i];
            }
            for (int i = 0; i < sReversed.Length-1; i++)
            {
                Console.Write(sReversed[i]+'.');

            }
            Console.WriteLine(sReversed[sReversed.Length-1]);
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StrArray[] str = new StrArray[t];
            for (int i = 0; i < t; i++)
            {
                str[i] = new StrArray();
                str[i].s = Console.ReadLine().Split('.');
            }
            for (int i = 0; i < t; i++)
            {
                str[i].Reverse();

            }
            Console.ReadLine();
        }
    }
}
