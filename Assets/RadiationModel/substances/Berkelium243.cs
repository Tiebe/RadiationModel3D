using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium243";
        public override double halfLife { get; } = 16560.0d;
        public override double atomicWeight { get; } = 243.06301d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9984999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium243() }, { 1.0d, new BetaParticle(1, 757500.0) } } },
            { 0.0015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium239() }, { 1.0d, new AlphaParticle(7896602.09) }, { 6e-05d, new GammaParticle(42000.0, 0.02952) }, { 0.00012d, new GammaParticle(146400.0, 0.00847) }, { 0.0006d, new GammaParticle(187100.0, 0.00663) }, { 0.00015d, new GammaParticle(536000.0, 0.00231) }, { 0.00015d, new GammaParticle(536000.0, 0.00231) }, { 0.0019d, new GammaParticle(18078.0, 0.06858) }, { 2.5e-05d, new GammaParticle(102031.0, 0.01215) }, { 4e-05d, new GammaParticle(106468.0, 0.01165) }, { 1.5e-05d, new GammaParticle(120157.0, 0.01032) }, { 2e-05d, new GammaParticle(121688.0, 0.01019) }, { 5.199999999999999e-06d, new GammaParticle(123677.0, 0.01002) } } },

        };
    }
}
    