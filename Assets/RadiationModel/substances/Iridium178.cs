using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium178";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 177.96108d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium178() }, { 1.0d, new BetaParticle(1, 4699500.0) } } },

        };
    }
}
    