using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury172 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury172";
        public override double halfLife { get; } = 0.00023d;
        public override double atomicWeight { get; } = 171.99886d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum168() }, { 1.0d, new AlphaParticle(8547002.09) } } },

        };
    }
}
    