using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg_string_KeypadTyping
{
    class Keypad
    {
        // char[] c;
        public string s;
        public void GenerateCode()
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]<=111)
                {
                    int c = (s[i] - 97) / 3;
                    Console.Write(c + 2);
                }
                else
                if (s[i]>111&& s[i]<=115)
                {
                    Console.Write('7');
                }
                else
                if (s[i] > 115 && s[i] <= 118)
                {
                    Console.Write('8');
                }
                else
                if (s[i] > 118 && s[i] <= 122)
                {
                    Console.Write('9');
                }
            }
            Console.WriteLine();
        }
    }
    class gfg_KeypadTyping
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            Keypad[] k = new Keypad[test];
            for (int i = 0; i < test; i++)
            {
                k[i] = new Keypad();
                k[i].s = Console.ReadLine();
            }
            for (int i = 0; i < test; i++)
            {
                k[i].GenerateCode();
            }
            Console.Read();
        }
    }
}
