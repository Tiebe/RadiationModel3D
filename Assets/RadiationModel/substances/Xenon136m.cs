using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon136m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon136m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 135.90925d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00066, 1891740.0), new Xenon136() } },

        };
    }
}
    
    