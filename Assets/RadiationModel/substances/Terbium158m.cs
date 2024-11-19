using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium158m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium158m";
        public override double halfLife { get; } = 10.7d;
        public override double atomicWeight { get; } = 157.92554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((110300.00001, 0.01124)), new Terbium158() } },

        };
    }
}
    
    