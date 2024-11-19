using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium98q : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium98q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 97.92303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00209, 594000.0), new Yttrium98() } },

        };
    }
}
    
    