
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium184";
        public override double halfLife { get; } = 11124.0d;
        public override double atomicWeight { get; } = 183.95748d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium184() } },

        };
    }
}
    
    