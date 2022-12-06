using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");

            //char one = input[0];
            //char two = input[1];
            //char three = input[2];
            //char four = input[3];

            //int i;

            //for (i = 4; i < input.Length; i++)
            //{
            //    if (one!=two && two!=three && three!=four && one!=three && one !=four && two!=four && three!=one)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        one = two;
            //        two = three;
            //        three = four;
            //        four = input[i];
            //    }
            //}
            //Console.WriteLine(i);

            // Part 2
            int[] freqChar = new int[26];
            Reset(freqChar);

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < i + 14; j++)
                {
                    freqChar[(int)input[j]-97] += 1;
                }
                // are they different?
                bool different = true;
                for (int k = 0; k < freqChar.Length; k++)
                {
                    if (freqChar[k]>1)
                    {
                        different = false;
                    }
                }
                if (different)
                {
                    Console.WriteLine(i+14);
                    break;          
                }
                else
                {
                    Reset(freqChar);
                }
            }
        }

        private static void Reset(int[] freqChar)
        {
            for (int i = 0; i < freqChar.Length; i++)
            {
                freqChar[i] = 0;
            }
        }
    }
}
