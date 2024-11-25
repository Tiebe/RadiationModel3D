using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten172 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten172";
        public override double halfLife { get; } = 396.0d;
        public override double atomicWeight { get; } = 171.94729d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium172() }, { 1.0d, new BetaParticle(1, 3652500.0) } } },

        };
    }
}
    