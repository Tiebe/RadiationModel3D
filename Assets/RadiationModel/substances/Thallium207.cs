using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium207 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium207";
        public override double halfLife { get; } = 286.2d;
        public override double atomicWeight { get; } = 206.97742d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead207() }, { 1.0d, new BetaParticle(-1, 709000.0) }, { 1.42e-05d, new GammaParticle(328100.0, 0.00378) }, { 1.8500000000000002e-05d, new GammaParticle(569698.0, 0.00218) }, { 0.00263d, new GammaParticle(897770.0, 0.00138) }, { 2.025382406616e-05d, new GammaParticle(12522.0, 0.09901) }, { 1.5354174002220587e-05d, new GammaParticle(72805.0, 0.01703) }, { 2.580533445751359e-05d, new GammaParticle(74970.0, 0.01654) }, { 8.819894669943036e-06d, new GammaParticle(84986.0, 0.01459) }, { 1.1483502860265833e-05d, new GammaParticle(86022.0, 0.01441) }, { 2.663608190322797e-06d, new GammaParticle(87301.0, 0.0142) } } },

        };
    }
}
    