
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony114 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony114";
        public override double halfLife { get; } = 209.4d;
        public override double atomicWeight { get; } = 113.90929d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin114() } },

        };
    }
}
    
    