using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur42 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur42";
        public override double halfLife { get; } = 1.016d;
        public override double atomicWeight { get; } = 41.98107d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7192300.0), new Chlorine42() } },

        };
    }
}
    
    