using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron15 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron15";
        public override double halfLife { get; } = 0.00993d;
        public override double atomicWeight { get; } = 15.03109d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon15() }, { 1.0d, new BetaParticle(-1, 9541950.0) } } },
            { 0.9968d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon15() }, { 1.0d, new BetaParticle(-1, 9541950.0) } } },

        };
    }
}
    