using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium100";
        public override double halfLife { get; } = 0.052d;
        public override double atomicWeight { get; } = 99.95033d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium100() }, { 1.0d, new BetaParticle(-1, 6776000.0) } } },
            { 0.055999999999999994d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium100() }, { 1.0d, new BetaParticle(-1, 6776000.0) } } },
            { 0.0015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium98() }, { 1.0d, new BetaParticle(-1, 941572103.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    