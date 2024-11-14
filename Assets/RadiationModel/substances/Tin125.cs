using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin125 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin125";
        public override double halfLife { get; } = 832377.6d;
        public override double atomicWeight { get; } = 124.90779d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2361400.0), new Antimony125() } },

        };
    }
}
    
    