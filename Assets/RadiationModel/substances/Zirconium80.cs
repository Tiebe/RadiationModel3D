using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium80";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 79.94121d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6388000.0), new Yttrium80() } },

        };
    }
}
    
    