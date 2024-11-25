using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum141 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum141";
        public override double halfLife { get; } = 14112.0d;
        public override double atomicWeight { get; } = 140.91097d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium141() }, { 1.0d, new BetaParticle(-1, 1250550.0) }, { 1.3e-05d, new GammaParticle(324600.0, 0.00382) }, { 7e-06d, new GammaParticle(435000.0, 0.00285) }, { 7e-06d, new GammaParticle(474900.0, 0.00261) }, { 1e-05d, new GammaParticle(547100.0, 0.00227) }, { 1e-05d, new GammaParticle(561800.0, 0.00221) }, { 1.1999999999999999e-05d, new GammaParticle(581100.0, 0.00213) }, { 1e-05d, new GammaParticle(589900.0, 0.0021) }, { 0.000259d, new GammaParticle(662060.0, 0.00187) }, { 1.3e-05d, new GammaParticle(676800.0, 0.00183) }, { 1.1999999999999999e-05d, new GammaParticle(694900.0, 0.00178) }, { 3.1e-05d, new GammaParticle(710400.0, 0.00175) }, { 2e-05d, new GammaParticle(834800.0, 0.00149) }, { 3.1e-05d, new GammaParticle(853000.0, 0.00145) }, { 1.5e-05d, new GammaParticle(964000.0, 0.00129) }, { 0.016399999999999998d, new GammaParticle(1354520.0, 0.00092) }, { 4.9e-05d, new GammaParticle(1368700.0, 0.00091) }, { 0.000182d, new GammaParticle(1497000.0, 0.00083) }, { 9.2e-05d, new GammaParticle(1512100.0, 0.00082) }, { 8.5e-05d, new GammaParticle(1604800.0, 0.00077) }, { 0.00074d, new GammaParticle(1693300.0, 0.00073) }, { 0.000156d, new GammaParticle(1739000.0, 0.00071) }, { 3.3e-05d, new GammaParticle(1943700.0, 0.00064) }, { 5.1000000000000006e-05d, new GammaParticle(2030200.0, 0.00061) }, { 2.3e-05d, new GammaParticle(2049200.0, 0.00061) }, { 0.00020299999999999997d, new GammaParticle(2171100.0, 0.00057) }, { 0.000164d, new GammaParticle(2173900.0, 0.00057) }, { 7.900000000000001e-05d, new GammaParticle(2207300.0, 0.00056) }, { 0.00041d, new GammaParticle(2267000.0, 0.00055) }, { 5e-06d, new GammaParticle(2328900.0, 0.00053) }, { 2.6469180799999996e-07d, new GammaParticle(5410.0, 0.22918) }, { 5.393869605764512e-07d, new GammaParticle(34279.0, 0.03617) }, { 9.878882061839765e-07d, new GammaParticle(34720.0, 0.03571) }, { 2.9753853527876594e-07d, new GammaParticle(39366.0, 0.0315) }, { 3.731133232395725e-07d, new GammaParticle(39753.0, 0.03119) }, { 7.557478796080654e-08d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    