using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin131 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin131";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 130.91705d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony131() }, { 1.0d, new BetaParticle(-1, 2358200.0) } } },

        };
    }
}
    