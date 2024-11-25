using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium44";
        public override double halfLife { get; } = 0.0428d;
        public override double atomicWeight { get; } = 43.98559d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium44() }, { 1.0d, new BetaParticle(1, 12064300.0) }, { 0.59d, new GammaParticle(676900.0, 0.00183) }, { 1.268d, new GammaParticle(511000.0, 0.00243) }, { 1e-06d, new GammaParticle(536.0, 2.31314) }, { 1.1999999999999999e-05d, new GammaParticle(4945.0, 0.25073) }, { 2.3999999999999997e-05d, new GammaParticle(4952.0, 0.25037) }, { 5e-06d, new GammaParticle(5444.0, 0.22774) }, { 5e-06d, new GammaParticle(5444.0, 0.22774) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium43() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    