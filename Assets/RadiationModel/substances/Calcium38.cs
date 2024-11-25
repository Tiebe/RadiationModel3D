using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium38 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium38";
        public override double halfLife { get; } = 0.44376d;
        public override double atomicWeight { get; } = 37.97632d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon38() }, { 1.0d, new BetaParticle(1, 6328165.0) }, { 0.02911216d, new GammaParticle(328100.0, 0.00378) }, { 0.0005059600000000001d, new GammaParticle(1239000.0, 0.001) }, { 0.1946d, new GammaParticle(1567400.0, 0.00079) }, { 0.0004865d, new GammaParticle(1643000.0, 0.00075) }, { 0.00015568d, new GammaParticle(1698000.0, 0.00073) }, { 4.0866e-05d, new GammaParticle(2534000.0, 0.00049) }, { 0.00011676d, new GammaParticle(2883000.0, 0.00043) }, { 0.0028022399999999997d, new GammaParticle(3210700.0, 0.00039) }, { 0.00046704d, new GammaParticle(3341000.0, 0.00037) }, { 7.784e-05d, new GammaParticle(3516400.0, 0.00035) }, { 3.892e-05d, new GammaParticle(3716000.0, 0.00033) }, { 0.00025298000000000003d, new GammaParticle(3725400.0, 0.00033) }, { 0.00105084d, new GammaParticle(3848000.0, 0.00032) }, { 1.9980719999999998d, new GammaParticle(511000.0, 0.00243) }, { 2.9999999999999997e-06d, new GammaParticle(311.0, 3.98663) }, { 3.9899999999999994e-05d, new GammaParticle(3311.0, 0.37446) }, { 7.89e-05d, new GammaParticle(3314.0, 0.37412) }, { 1.4599999999999999e-05d, new GammaParticle(3591.0, 0.34526) }, { 1.4599999999999999e-05d, new GammaParticle(3591.0, 0.34526) } } },

        };
    }
}
    