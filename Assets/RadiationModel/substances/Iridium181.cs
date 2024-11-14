using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium181";
        public override double halfLife { get; } = 294.0d;
        public override double atomicWeight { get; } = 180.95763d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4087000.0), new Osmium181() } },

        };
    }
}
    
    