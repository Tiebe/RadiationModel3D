using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury194 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury194";
        public override double halfLife { get; } = 14105945910.64262d;
        public override double atomicWeight { get; } = 193.96545d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold194() }, { 0.235298d, new GammaParticle(11419.0, 0.10858) } } },

        };
    }
}
    