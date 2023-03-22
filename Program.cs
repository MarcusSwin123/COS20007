﻿using System;

namespace Counter_Task
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            int i = 0;
            Counter[] myCounters = new Counter[3];
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            for (i = 0; i <= 9;i++) ;

            myCounters[0].Increment();

            for (i = 0; i <= 14; i++)

            myCounters[1].Increment();

            PrintCounters(myCounters);
            Console.ReadLine();

            myCounters[2].Reset();

            PrintCounters(myCounters);
            Console.ReadLine();
        }
        private static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
                Console.WriteLine("{0} is {1}", c.Name, c.Tick);

        }

    }
}
