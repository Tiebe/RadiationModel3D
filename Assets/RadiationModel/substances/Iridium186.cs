using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium186";
        public override double halfLife { get; } = 59904.0d;
        public override double atomicWeight { get; } = 185.95795d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3828000.0), new Osmium186() } },

        };
    }
}
    
    