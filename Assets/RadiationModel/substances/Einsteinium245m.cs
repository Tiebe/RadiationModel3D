
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium245m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium245m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 245.07123d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    