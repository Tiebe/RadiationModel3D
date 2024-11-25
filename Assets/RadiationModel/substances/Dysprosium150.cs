using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium150";
        public override double halfLife { get; } = 430.2d;
        public override double atomicWeight { get; } = 149.92559d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium150() }, { 1.0d, new BetaParticle(1, 3227000.0) }, { 0.63d, new GammaParticle(397200.0, 0.00312) }, { 0.00104d, new GammaParticle(511000.0, 0.00243) }, { 0.100480358466d, new GammaParticle(7118.0, 0.17418) }, { 0.1436630562763717d, new GammaParticle(43743.0, 0.02834) }, { 0.2575991685070319d, new GammaParticle(44481.0, 0.02787) }, { 0.08226034965575574d, new GammaParticle(50494.0, 0.02455) }, { 0.10356578021659647d, new GammaParticle(51040.0, 0.02429) }, { 0.021305430560840735d, new GammaParticle(51699.0, 0.02398) } } },
            { 0.36d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium146() }, { 1.0d, new AlphaParticle(5373002.09) } } },

        };
    }
}
    