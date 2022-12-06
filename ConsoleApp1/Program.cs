using System;
using System.Collections.Generic;
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
            //int[] frequencyChar = new int[26];
            //Reset(frequencyChar);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = i; j < i + 14; j++)
            //    {
            //        frequencyChar[(int)input[j]-97] += 1;
            //    }
            //    // are they different?
            //    bool different = true;
            //    for (int k = 0; k < frequencyChar.Length; k++)
            //    {
            //        if (frequencyChar[k]>1)
            //        {
            //            different = false;
            //        }
            //    }
            //    if (different)
            //    {
            //        Console.WriteLine(i+14);
            //        break;          
            //    }
            //    else
            //    {
            //        Reset(frequencyChar);
            //    }

            // Part 2 with set
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < i+14; j++)
                {
                    if (!set.Add(input[j]))
                    {
                        set.Clear();
                        break;
                    }
                    if (set.Count==14)
                    {
                        Console.WriteLine($"found at: {i}");
                    }
                    break;
                }
                
            }
        }
    }
}
