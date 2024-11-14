using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur43 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur43";
        public override double halfLife { get; } = 0.265d;
        public override double atomicWeight { get; } = 42.98691d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11965000.0), new Chlorine43() } },

        };
    }
}
    
    