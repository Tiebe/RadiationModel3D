using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium262m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium262m";
        public override double halfLife { get; } = 0.047d;
        public override double atomicWeight { get; } = 262.11099d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    