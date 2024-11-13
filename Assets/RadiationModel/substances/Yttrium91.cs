
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium91";
        public override double halfLife { get; } = 5055264.0d;
        public override double atomicWeight { get; } = 90.9073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium91() } },

        };
    }
}
    
    