using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium233";
        public override double halfLife { get; } = 143.0d;
        public override double atomicWeight { get; } = 233.04435d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium233() }, { 1.0d, new BetaParticle(-1, 1288200.0) }, { 0.5734d, new GammaParticle(522757.0, 0.00237) }, { 0.3666d, new GammaParticle(539599.0, 0.0023) }, { 0.0039843839362880005d, new GammaParticle(15784.0, 0.07855) }, { 0.00246368673139942d, new GammaParticle(89954.0, 0.01378) }, { 0.00398525838142902d, new GammaParticle(93347.0, 0.01328) }, { 0.0014180926426114893d, new GammaParticle(105566.0, 0.01174) }, { 0.001895989863171561d, new GammaParticle(106894.0, 0.0116) }, { 0.0004778972205600719d, new GammaParticle(108580.0, 0.01142) } } },

        };
    }
}
    