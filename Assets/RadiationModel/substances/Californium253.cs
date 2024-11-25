using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium253";
        public override double halfLife { get; } = 1538784.0d;
        public override double atomicWeight { get; } = 253.08513d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9969d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium253() }, { 1.0d, new BetaParticle(-1, 145750.0) } } },
            { 0.0031d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium249() }, { 1.0d, new AlphaParticle(7148302.09) } } },

        };
    }
}
    