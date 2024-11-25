using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium88";
        public override double halfLife { get; } = 1.53d;
        public override double atomicWeight { get; } = 87.93142d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine88() }, { 1.0d, new BetaParticle(-1, 3416000.0) }, { 0.016191999999999998d, new GammaParticle(113500.0, 0.01092) }, { 0.184d, new GammaParticle(159200.0, 0.00779) }, { 0.053360000000000005d, new GammaParticle(249500.0, 0.00497) }, { 0.15088d, new GammaParticle(259200.0, 0.00478) }, { 0.07544d, new GammaParticle(272700.0, 0.00455) }, { 0.030728d, new GammaParticle(293300.0, 0.00423) }, { 0.06256d, new GammaParticle(408700.0, 0.00303) }, { 0.029807999999999998d, new GammaParticle(566000.0, 0.00219) }, { 0.06072d, new GammaParticle(1495000.0, 0.00083) }, { 0.10672000000000001d, new GammaParticle(1644500.0, 0.00075) }, { 0.11408d, new GammaParticle(1744500.0, 0.00071) }, { 0.11776d, new GammaParticle(1903700.0, 0.00065) }, { 0.06808d, new GammaParticle(2894800.0, 0.00043) }, { 0.00016073908800000002d, new GammaParticle(1535.0, 0.80771) }, { 0.001181420075526435d, new GammaParticle(11879.0, 0.10437) }, { 0.0022802935254322234d, new GammaParticle(11925.0, 0.10397) }, { 0.0005408525798749928d, new GammaParticle(13345.0, 0.09291) }, { 0.0005826063990413422d, new GammaParticle(13377.0, 0.09268) }, { 4.175381916634945e-05d, new GammaParticle(13469.0, 0.09205) } } },
            { 0.009899999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine88() }, { 1.0d, new BetaParticle(-1, 3416000.0) }, { 0.016191999999999998d, new GammaParticle(113500.0, 0.01092) }, { 0.184d, new GammaParticle(159200.0, 0.00779) }, { 0.053360000000000005d, new GammaParticle(249500.0, 0.00497) }, { 0.15088d, new GammaParticle(259200.0, 0.00478) }, { 0.07544d, new GammaParticle(272700.0, 0.00455) }, { 0.030728d, new GammaParticle(293300.0, 0.00423) }, { 0.06256d, new GammaParticle(408700.0, 0.00303) }, { 0.029807999999999998d, new GammaParticle(566000.0, 0.00219) }, { 0.06072d, new GammaParticle(1495000.0, 0.00083) }, { 0.10672000000000001d, new GammaParticle(1644500.0, 0.00075) }, { 0.11408d, new GammaParticle(1744500.0, 0.00071) }, { 0.11776d, new GammaParticle(1903700.0, 0.00065) }, { 0.06808d, new GammaParticle(2894800.0, 0.00043) }, { 0.00016073908800000002d, new GammaParticle(1535.0, 0.80771) }, { 0.001181420075526435d, new GammaParticle(11879.0, 0.10437) }, { 0.0022802935254322234d, new GammaParticle(11925.0, 0.10397) }, { 0.0005408525798749928d, new GammaParticle(13345.0, 0.09291) }, { 0.0005826063990413422d, new GammaParticle(13377.0, 0.09268) }, { 4.175381916634945e-05d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    