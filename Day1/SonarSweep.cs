using System;
using System.Collections.Generic;

namespace Day1
{
    public class SonarSweep
    {
        public int CountdepthMeasurementIncrease()
        {
            var depthMeasurementIncrease = 0;

            var depthMeasurements = DepthMeasurementst();

            for (int i = 1; i < depthMeasurements.Count; i++)
            {
                if (depthMeasurements[i] > depthMeasurements[i-1])
                {
                    depthMeasurementIncrease += 1;
                }
            }

            return depthMeasurementIncrease;
        }

        //public int CountThreeMeasurementSlidingWindow(string[] depthMeasurementsStrings)
        //{
        //    var depthMeasurements = DepthMeasurementsToInt(depthMeasurementsStrings);
        //}

        private List<int> DepthMeasurementst()
        {
            string[] depthMeasurementsStrings = System.IO.File.ReadAllLines(@"C:\repos\adventofcode\Day1\puzzle1.txt");

            var depthMeasurements = new List<int>();

            foreach (var depthMeasurementsString in depthMeasurementsStrings)
            {
                Int32.TryParse(depthMeasurementsString, out int k);

                depthMeasurements.Add(k);
            }

            return depthMeasurements;
        }

    }
}
