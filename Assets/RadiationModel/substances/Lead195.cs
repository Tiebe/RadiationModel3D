using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead195 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead195";
        public override double halfLife { get; } = 900.0d;
        public override double atomicWeight { get; } = 194.97452d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury195() }, { 1.0d, new BetaParticle(1, 3637500.0) } } },

        };
    }
}
    