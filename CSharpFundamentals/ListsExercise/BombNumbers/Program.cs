﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombNumberAndPower = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int startIndex;
            int sum = 0;

            while (listOfIntegers.Contains(bombNumberAndPower[0]))
            {

                startIndex = listOfIntegers.IndexOf(bombNumberAndPower[0]) - bombNumberAndPower[1];

                if (startIndex < 0)             //тук
                    startIndex = 0;

                for (int i = 0; i < bombNumberAndPower[1] * 2 + 1; i++)
                {
                    if (startIndex <= listOfIntegers.Count - 1)
                    {
                        listOfIntegers.RemoveAt(startIndex);
                    }
                }

            }

            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                sum += listOfIntegers[i];
            }

            Console.WriteLine(sum);
        }
    }
}