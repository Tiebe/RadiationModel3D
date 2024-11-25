using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium113";
        public override double halfLife { get; } = 0.032d;
        public override double atomicWeight { get; } = 112.95683d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum113() }, { 1.0d, new BetaParticle(-1, 6220000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    