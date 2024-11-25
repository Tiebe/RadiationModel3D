using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium208";
        public override double halfLife { get; } = 91451971.47437d;
        public override double atomicWeight { get; } = 207.98125d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99996d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead204() }, { 1.0d, new AlphaParticle(6237602.09) } } },
            { 4e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead208() }, { 1.0d, new BetaParticle(1, 2139650.00001) }, { 2.7e-07d, new GammaParticle(31800.0, 0.03899) }, { 3.4e-06d, new GammaParticle(63130.0, 0.01964) }, { 2.27e-05d, new GammaParticle(291810.0, 0.00425) }, { 5e-06d, new GammaParticle(538390.0, 0.0023) }, { 1.38e-05d, new GammaParticle(570130.0, 0.00217) }, { 1.07e-05d, new GammaParticle(601520.0, 0.00206) }, { 7.4e-06d, new GammaParticle(861820.0, 0.00144) }, { 5e-07d, new GammaParticle(925110.0, 0.00134) }, { 2.8951154085722e-05d, new GammaParticle(12904.0, 0.09608) }, { 1.1124513970896836e-05d, new GammaParticle(74815.0, 0.01657) }, { 1.8612203397853164e-05d, new GammaParticle(77108.0, 0.01608) }, { 6.375406480283307e-06d, new GammaParticle(87388.0, 0.01419) }, { 8.32628086325e-06d, new GammaParticle(88458.0, 0.01402) }, { 1.950874382966692e-06d, new GammaParticle(89784.0, 0.01381) } } },

        };
    }
}
    