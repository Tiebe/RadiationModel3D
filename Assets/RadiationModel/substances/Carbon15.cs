using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon15 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon15";
        public override double halfLife { get; } = 2.449d;
        public override double atomicWeight { get; } = 15.0106d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen15() }, { 1.0d, new BetaParticle(-1, 4885830.95) }, { 2.4000000000000003e-07d, new GammaParticle(977020.0, 0.00127) }, { 1.8e-05d, new GammaParticle(1011750.0, 0.00123) }, { 5e-06d, new GammaParticle(1157520.0, 0.00107) }, { 4.7e-06d, new GammaParticle(1416280.0, 0.00088) }, { 4.1e-06d, new GammaParticle(1748770.0, 0.00071) }, { 1e-05d, new GammaParticle(1884770.0, 0.00066) }, { 1.8e-05d, new GammaParticle(1988700.0, 0.00062) }, { 1.9e-07d, new GammaParticle(2001860.0, 0.00062) }, { 5.8e-07d, new GammaParticle(2030530.0, 0.00061) }, { 1.8000000000000001e-06d, new GammaParticle(2247440.0, 0.00055) }, { 1.5e-05d, new GammaParticle(2725660.0, 0.00045) }, { 4.1e-05d, new GammaParticle(3013470.0, 0.00041) }, { 1.4e-05d, new GammaParticle(3042130.0, 0.00041) }, { 8.4e-05d, new GammaParticle(3300850.0, 0.00038) }, { 1.1999999999999999e-05d, new GammaParticle(3779040.0, 0.00033) }, { 3.7000000000000005e-05d, new GammaParticle(5269161.0, 0.00024) }, { 0.632d, new GammaParticle(5297817.0, 0.00023) }, { 5.4999999999999995e-05d, new GammaParticle(6322350.0, 0.0002) }, { 9.499999999999999e-05d, new GammaParticle(7298920.0, 0.00017) }, { 0.00032d, new GammaParticle(8310150.0, 0.00015) }, { 4.3e-05d, new GammaParticle(8568770.0, 0.00014) }, { 0.00031d, new GammaParticle(9046780.0, 0.00014) } } },

        };
    }
}
    