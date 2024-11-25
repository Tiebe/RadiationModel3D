using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold192n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold192n";
        public override double halfLife { get; } = 0.16d;
        public override double atomicWeight { get; } = 191.96528d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold192() }, { 0.0212d, new GammaParticle(31610.0, 0.03922) }, { 0.00041d, new GammaParticle(59800.0, 0.02073) }, { 0.505239d, new GammaParticle(11419.0, 0.10858) } } },

        };
    }
}
    