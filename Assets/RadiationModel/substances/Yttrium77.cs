using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium77";
        public override double halfLife { get; } = 0.063d;
        public override double atomicWeight { get; } = 76.95014d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11363000.0), new Strontium77() } },

        };
    }
}
    
    