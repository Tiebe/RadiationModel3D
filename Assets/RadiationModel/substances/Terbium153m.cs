using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium153m";
        public override double halfLife { get; } = 0.00019d;
        public override double atomicWeight { get; } = 152.92362d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00761), new Terbium153() } },

        };
    }
}
    
    