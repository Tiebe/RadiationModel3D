using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum165 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum165";
        public override double halfLife { get; } = 31.0d;
        public override double atomicWeight { get; } = 164.95078d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium165() }, { 1.0d, new BetaParticle(1, 5297000.0) } } },

        };
    }
}
    