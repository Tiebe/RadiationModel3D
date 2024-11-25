using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium23i : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium23i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 23.0025d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0017000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium22() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    