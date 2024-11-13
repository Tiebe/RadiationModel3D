
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium80m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium80m";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 79.9346d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.81d, new List<RadioactiveSubstance> { new GammaParticle(), new Yttrium80() } },

            { 0.19d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium80() } },

        };
    }
}
    
    