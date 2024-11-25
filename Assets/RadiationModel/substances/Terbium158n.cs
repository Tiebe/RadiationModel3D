using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium158n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium158n";
        public override double halfLife { get; } = 0.0004d;
        public override double atomicWeight { get; } = 157.92584d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium158() }, { 0.37799999999999995d, new GammaParticle(55040.0, 0.02253) }, { 0.28224d, new GammaParticle(65760.0, 0.01885) }, { 0.12096d, new GammaParticle(73210.0, 0.01694) }, { 0.17135999999999998d, new GammaParticle(89080.0, 0.01392) }, { 0.14112d, new GammaParticle(105330.0, 0.01177) }, { 0.0756d, new GammaParticle(162220.0, 0.00764) }, { 0.504d, new GammaParticle(171070.0, 0.00725) }, { 0.18648d, new GammaParticle(194410.0, 0.00638) }, { 0.403920852379632d, new GammaParticle(7118.0, 0.17418) }, { 0.44912972080929797d, new GammaParticle(43743.0, 0.02834) }, { 0.8053249431760767d, new GammaParticle(44481.0, 0.02787) }, { 0.2571681880656277d, new GammaParticle(50494.0, 0.02455) }, { 0.32377474877462525d, new GammaParticle(51040.0, 0.02429) }, { 0.06660656070899758d, new GammaParticle(51699.0, 0.02398) } } },

        };
    }
}
    