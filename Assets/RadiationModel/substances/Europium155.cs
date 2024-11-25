using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium155";
        public override double halfLife { get; } = 149990069.15724d;
        public override double atomicWeight { get; } = 154.9229d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium155() }, { 1.0d, new BetaParticle(-1, 126000.0) }, { 3.5612e-05d, new GammaParticle(10417.8, 0.11901) }, { 9.824e-05d, new GammaParticle(12700.0, 0.09763) }, { 0.00019648d, new GammaParticle(13800.0, 0.08984) }, { 0.0004912d, new GammaParticle(18763.0, 0.06608) }, { 4.6664e-06d, new GammaParticle(21035.0, 0.05894) }, { 7.675000000000001e-05d, new GammaParticle(24560.0, 0.05048) }, { 0.0031620999999999997d, new GammaParticle(26527.0, 0.04674) }, { 7.060999999999999e-05d, new GammaParticle(31444.0, 0.03943) }, { 0.00026402d, new GammaParticle(40750.0, 0.03043) }, { 0.013108900000000001d, new GammaParticle(45298.9, 0.02737) }, { 0.00066312d, new GammaParticle(57987.3, 0.02138) }, { 0.011666000000000001d, new GammaParticle(60008.9, 0.02066) }, { 0.001535d, new GammaParticle(86059.1, 0.01441) }, { 0.307d, new GammaParticle(86546.3, 0.01433) }, { 0.21121600000000001d, new GammaParticle(105308.7, 0.01177) }, { 3.9909999999999996e-06d, new GammaParticle(107600.0, 0.01152) }, { 0.00050962d, new GammaParticle(146070.6, 0.00849) }, { 0.07370410185776d, new GammaParticle(6858.0, 0.18079) }, { 0.06490793078434573d, new GammaParticle(42308.0, 0.02931) }, { 0.11676188304433484d, new GammaParticle(42996.0, 0.02884) }, { 0.036909322429484914d, new GammaParticle(48802.0, 0.02541) }, { 0.04661647422843944d, new GammaParticle(49326.0, 0.02514) }, { 0.009707151798954532d, new GammaParticle(49957.0, 0.02482) } } },

        };
    }
}
    