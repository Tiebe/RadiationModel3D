
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium195";
        public override double halfLife { get; } = 390.0d;
        public override double atomicWeight { get; } = 194.96832d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iridium195() } },

        };
    }
}
    
    