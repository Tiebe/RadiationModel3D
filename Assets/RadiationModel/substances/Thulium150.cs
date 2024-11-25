using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium150";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 149.95009d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium150() }, { 1.0d, new BetaParticle(1, 7728000.0) }, { 0.013666395d, new GammaParticle(100700.0, 0.01231) }, { 0.04806801d, new GammaParticle(360400.0, 0.00344) }, { 0.09613602d, new GammaParticle(372400.0, 0.00333) }, { 0.6126315d, new GammaParticle(474400.0, 0.00261) }, { 0.07540079999999999d, new GammaParticle(508300.0, 0.00244) }, { 0.15739917d, new GammaParticle(594200.0, 0.00209) }, { 0.018850199999999998d, new GammaParticle(734700.0, 0.00169) }, { 0.040527930000000004d, new GammaParticle(1401100.0, 0.00088) }, { 0.03393036d, new GammaParticle(1513800.0, 0.00082) }, { 0.9425100000000001d, new GammaParticle(1578300.0, 0.00079) }, { 0.05560809d, new GammaParticle(1785900.0, 0.00069) }, { 0.03016032d, new GammaParticle(2177400.0, 0.00057) }, { 1.37d, new GammaParticle(511000.0, 0.00243) }, { 0.011196033748416d, new GammaParticle(7933.0, 0.15629) }, { 0.014302609380108862d, new GammaParticle(48222.0, 0.02571) }, { 0.025386243131183636d, new GammaParticle(49128.0, 0.02524) }, { 0.008249611486275796d, new GammaParticle(55779.0, 0.02223) }, { 0.010394510472707503d, new GammaParticle(56399.0, 0.02198) }, { 0.002144898986431707d, new GammaParticle(57145.0, 0.0217) } } },
            { 0.012d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium149() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    