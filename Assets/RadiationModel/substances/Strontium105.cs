
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium105";
        public override double halfLife { get; } = 0.039d;
        public override double atomicWeight { get; } = 104.959d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium105() } },

        };
    }
}
    
    