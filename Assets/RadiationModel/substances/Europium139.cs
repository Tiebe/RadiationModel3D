using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium139";
        public override double halfLife { get; } = 17.9d;
        public override double atomicWeight { get; } = 138.92979d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium139() }, { 1.0d, new BetaParticle(1, 6051500.0) }, { 0.135d, new GammaParticle(132200.0, 0.00938) }, { 0.14550000000000002d, new GammaParticle(189400.0, 0.00655) }, { 0.06d, new GammaParticle(197200.0, 0.00629) }, { 0.0285d, new GammaParticle(263900.0, 0.0047) }, { 0.0375d, new GammaParticle(299500.0, 0.00414) }, { 0.12d, new GammaParticle(330500.0, 0.00375) }, { 0.03d, new GammaParticle(419500.0, 0.00296) }, { 0.1275d, new GammaParticle(420300.0, 0.00295) }, { 0.09d, new GammaParticle(437700.0, 0.00283) }, { 0.15d, new GammaParticle(453400.0, 0.00273) }, { 0.0225d, new GammaParticle(463400.0, 0.00268) }, { 0.087d, new GammaParticle(497200.0, 0.00249) }, { 0.0315d, new GammaParticle(531500.0, 0.00233) }, { 0.069d, new GammaParticle(659500.0, 0.00188) }, { 0.06d, new GammaParticle(693800.0, 0.00179) }, { 0.063d, new GammaParticle(701200.0, 0.00177) }, { 0.195d, new GammaParticle(719000.0, 0.00172) }, { 1.926d, new GammaParticle(511000.0, 0.00243) }, { 0.044000000000000004d, new GammaParticle(6354.0, 0.19513) }, { 0.073d, new GammaParticle(39522.0, 0.03137) }, { 0.132d, new GammaParticle(40117.0, 0.03091) }, { 0.040999999999999995d, new GammaParticle(45523.0, 0.02724) }, { 0.052000000000000005d, new GammaParticle(45998.0, 0.02695) }, { 0.0106d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    