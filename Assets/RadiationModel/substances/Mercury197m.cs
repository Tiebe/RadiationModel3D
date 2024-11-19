using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury197m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury197m";
        public override double halfLife { get; } = 85752.0d;
        public override double atomicWeight { get; } = 196.96753d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9468000000000001d, new List<RadioactiveSubstance> { new GammaParticle((299000.0, 0.00415)), new Mercury197() } },
            { 0.053200000000000004d, new List<RadioactiveSubstance> { new Gold197() } },

        };
    }
}
    
    