using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese48i : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese48i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 47.97181d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium47() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    