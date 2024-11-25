using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum165 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum165";
        public override double halfLife { get; } = 0.00026d;
        public override double atomicWeight { get; } = 164.99966d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium161() }, { 1.0d, new AlphaParticle(8477002.09) } } },

        };
    }
}
    