using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium153";
        public override double halfLife { get; } = 0.865d;
        public override double atomicWeight { get; } = 152.94105d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium153() }, { 1.0d, new BetaParticle(-1, 3329000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    