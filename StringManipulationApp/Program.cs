using System.IO;


namespace StringManipulationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Modulator modulator = new Modulator();
            string firstModulatorResult = modulator.FirstStringModulator("madarnyelv");
            Console.WriteLine(firstModulatorResult);
            Console.WriteLine("Nyomj meg egy gombot a folytatáshoz!");
            Console.ReadKey();
            string secondModulatorResult = modulator.Squeeze("megadott sztring", "gt");
            Console.WriteLine(secondModulatorResult);
        }
    }
}
