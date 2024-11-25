using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium80m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium80m";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 79.9346d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.81d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium80() } } },
            { 0.19d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium80() }, { 1.0d, new BetaParticle(1, 5627750.0) }, { 0.2d, new GammaParticle(385900.0, 0.00321) }, { 0.0101d, new GammaParticle(428400.0, 0.00289) }, { 0.0101d, new GammaParticle(594800.0, 0.00208) }, { 0.02d, new GammaParticle(756200.0, 0.00164) }, { 0.0101d, new GammaParticle(1142100.0, 0.00109) }, { 0.0121d, new GammaParticle(1350400.0, 0.00092) }, { 0.5682d, new GammaParticle(511000.0, 0.00243) }, { 1.6e-05d, new GammaParticle(1890.0, 0.656) }, { 0.0001d, new GammaParticle(14098.0, 0.08794) }, { 0.00018999999999999998d, new GammaParticle(14165.0, 0.08753) }, { 5e-05d, new GammaParticle(15898.0, 0.07799) }, { 5e-05d, new GammaParticle(15955.0, 0.07771) }, { 5.999999999999999e-06d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    