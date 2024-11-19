using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium81m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium81m";
        public override double halfLife { get; } = 1830.0d;
        public override double atomicWeight { get; } = 80.91909d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.976d, new List<RadioactiveSubstance> { new GammaParticle(0.01442, 86000.0), new Rubidium81() } },
            { 0.024d, new List<RadioactiveSubstance> { new BetaParticle(1, 2325200.0), new Krypton81() } },

        };
    }
}
    
    