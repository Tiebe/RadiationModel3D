using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium152";
        public override double halfLife { get; } = 1.4d;
        public override double atomicWeight { get; } = 151.93668d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium152() }, { 1.0d, new BetaParticle(-1, 2389000.0) } } },

        };
    }
}
    