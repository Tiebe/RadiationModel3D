using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium37 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium37";
        public override double halfLife { get; } = 0.1811d;
        public override double atomicWeight { get; } = 36.9859d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon37() }, { 1.0d, new BetaParticle(1, 8905790.0) }, { 0.021d, new GammaParticle(1370900.0, 0.0009) }, { 0.027999999999999997d, new GammaParticle(2750400.0, 0.00045) }, { 0.048d, new GammaParticle(3239300.0, 0.00038) }, { 2.00412d, new GammaParticle(511000.0, 0.00243) } } },
            { 0.821d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon36() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    