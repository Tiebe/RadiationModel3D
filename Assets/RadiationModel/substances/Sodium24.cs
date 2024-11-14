using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium24 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium24";
        public override double halfLife { get; } = 53841.6d;
        public override double atomicWeight { get; } = 23.99096d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5515677.0), new Magnesium24() } },

        };
    }
}
    
    