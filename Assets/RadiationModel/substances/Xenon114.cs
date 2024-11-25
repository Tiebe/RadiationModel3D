using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon114 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon114";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 113.92798d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium114() }, { 1.0d, new BetaParticle(1, 7402000.0) } } },

        };
    }
}
    