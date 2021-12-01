using System;
using System.Collections.Generic;

namespace Day1
{
    public class SonarSweep
    {
        public int CountdepthMeasurementIncrease(string[] depthMeasurementsStrings)
        {
            var depthMeasurementIncrease = 0;

            var depthMeasurements = DepthMeasurementsToInt(depthMeasurementsStrings);


            for (int i = 0; i < depthMeasurements.Count; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else if(depthMeasurements[i] > depthMeasurements[i-1])
                {
                    depthMeasurementIncrease += 1;
                }
            }

            return depthMeasurementIncrease;
        }

        public int CountThreeMeasurementSlidingWindow(string[] depthMeasurementsStrings)
        {

        }

        private List<int> DepthMeasurementsToInt(string[] depthMeasurementsStrings)
        {
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
