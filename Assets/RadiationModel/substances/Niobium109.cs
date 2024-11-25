using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium109";
        public override double halfLife { get; } = 0.108d;
        public override double atomicWeight { get; } = 108.93914d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum109() }, { 1.0d, new BetaParticle(-1, 4984500.0) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum109() }, { 1.0d, new BetaParticle(-1, 4984500.0) } } },

        };
    }
}
    