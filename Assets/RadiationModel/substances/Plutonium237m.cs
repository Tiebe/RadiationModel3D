using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium237m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium237m";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 237.04856d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00852, 145500.0), new Plutonium237() } },

        };
    }
}
    
    