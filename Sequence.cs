﻿using System;

    class Program
    {
        static void Main()
        {
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}",i);
            }
            else
            {
                Console.WriteLine("-{0}",i);
            }
        }
        }
    }

