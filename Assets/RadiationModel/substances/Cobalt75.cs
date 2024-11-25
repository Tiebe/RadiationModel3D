using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt75 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt75";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 74.96719d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel75() }, { 1.0d, new BetaParticle(-1, 6840000.0) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel75() }, { 1.0d, new BetaParticle(-1, 6840000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    