using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin121m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin121m";
        public override double halfLife { get; } = 1385349050.28459d;
        public override double atomicWeight { get; } = 120.90425d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7759999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin121() }, { 8.9e-12d, new GammaParticle(6290.0, 0.19711) }, { 0.036751360000000004d, new GammaParticle(3753.0, 0.33036) } } },
            { 0.22399999999999998d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony121() }, { 1.0d, new BetaParticle(-1, 204450.0) }, { 0.018500000000000003d, new GammaParticle(37150.0, 0.03337) }, { 0.01454008425d, new GammaParticle(3941.0, 0.3146) }, { 0.04279825490286074d, new GammaParticle(26111.0, 0.04748) }, { 0.07990712267150996d, new GammaParticle(26359.0, 0.04704) }, { 0.022731501595384663d, new GammaParticle(29821.0, 0.04158) }, { 0.027436922425629288d, new GammaParticle(30069.0, 0.04123) }, { 0.004705420830244625d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    