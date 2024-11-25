using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine32 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine32";
        public override double halfLife { get; } = 0.298d;
        public override double atomicWeight { get; } = 31.98568d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus32() }, { 1.0d, new BetaParticle(1, 5485090.0) }, { 0.027000000000000003d, new GammaParticle(1548000.0, 0.0008) }, { 0.7d, new GammaParticle(2230500.0, 0.00056) }, { 0.03d, new GammaParticle(2463800.0, 0.0005) }, { 0.0076d, new GammaParticle(2885000.0, 0.00043) }, { 0.019d, new GammaParticle(3317500.0, 0.00037) }, { 0.02d, new GammaParticle(4281500.0, 0.00029) }, { 0.006d, new GammaParticle(4433000.0, 0.00028) }, { 0.021d, new GammaParticle(4694000.0, 0.00026) }, { 0.155d, new GammaParticle(4770000.0, 0.00026) }, { 0.0034000000000000002d, new GammaParticle(4881000.0, 0.00025) }, { 0.012d, new GammaParticle(5549500.0, 0.00022) }, { 0.0031d, new GammaParticle(7194000.0, 0.00017) }, { 2.0275862d, new GammaParticle(511000.0, 0.00243) }, { 3.88606100893659e-07d, new GammaParticle(185.0, 6.70185) }, { 5.585754481537429e-06d, new GammaParticle(2306.0, 0.53766) }, { 1.1054333032925845e-05d, new GammaParticle(2308.0, 0.53719) }, { 1.031685425896723e-06d, new GammaParticle(2466.0, 0.50277) }, { 1.031685425896723e-06d, new GammaParticle(2466.0, 0.50277) } } },
            { 0.00054d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon28() }, { 1.0d, new AlphaParticle(6755099.1899999995) } } },
            { 0.00026d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus31() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    