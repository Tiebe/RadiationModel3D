using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium133";
        public override double halfLife { get; } = 13.5d;
        public override double atomicWeight { get; } = 132.92978d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium133() }, { 1.0d, new BetaParticle(1, 6264000.0) } } },

        };
    }
}
    