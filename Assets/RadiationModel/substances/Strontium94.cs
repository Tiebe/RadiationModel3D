using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium94";
        public override double halfLife { get; } = 75.3d;
        public override double atomicWeight { get; } = 93.91536d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium94() }, { 1.0d, new BetaParticle(-1, 1752650.0) }, { 6.594e-05d, new GammaParticle(102100.0, 0.01214) }, { 0.0015072d, new GammaParticle(520800.0, 0.00238) }, { 0.001884d, new GammaParticle(530100.0, 0.00234) }, { 0.0195936d, new GammaParticle(621700.0, 0.00199) }, { 0.021289199999999998d, new GammaParticle(703900.0, 0.00176) }, { 0.024021d, new GammaParticle(723800.0, 0.00171) }, { 0.0012246d, new GammaParticle(754700.0, 0.00164) }, { 0.0175212d, new GammaParticle(806000.0, 0.00154) }, { 0.0038622d, new GammaParticle(906900.0, 0.00137) }, { 0.9420000000000001d, new GammaParticle(1427700.0, 0.00087) }, { 0.00064056d, new GammaParticle(1560700.0, 0.00079) }, { 0.0006311400000000001d, new GammaParticle(1649200.0, 0.00075) }, { 0.00049926d, new GammaParticle(1751300.0, 0.00071) }, { 0.0003768d, new GammaParticle(2063000.0, 0.0006) }, { 0.0057462d, new GammaParticle(2182400.0, 0.00057) }, { 0.00042389999999999995d, new GammaParticle(2246100.0, 0.00055) } } },

        };
    }
}
    