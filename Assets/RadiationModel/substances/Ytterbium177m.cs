using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium177m";
        public override double halfLife { get; } = 6.41d;
        public override double atomicWeight { get; } = 176.94562d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00374, 331500.0), new Ytterbium177() } },

        };
    }
}
    
    