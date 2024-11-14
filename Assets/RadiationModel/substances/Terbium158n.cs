using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium158n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium158n";
        public override double halfLife { get; } = 0.0004d;
        public override double atomicWeight { get; } = 157.92584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00319), new Terbium158() } },

        };
    }
}
    
    