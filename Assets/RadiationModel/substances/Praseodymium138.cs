using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium138";
        public override double halfLife { get; } = 87.0d;
        public override double atomicWeight { get; } = 137.91076d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum138() }, { 1.0d, new BetaParticle(1, 1692200.0) }, { 0.00055d, new GammaParticle(581000.0, 0.00213) }, { 0.00855d, new GammaParticle(688200.0, 0.0018) }, { 0.0008d, new GammaParticle(722300.0, 0.00172) }, { 0.00015d, new GammaParticle(755000.0, 0.00164) }, { 0.000125d, new GammaParticle(772000.0, 0.00161) }, { 0.025d, new GammaParticle(788700.0, 0.00157) }, { 0.00045d, new GammaParticle(1081900.0, 0.00115) }, { 0.0001125d, new GammaParticle(1092100.0, 0.00114) }, { 6.25e-05d, new GammaParticle(1172800.0, 0.00106) }, { 0.00035000000000000005d, new GammaParticle(1248000.0, 0.00099) }, { 0.0001125d, new GammaParticle(1347800.0, 0.00092) }, { 0.000375d, new GammaParticle(1358900.0, 0.00091) }, { 0.000125d, new GammaParticle(1426900.0, 0.00087) }, { 0.0009750000000000001d, new GammaParticle(1430800.0, 0.00087) }, { 0.0005d, new GammaParticle(1432600.0, 0.00087) }, { 0.00135d, new GammaParticle(1447800.0, 0.00086) }, { 0.0009d, new GammaParticle(1510200.0, 0.00082) }, { 0.004375d, new GammaParticle(1551100.0, 0.0008) }, { 0.0001d, new GammaParticle(1619900.0, 0.00077) }, { 0.0002d, new GammaParticle(1631100.0, 0.00076) }, { 0.000375d, new GammaParticle(1682100.0, 0.00074) }, { 0.00035000000000000005d, new GammaParticle(1804200.0, 0.00069) }, { 0.00025d, new GammaParticle(1853700.0, 0.00067) }, { 0.00055d, new GammaParticle(1893200.0, 0.00065) }, { 0.0004d, new GammaParticle(2114400.0, 0.00059) }, { 3.75e-05d, new GammaParticle(2223300.0, 0.00056) }, { 0.000825d, new GammaParticle(2236500.0, 0.00055) }, { 6.25e-05d, new GammaParticle(2298100.0, 0.00054) }, { 0.00055d, new GammaParticle(2471100.0, 0.0005) }, { 8.750000000000001e-05d, new GammaParticle(2642000.0, 0.00047) }, { 8.750000000000001e-05d, new GammaParticle(2922600.0, 0.00042) }, { 9.25e-05d, new GammaParticle(3177400.0, 0.00039) }, { 1.49922d, new GammaParticle(511000.0, 0.00243) }, { 0.026981656643675002d, new GammaParticle(5410.0, 0.22918) }, { 0.05498665877792917d, new GammaParticle(34279.0, 0.03617) }, { 0.10070816625994354d, new GammaParticle(34720.0, 0.03571) }, { 0.030331934415272967d, new GammaParticle(39366.0, 0.0315) }, { 0.0380362457567523d, new GammaParticle(39753.0, 0.03119) }, { 0.007704311341479334d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    