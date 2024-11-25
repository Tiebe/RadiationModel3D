using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese50 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese50";
        public override double halfLife { get; } = 0.28319d;
        public override double atomicWeight { get; } = 49.95424d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium50() }, { 1.0d, new BetaParticle(1, 3298175.0) }, { 1.978e-08d, new GammaParticle(783000.0, 0.00158) }, { 0.00018999999999999998d, new GammaParticle(2844000.0, 0.00044) }, { 2.9999999999999997e-06d, new GammaParticle(3044000.0, 0.00041) }, { 0.00037999999999999997d, new GammaParticle(3628000.0, 0.00034) }, { 7e-06d, new GammaParticle(4215000.0, 0.00029) }, { 1.99792d, new GammaParticle(511000.0, 0.00243) }, { 6.7e-06d, new GammaParticle(597.0, 2.07679) }, { 7.929999999999999e-05d, new GammaParticle(5406.0, 0.22935) }, { 0.000156d, new GammaParticle(5415.0, 0.22896) }, { 3.16e-05d, new GammaParticle(5966.0, 0.20782) }, { 3.16e-05d, new GammaParticle(5966.0, 0.20782) } } },

        };
    }
}
    