/*
 * fia71@gso-koeln.de 2018
 */
using System;

namespace ListardDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Listard myListard = new Listard(10);
            myListard.Set(4710, 0);
            myListard.Set(4711, 1);

            // Eigene Klassen wie ein Array benutzen
            myListard[1] = 99; // schreibender Zugriff
            int y = myListard[1]; // lesender Zugriff

            for (int i = 0; i < 100; i++) {
                myListard.Add(4712);
            }

            DateTime t1 = DateTime.Now;
            myListard.Add(new int[100000]);
            DateTime t2 = DateTime.Now;
            TimeSpan dt = t2 - t1;

            Listard myListard2 = new Listard();
            myListard2.Set(3710, 4);
            myListard2.Add(3711);
        }
    }
}
