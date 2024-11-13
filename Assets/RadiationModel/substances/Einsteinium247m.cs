
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium247m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium247m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 247.07368d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    