using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium91m";
        public override double halfLife { get; } = 2982.6d;
        public override double atomicWeight { get; } = 90.90789d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00223, 555600.0), new Yttrium91() } },

        };
    }
}
    
    