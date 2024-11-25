using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine137 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine137";
        public override double halfLife { get; } = 24.5d;
        public override double atomicWeight { get; } = 136.91803d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon137() }, { 1.0d, new BetaParticle(-1, 3013705.0) }, { 6e-05d, new GammaParticle(4199100.0, 0.0003) }, { 0.00010999999999999999d, new GammaParticle(4298300.0, 0.00029) }, { 0.00035999999999999997d, new GammaParticle(4379700.0, 0.00028) }, { 5e-05d, new GammaParticle(4420700.0, 0.00028) }, { 3.6e-05d, new GammaParticle(4489400.0, 0.00028) }, { 9.3e-05d, new GammaParticle(4609300.0, 0.00027) }, { 4.2e-05d, new GammaParticle(4750300.0, 0.00026) }, { 0.00014000000000000001d, new GammaParticle(4880500.0, 0.00025) } } },
            { 0.07139999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon137() }, { 1.0d, new BetaParticle(-1, 3013705.0) }, { 6e-05d, new GammaParticle(4199100.0, 0.0003) }, { 0.00010999999999999999d, new GammaParticle(4298300.0, 0.00029) }, { 0.00035999999999999997d, new GammaParticle(4379700.0, 0.00028) }, { 5e-05d, new GammaParticle(4420700.0, 0.00028) }, { 3.6e-05d, new GammaParticle(4489400.0, 0.00028) }, { 9.3e-05d, new GammaParticle(4609300.0, 0.00027) }, { 4.2e-05d, new GammaParticle(4750300.0, 0.00026) }, { 0.00014000000000000001d, new GammaParticle(4880500.0, 0.00025) } } },

        };
    }
}
    