using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium243m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium243m";
        public override double halfLife { get; } = 21.0d;
        public override double atomicWeight { get; } = 243.06957d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.61d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium239() }, { 1.0d, new AlphaParticle(9147002.09) } } },
            { 0.39d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium243() }, { 1.0d, new BetaParticle(1, 3055000.0) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    