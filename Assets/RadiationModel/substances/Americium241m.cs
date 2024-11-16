using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium241m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium241m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 241.05918d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    