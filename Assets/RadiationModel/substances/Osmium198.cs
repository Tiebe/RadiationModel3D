using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium198 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium198";
        public override double halfLife { get; } = 125.0d;
        public override double atomicWeight { get; } = 197.97466d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2110000.0), new Iridium198() } },

        };
    }
}
    
    