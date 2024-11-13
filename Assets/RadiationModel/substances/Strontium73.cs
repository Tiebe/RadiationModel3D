
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium73 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium73";
        public override double halfLife { get; } = 0.0253d;
        public override double atomicWeight { get; } = 72.9657d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium73() } },

        };
    }
}
    
    