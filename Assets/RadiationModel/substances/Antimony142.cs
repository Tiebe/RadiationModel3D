using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony142 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony142";
        public override double halfLife { get; } = 0.053d;
        public override double atomicWeight { get; } = 141.96392d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium142() }, { 1.0d, new BetaParticle(-1, 6470000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    