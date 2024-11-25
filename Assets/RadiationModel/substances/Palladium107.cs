using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium107";
        public override double halfLife { get; } = 205120018834848.0d;
        public override double atomicWeight { get; } = 106.90513d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver107() }, { 1.0d, new BetaParticle(-1, 17000.0) } } },

        };
    }
}
    