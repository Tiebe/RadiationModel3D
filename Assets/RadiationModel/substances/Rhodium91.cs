using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium91";
        public override double halfLife { get; } = 1.47d;
        public override double atomicWeight { get; } = 90.93712d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium91() }, { 1.0d, new BetaParticle(1, 8708350.0) }, { 0.2808d, new GammaParticle(387400.0, 0.0032) }, { 0.08d, new GammaParticle(437700.0, 0.00283) }, { 0.0168d, new GammaParticle(533300.0, 0.00232) }, { 0.0504d, new GammaParticle(821100.0, 0.00151) }, { 0.0416d, new GammaParticle(889800.0, 0.00139) }, { 0.048799999999999996d, new GammaParticle(973100.0, 0.00127) }, { 1.88d, new GammaParticle(511000.0, 0.00243) }, { 0.00025766732412d, new GammaParticle(2737.0, 0.45299) }, { 0.0011566280453538264d, new GammaParticle(19150.0, 0.06474) }, { 0.0021947401240110555d, new GammaParticle(19279.0, 0.06431) }, { 0.0005898061881541466d, new GammaParticle(21736.0, 0.05704) }, { 0.0006853547906351184d, new GammaParticle(21875.0, 0.05668) }, { 9.554860248097174e-05d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.013000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium90() }, { 1.0d, new BetaParticle(1, 471824401.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    