
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium245m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium245m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 245.06903d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    