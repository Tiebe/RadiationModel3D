using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine31 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine31";
        public override double halfLife { get; } = 0.19d;
        public override double atomicWeight { get; } = 30.99245d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12007530.0), new Sulfur31() } },

        };
    }
}
    
    