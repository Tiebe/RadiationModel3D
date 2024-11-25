using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium34 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium34";
        public override double halfLife { get; } = 0.0055d;
        public override double atomicWeight { get; } = 34.03401d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium34() }, { 1.0d, new BetaParticle(-1, 11678500.0) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium32() }, { 1.0d, new BetaParticle(-1, 947748603.472) }, { 1.0d, new NeutronParticle() } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium34() }, { 1.0d, new BetaParticle(-1, 11678500.0) } } },

        };
    }
}
    