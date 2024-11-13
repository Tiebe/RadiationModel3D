
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin125m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin125m";
        public override double halfLife { get; } = 586.2d;
        public override double atomicWeight { get; } = 124.90782d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony125() } },

        };
    }
}
    
    