using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon41 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon41";
        public override double halfLife { get; } = 6576.6d;
        public override double atomicWeight { get; } = 40.9645d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2492049.0), new Potassium41() } },

        };
    }
}
    
    