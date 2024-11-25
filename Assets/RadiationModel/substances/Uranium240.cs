using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium240";
        public override double halfLife { get; } = 50760.0d;
        public override double atomicWeight { get; } = 240.05659d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium240() }, { 1.0d, new BetaParticle(-1, 199750.0) }, { 0.0105d, new GammaParticle(44100.0, 0.02811) }, { 7.000000000000001e-05d, new GammaParticle(49100.0, 0.02525) }, { 5e-05d, new GammaParticle(50300.0, 0.02465) }, { 0.00154d, new GammaParticle(66500.0, 0.01864) }, { 4e-05d, new GammaParticle(78100.0, 0.01588) }, { 0.00014000000000000001d, new GammaParticle(82600.0, 0.01501) }, { 0.0008699999999999999d, new GammaParticle(128300.0, 0.00966) }, { 0.0008100000000000001d, new GammaParticle(145400.0, 0.00853) }, { 8e-05d, new GammaParticle(167300.0, 0.00741) }, { 0.00115d, new GammaParticle(169200.0, 0.00733) }, { 0.0024d, new GammaParticle(189700.0, 0.00654) }, { 5e-05d, new GammaParticle(203900.0, 0.00608) }, { 1.5e-05d, new GammaParticle(212300.0, 0.00584) }, { 4e-05d, new GammaParticle(255600.0, 0.00485) }, { 0.00016d, new GammaParticle(280100.0, 0.00443) }, { 1.9e-05d, new GammaParticle(294800.0, 0.00421) }, { 0.00013d, new GammaParticle(299800.0, 0.00414) }, { 0.23608200000000001d, new GammaParticle(17136.0, 0.07235) } } },

        };
    }
}
    