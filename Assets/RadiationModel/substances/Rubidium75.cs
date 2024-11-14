using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium75";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 74.93857d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7105300.0), new Krypton75() } },

        };
    }
}
    
    