
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium80";
        public override double halfLife { get; } = 33.4d;
        public override double atomicWeight { get; } = 79.92252d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton80() } },

        };
    }
}
    
    