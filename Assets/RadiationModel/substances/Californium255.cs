using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium255";
        public override double halfLife { get; } = 5100.0d;
        public override double atomicWeight { get; } = 255.09105d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium255() }, { 1.0d, new BetaParticle(-1, 360500.0) } } },

        };
    }
}
    