using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper70 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper70";
        public override double halfLife { get; } = 44.5d;
        public override double atomicWeight { get; } = 69.93239d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc70() }, { 1.0d, new BetaParticle(-1, 3294150.0) }, { 0.013999999999999999d, new GammaParticle(438200.0, 0.00283) }, { 0.0103d, new GammaParticle(560820.0, 0.00221) }, { 0.0083d, new GammaParticle(584700.0, 0.00212) }, { 0.0125d, new GammaParticle(750000.0, 0.00165) }, { 0.0049d, new GammaParticle(783100.0, 0.00158) }, { 1.0d, new GammaParticle(884880.0, 0.0014) }, { 0.02d, new GammaParticle(893100.0, 0.00139) }, { 0.997d, new GammaParticle(901700.0, 0.00138) }, { 0.0024d, new GammaParticle(906500.0, 0.00137) }, { 0.0074d, new GammaParticle(963300.0, 0.00129) }, { 0.0072d, new GammaParticle(988000.0, 0.00125) }, { 0.0058d, new GammaParticle(1023300.0, 0.00121) }, { 0.09300000000000001d, new GammaParticle(1108400.0, 0.00112) }, { 0.0216d, new GammaParticle(1226300.0, 0.00101) }, { 0.733d, new GammaParticle(1251700.0, 0.00099) }, { 0.0165d, new GammaParticle(1270800.0, 0.00098) }, { 0.005699999999999999d, new GammaParticle(1315000.0, 0.00094) }, { 0.0070999999999999995d, new GammaParticle(1413900.0, 0.00088) }, { 0.026000000000000002d, new GammaParticle(1426500.0, 0.00087) }, { 0.013500000000000002d, new GammaParticle(1476100.0, 0.00084) }, { 0.012d, new GammaParticle(1520100.0, 0.00082) }, { 0.013999999999999999d, new GammaParticle(1550600.0, 0.0008) }, { 0.009399999999999999d, new GammaParticle(1555200.0, 0.0008) }, { 0.0083d, new GammaParticle(1569800.0, 0.00079) }, { 0.063d, new GammaParticle(1690300.0, 0.00073) }, { 0.0026d, new GammaParticle(1809100.0, 0.00069) }, { 0.0104d, new GammaParticle(1815000.0, 0.00068) }, { 0.027999999999999997d, new GammaParticle(1954200.0, 0.00063) }, { 0.049d, new GammaParticle(2061600.0, 0.0006) }, { 0.005699999999999999d, new GammaParticle(2117200.0, 0.00059) }, { 0.005d, new GammaParticle(2166200.0, 0.00057) }, { 0.0178d, new GammaParticle(2771200.0, 0.00045) }, { 0.0239d, new GammaParticle(3062100.0, 0.0004) }, { 1.1852251734096e-05d, new GammaParticle(1035.0, 1.19791) }, { 0.0001112114501431319d, new GammaParticle(8616.0, 0.1439) }, { 0.0002162805331449473d, new GammaParticle(8639.0, 0.14352) }, { 4.640561403192083e-05d, new GammaParticle(9610.0, 0.12902) }, { 4.640561403192083e-05d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    