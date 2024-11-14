using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum199 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum199";
        public override double halfLife { get; } = 1848.0d;
        public override double atomicWeight { get; } = 198.9706d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1705100.0), new Gold199() } },

        };
    }
}
    
    