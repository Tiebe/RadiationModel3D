using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium202";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 201.98214d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum202() }, { 1.0d, new BetaParticle(-1, 3026000.0) } } },

        };
    }
}
    