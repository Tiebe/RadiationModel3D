using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold179m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold179m";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 178.97327d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    