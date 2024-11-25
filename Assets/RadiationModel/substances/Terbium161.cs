using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium161";
        public override double halfLife { get; } = 595296.0d;
        public override double atomicWeight { get; } = 160.92758d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium161() }, { 1.0d, new BetaParticle(-1, 296849.99999) }, { 0.00021d, new GammaParticle(18150.0, 0.06831) }, { 0.23154d, new GammaParticle(25651.35, 0.04833) }, { 0.00036516d, new GammaParticle(28701.0, 0.0432) }, { 0.0006018d, new GammaParticle(43810.0, 0.0283) }, { 0.17034d, new GammaParticle(48915.33, 0.02535) }, { 0.017849999999999998d, new GammaParticle(57191.7, 0.02168) }, { 0.00022235999999999998d, new GammaParticle(59243.0, 0.02093) }, { 0.102d, new GammaParticle(74566.69, 0.01663) }, { 0.0005967d, new GammaParticle(77422.0, 0.01601) }, { 2.244e-05d, new GammaParticle(81270.0, 0.01526) }, { 4.182e-06d, new GammaParticle(84730.0, 0.01463) }, { 0.0018257999999999998d, new GammaParticle(87941.0, 0.0141) }, { 1.02e-06d, new GammaParticle(100500.0, 0.01234) }, { 0.0010098d, new GammaParticle(103065.0, 0.01203) }, { 0.00077826d, new GammaParticle(106113.0, 0.01168) }, { 1.122e-06d, new GammaParticle(112600.0, 0.01101) }, { 1.02e-06d, new GammaParticle(131800.0, 0.00941) }, { 7.956e-06d, new GammaParticle(138300.0, 0.00896) }, { 3.876e-07d, new GammaParticle(212800.0, 0.00583) }, { 2.2644000000000002e-05d, new GammaParticle(238570.0, 0.0052) }, { 0.0001428d, new GammaParticle(286481.0, 0.00433) }, { 0.0005813999999999999d, new GammaParticle(292401.0, 0.00424) }, { 5.5080000000000005e-06d, new GammaParticle(315100.0, 0.00393) }, { 3.3048e-05d, new GammaParticle(319660.0, 0.00388) }, { 3.468e-05d, new GammaParticle(341400.0, 0.00363) }, { 0.0001326d, new GammaParticle(343630.0, 0.00361) }, { 5.712e-06d, new GammaParticle(348200.0, 0.00356) }, { 6.12e-06d, new GammaParticle(376810.0, 0.00329) }, { 2.1012e-05d, new GammaParticle(392570.0, 0.00316) }, { 8.057999999999999e-05d, new GammaParticle(418470.0, 0.00296) }, { 2.958e-06d, new GammaParticle(425800.0, 0.00291) }, { 0.00018156d, new GammaParticle(475658.0, 0.00261) }, { 8.466e-06d, new GammaParticle(506680.0, 0.00245) }, { 0.00036209999999999997d, new GammaParticle(550249.0, 0.00225) }, { 0.2143537540898185d, new GammaParticle(7384.0, 0.16791) }, { 0.06292804736503083d, new GammaParticle(45207.0, 0.02743) }, { 0.11245183589176344d, new GammaParticle(45998.0, 0.02695) }, { 0.036105985489533685d, new GammaParticle(52220.0, 0.02374) }, { 0.04549354171681244d, new GammaParticle(52791.0, 0.02349) }, { 0.009387556227278758d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    