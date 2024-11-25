using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium140";
        public override double halfLife { get; } = 0.348d;
        public override double atomicWeight { get; } = 139.93949d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine140() }, { 1.0d, new BetaParticle(-1, 3619500.0) }, { 0.018744d, new GammaParticle(44000.0, 0.02818) }, { 0.043296d, new GammaParticle(51400.0, 0.02412) }, { 0.017952d, new GammaParticle(56000.0, 0.02214) }, { 0.049896d, new GammaParticle(77700.0, 0.01596) }, { 0.081048d, new GammaParticle(102000.0, 0.01216) }, { 0.01452d, new GammaParticle(113800.0, 0.01089) }, { 0.0113256d, new GammaParticle(120900.0, 0.01026) }, { 0.026928d, new GammaParticle(134200.0, 0.00924) }, { 0.032736d, new GammaParticle(142400.0, 0.00871) }, { 0.032472d, new GammaParticle(185600.0, 0.00668) }, { 0.055704000000000004d, new GammaParticle(198100.0, 0.00626) }, { 0.0158928d, new GammaParticle(229400.0, 0.0054) }, { 0.061248d, new GammaParticle(234500.0, 0.00529) }, { 0.06890399999999999d, new GammaParticle(342100.0, 0.00362) }, { 0.03168d, new GammaParticle(351900.0, 0.00352) }, { 0.0079992d, new GammaParticle(382600.0, 0.00324) }, { 0.0061776d, new GammaParticle(435200.0, 0.00285) }, { 0.0068376d, new GammaParticle(497000.0, 0.00249) }, { 0.005676d, new GammaParticle(583300.0, 0.00213) }, { 0.020011199999999996d, new GammaParticle(620300.0, 0.002) }, { 0.0065208d, new GammaParticle(646500.0, 0.00192) }, { 0.028248000000000002d, new GammaParticle(722300.0, 0.00172) }, { 0.00924d, new GammaParticle(734700.0, 0.00169) }, { 0.076824d, new GammaParticle(739800.0, 0.00168) }, { 0.0166584d, new GammaParticle(783300.0, 0.00158) }, { 0.0136224d, new GammaParticle(790600.0, 0.00157) }, { 0.039336d, new GammaParticle(804500.0, 0.00154) }, { 0.019905600000000002d, new GammaParticle(817800.0, 0.00152) }, { 0.018216d, new GammaParticle(830000.0, 0.00149) }, { 0.06732d, new GammaParticle(875000.0, 0.00142) }, { 0.012012d, new GammaParticle(925100.0, 0.00134) }, { 0.0218328d, new GammaParticle(952900.0, 0.0013) }, { 0.002376d, new GammaParticle(1045700.0, 0.00119) }, { 0.0163944d, new GammaParticle(1067100.0, 0.00116) }, { 0.038016d, new GammaParticle(1136400.0, 0.00109) }, { 0.006362400000000001d, new GammaParticle(1188500.0, 0.00104) }, { 0.0016896d, new GammaParticle(1551600.0, 0.0008) }, { 0.0055704d, new GammaParticle(1601100.0, 0.00077) }, { 0.0028776d, new GammaParticle(1644500.0, 0.00075) }, { 0.0024024000000000003d, new GammaParticle(1787200.0, 0.00069) }, { 0.05109961887190871d, new GammaParticle(4335.0, 0.28601) }, { 0.13395644694244185d, new GammaParticle(28318.0, 0.04378) }, { 0.24880469342949826d, new GammaParticle(28613.0, 0.04333) }, { 0.071681857935887d, new GammaParticle(32395.0, 0.03827) }, { 0.08788195782939745d, new GammaParticle(32680.0, 0.03794) }, { 0.01620009989351046d, new GammaParticle(33040.0, 0.03753) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    