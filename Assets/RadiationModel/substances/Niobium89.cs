using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium89";
        public override double halfLife { get; } = 7308.0d;
        public override double atomicWeight { get; } = 88.91344d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4252000.0), new Zirconium89() } },

        };
    }
}
    
    