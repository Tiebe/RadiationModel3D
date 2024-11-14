using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium83m";
        public override double halfLife { get; } = 4.95d;
        public override double atomicWeight { get; } = 82.91783d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00479), new Strontium83() } },

        };
    }
}
    
    