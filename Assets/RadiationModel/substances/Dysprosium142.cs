using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium142";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 141.94619d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium142() }, { 1.0d, new BetaParticle(1, 8420000.0) }, { 0.043d, new GammaParticle(181900.0, 0.00682) }, { 0.0027119138520000003d, new GammaParticle(7118.0, 0.17418) }, { 0.0039129818614882525d, new GammaParticle(43743.0, 0.02834) }, { 0.00701628449253766d, new GammaParticle(44481.0, 0.02787) }, { 0.0022405430071279495d, new GammaParticle(50494.0, 0.02455) }, { 0.0028208436459740884d, new GammaParticle(51040.0, 0.02429) }, { 0.0005803006388461389d, new GammaParticle(51699.0, 0.02398) } } },
            { 0.0006d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium141() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    