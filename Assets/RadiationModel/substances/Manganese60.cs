using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese60 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese60";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 59.94314d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese60() } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron60() }, { 1.0d, new BetaParticle(-1, 4222550.0) }, { 0.122d, new GammaParticle(823400.0, 0.00151) }, { 0.05d, new GammaParticle(1150200.0, 0.00108) }, { 0.03d, new GammaParticle(1532400.0, 0.00081) } } },

        };
    }
}
    