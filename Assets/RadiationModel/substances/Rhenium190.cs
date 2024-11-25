using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium190";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 189.9618d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium190() }, { 1.0d, new BetaParticle(-1, 1562400.00001) }, { 0.49d, new GammaParticle(186680.0, 0.00664) }, { 0.017d, new GammaParticle(198080.0, 0.00626) }, { 0.0031d, new GammaParticle(199300.0, 0.00622) }, { 0.0084d, new GammaParticle(207910.0, 0.00596) }, { 0.0013d, new GammaParticle(207910.0, 0.00596) }, { 0.261d, new GammaParticle(223810.0, 0.00554) }, { 0.146d, new GammaParticle(361090.0, 0.00343) }, { 0.213d, new GammaParticle(371240.0, 0.00334) }, { 0.08d, new GammaParticle(397360.0, 0.00312) }, { 0.09699999999999999d, new GammaParticle(407220.0, 0.00304) }, { 0.057999999999999996d, new GammaParticle(407220.0, 0.00304) }, { 0.17d, new GammaParticle(431620.0, 0.00287) }, { 0.29d, new GammaParticle(557950.0, 0.00222) }, { 0.25d, new GammaParticle(569300.0, 0.00218) }, { 0.168d, new GammaParticle(605140.0, 0.00205) }, { 0.00199d, new GammaParticle(615390.0, 0.00201) }, { 0.177d, new GammaParticle(630910.0, 0.00197) }, { 0.027999999999999997d, new GammaParticle(768570.0, 0.00161) }, { 0.23d, new GammaParticle(828990.0, 0.0015) }, { 0.08d, new GammaParticle(839140.0, 0.00148) }, { 0.032d, new GammaParticle(1200240.0, 0.00103) }, { 0.013300000000000001d, new GammaParticle(1386950.0, 0.00089) }, { 0.0016d, new GammaParticle(1397100.0, 0.00089) }, { 0.0066d, new GammaParticle(1437500.0, 0.00086) }, { 0.0023d, new GammaParticle(1447700.0, 0.00086) }, { 0.0015d, new GammaParticle(1596400.0, 0.00078) }, { 0.0053d, new GammaParticle(1794500.0, 0.00069) }, { 0.0018d, new GammaParticle(1809300.0, 0.00069) }, { 0.0006d, new GammaParticle(2165500.0, 0.00057) }, { 0.0667295886030312d, new GammaParticle(10393.0, 0.1193) }, { 0.04105142687263074d, new GammaParticle(61486.0, 0.02016) }, { 0.07074173164334092d, new GammaParticle(63000.0, 0.01968) }, { 0.023668707779553374d, new GammaParticle(71496.0, 0.01734) }, { 0.03029594595782832d, new GammaParticle(72338.0, 0.01714) }, { 0.006627238178274945d, new GammaParticle(73364.0, 0.0169) } } },

        };
    }
}
    