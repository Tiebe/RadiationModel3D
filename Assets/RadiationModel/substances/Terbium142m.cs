using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium142m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium142m";
        public override double halfLife { get; } = 0.303d;
        public override double atomicWeight { get; } = 141.93958d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((280000.0, 0.00443)), new Terbium142() } },

        };
    }
}
    
    