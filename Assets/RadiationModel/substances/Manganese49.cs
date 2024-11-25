using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese49 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese49";
        public override double halfLife { get; } = 0.382d;
        public override double atomicWeight { get; } = 48.95961d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium49() }, { 1.0d, new BetaParticle(1, 5171150.0) }, { 0.064d, new GammaParticle(272300.0, 0.00455) }, { 0.006d, new GammaParticle(2231500.0, 0.00056) }, { 0.017d, new GammaParticle(2504800.0, 0.00049) }, { 1.9980000000000002d, new GammaParticle(511000.0, 0.00243) }, { 6.531288148799999e-06d, new GammaParticle(597.0, 2.07679) }, { 7.740240246653116e-05d, new GammaParticle(5406.0, 0.22935) }, { 0.00015203771845714235d, new GammaParticle(5415.0, 0.22896) }, { 3.088264027632646e-05d, new GammaParticle(5966.0, 0.20782) }, { 3.088264027632646e-05d, new GammaParticle(5966.0, 0.20782) } } },

        };
    }
}
    