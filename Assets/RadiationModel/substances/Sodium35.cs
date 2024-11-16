using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium35";
        public override double halfLife { get; } = 0.0015d;
        public override double atomicWeight { get; } = 35.04061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 22190000.0), new Magnesium35() } },

        };
    }
}
    
    