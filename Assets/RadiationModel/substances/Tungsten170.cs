using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten170 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten170";
        public override double halfLife { get; } = 145.2d;
        public override double atomicWeight { get; } = 169.94923d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium170() }, { 1.0d, new BetaParticle(1, 4481500.0) } } },

        };
    }
}
    