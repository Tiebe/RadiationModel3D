using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium226";
        public override double halfLife { get; } = 108.0d;
        public override double atomicWeight { get; } = 226.02795d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.74d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium222() }, { 1.0d, new AlphaParticle(8009002.09) } } },
            { 0.26d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium226() }, { 1.0d, new BetaParticle(1, 862500.0) } } },

        };
    }
}
    