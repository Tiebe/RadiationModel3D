using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon35 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon35";
        public override double halfLife { get; } = 1.7756d;
        public override double atomicWeight { get; } = 34.97526d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur35() }, { 1.0d, new BetaParticle(1, 2899455.0) }, { 2.0655e-05d, new GammaParticle(544000.0, 0.00228) }, { 0.00021194999999999997d, new GammaParticle(930700.0, 0.00133) }, { 0.00011745000000000001d, new GammaParticle(965000.0, 0.00128) }, { 0.013500000000000002d, new GammaParticle(1219300.0, 0.00102) }, { 8.1e-06d, new GammaParticle(1239000.0, 0.001) }, { 5.6699999999999996e-05d, new GammaParticle(1274000.0, 0.00097) }, { 0.00013769999999999999d, new GammaParticle(1474800.0, 0.00084) }, { 0.003051d, new GammaParticle(1763000.0, 0.0007) }, { 6.750000000000001e-06d, new GammaParticle(1783000.0, 0.0007) }, { 2.8349999999999998e-05d, new GammaParticle(1931000.0, 0.00064) }, { 2.0249999999999998e-05d, new GammaParticle(2155100.0, 0.00058) }, { 3.645e-05d, new GammaParticle(2204000.0, 0.00056) }, { 1.62e-05d, new GammaParticle(2645000.0, 0.00047) }, { 0.0014796000000000002d, new GammaParticle(2693700.0, 0.00046) }, { 4.455e-05d, new GammaParticle(2699000.0, 0.00046) }, { 6.4395e-05d, new GammaParticle(2748500.0, 0.00045) }, { 1.3500000000000001e-05d, new GammaParticle(2861000.0, 0.00043) }, { 0.00098415d, new GammaParticle(3002100.0, 0.00041) }, { 7.02e-05d, new GammaParticle(3918000.0, 0.00032) }, { 1.431e-05d, new GammaParticle(3968000.0, 0.00031) }, { 4.725e-06d, new GammaParticle(4624000.0, 0.00027) }, { 1.99866564d, new GammaParticle(511000.0, 0.00243) }, { 1.4999999999999998e-06d, new GammaParticle(223.0, 5.55983) }, { 2.14e-05d, new GammaParticle(2621.0, 0.47304) }, { 4.2199999999999996e-05d, new GammaParticle(2623.0, 0.47268) }, { 5.500000000000001e-06d, new GammaParticle(2816.0, 0.44028) }, { 5.500000000000001e-06d, new GammaParticle(2816.0, 0.44028) } } },

        };
    }
}
    