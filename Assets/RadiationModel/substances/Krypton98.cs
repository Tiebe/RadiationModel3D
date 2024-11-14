using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton98 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton98";
        public override double halfLife { get; } = 0.0428d;
        public override double atomicWeight { get; } = 97.95264d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10249000.0), new Rubidium98() } },

        };
    }
}
    
    