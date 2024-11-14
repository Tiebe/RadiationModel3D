using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon31 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon31";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 31.01216d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 18365000.0), new Chlorine31() } },
            { 5.999999999999999e-06d, new List<RadioactiveSubstance> { new ProtonParticle(), new Sulfur29() } },

        };
    }
}
    
    