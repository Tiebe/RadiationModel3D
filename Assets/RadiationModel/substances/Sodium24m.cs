using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium24m : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium24m";
        public override double halfLife { get; } = 0.02018d;
        public override double atomicWeight { get; } = 23.99147d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium24() }, { 0.9990000000000001d, new GammaParticle(472202.3, 0.00263) }, { 3.120944712271072e-06d, new GammaParticle(1041.0, 1.19101) }, { 6.205895232195411e-06d, new GammaParticle(1041.0, 1.19101) } } },
            { 0.0005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium24() }, { 1.0d, new BetaParticle(-1, 2993942.0) } } },

        };
    }
}
    