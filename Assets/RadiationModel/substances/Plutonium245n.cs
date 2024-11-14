using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium245n : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium245n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 245.06997d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    