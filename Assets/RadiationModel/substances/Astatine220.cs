using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine220 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine220";
        public override double halfLife { get; } = 222.6d;
        public override double atomicWeight { get; } = 220.01543d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon220() }, { 1.0d, new BetaParticle(-1, 1882000.0) }, { 0.69d, new GammaParticle(240970.0, 0.00515) }, { 0.3d, new GammaParticle(292710.0, 0.00424) }, { 0.025d, new GammaParticle(318300.0, 0.0039) }, { 0.017d, new GammaParticle(404800.0, 0.00306) }, { 0.19d, new GammaParticle(422260.0, 0.00294) }, { 0.02d, new GammaParticle(533800.0, 0.00232) }, { 0.016d, new GammaParticle(592300.0, 0.00209) }, { 0.039d, new GammaParticle(645600.0, 0.00192) }, { 0.03d, new GammaParticle(668000.0, 0.00186) }, { 0.040999999999999995d, new GammaParticle(697600.0, 0.00178) }, { 0.07822123850112d, new GammaParticle(14088.0, 0.08801) }, { 0.028685055777395666d, new GammaParticle(81070.0, 0.01529) }, { 0.047319458557234684d, new GammaParticle(83789.0, 0.0148) }, { 0.01641006559497701d, new GammaParticle(94878.0, 0.01307) }, { 0.021661286585369654d, new GammaParticle(96054.0, 0.01291) }, { 0.005251220990392643d, new GammaParticle(97530.0, 0.01271) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth216() }, { 1.0d, new AlphaParticle(7099002.09) } } },

        };
    }
}
    