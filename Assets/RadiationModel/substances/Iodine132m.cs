using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine132m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine132m";
        public override double halfLife { get; } = 4993.2d;
        public override double atomicWeight { get; } = 131.90811d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine132() }, { 0.037200000000000004d, new GammaParticle(98000.0, 0.01265) }, { 0.061041002351999996d, new GammaParticle(4335.0, 0.28601) }, { 0.06509029331609177d, new GammaParticle(28318.0, 0.04378) }, { 0.12089578996302336d, new GammaParticle(28613.0, 0.04333) }, { 0.03483067269240198d, new GammaParticle(32395.0, 0.03827) }, { 0.04270240472088483d, new GammaParticle(32680.0, 0.03794) }, { 0.007871732028482849d, new GammaParticle(33040.0, 0.03753) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon132() }, { 1.0d, new BetaParticle(-1, 1842487.5) }, { 0.08800000000000001d, new GammaParticle(175000.0, 0.00708) }, { 0.0064d, new GammaParticle(310000.0, 0.004) }, { 0.14d, new GammaParticle(599800.0, 0.00207) }, { 0.015d, new GammaParticle(610000.0, 0.00203) }, { 0.025d, new GammaParticle(614000.0, 0.00202) }, { 0.139d, new GammaParticle(667714.0, 0.00186) }, { 0.14d, new GammaParticle(772600.0, 0.0016) }, { 0.00202532504896d, new GammaParticle(4540.0, 0.27309) }, { 0.004679965770827811d, new GammaParticle(29458.0, 0.04209) }, { 0.008669814321652113d, new GammaParticle(29778.0, 0.04164) }, { 0.0025133445206473124d, new GammaParticle(33726.0, 0.03676) }, { 0.003106493827520078d, new GammaParticle(34030.0, 0.03643) }, { 0.0005931493068727658d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    