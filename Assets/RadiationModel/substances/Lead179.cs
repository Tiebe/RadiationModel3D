using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead179 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead179";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 179.0022d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury175() }, { 1.0d, new AlphaParticle(8617002.09) } } },

        };
    }
}
    