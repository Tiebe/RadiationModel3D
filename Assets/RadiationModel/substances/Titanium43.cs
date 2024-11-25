using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium43";
        public override double halfLife { get; } = 0.509d;
        public override double atomicWeight { get; } = 42.96853d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium43() }, { 1.0d, new BetaParticle(1, 4546435.0) }, { 0.001276d, new GammaParticle(151900.0, 0.00816) }, { 0.002112d, new GammaParticle(472700.0, 0.00262) }, { 0.001232d, new GammaParticle(562900.0, 0.0022) }, { 0.027676d, new GammaParticle(845200.0, 0.00147) }, { 0.000484d, new GammaParticle(880700.0, 0.00141) }, { 0.00043999999999999996d, new GammaParticle(936000.0, 0.00132) }, { 0.005544d, new GammaParticle(1408000.0, 0.00088) }, { 0.000572d, new GammaParticle(1443500.0, 0.00086) }, { 0.00021999999999999998d, new GammaParticle(1490200.0, 0.00083) }, { 0.00039600000000000003d, new GammaParticle(1815400.0, 0.00068) }, { 0.002596d, new GammaParticle(1882500.0, 0.00066) }, { 0.0009239999999999999d, new GammaParticle(2137100.0, 0.00058) }, { 0.044000000000000004d, new GammaParticle(2288300.0, 0.00054) }, { 0.003828d, new GammaParticle(2335400.0, 0.00053) }, { 0.009108d, new GammaParticle(2458600.0, 0.0005) }, { 0.00198d, new GammaParticle(2760000.0, 0.00045) }, { 0.0001056d, new GammaParticle(3259600.0, 0.00038) }, { 0.0001584d, new GammaParticle(3631500.0, 0.00034) }, { 1.9987799999999998d, new GammaParticle(511000.0, 0.00243) }, { 4.7e-06d, new GammaParticle(422.0, 2.93801) }, { 5.99e-05d, new GammaParticle(4086.0, 0.30344) }, { 0.000118d, new GammaParticle(4091.0, 0.30307) }, { 2.3500000000000002e-05d, new GammaParticle(4474.0, 0.27712) }, { 2.3500000000000002e-05d, new GammaParticle(4474.0, 0.27712) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    