using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium135";
        public override double halfLife { get; } = 49.0d;
        public override double atomicWeight { get; } = 134.92479d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium135() }, { 1.0d, new BetaParticle(1, 5438000.0) } } },

        };
    }
}
    