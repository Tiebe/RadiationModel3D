using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium37 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium37";
        public override double halfLife { get; } = 1.225d;
        public override double atomicWeight { get; } = 36.97338d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine37() }, { 1.0d, new BetaParticle(1, 3480675.0) }, { 2e-06d, new GammaParticle(879000.0, 0.00141) }, { 0.000263d, new GammaParticle(1184840.0, 0.00105) }, { 4.3e-05d, new GammaParticle(1386250.0, 0.00089) }, { 9.599999999999999e-05d, new GammaParticle(1409780.0, 0.00088) }, { 0.000289d, new GammaParticle(1611240.0, 0.00077) }, { 9e-06d, new GammaParticle(2191500.0, 0.00057) }, { 2.7000000000000002e-05d, new GammaParticle(2490000.0, 0.0005) }, { 1.8000000000000001e-06d, new GammaParticle(2528000.0, 0.00049) }, { 0.0204d, new GammaParticle(2795970.0, 0.00044) }, { 2.7000000000000002e-05d, new GammaParticle(3169650.0, 0.00039) }, { 0.000215d, new GammaParticle(3601600.0, 0.00034) }, { 9.7e-06d, new GammaParticle(3937700.0, 0.00031) }, { 1.9979018d, new GammaParticle(511000.0, 0.00243) }, { 2.256469593606627e-06d, new GammaParticle(265.0, 4.67865) }, { 3.1072399719511264e-05d, new GammaParticle(2956.0, 0.41943) }, { 6.154169086851112e-05d, new GammaParticle(2958.0, 0.41915) }, { 9.993060374447614e-06d, new GammaParticle(3190.0, 0.38867) }, { 9.993060374447614e-06d, new GammaParticle(3190.0, 0.38867) } } },

        };
    }
}
    