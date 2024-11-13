
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony111 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony111";
        public override double halfLife { get; } = 75.0d;
        public override double atomicWeight { get; } = 110.91322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin111() } },

        };
    }
}
    
    