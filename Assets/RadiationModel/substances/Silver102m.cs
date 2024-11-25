using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver102m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver102m";
        public override double halfLife { get; } = 462.0d;
        public override double atomicWeight { get; } = 101.91171d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium102() }, { 1.0d, new BetaParticle(1, 2272500.0) }, { 0.42560000000000003d, new GammaParticle(556700.0, 0.00223) }, { 0.04522d, new GammaParticle(719400.0, 0.00172) }, { 0.026600000000000002d, new GammaParticle(977700.0, 0.00127) }, { 0.02926d, new GammaParticle(1331200.0, 0.00093) }, { 0.015960000000000002d, new GammaParticle(1387800.0, 0.00089) }, { 0.04522d, new GammaParticle(1461100.0, 0.00085) }, { 0.026600000000000002d, new GammaParticle(1534800.0, 0.00081) }, { 0.011970000000000001d, new GammaParticle(1588800.0, 0.00078) }, { 0.02261d, new GammaParticle(1692300.0, 0.00073) }, { 0.09842000000000001d, new GammaParticle(1834700.0, 0.00068) }, { 0.01064d, new GammaParticle(1924900.0, 0.00064) }, { 0.02793d, new GammaParticle(2017800.0, 0.00061) }, { 0.0665d, new GammaParticle(2054500.0, 0.0006) }, { 0.00532d, new GammaParticle(2110700.0, 0.00059) }, { 0.05054d, new GammaParticle(2159400.0, 0.00057) }, { 0.013300000000000001d, new GammaParticle(2310200.0, 0.00054) }, { 0.007980000000000001d, new GammaParticle(2493900.0, 0.0005) }, { 0.007980000000000001d, new GammaParticle(2566900.0, 0.00048) }, { 0.03325d, new GammaParticle(2613000.0, 0.00047) }, { 0.01729d, new GammaParticle(2682100.0, 0.00046) }, { 0.00931d, new GammaParticle(2690900.0, 0.00046) }, { 0.01862d, new GammaParticle(2716500.0, 0.00046) }, { 0.013300000000000001d, new GammaParticle(2726900.0, 0.00045) }, { 0.007980000000000001d, new GammaParticle(2805000.0, 0.00044) }, { 0.049210000000000004d, new GammaParticle(3238600.0, 0.00038) }, { 0.013300000000000001d, new GammaParticle(3398000.0, 0.00036) }, { 0.015960000000000002d, new GammaParticle(3406500.0, 0.00036) }, { 0.7120000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.0084563130224d, new GammaParticle(3053.0, 0.40611) }, { 0.03366288921048357d, new GammaParticle(21020.0, 0.05898) }, { 0.06359888382861056d, new GammaParticle(21177.0, 0.05855) }, { 0.01744892834265458d, new GammaParticle(23904.0, 0.05187) }, { 0.02041524616090586d, new GammaParticle(24070.0, 0.05151) }, { 0.002966317818251279d, new GammaParticle(24297.0, 0.05103) } } },
            { 0.49d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver102() }, { 4.0999999999999997e-08d, new GammaParticle(9300.0, 0.13332) }, { 0.025480598d, new GammaParticle(3218.0, 0.38528) } } },

        };
    }
}
    