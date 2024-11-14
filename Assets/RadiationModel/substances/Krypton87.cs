using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton87 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton87";
        public override double halfLife { get; } = 4578.0d;
        public override double atomicWeight { get; } = 86.91335d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3888272.0), new Rubidium87() } },

        };
    }
}
    
    