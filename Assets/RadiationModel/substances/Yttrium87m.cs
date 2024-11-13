
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium87m";
        public override double halfLife { get; } = 48132.0d;
        public override double atomicWeight { get; } = 86.91128d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9843000000000001d, new List<RadioactiveSubstance> { new GammaParticle(), new Yttrium87() } },

            { 0.015700000000000002d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium87() } },

        };
    }
}
    
    