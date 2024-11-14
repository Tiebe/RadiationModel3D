using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium142n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium142n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 141.93998d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00191), new Terbium142() } },

        };
    }
}
    
    