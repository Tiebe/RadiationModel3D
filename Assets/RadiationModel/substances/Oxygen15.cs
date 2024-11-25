using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen15 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen15";
        public override double halfLife { get; } = 122.24d;
        public override double atomicWeight { get; } = 15.00307d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon15() }, { 1.0d, new BetaParticle(1, -3508750.0) }, { 1.998006d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    