﻿using System.IO;


namespace StringManipulationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Modulator modulator = new Modulator();
            modulator.FirstStringModulator("madárnyelv");
            Console.WriteLine("Nyomj meg egy gombot a folytatáshoz!");
            Console.ReadKey();
            modulator.Squeeze("megadott sztring", "gt");
        }
    }
}
