using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium44";
        public override double halfLife { get; } = 0.111d;
        public override double atomicWeight { get; } = 43.97444d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium44() }, { 1.0d, new BetaParticle(1, 7004000.0) }, { 0.91d, new GammaParticle(1083080.0, 0.00114) }, { 0.217d, new GammaParticle(1447880.0, 0.00086) }, { 0.092d, new GammaParticle(2530860.0, 0.00049) }, { 0.066d, new GammaParticle(2947900.0, 0.00042) }, { 0.147d, new GammaParticle(3032100.0, 0.00041) }, { 0.077d, new GammaParticle(4075200.0, 0.0003) }, { 0.22d, new GammaParticle(5523100.0, 0.00022) }, { 2.0140000000000002d, new GammaParticle(511000.0, 0.00243) }, { 2.6183860220568e-06d, new GammaParticle(477.0, 2.59925) }, { 3.278959915535415e-05d, new GammaParticle(4505.0, 0.27521) }, { 6.459731906098138e-05d, new GammaParticle(4511.0, 0.27485) }, { 1.290376666366446e-05d, new GammaParticle(4947.0, 0.25063) }, { 1.290376666366446e-05d, new GammaParticle(4947.0, 0.25063) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    