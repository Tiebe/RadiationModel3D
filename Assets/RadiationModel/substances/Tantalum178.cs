using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum178 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum178";
        public override double halfLife { get; } = 8496.0d;
        public override double atomicWeight { get; } = 177.94568d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium178() }, { 1.0d, new BetaParticle(1, -131050.0) }, { 0.6690510000000001d, new GammaParticle(88857.0, 0.01395) }, { 0.06576d, new GammaParticle(93130.0, 0.01331) }, { 0.173144d, new GammaParticle(93179.0, 0.01331) }, { 4.7999999999999994e-05d, new GammaParticle(151280.0, 0.0082) }, { 7.44e-05d, new GammaParticle(203730.0, 0.00609) }, { 3.84e-05d, new GammaParticle(204100.0, 0.00607) }, { 0.0008592d, new GammaParticle(213390.0, 0.00581) }, { 0.808319d, new GammaParticle(213434.0, 0.00581) }, { 0.0024465999999999997d, new GammaParticle(216640.0, 0.00572) }, { 3.3600000000000004e-05d, new GammaParticle(256540.0, 0.00483) }, { 0.0001824d, new GammaParticle(269400.0, 0.0046) }, { 0.941d, new GammaParticle(325555.0, 0.00381) }, { 0.3119415d, new GammaParticle(331608.0, 0.00374) }, { 0.973935d, new GammaParticle(426355.0, 0.00291) }, { 0.000552d, new GammaParticle(970030.0, 0.00128) }, { 0.00017952d, new GammaParticle(1081520.0, 0.00115) }, { 0.0053568d, new GammaParticle(1106090.0, 0.00112) }, { 0.00015792d, new GammaParticle(1174630.0, 0.00106) }, { 0.0016944d, new GammaParticle(1183380.0, 0.00105) }, { 0.0002256d, new GammaParticle(1189490.0, 0.00104) }, { 6.624e-05d, new GammaParticle(1216790.0, 0.00102) }, { 0.0003552d, new GammaParticle(1254730.0, 0.00099) }, { 0.00028512d, new GammaParticle(1269230.0, 0.00098) }, { 0.0003552d, new GammaParticle(1276540.0, 0.00097) }, { 0.00041279999999999995d, new GammaParticle(1309900.0, 0.00095) }, { 0.010271999999999998d, new GammaParticle(1340850.0, 0.00092) }, { 0.01176d, new GammaParticle(1350550.0, 0.00092) }, { 0.0048d, new GammaParticle(1402870.0, 0.00088) }, { 4.176e-05d, new GammaParticle(1420540.0, 0.00087) }, { 0.0001224d, new GammaParticle(1468130.0, 0.00084) }, { 3.12e-05d, new GammaParticle(1473320.0, 0.00084) }, { 0.002688d, new GammaParticle(1496010.0, 0.00083) }, { 4.608e-05d, new GammaParticle(1513630.0, 0.00082) }, { 0.0001056d, new GammaParticle(1561300.0, 0.00079) }, { 3.696e-05d, new GammaParticle(1678810.0, 0.00074) }, { 0.0248d, new GammaParticle(511000.0, 0.00243) }, { 0.27220299078569915d, new GammaParticle(9114.0, 0.13604) }, { 0.501865144192048d, new GammaParticle(9114.0, 0.13604) }, { 0.39135432983127694d, new GammaParticle(54608.0, 0.0227) }, { 0.24138739588632618d, new GammaParticle(54608.0, 0.0227) }, { 0.4224490652543335d, new GammaParticle(55786.0, 0.02222) }, { 0.6849043224208557d, new GammaParticle(55786.0, 0.02222) }, { 0.13936898079196172d, new GammaParticle(63333.0, 0.01958) }, { 0.22595485516895603d, new GammaParticle(63333.0, 0.01958) }, { 0.1765804986634155d, new GammaParticle(64057.0, 0.01936) }, { 0.28628480149906727d, new GammaParticle(64057.0, 0.01936) }, { 0.06032994633011127d, new GammaParticle(64935.0, 0.01909) }, { 0.037211517871453784d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    