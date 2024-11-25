using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese50m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese50m";
        public override double halfLife { get; } = 105.0d;
        public override double atomicWeight { get; } = 49.95448d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium50() }, { 1.0d, new BetaParticle(1, 3410835.0) }, { 0.02d, new GammaParticle(161000.0, 0.0077) }, { 0.25d, new GammaParticle(661500.0, 0.00187) }, { 1.0d, new GammaParticle(783300.0, 0.00158) }, { 0.985d, new GammaParticle(1098000.0, 0.00113) }, { 0.33d, new GammaParticle(1282400.0, 0.00097) }, { 0.69d, new GammaParticle(1443300.0, 0.00086) }, { 0.005d, new GammaParticle(1793500.0, 0.00069) }, { 0.038d, new GammaParticle(1944500.0, 0.00064) }, { 0.0016d, new GammaParticle(2404400.0, 0.00052) }, { 0.01d, new GammaParticle(2541000.0, 0.00049) }, { 0.02d, new GammaParticle(3042000.0, 0.00041) }, { 2.11d, new GammaParticle(511000.0, 0.00243) }, { 6e-05d, new GammaParticle(597.0, 2.07679) }, { 0.0007099999999999999d, new GammaParticle(5406.0, 0.22935) }, { 0.0014000000000000002d, new GammaParticle(5415.0, 0.22896) }, { 0.000284d, new GammaParticle(5966.0, 0.20782) }, { 0.000284d, new GammaParticle(5966.0, 0.20782) } } },

        };
    }
}
    