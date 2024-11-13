
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium199";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 198.97824d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iridium199() } },

        };
    }
}
    
    