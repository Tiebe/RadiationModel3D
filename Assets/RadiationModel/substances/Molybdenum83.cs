using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum83 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum83";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 82.95025d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium83() }, { 1.0d, new BetaParticle(1, 9786000.0) } } },

        };
    }
}
    