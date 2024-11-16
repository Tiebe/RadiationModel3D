using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium44";
        public override double halfLife { get; } = 0.111d;
        public override double atomicWeight { get; } = 43.97444d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 13740600.0), new Titanium44() } },

        };
    }
}
    
    