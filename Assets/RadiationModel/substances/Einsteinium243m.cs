
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium243m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium243m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 243.06957d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    