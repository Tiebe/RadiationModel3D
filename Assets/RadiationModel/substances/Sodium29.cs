using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium29 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium29";
        public override double halfLife { get; } = 0.0441d;
        public override double atomicWeight { get; } = 29.00288d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium29() }, { 1.0d, new BetaParticle(-1, 6646200.0) } } },
            { 0.215d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium29() }, { 1.0d, new BetaParticle(-1, 6646200.0) } } },

        };
    }
}
    