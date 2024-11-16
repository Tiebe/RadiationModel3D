using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen20 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen20";
        public override double halfLife { get; } = 0.136d;
        public override double atomicWeight { get; } = 20.02337d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 17973800.0), new Oxygen20() } },

        };
    }
}
    
    