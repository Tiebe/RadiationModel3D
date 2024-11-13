
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium251m";
        public override double halfLife { get; } = 0.0002d;
        public override double atomicWeight { get; } = 251.08d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    