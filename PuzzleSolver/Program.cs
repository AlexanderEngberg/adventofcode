using System;
using Day1;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] depthMeasurementsStrings = System.IO.File.ReadAllLines(@"C:\repos\adventofcode\Day1\puzzle1.txt");

            var kaka = new SonarSweep().CountdepthMeasurementIncrease(depthMeasurementsStrings);

            Console.WriteLine(kaka);
        }
    }
}
