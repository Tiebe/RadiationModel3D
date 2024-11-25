using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper58 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper58";
        public override double halfLife { get; } = 3.204d;
        public override double atomicWeight { get; } = 57.94453d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt58() }, { 1.0d, new BetaParticle(1, 4089700.0) }, { 0.0507d, new GammaParticle(40300.0, 0.03077) }, { 0.009633000000000001d, new GammaParticle(167200.0, 0.00742) }, { 0.001183d, new GammaParticle(818600.0, 0.00151) }, { 0.006928999999999999d, new GammaParticle(855000.0, 0.00145) }, { 0.012337d, new GammaParticle(1321400.0, 0.00094) }, { 0.12168d, new GammaParticle(1448300.0, 0.00086) }, { 0.16899999999999998d, new GammaParticle(1454600.0, 0.00085) }, { 0.011153999999999999d, new GammaParticle(1488600.0, 0.00083) }, { 0.0007605000000000001d, new GammaParticle(1547000.0, 0.0008) }, { 0.0021294d, new GammaParticle(1584200.0, 0.00078) }, { 0.0008619000000000001d, new GammaParticle(1673800.0, 0.00074) }, { 0.004225d, new GammaParticle(1810100.0, 0.00068) }, { 0.0007266999999999999d, new GammaParticle(2077600.0, 0.0006) }, { 0.0007098d, new GammaParticle(2140200.0, 0.00058) }, { 0.0008112d, new GammaParticle(2445600.0, 0.00051) }, { 0.0007774d, new GammaParticle(2776200.0, 0.00045) }, { 0.0052052d, new GammaParticle(2902500.0, 0.00043) }, { 0.0010985d, new GammaParticle(3038500.0, 0.00041) }, { 0.0010478d, new GammaParticle(3083700.0, 0.0004) }, { 0.007267d, new GammaParticle(3264500.0, 0.00038) }, { 0.0045799000000000005d, new GammaParticle(3595000.0, 0.00034) }, { 0.0004225d, new GammaParticle(3898500.0, 0.00032) }, { 2.00476d, new GammaParticle(511000.0, 0.00243) }, { 0.00035999999999999997d, new GammaParticle(874.0, 1.41858) }, { 0.0036d, new GammaParticle(7461.0, 0.16618) }, { 0.0070999999999999995d, new GammaParticle(7478.0, 0.1658) }, { 0.00147d, new GammaParticle(8296.0, 0.14945) }, { 0.00147d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    