using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium158";
        public override double halfLife { get; } = 5680246675.42656d;
        public override double atomicWeight { get; } = 157.92542d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8340000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium158() }, { 1.0d, new BetaParticle(1, -1100200.0) }, { 0.11800000000000001d, new GammaParticle(79513.0, 0.01559) }, { 0.1d, new GammaParticle(181944.0, 0.00681) }, { 0.0001d, new GammaParticle(210700.0, 0.00588) }, { 0.09699999999999999d, new GammaParticle(780183.0, 0.00159) }, { 0.00098d, new GammaParticle(897549.0, 0.00138) }, { 0.00146d, new GammaParticle(897622.0, 0.00138) }, { 0.00045d, new GammaParticle(925560.0, 0.00134) }, { 0.444d, new GammaParticle(944189.0, 0.00131) }, { 0.205d, new GammaParticle(962126.0, 0.00129) }, { 0.0017699999999999999d, new GammaParticle(977131.0, 0.00127) }, { 0.0217d, new GammaParticle(1107626.0, 0.00112) }, { 0.017d, new GammaParticle(1187143.0, 0.00104) }, { 0.22394390882380003d, new GammaParticle(6858.0, 0.18079) }, { 0.22939081544187367d, new GammaParticle(42308.0, 0.02931) }, { 0.412647626267087d, new GammaParticle(42996.0, 0.02884) }, { 0.13044106424585855d, new GammaParticle(48802.0, 0.02541) }, { 0.16474706414251933d, new GammaParticle(49326.0, 0.02514) }, { 0.034305999896660805d, new GammaParticle(49957.0, 0.02482) } } },
            { 0.166d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium158() }, { 1.0d, new BetaParticle(-1, 468149.99999) }, { 0.043d, new GammaParticle(98918.0, 0.01253) }, { 0.009399999999999999d, new GammaParticle(218221.0, 0.00568) }, { 0.019289828334d, new GammaParticle(7384.0, 0.16791) }, { 0.013557286424044503d, new GammaParticle(45207.0, 0.02743) }, { 0.024226744860694253d, new GammaParticle(45998.0, 0.02695) }, { 0.0077787124724295505d, new GammaParticle(52220.0, 0.02374) }, { 0.009801177715261235d, new GammaParticle(52791.0, 0.02349) }, { 0.0020224652428316833d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    