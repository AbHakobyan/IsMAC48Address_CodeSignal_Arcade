using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IsMAC48Address_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "00-1B-63-84-45-E6";
            bool v = isMAC48Address(s);
            Console.WriteLine(v);
        }

        static bool isMAC48Address(string inputString)
        { 
            string[] array = inputString.Split('-');
            char[] arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int count = 0;
            List<char> x = new List<char>();
            string v = "";
            for (int i = 0; i < array.Length; i++)
            {
                v += array[i];
            }
            for (int i = 0; i < v.Length; i++)
            {
                x.Add(v[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 6 && array[i].Length == 2)
                {
                    for (int j = 0; j < x.Count; j++)
                    {
                        for (int g = 0; g < arr.Length; g++)
                        {
                            if (x[j] == arr[g])
                            {
                                count++;
                            }
                        }
                    }
                }
                break;
            }
            if (count == 12)
            {
                return true;
            }
            return false;
        }
    }
}
