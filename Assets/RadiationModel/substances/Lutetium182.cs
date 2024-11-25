using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium182";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 181.95516d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium182() }, { 1.0d, new BetaParticle(-1, 2140000.0) }, { 0.15d, new GammaParticle(97800.0, 0.01268) }, { 0.045d, new GammaParticle(224000.0, 0.00554) }, { 0.3d, new GammaParticle(720800.0, 0.00172) }, { 0.15d, new GammaParticle(808100.0, 0.00153) }, { 0.3d, new GammaParticle(818200.0, 0.00152) }, { 0.11865871953d, new GammaParticle(9114.0, 0.13604) }, { 0.042268371962363986d, new GammaParticle(54608.0, 0.0227) }, { 0.07397334960161707d, new GammaParticle(55786.0, 0.02222) }, { 0.024404339333874474d, new GammaParticle(63333.0, 0.01958) }, { 0.03092029793601896d, new GammaParticle(64057.0, 0.01936) }, { 0.006515958602144485d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    