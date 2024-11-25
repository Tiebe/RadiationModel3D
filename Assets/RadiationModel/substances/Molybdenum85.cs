using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum85 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum85";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 84.93826d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium85() }, { 1.0d, new BetaParticle(1, 7832500.0) } } },
            { 0.0014000000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium84() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    