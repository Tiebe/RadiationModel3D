using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium75m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium75m";
        public override double halfLife { get; } = 47.7d;
        public override double atomicWeight { get; } = 74.92301d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00888, 139690.0), new Germanium75() } },
            { 0.0003d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1316920.0), new Arsenic75() } },

        };
    }
}
    
    