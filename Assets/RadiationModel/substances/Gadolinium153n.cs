using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium153n : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium153n";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 152.92194d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium153() }, { 0.09d, new GammaParticle(41560.0, 0.02983) }, { 0.045d, new GammaParticle(51780.0, 0.02394) }, { 0.036000000000000004d, new GammaParticle(75070.0, 0.01652) }, { 0.18899999999999997d, new GammaParticle(76010.0, 0.01631) }, { 0.0225d, new GammaParticle(77900.0, 0.01592) }, { 0.009899999999999999d, new GammaParticle(93340.0, 0.01328) }, { 0.0063d, new GammaParticle(126850.0, 0.00977) }, { 0.28352010456d, new GammaParticle(6858.0, 0.18079) }, { 0.20988110572497287d, new GammaParticle(42308.0, 0.02931) }, { 0.3775519081219156d, new GammaParticle(42996.0, 0.02884) }, { 0.11934703986786349d, new GammaParticle(48802.0, 0.02541) }, { 0.15073531135311158d, new GammaParticle(49326.0, 0.02514) }, { 0.0313882714852481d, new GammaParticle(49957.0, 0.02482) } } },

        };
    }
}
    